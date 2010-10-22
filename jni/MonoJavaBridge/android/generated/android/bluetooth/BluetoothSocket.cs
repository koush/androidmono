namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BluetoothSocket()
		{
			InitJNI();
		}
		internal BluetoothSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close2545;
		public void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket._close2545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._close2545);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream2546;
		public global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket._getInputStream2546)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getInputStream2546)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect2547;
		public void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket._connect2547);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._connect2547);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream2548;
		public global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket._getOutputStream2548)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getOutputStream2548)) as java.io.OutputStream;
		}
		public new global::android.bluetooth.BluetoothDevice RemoteDevice
		{
			get
			{
				return getRemoteDevice();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteDevice2549;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothDevice>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket._getRemoteDevice2549)) as android.bluetooth.BluetoothDevice;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothDevice>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getRemoteDevice2549)) as android.bluetooth.BluetoothDevice;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothSocket"));
			global::android.bluetooth.BluetoothSocket._close2545 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V");
			global::android.bluetooth.BluetoothSocket._getInputStream2546 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.bluetooth.BluetoothSocket._connect2547 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V");
			global::android.bluetooth.BluetoothSocket._getOutputStream2548 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.bluetooth.BluetoothSocket._getRemoteDevice2549 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;");
		}
	}
}
