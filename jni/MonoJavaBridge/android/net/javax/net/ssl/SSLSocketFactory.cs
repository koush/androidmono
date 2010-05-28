namespace javax.net.ssl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SSLSocketFactory : javax.net.SocketFactory
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SSLSocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::javax.net.ssl.SSLSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SSLSocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault13261; 
		public static new global::javax.net.SocketFactory getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._getDefault13261)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket13262; 
		public abstract global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultCipherSuites13263; 
		public abstract global::java.lang.String[] getDefaultCipherSuites(); 
		internal static global::net.sf.jni4net.jni.MethodId _getSupportedCipherSuites13264; 
		public abstract global::java.lang.String[] getSupportedCipherSuites(); 
		internal static global::net.sf.jni4net.jni.MethodId _SSLSocketFactory13265; 
		public SSLSocketFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory13265, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::javax.net.ssl.SSLSocketFactory.staticClass = @__class; 
			global::javax.net.ssl.SSLSocketFactory._getDefault13261 = @__env.GetStaticMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;"); 
			global::javax.net.ssl.SSLSocketFactory._createSocket13262 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;"); 
			global::javax.net.ssl.SSLSocketFactory._getDefaultCipherSuites13263 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;"); 
			global::javax.net.ssl.SSLSocketFactory._getSupportedCipherSuites13264 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;"); 
			global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory13265 = @__env.GetMethodID(global::javax.net.ssl.SSLSocketFactory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
