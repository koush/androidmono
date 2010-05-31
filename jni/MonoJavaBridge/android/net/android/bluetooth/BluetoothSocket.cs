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
		internal static global::net.sf.jni4net.jni.MethodId _close904; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket._close904); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._close904); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream905; 
		public global::java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getInputStream905)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getInputStream905)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect906; 
		public void connect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothSocket._connect906); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._connect906); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream907; 
		public global::java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getOutputStream907)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getOutputStream907)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRemoteDevice908; 
		public global::android.bluetooth.BluetoothDevice getRemoteDevice() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket._getRemoteDevice908)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothDevice>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getRemoteDevice908)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothSocket.staticClass = @__class; 
			global::android.bluetooth.BluetoothSocket._close904 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V"); 
			global::android.bluetooth.BluetoothSocket._getInputStream905 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.bluetooth.BluetoothSocket._connect906 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V"); 
			global::android.bluetooth.BluetoothSocket._getOutputStream907 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::android.bluetooth.BluetoothSocket._getRemoteDevice908 = @__env.GetMethodID(global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;"); 
		} 
	} 
} 
