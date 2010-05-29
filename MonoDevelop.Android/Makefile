include config.make
TOP_SRCDIR=/Users/koush/src/monodevelop
installdir = "$(prefix)/lib/monodevelop/AddIns/MonoDevelop.Android"
conf=Debug
SLN=MonoDevelop.Android.sln


ISLOCAL := $(wildcard "$(TOP_SRCDIR)/local-config/monodevelop.pc")
ifeq ($(strip $(ISLOCAL)),)
	LOCAL_MDBUILD=$(TOP_SRCDIR)/main/build
	MDTOOL=\
		PKG_CONFIG_PATH="$(TOP_SRCDIR)/local-config:${PKG_CONFIG_PATH}" \
		MONODEVELOP_LOCALE_PATH="${LOCAL_MDBUILD}/locale" \
		MONO_ADDINS_REGISTRY="${LOCAL_MDBUILD}/bin" \
		mono --debug "${LOCAL_MDBUILD}/bin/mdrun.exe"
else
	MDTOOL=mdtool
endif

all: update-reg
	$(MDTOOL) build -c:$(conf) $(SLN)

clean:
	rm -rf build/*

# this breaks if the local MD has been cleaned
#clean: update-reg	
#	$(MDTOOL) build -t:Clean -c:$(conf) $(SLN)

install: all
	mkdir -p  $(installdir)
	cp -r ./build/* $(installdir)

uninstall:
	rm -rf "$(installdir)"

ifeq ($(strip $(ISLOCAL)),)
update-reg:
	$(MDTOOL) setup reg-update
else
	update-reg:
endif
