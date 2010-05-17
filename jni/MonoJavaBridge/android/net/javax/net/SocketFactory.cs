namespace javax.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SocketFactory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(javax.net.SocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault12154; 
		public static javax.net.SocketFactory getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(javax.net.SocketFactory.staticClass, _getDefault12154)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12155; 
		public virtual java.net.Socket createSocket() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(javax.net.SocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket12155)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, javax.net.SocketFactory.staticClass, _createSocket12155)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12156; 
		public abstract java.net.Socket createSocket(java.lang.String arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12157; 
		public abstract java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12158; 
		public abstract java.net.Socket createSocket(java.net.InetAddress arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12159; 
		public abstract java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _SocketFactory12160; 
		protected SocketFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.net.SocketFactory.staticClass, _SocketFactory12160, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.net.SocketFactory.staticClass = @__class; 
			global::javax.net.SocketFactory._getDefault12154 = @__env.GetStaticMethodID(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;"); 
			global::javax.net.SocketFactory._createSocket12155 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket12156 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket12157 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket12158 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._createSocket12159 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::javax.net.SocketFactory._SocketFactory12160 = @__env.GetMethodID(global::javax.net.SocketFactory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
