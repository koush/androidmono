---- setup ----

# This README assumes that your Android NDK directory is located at ~/src/android-ndk.
# Adjust any instructions as necessary.
# The current supported Android NDK is Android NDK r4, and can be found at:
# http://developer.android.com/sdk/ndk/index.html

# Get the androidmono repository which contains the build scripts and patches 
# necessary to build mono.
cd ~/src
git clone git://github.com/koush/androidmono.git

# Use the get-mono.sh script to check out the proper revision of mono from svn and 
# apply any necessary patches. This step may take a while because it builds mono
# and mcs so the assemblies are available for packaging in the APK.
cd androidmono
./get-mono.sh

---- building the mono binaries and jni bindings ----

# This will call ndk-build in the MonoActivity directory and build the android.dll
cd ~/src/androidmono/jni/MonoJavaBridge
./build.sh

---- building and installing the mono APK ----

cd ~/src/androidmono/MonoActivity
ant install

---- running mono from the command line ----

# start up and adb shell and navigate to the proper directory.
adb shell
cd /data/data/com.koushikdutta.mono

# run the test.exe program which prints Hello World and retrieves and prints the
# Yahoo! Homepage.
./mono test.exe

---- rebuilding and using the JNI bindings (pre alpha, heavy development) ----

1) Regenerating the androidsdk.xml from the android.jar in the SDK.
The androidsdk.xml file is part of the repository now, and should generally not need
to be regenerated. But if you want to tweak the XML at all, it can be done as follows.
Import the jni/MonoJavaBridge/JavaObjectModelGenerator project into Eclipse as a standard
Java application. Run the project. When it completes, the androidsdk.xml will be 
created and placed in jni/MonoJavaBridge.

2) Regenerating the android.dll source files.
The android.dll sources are part of the repository now, and should generally not need to
be regenerated unless you change the code generator. Instructions to regenerate are below.
Open the MonoJavaBridge workspace. Run MonoDroid. The android project source files will be 
regenerated.

3) Testing the HelloWorldActivity application.

# This builds the C# application. You can also open it in MonoDevelop and build it.
cd jni/MonoJavaBridge/HelloWorld/
xbuild

# This builds the Android Eclipse application that wraps the C# application. You can
# also use Eclipse to build/run this.
cd Android
ant install
