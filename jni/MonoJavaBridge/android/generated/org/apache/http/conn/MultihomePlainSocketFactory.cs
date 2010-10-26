namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MultihomePlainSocketFactory : java.lang.Object, org.apache.http.conn.scheme.SocketFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MultihomePlainSocketFactory()
		{
			InitJNI();
		}
		internal MultihomePlainSocketFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals32143;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory._equals32143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._equals32143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode32144;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32144);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32144);
		}
		internal static global::MonoJavaBridge.MethodId _createSocket32145;
		public global::java.net.Socket createSocket() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32145)) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32145)) as java.net.Socket;
		}
		public static global::org.apache.http.conn.MultihomePlainSocketFactory SocketFactory
		{
			get
			{
				return getSocketFactory();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketFactory32146;
		public static global::org.apache.http.conn.MultihomePlainSocketFactory getSocketFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.conn.MultihomePlainSocketFactory>(@__env.CallStaticObjectMethod(org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._getSocketFactory32146)) as org.apache.http.conn.MultihomePlainSocketFactory;
		}
		internal static global::MonoJavaBridge.MethodId _connectSocket32147;
		public global::java.net.Socket connectSocket(java.net.Socket arg0, java.lang.String arg1, int arg2, java.net.InetAddress arg3, int arg4, org.apache.http.@params.HttpParams arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.net.Socket;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32148;
		public bool isSecure(java.net.Socket arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/MultihomePlainSocketFactory"));
			global::org.apache.http.conn.MultihomePlainSocketFactory._equals32143 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.conn.MultihomePlainSocketFactory._hashCode32144 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "hashCode", "()I");
			global::org.apache.http.conn.MultihomePlainSocketFactory._createSocket32145 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "createSocket", "()Ljava/net/Socket;");
			global::org.apache.http.conn.MultihomePlainSocketFactory._getSocketFactory32146 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "getSocketFactory", "()Lorg/apache/http/conn/MultihomePlainSocketFactory;");
			global::org.apache.http.conn.MultihomePlainSocketFactory._connectSocket32147 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			global::org.apache.http.conn.MultihomePlainSocketFactory._isSecure32148 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.MultihomePlainSocketFactory.staticClass, "isSecure", "(Ljava/net/Socket;)Z");
		}
	}
}
