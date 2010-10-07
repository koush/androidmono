namespace android.bluetooth
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class BluetoothSocket : java.lang.Object, java.io.Closeable
	{
		internal static global::java.lang.Class staticClass;
		static BluetoothSocket()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.bluetooth.BluetoothSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.bluetooth.BluetoothSocket(@__env);
			}
		}
		internal BluetoothSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _close1034;
		public void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket._close1034);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._close1034);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream1035;
		public global::java.io.InputStream getInputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getInputStream1035));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getInputStream1035));
		}
		internal static global::net.sf.jni4net.jni.MethodId _connect1036;
		public void connect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket._connect1036);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._connect1036);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream1037;
		public global::java.io.OutputStream getOutputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getOutputStream1037));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getOutputStream1037));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteDevice1038;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getRemoteDevice1038));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getRemoteDevice1038));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.bluetooth.BluetoothSocket.staticClass = @__class;
			global::android.bluetooth.BluetoothSocket._close1034 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V");
			global::android.bluetooth.BluetoothSocket._getInputStream1035 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::android.bluetooth.BluetoothSocket._connect1036 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V");
			global::android.bluetooth.BluetoothSocket._getOutputStream1037 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::android.bluetooth.BluetoothSocket._getRemoteDevice1038 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;");
		}
	}
}
