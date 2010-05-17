namespace javax.net.ssl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SSLSocketFactory : javax.net.SocketFactory
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SSLSocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(javax.net.ssl.SSLSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SSLSocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault12161; 
		public static new javax.net.SocketFactory getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(javax.net.ssl.SSLSocketFactory.staticClass, _getDefault12161)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket12162; 
		public abstract java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultCipherSuites12163; 
		public abstract java.lang.String[] getDefaultCipherSuites(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSupportedCipherSuites12164; 
		public abstract java.lang.String[] getSupportedCipherSuites(); 
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory12165; 
		public SSLSocketFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.net.ssl.SSLSocketFactory.staticClass, _SSLSocketFactory12165, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.net.ssl.SSLSocketFactory.staticClass = @__class; 
			global::javax.net.ssl.SSLSocketFactory._getDefault12161 = @__env.GetStaticMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;"); 
			global::javax.net.ssl.SSLSocketFactory._createSocket12162 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;"); 
			global::javax.net.ssl.SSLSocketFactory._getDefaultCipherSuites12163 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;"); 
			global::javax.net.ssl.SSLSocketFactory._getSupportedCipherSuites12164 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;"); 
			global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory12165 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
