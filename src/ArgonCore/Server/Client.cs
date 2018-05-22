﻿using System;
using System.Collections.Generic;
using System.Text;

using ArgonCore.Interface;
using SteamKit2;

namespace ArgonCore.Server
{
    /// <summary>
    /// Represents a client on the server
    /// </summary>
    public class Client
    {
        public static object active_client_lock = new object();
        static Dictionary<uint, Client> ActiveClients { get; set; } = new Dictionary<uint, Client>();

        public Queue<ArgonCore.Client.InternalCallbackMsg> PendingCallbacks { get; set; } = new Queue<ArgonCore.Client.InternalCallbackMsg>();

        // Used for internal handling of clients
        // This is set by the IPC by connection id
        public uint Id { get; private set; }

        public List<IBaseInterface> interfaces;

        // Steamkit helpers for this client
        public SteamClient SteamClient { get; private set; }
        public CallbackManager CallbackManager { get; set; }

        // Whether user is connected / running
        public bool Running { get; private set; }
        public bool Connected { get; private set; }

        // Logging instance for this client
        public Logger Log { get; private set; }

        /// <summary>
        /// Create a new <see cref="Client"/> from the requested instance 
        /// </summary>
        Client(uint id)
        {
            interfaces = new List<IBaseInterface>();

            Loader.Load();

            Id = id;

            Log = new Logger(Id);

            {
                // create our steamclient instance
                SteamClient = new SteamClient();

                // create the callback manager which will route callbacks to function calls
                CallbackManager = new CallbackManager(SteamClient);

                // Setup our packet handler for all packets
                SteamClient.AddHandler(new PacketHandler(this));

                // Subscribe to some important callbacks
                CallbackManager.Subscribe<SteamClient.ConnectedCallback>(OnConnect);
                CallbackManager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnect);
            }

            // Automatically try to connect...
            Connect();
        }

        public static void CreateNewClient(uint id)
        {
            var c = new Client(id);
            lock (active_client_lock)
                ActiveClients[id] = c;
        }

        public IBaseInterface CreateInterface(string name)
        {
            // Server never needs delegates or contexts becuase it is just managing instances
            // within C#
            var impl = Context.FindImpl(name);
            var instance = (IBaseInterface)Context.CreateInterfaceInstance(impl);
            interfaces.Add(instance);

            instance.ClientId = (int)Id;
            instance.InterfaceId = interfaces.Count - 1;
            instance.Implementation = impl;

            return instance;
        }

        /// <summary>
        /// Handles connecting the user's client instance to steam.
        /// </summary>
        public void Connect()
        {
            Log.WriteLine("client", "Attempting connection...");
            SteamClient.Connect();
            Running = true;
        }

        /// <summary>
        /// Handles connecting the user's client instance to steam.
        /// </summary>
        public void Disconnect()
        {
            Log.WriteLine("client", "Disconnecting...");
            SteamClient.Disconnect();
            Running = false;
        }

        public void RunCallbacks()
        {
            // Dont wait indefinitely for new callbacks
            CallbackManager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
        }

        public static void RunAllCallbacks()
        {
            lock (active_client_lock)
            {
                foreach (var c in ActiveClients.Values)
                {
                    c.RunCallbacks();
                }
            }
        }

        // Static event handlers
        public void OnConnect(SteamClient.ConnectedCallback cb)
        {
            Log.WriteLine("client", "Connected [token: {0}]", SteamClient.SessionToken);

            Connected = true;
        }

        public void OnDisconnect(SteamClient.DisconnectedCallback cb)
        {
            Log.WriteLine("client", "Disconnected");

            Connected = false;
        }

        object CallSerializedFunction(int interface_id, string name, object[] args)
        {
            if (interface_id != -1)
            {
                var iface = interfaces[interface_id];
                var mi = iface.Implementation.methods.Find(x => x.Name == name);

                if (mi != null)
                {
                    return mi.Invoke(interfaces[interface_id], args);
                }

                Log.WriteLine("client", "Unable to find method \"{0}\" from interface \"{1}\"", name, iface.Implementation.name);

                return null;
            }

            // TODO: handle special server related functions
            switch (name)
            {
                case "CreateInterface": { return CreateInterface((string)args[0]).InterfaceId; }
                case "NextCallback":
                    {
                        if (PendingCallbacks.Count > 0)
                        {
                            return PendingCallbacks.Dequeue();
                        }

                        return null;
                    }
                default:
                    Log.WriteLine("client", "Method \"{0}\" is not defined for Interface -1", name);
                    break;
            }

            return null;
        }

        public static object CallSerializedFunction(uint client_id, int interface_id, string name, object[] args)
        {
            return ActiveClients[client_id].CallSerializedFunction(interface_id, name, args);
        }
    }
}
