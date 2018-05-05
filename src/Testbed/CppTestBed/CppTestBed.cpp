#include <cassert>
#include <cstdio>

#include <Windows.h>

class SteamClientTest001 {
public:
	virtual int Test(const char *a, int b) = 0;
	virtual const char *Test2(const char *a, const char *b) = 0;
};

class SteamClientTest002 {
public:
	virtual int Test3(const char *a, int b) = 0;
	virtual const char *Test4(const char *a, const char *b) = 0;
};

using CreateInterfaceFn = void *(__stdcall *)(const char *);

int main(int argc, const char **argv) {
	if (argc == 1) return 0;

	auto path = argv[1];

	auto handle = LoadLibrary(path);

	auto create_interface_proc = (CreateInterfaceFn) GetProcAddress(handle, "CreateInterface");
	if (create_interface_proc != nullptr) {
		auto iface1 = (SteamClientTest001 *)create_interface_proc("STEAMCLIENT_INTERFACE_VERSION001");
		if (iface1 != nullptr) {
			
			auto out = iface1->Test("good job nicely done", 10);
			printf("iface->Test('good job nicely done', 10) = %d\n", out);

			auto out2 = iface1->Test2("good job ", "nicely done");
			printf("iface->Test2('good job ', 'nicely done') = %s\n", out2);

		} else {
			printf("CreateInterface returned null for iface1!\n");
		}

		auto iface2 = (SteamClientTest002 *)create_interface_proc("STEAMCLIENT_INTERFACE_VERSION002");
		if (iface2 != nullptr) {

			auto out = iface2->Test3("good job nicely done", 10);
			printf("iface->Test3('good job nicely done', 10) = %d\n", out);

			auto out2 = iface2->Test4("good job ", "nicely done");
			printf("iface->Test4('good job ', 'nicely done') = %s\n", out2);

		}
		else {
			printf("CreateInterface returned null for iface2!\n");
		}

	} else {
		printf("Unable to find CreateInterface in %s\n", path);
	}

	getc(stdin);

    return 0;
}

