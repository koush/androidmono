namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLCertificateSocketFactory : javax.net.ssl.SSLSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLCertificateSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.ssl.SSLSocketFactory getDefault(int arg0, android.net.SSLSessionCache arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLCertificateSocketFactory._m0.native == global::System.IntPtr.Zero)
				global::android.net.SSLCertificateSocketFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::javax.net.SocketFactory getDefault(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLCertificateSocketFactory._m1.native == global::System.IntPtr.Zero)
				global::android.net.SSLCertificateSocketFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(I)Ljavax/net/SocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.SocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::javax.net.ssl.SSLSocketFactory getInsecure(int arg0, android.net.SSLSessionCache arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLCertificateSocketFactory._m2.native == global::System.IntPtr.Zero)
				global::android.net.SSLCertificateSocketFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getInsecure", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.apache.http.conn.ssl.SSLSocketFactory getHttpSocketFactory(int arg0, android.net.SSLSessionCache arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLCertificateSocketFactory._m3.native == global::System.IntPtr.Zero)
				global::android.net.SSLCertificateSocketFactory._m3 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getHttpSocketFactory", "(ILandroid/net/SSLSessionCache;)Lorg/apache/http/conn/ssl/SSLSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ssl.SSLSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.net.Socket createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m5) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::android.net.SSLCertificateSocketFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		public new global::java.lang.String[] DefaultCipherSuites
		{
			get
			{
				return getDefaultCipherSuites();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String[] getDefaultCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.net.SSLCertificateSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;", ref global::android.net.SSLCertificateSocketFactory._m10) as java.lang.String[];
		}
		public new global::java.lang.String[] SupportedCipherSuites
		{
			get
			{
				return getSupportedCipherSuites();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.lang.String[] getSupportedCipherSuites()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.net.SSLCertificateSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;", ref global::android.net.SSLCertificateSocketFactory._m11) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SSLCertificateSocketFactory(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.SSLCertificateSocketFactory._m12.native == global::System.IntPtr.Zero)
				global::android.net.SSLCertificateSocketFactory._m12 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SSLCertificateSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.SSLCertificateSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/SSLCertificateSocketFactory"));
		}
	}
}
