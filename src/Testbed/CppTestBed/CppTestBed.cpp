#include <cassert>
#include <cstdio>

#include <Windows.h>

class SteamClientTest {
public:
	virtual int Test(const char *a, int b) = 0;
};

using CreateInterfaceFn = void *(__stdcall *)(const char *);

int main(int argc, const char **argv) {
	if (argc == 1) return 0;

	auto path = argv[1];

	auto handle = LoadLibrary(path);

	auto create_interface_proc = (CreateInterfaceFn) GetProcAddress(handle, "CreateInterface");
	if (create_interface_proc != nullptr) {
		auto iface = (SteamClientTest *)create_interface_proc("STEAMCLIENT_INTERFACE_VERSION001");
		if (iface != nullptr) {
			auto out = iface->Test("wow", 10);
			printf("iface->Test('wow', 10) = %d", out);
		} else {
			printf("CreateInterface returned null!\n");
		}
	} else {
		printf("Unable to find CreateInterface in %s\n", path);
	}

	getc(stdin);

    return 0;
}

