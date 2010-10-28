ant compile
rm ~/Projects/com.koushikdutta.helloworld/com.koushikdutta.helloworld/Android/libs/*
pushd bin/classes
jar -cf ~/.androidmono/com.koushikdutta.monojavabridge.jar .
popd