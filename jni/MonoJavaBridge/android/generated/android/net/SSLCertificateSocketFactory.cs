namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLCertificateSocketFactory : javax.net.ssl.SSLSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLCertificateSocketFactory()
		{
			InitJNI();
		}
		protected SSLCertificateSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault5240;
		public static global::javax.net.ssl.SSLSocketFactory getDefault(int arg0, android.net.SSLSessionCache arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getDefault5240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getDefault5241;
		public static global::javax.net.SocketFactory getDefault(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getDefault5241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getInsecure5242;
		public static global::javax.net.ssl.SSLSocketFactory getInsecure(int arg0, android.net.SSLSessionCache arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getInsecure5242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.net.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getHttpSocketFactory5243;
		public static global::org.apache.http.conn.ssl.SSLSocketFactory getHttpSocketFactory(int arg0, android.net.SSLSessionCache arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getHttpSocketFactory5243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.conn.ssl.SSLSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5244;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5245;
		public override global::java.net.Socket createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5245)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5245)) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5246;
		public override global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5247;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5248;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket5249;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._createSocket5249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._createSocket5249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		public new global::java.lang.String[] DefaultCipherSuites
		{
			get
			{
				return getDefaultCipherSuites();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites5250;
		public override global::java.lang.String[] getDefaultCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites5250)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites5250)) as java.lang.String[];
		}
		public new global::java.lang.String[] SupportedCipherSuites
		{
			get
			{
				return getSupportedCipherSuites();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites5251;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites5251)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites5251)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _SSLCertificateSocketFactory5252;
		public SSLCertificateSocketFactory(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.SSLCertificateSocketFactory.staticClass, global::android.net.SSLCertificateSocketFactory._SSLCertificateSocketFactory5252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.SSLCertificateSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/SSLCertificateSocketFactory"));
			global::android.net.SSLCertificateSocketFactory._getDefault5240 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;");
			global::android.net.SSLCertificateSocketFactory._getDefault5241 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefault", "(I)Ljavax/net/SocketFactory;");
			global::android.net.SSLCertificateSocketFactory._getInsecure5242 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getInsecure", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;");
			global::android.net.SSLCertificateSocketFactory._getHttpSocketFactory5243 = @__env.GetStaticMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getHttpSocketFactory", "(ILandroid/net/SSLSessionCache;)Lorg/apache/http/conn/ssl/SSLSocketFactory;");
			global::android.net.SSLCertificateSocketFactory._createSocket5244 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._createSocket5245 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._createSocket5246 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._createSocket5247 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._createSocket5248 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._createSocket5249 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::android.net.SSLCertificateSocketFactory._getDefaultCipherSuites5250 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			global::android.net.SSLCertificateSocketFactory._getSupportedCipherSuites5251 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::android.net.SSLCertificateSocketFactory._SSLCertificateSocketFactory5252 = @__env.GetMethodIDNoThrow(global::android.net.SSLCertificateSocketFactory.staticClass, "<init>", "(I)V");
		}
	}
}
