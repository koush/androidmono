namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothServerSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothServerSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close2550;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "close", "()V", ref global::android.bluetooth.BluetoothServerSocket._close2550);
		}
		internal static global::MonoJavaBridge.MethodId _accept2551;
		public global::android.bluetooth.BluetoothSocket accept()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothSocket>(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "()Landroid/bluetooth/BluetoothSocket;", ref global::android.bluetooth.BluetoothServerSocket._accept2551) as android.bluetooth.BluetoothSocket;
		}
		internal static global::MonoJavaBridge.MethodId _accept2552;
		public global::android.bluetooth.BluetoothSocket accept(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothSocket>(this, global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "(I)Landroid/bluetooth/BluetoothSocket;", ref global::android.bluetooth.BluetoothServerSocket._accept2552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.bluetooth.BluetoothSocket;
		}
		static BluetoothServerSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothServerSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothServerSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
