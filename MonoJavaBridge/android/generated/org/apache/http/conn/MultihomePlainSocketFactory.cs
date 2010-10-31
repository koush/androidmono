namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MultihomePlainSocketFactory : java.lang.Object, org.apache.http.conn.scheme.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MultihomePlainSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.conn.MultihomePlainSocketFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "hashCode", "()I", ref global::org.apache.http.conn.MultihomePlainSocketFactory._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.net.Socket createSocket()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;", ref global::org.apache.http.conn.MultihomePlainSocketFactory._m2) as java.net.Socket;
		}
		public static global::org.apache.http.conn.MultihomePlainSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.apache.http.conn.MultihomePlainSocketFactory getSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.MultihomePlainSocketFactory>(@__env.CallStaticObjectMethod(org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._m3)) as org.apache.http.conn.MultihomePlainSocketFactory;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;", ref global::org.apache.http.conn.MultihomePlainSocketFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5)) as java.net.Socket;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool isSecure(java.net.Socket arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z", ref global::org.apache.http.conn.MultihomePlainSocketFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static MultihomePlainSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/MultihomePlainSocketFactory"));
		}
	}
}
