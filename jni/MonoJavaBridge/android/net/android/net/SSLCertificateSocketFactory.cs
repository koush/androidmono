namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SSLCertificateSocketFactory : javax.net.ssl.SSLSocketFactory
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SSLCertificateSocketFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.SSLCertificateSocketFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getDefault4729; 
		public static global::javax.net.SocketFactory getDefault(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<javax.net.SocketFactory>(@__env, @__env.CallStaticObjectMethodPtr(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getDefault4729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4730; 
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._createSocket4730, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket4730, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4731; 
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._createSocket4731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket4731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4732; 
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._createSocket4732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket4732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4733; 
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._createSocket4733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket4733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createSocket4734; 
		public override global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._createSocket4734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.Socket>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket4734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultCipherSuites4735; 
		public override global::java.lang.String[] getDefaultCipherSuites() 
		{ 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites4735)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites4735)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSupportedCipherSuites4736; 
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{ 
			if (GetType() == typeof(android.net.SSLCertificateSocketFactory)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites4736)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites4736)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SSLCertificateSocketFactory4737; 
		public SSLCertificateSocketFactory(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._SSLCertificateSocketFactory4737, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.SSLCertificateSocketFactory.staticClass = @__class; 
			global::android.net.SSLCertificateSocketFactory._getDefault4729 = @__env.GetStaticMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(I)Ljavax/net/SocketFactory;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4730 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4731 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4732 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4733 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._createSocket4734 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;"); 
			global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites4735 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;"); 
			global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites4736 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;"); 
			global::android.net.SSLCertificateSocketFactory._SSLCertificateSocketFactory4737 = @__env.GetMethodID(global::android.net.SSLCertificateSocketFactory.staticClass, "<init>", "(I)V"); 
		} 
	} 
} 
