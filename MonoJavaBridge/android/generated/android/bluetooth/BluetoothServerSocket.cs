namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothServerSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "close", "()V", ref global::android.bluetooth.BluetoothServerSocket._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::android.bluetooth.BluetoothSocket accept()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothSocket>(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "()Landroid/bluetooth/BluetoothSocket;", ref global::android.bluetooth.BluetoothServerSocket._m1) as android.bluetooth.BluetoothSocket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::android.bluetooth.BluetoothSocket accept(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothSocket>(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "(I)Landroid/bluetooth/BluetoothSocket;", ref global::android.bluetooth.BluetoothServerSocket._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.bluetooth.BluetoothSocket;
		}
		static BluetoothServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothServerSocket"));
		}
	}
}
