cd $(dirname $0)/../../MonoActivity
ant reinstall
adb shell am start -n com.koushikdutta.mono/com.koushikdutta.mono.MonoActivity
