---- setup ----
# This README assumes that your android source directory is located at ~/mydroid.
# Adjust any instructions as necessary.

# Go to your Android repository and set up your environment.
# Cupcake, Donut, Eclair are currently supported. Release 1.0 probably won't work.

cd ~/mydroid
. build/envsetup.sh
lunch 1

# Now get the androidmono repository which contains the build scripts and patches 
# necessary to build mono.
cd external
git clone git@github.com:koush/androidmono.git

# Use the get-mono.sh script to check out the proper revision of mono from svn and 
# apply any necessary patches. This step may take a while.
cd androidmono
./get-mono.sh

---- building the mono binaries ----
# Go back to your Android repository and make.

cd ~/mydroid
make

---- building the mono APK ----

From Eclipse, create a new Android project. Choose open existing, and browse to the
directory: ~/mydroid/external/androidmono/MonoActivity and continue.

Run the project, and you will see an Activity that starts and extracts the mono binaries 
to your device/emulator.

---- running mono from the command line ----

# start up and adb shell and navigate to the proper directory.
adb shell
cd /data/data/com.koushikdutta.mono

# export the HOME variable, because adb does not. Mono will throw assertions upon exit 
# otherwise.
export HOME=/data/local

# run the test.exe program which prints Hello World and retrieves and prints the
# Yahoo! Homepage.
./mono test.exe



Good luck!
