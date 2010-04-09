mkdir -p bin
gcc-4.0 -dynamiclib -o bin/libmonojavabridge.so -I /Developer/SDKs/MacOSX10.5.sdk/System/Library/Frameworks/JavaVM.framework/Versions/1.5.0/Headers/ -I../../hostbuild/mono/ -I../../hostbuild/mono/eglib/src/ -liconv MonoJavaInterop/MonoJavaInterop.c ../../hostbuild/install/lib/libmono.0.dylib
xbuild
