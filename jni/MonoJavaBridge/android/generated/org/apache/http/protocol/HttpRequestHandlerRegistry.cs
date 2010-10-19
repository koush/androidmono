namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestHandlerRegistry : java.lang.Object, HttpRequestHandlerResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRequestHandlerRegistry()
		{
			InitJNI();
		}
		protected HttpRequestHandlerRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register27101;
		public virtual void register(java.lang.String arg0, org.apache.http.protocol.HttpRequestHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry._register27101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._register27101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lookup27102;
		public virtual global::org.apache.http.protocol.HttpRequestHandler lookup(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpRequestHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry._lookup27102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.protocol.HttpRequestHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpRequestHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._lookup27102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.protocol.HttpRequestHandler;
		}
		internal static global::MonoJavaBridge.MethodId _unregister27103;
		public virtual void unregister(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry._unregister27103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._unregister27103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandlers27104;
		public virtual void setHandlers(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry._setHandlers27104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._setHandlers27104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchUriRequestPattern27105;
		protected virtual bool matchUriRequestPattern(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry._matchUriRequestPattern27105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._matchUriRequestPattern27105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestHandlerRegistry27106;
		public HttpRequestHandlerRegistry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._HttpRequestHandlerRegistry27106);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestHandlerRegistry"));
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._register27101 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/protocol/HttpRequestHandler;)V");
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._lookup27102 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;");
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._unregister27103 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._setHandlers27104 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "setHandlers", "(Ljava/util/Map;)V");
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._matchUriRequestPattern27105 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.apache.http.protocol.HttpRequestHandlerRegistry._HttpRequestHandlerRegistry27106 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "<init>", "()V");
		}
	}
}
