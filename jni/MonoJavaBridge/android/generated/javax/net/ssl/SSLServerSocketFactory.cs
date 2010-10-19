namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.SSLServerSocketFactory_))]
	public abstract partial class SSLServerSocketFactory : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLServerSocketFactory()
		{
			InitJNI();
		}
		protected SSLServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault23478;
		public static global::javax.net.ServerSocketFactory getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._getDefault23478)) as javax.net.ServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites23479;
		public abstract global::java.lang.String[] getDefaultCipherSuites();
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23480;
		public abstract global::java.lang.String[] getSupportedCipherSuites();
		internal static global::MonoJavaBridge.MethodId _SSLServerSocketFactory23481;
		protected SSLServerSocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLServerSocketFactory.staticClass, global::javax.net.ssl.SSLServerSocketFactory._SSLServerSocketFactory23481);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocketFactory"));
			global::javax.net.ssl.SSLServerSocketFactory._getDefault23478 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			global::javax.net.ssl.SSLServerSocketFactory._getDefaultCipherSuites23479 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocketFactory._getSupportedCipherSuites23480 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocketFactory._SSLServerSocketFactory23481 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.SSLServerSocketFactory))]
	public sealed partial class SSLServerSocketFactory_ : javax.net.ssl.SSLServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SSLServerSocketFactory_()
		{
			InitJNI();
		}
		internal SSLServerSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultCipherSuites23482;
		public override global::java.lang.String[] getDefaultCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_._getDefaultCipherSuites23482)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, global::javax.net.ssl.SSLServerSocketFactory_._getDefaultCipherSuites23482)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getSupportedCipherSuites23483;
		public override global::java.lang.String[] getSupportedCipherSuites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_._getSupportedCipherSuites23483)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, global::javax.net.ssl.SSLServerSocketFactory_._getSupportedCipherSuites23483)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23484;
		public override global::java.net.ServerSocket createServerSocket(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23485;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23486;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.SSLServerSocketFactory_.staticClass, global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLServerSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLServerSocketFactory"));
			global::javax.net.ssl.SSLServerSocketFactory_._getDefaultCipherSuites23482 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocketFactory_._getSupportedCipherSuites23483 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23484 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;");
			global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23485 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;");
			global::javax.net.ssl.SSLServerSocketFactory_._createServerSocket23486 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
		}
	}
}
