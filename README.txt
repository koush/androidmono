---- setup ----

# This README assumes that your Android NDK directory is located at ~/src/android-ndk.
# Adjust any instructions as necessary.
# The current supported Android NDK is Android NDK r3, and can be found at:
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

# Set up the NDK to be aware of the androidmono project
./ndk-setup.sh ~/src/android-ndk

---- building the mono binaries ----

# Go to your Android NDK directory and make.
cd ~/src/android-ndk
make APP=androidmono

---- building the mono APK ----

From Eclipse, create a new Android project. Choose open existing, and browse to the
directory: ~/src/androidmono/MonoActivity and continue.

Run the project, and you will see an Activity that starts and extracts the mono binaries 
to your device/emulator.

---- running mono from the command line ----

# start up and adb shell and navigate to the proper directory.
adb shell
cd /data/data/com.koushikdutta.mono

# run the test.exe program which prints Hello World and retrieves and prints the
# Yahoo! Homepage.
./mono test.exe

    