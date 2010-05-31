namespace javax.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketFactory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.net.SocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault13254; 
		public static global::javax.net.SocketFactory getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._getDefault13254)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13255; 
		public virtual global::java.net.Socket createSocket() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::javax.net.SocketFactory._createSocket13255)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._createSocket13255)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13256; 
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13257; 
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13258; 
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13259; 
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _SocketFactory13260; 
		protected SocketFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._SocketFactory13260, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.net.SocketFactory.staticClass = @__class; 
			global::javax.net.SocketFactory._getDefault13254 = @__env.GetStaticMethodID(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;"); 
			global::javax.net.SocketFactory._createSocket13255 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket13256 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket13257 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket13258 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket13259 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._SocketFactory13260 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
