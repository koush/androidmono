namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLSocketFactory_))]
	public abstract partial class SSLSocketFactory : javax.net.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocketFactory()
		{
			InitJNI();
		}
		protected SSLSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault23560;
		public static global::javax.net.SocketFactory getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._getDefault23560)) as javax.net.SocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23561;
		public abstract global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3);
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites23562;
		public abstract global::java.lang.String[] getDefaultCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23563;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _SSLSocketFactory23564;
		public SSLSocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLSocketFactory.staticClass, global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory23564);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocketFactory"));
			global::javax.net.ssl.SSLSocketFactory._getDefault23560 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			global::javax.net.ssl.SSLSocketFactory._createSocket23561 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::javax.net.ssl.SSLSocketFactory._getDefaultCipherSuites23562 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocketFactory._getSupportedCipherSuites23563 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocketFactory._SSLSocketFactory23564 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLSocketFactory))]
	public sealed partial class SSLSocketFactory_ : javax.net.ssl.SSLSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLSocketFactory_()
		{
			InitJNI();
		}
		internal SSLSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23565;
		public override global::java.net.Socket createSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._createSocket23565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._createSocket23565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites23566;
		public override global::java.lang.String[] getDefaultCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._getDefaultCipherSuites23566)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._getDefaultCipherSuites23566)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23567;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._getSupportedCipherSuites23567)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._getSupportedCipherSuites23567)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23568;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._createSocket23568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._createSocket23568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23569;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._createSocket23569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._createSocket23569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23570;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._createSocket23570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._createSocket23570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _createSocket23571;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_._createSocket23571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLSocketFactory_.staticClass, global::javax.net.ssl.SSLSocketFactory_._createSocket23571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.net.Socket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLSocketFactory"));
			global::javax.net.ssl.SSLSocketFactory_._createSocket23565 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			global::javax.net.ssl.SSLSocketFactory_._getDefaultCipherSuites23566 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocketFactory_._getSupportedCipherSuites23567 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLSocketFactory_._createSocket23568 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			global::javax.net.ssl.SSLSocketFactory_._createSocket23569 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.ssl.SSLSocketFactory_._createSocket23570 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			global::javax.net.ssl.SSLSocketFactory_._createSocket23571 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLSocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
		}
	}
}
