namespace javax.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ServerSocketFactory_))]
	public abstract partial class ServerSocketFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ServerSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.ServerSocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ServerSocketFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.net.ServerSocketFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "getDefault", "()Ljavax/net/ServerSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._m0)) as javax.net.ServerSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.net.ServerSocket createServerSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ServerSocketFactory.staticClass, "createServerSocket", "()Ljava/net/ServerSocket;", ref global::javax.net.ServerSocketFactory._m1) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		protected ServerSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ServerSocketFactory._m5.native == global::System.IntPtr.Zero)
				global::javax.net.ServerSocketFactory._m5 = @__env.GetMethodIDNoThrow(global::javax.net.ServerSocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ServerSocketFactory.staticClass, global::javax.net.ServerSocketFactory._m5);
			Init(@__env, handle);
		}
		static ServerSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ServerSocketFactory))]
	internal sealed partial class ServerSocketFactory_ : javax.net.ServerSocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ServerSocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.net.ServerSocket createServerSocket(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(I)Ljava/net/ServerSocket;", ref global::javax.net.ServerSocketFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(II)Ljava/net/ServerSocket;", ref global::javax.net.ServerSocketFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.ServerSocket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.net.ServerSocket createServerSocket(int arg0, int arg1, java.net.InetAddress arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.ServerSocketFactory_.staticClass, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", ref global::javax.net.ServerSocketFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.net.ServerSocket;
		}
		static ServerSocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ServerSocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ServerSocketFactory"));
		}
	}
}
