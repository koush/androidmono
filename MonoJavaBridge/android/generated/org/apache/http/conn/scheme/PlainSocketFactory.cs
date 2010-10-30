namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PlainSocketFactory : java.lang.Object, SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PlainSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.conn.scheme.PlainSocketFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "hashCode", "()I", ref global::org.apache.http.conn.scheme.PlainSocketFactory._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.net.Socket createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::org.apache.http.conn.scheme.PlainSocketFactory._m2) as java.net.Socket;
		}
		public static global::org.apache.http.conn.scheme.PlainSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.apache.http.conn.scheme.PlainSocketFactory getSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.PlainSocketFactory._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.PlainSocketFactory._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.PlainSocketFactory>(@__env.CallStaticObjectMethod(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._m3)) as org.apache.http.conn.scheme.PlainSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;", ref global::org.apache.http.conn.scheme.PlainSocketFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool isSecure(java.net.Socket arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z", ref global::org.apache.http.conn.scheme.PlainSocketFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PlainSocketFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.PlainSocketFactory._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.PlainSocketFactory._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._m6);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public PlainSocketFactory(org.apache.http.conn.scheme.HostNameResolver arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.PlainSocketFactory._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.PlainSocketFactory._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/HostNameResolver;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PlainSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/PlainSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
