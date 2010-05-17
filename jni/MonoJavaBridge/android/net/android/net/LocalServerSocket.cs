namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalServerSocket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalServerSocket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.LocalServerSocket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.LocalServerSocket(@__env); 
			} 
		} 
		protected LocalServerSocket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close4389; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalServerSocket)) 
				@__env.CallVoidMethod(this, _close4389); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.LocalServerSocket.staticClass, _close4389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _accept4390; 
		public virtual android.net.LocalSocket accept() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocket>(@__env, @__env.CallObjectMethodPtr(this, _accept4390)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalServerSocket.staticClass, _accept4390)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor4391; 
		public virtual java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFileDescriptor4391)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalServerSocket.staticClass, _getFileDescriptor4391)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalSocketAddress4392; 
		public virtual android.net.LocalSocketAddress getLocalSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalServerSocket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getLocalSocketAddress4392)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalServerSocket.staticClass, _getLocalSocketAddress4392)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalServerSocket4393; 
		public LocalServerSocket(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalServerSocket.staticClass, _LocalServerSocket4393, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalServerSocket4394; 
		public LocalServerSocket(java.io.FileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalServerSocket.staticClass, _LocalServerSocket4394, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.LocalServerSocket.staticClass = @__class; 
			global::android.net.LocalServerSocket._close4389 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "close", "()V"); 
			global::android.net.LocalServerSocket._accept4390 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "accept", "()Landroid/net/LocalSocket;"); 
			global::android.net.LocalServerSocket._getFileDescriptor4391 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::android.net.LocalServerSocket._getLocalSocketAddress4392 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;"); 
			global::android.net.LocalServerSocket._LocalServerSocket4393 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.net.LocalServerSocket._LocalServerSocket4394 = @__env.GetMethodID(global::android.net.LocalServerSocket.staticClass, "<init>", "(Ljava/io/FileDescriptor;)V"); 
		} 
	} 
} 
