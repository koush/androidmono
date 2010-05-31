namespace android.bluetooth 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class BluetoothServerSocket : java.lang.Object, java.io.Closeable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BluetoothServerSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.bluetooth.BluetoothServerSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.bluetooth.BluetoothServerSocket(@__env); 
			} 
		} 
		internal BluetoothServerSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close901; 
		public void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.bluetooth.BluetoothServerSocket._close901); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.bluetooth.BluetoothServerSocket.staticClass, global::android.bluetooth.BluetoothServerSocket._close901); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept902; 
		public global::android.bluetooth.BluetoothSocket accept() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothServerSocket._accept902)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothServerSocket.staticClass, global::android.bluetooth.BluetoothServerSocket._accept902)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept903; 
		public global::android.bluetooth.BluetoothSocket accept(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallObjectMethodPtr(this, global::android.bluetooth.BluetoothServerSocket._accept903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.bluetooth.BluetoothSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.bluetooth.BluetoothServerSocket.staticClass, global::android.bluetooth.BluetoothServerSocket._accept903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothServerSocket.staticClass = @__class; 
			global::android.bluetooth.BluetoothServerSocket._close901 = @__env.GetMethodID(global::android.bluetooth.BluetoothServerSocket.staticClass, "close", "()V"); 
			global::android.bluetooth.BluetoothServerSocket._accept902 = @__env.GetMethodID(global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "()Landroid/bluetooth/BluetoothSocket;"); 
			global::android.bluetooth.BluetoothServerSocket._accept903 = @__env.GetMethodID(global::android.bluetooth.BluetoothServerSocket.staticClass, "accept", "(I)Landroid/bluetooth/BluetoothSocket;"); 
		} 
	} 
} 
