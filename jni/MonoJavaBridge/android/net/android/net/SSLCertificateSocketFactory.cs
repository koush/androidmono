namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SSLCertificateSocketFactory : javax.net.ssl.SSLSocketFactory
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SSLCertificateSocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.SSLCertificateSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.SSLCertificateSocketFactory(@__env); 
			} 
		} 
		protected SSLCertificateSocketFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault4481; 
		public static javax.net.SocketFactory getDefault(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(android.net.SSLCertificateSocketFactory.staticClass, _getDefault4481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4482; 
		public override java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket4482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _createSocket4482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4483; 
		public override java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket4483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _createSocket4483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4484; 
		public override java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket4484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _createSocket4484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4485; 
		public override java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket4485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _createSocket4485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4486; 
		public override java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, _createSocket4486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _createSocket4486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultCipherSuites4487; 
		public override java.lang.String[] getDefaultCipherSuites() 
		{ 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getDefaultCipherSuites4487)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _getDefaultCipherSuites4487)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSupportedCipherSuites4488; 
		public override java.lang.String[] getSupportedCipherSuites() 
		{ 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getSupportedCipherSuites4488)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.SSLCertificateSocketFactory.staticClass, _getSupportedCipherSuites4488)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SSLCertificateSocketFactory4489; 
		public SSLCertificateSocketFactory(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.SSLCertificateSocketFactory.staticClass, _SSLCertificateSocketFactory4489, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.SSLCertificateSocketFactory.staticClass = @__class; 
			global::android.net.SSLCertificateSocketFactory._getDefault4481 = @__env.GetStaticMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(I)Ljavax/net/SocketFactory;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4482 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4483 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4484 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4485 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4486 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites4487 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;"); 
			global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites4488 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;"); 
			global::android.net.SSLCertificateSocketFactory._SSLCertificateSocketFactory4489 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
