namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V", ref global::android.bluetooth.BluetoothSocket._m0);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.bluetooth.BluetoothSocket._m1) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V", ref global::android.bluetooth.BluetoothSocket._m2);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::android.bluetooth.BluetoothSocket._m3) as java.io.OutputStream;
		}
		public new global::android.bluetooth.BluetoothDevice RemoteDevice
		{
			get
			{
				return getRemoteDevice();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.bluetooth.BluetoothDevice>(this, global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;", ref global::android.bluetooth.BluetoothSocket._m4) as android.bluetooth.BluetoothDevice;
		}
		static BluetoothSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothSocket"));
		}
	}
}
