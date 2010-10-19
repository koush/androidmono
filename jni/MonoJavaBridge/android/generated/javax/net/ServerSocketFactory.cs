namespace javax.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ServerSocketFactory_))]
	public abstract partial class ServerSocketFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocketFactory()
		{
			InitJNI();
		}
		protected ServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault23259;
		public static global::javax.net.ServerSocketFactory getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._getDefault23259)) as javax.net.ServerSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23260;
		public virtual global::java.net.ServerSocket createServerSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory._createServerSocket23260)) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._createServerSocket23260)) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23261;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0);
		internal static global::MonoJavaBridge.MethodId _createServerSocket23262;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _createServerSocket23263;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2);
		internal static global::MonoJavaBridge.MethodId _ServerSocketFactory23264;
		protected ServerSocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._ServerSocketFactory23264);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
			global::javax.net.ServerSocketFactory._getDefault23259 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			global::javax.net.ServerSocketFactory._createServerSocket23260 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "()Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket23261 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket23262 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._createServerSocket23263 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory._ServerSocketFactory23264 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ServerSocketFactory))]
	public sealed partial class ServerSocketFactory_ : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ServerSocketFactory_()
		{
			InitJNI();
		}
		internal ServerSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23265;
		public override global::java.net.ServerSocket createServerSocket(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket23265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket23265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23266;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.net.ServerSocket;
		}
		internal static global::MonoJavaBridge.MethodId _createServerSocket23267;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_._createServerSocket23267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ServerSocketFactory_.staticClass, global::javax.net.ServerSocketFactory_._createServerSocket23267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.net.ServerSocket;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
			global::javax.net.ServerSocketFactory_._createServerSocket23265 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory_._createServerSocket23266 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;");
			global::javax.net.ServerSocketFactory_._createServerSocket23267 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;");
		}
	}
}
