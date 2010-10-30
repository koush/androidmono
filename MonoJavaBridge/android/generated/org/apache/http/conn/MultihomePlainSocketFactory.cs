namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MultihomePlainSocketFactory : java.lang.Object, org.apache.http.conn.scheme.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MultihomePlainSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32144;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._equals32144.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._equals32144 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._equals32144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32145;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32145.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32145 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32145);
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32146;
		public global::java.net.Socket createSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32146.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32146 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32146)) as java.net.Socket;
		}
		public static global::org.apache.http.conn.MultihomePlainSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory32147;
		public static global::org.apache.http.conn.MultihomePlainSocketFactory getSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._getSocketFactory32147.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._getSocketFactory32147 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.MultihomePlainSocketFactory>(@__env.CallStaticObjectMethod(org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._getSocketFactory32147)) as org.apache.http.conn.MultihomePlainSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32148;
		public global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32148.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32148 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32149;
		public bool isSecure(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32149.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32149 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static MultihomePlainSocketFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/MultihomePlainSocketFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
