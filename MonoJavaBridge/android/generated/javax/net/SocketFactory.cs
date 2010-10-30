namespace javax.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.SocketFactory_))]
	public abstract partial class SocketFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::javax.net.SocketFactory getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.SocketFactory._m0.native == global::System.IntPtr.Zero)
				global::javax.net.SocketFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "getDefault", "()Ljavax/net/SocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._m0)) as javax.net.SocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.net.Socket createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.SocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::javax.net.SocketFactory._m1) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m6;
		protected SocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.SocketFactory._m6.native == global::System.IntPtr.Zero)
				global::javax.net.SocketFactory._m6 = @__env.GetMethodIDNoThrow(global::javax.net.SocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.SocketFactory.staticClass, global::javax.net.SocketFactory._m6);
			Init(@__env, handle);
		}
		static SocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.SocketFactory))]
	internal sealed partial class SocketFactory_ : javax.net.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SocketFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", ref global::javax.net.SocketFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.net.Socket createSocket(java.lang.String arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.SocketFactory_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.SocketFactory_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.net.Socket createSocket(java.net.InetAddress arg0, int arg1, java.net.InetAddress arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.net.SocketFactory_.staticClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", ref global::javax.net.SocketFactory_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.net.Socket;
		}
		static SocketFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.SocketFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/SocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
