namespace android.bluetooth 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class BluetoothSocket : java.lang.Object, java.io.Closeable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BluetoothSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _close891; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothSocket)) 
				@__env.CallVoidMethod(this, _close891); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.bluetooth.BluetoothSocket.staticClass, _close891); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream892; 
		public java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream892)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothSocket.staticClass, _getInputStream892)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect893; 
		public void connect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothSocket)) 
				@__env.CallVoidMethod(this, _connect893); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.bluetooth.BluetoothSocket.staticClass, _connect893); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream894; 
		public java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream894)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothSocket.staticClass, _getOutputStream894)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteDevice895; 
		public android.bluetooth.BluetoothDevice getRemoteDevice() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallObjectMethodPtr(this, _getRemoteDevice895)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothSocket.staticClass, _getRemoteDevice895)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothSocket.staticClass = @__class; 
			global::android.bluetooth.BluetoothSocket._close891 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V"); 
			global::android.bluetooth.BluetoothSocket._getInputStream892 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.bluetooth.BluetoothSocket._connect893 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V"); 
			global::android.bluetooth.BluetoothSocket._getOutputStream894 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::android.bluetooth.BluetoothSocket._getRemoteDevice895 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;"); 
		} 
	} 
} 
