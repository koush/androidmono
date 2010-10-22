namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PlainSocketFactory : java.lang.Object, SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PlainSocketFactory()
		{
			InitJNI();
		}
		internal PlainSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32175;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory._equals32175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._equals32175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32176;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory._hashCode32176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._hashCode32176);
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32177;
		public global::java.net.Socket createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory._createSocket32177)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._createSocket32177)) as java.net.Socket;
		}
		public static global::org.apache.http.conn.scheme.PlainSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory32178;
		public static global::org.apache.http.conn.scheme.PlainSocketFactory getSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.scheme.PlainSocketFactory>(@__env.CallStaticObjectMethod(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._getSocketFactory32178)) as org.apache.http.conn.scheme.PlainSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32179;
		public global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory._connectSocket32179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._connectSocket32179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32180;
		public bool isSecure(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory._isSecure32180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._isSecure32180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PlainSocketFactory32181;
		public PlainSocketFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._PlainSocketFactory32181);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PlainSocketFactory32182;
		public PlainSocketFactory(org.apache.http.conn.scheme.HostNameResolver arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.PlainSocketFactory.staticClass, global::org.apache.http.conn.scheme.PlainSocketFactory._PlainSocketFactory32182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/PlainSocketFactory"));
			global::org.apache.http.conn.scheme.PlainSocketFactory._equals32175 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.scheme.PlainSocketFactory._hashCode32176 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.scheme.PlainSocketFactory._createSocket32177 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.PlainSocketFactory._getSocketFactory32178 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/scheme/PlainSocketFactory;");
			global::org.apache.http.conn.scheme.PlainSocketFactory._connectSocket32179 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/@params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.scheme.PlainSocketFactory._isSecure32180 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
			global::org.apache.http.conn.scheme.PlainSocketFactory._PlainSocketFactory32181 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "<init>", "()V");
			global::org.apache.http.conn.scheme.PlainSocketFactory._PlainSocketFactory32182 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.PlainSocketFactory.staticClass, "<init>", "(Lorg/apache/http/conn/scheme/HostNameResolver;)V");
		}
	}
}
