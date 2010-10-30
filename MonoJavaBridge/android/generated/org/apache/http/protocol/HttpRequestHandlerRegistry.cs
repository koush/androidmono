namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRequestHandlerRegistry : java.lang.Object, HttpRequestHandlerResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestHandlerRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register33904;
		public virtual void register(java.lang.String arg0, org.apache.http.protocol.HttpRequestHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/protocol/HttpRequestHandler;)V", ref global::org.apache.http.protocol.HttpRequestHandlerRegistry._register33904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lookup33905;
		public virtual global::org.apache.http.protocol.HttpRequestHandler lookup(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.protocol.HttpRequestHandler>(this, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "lookup", "(Ljava/lang/String;)Lorg/apache/http/protocol/HttpRequestHandler;", ref global::org.apache.http.protocol.HttpRequestHandlerRegistry._lookup33905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.protocol.HttpRequestHandler;
		}
		internal static global::MonoJavaBridge.MethodId _unregister33906;
		public virtual void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "unregister", "(Ljava/lang/String;)V", ref global::org.apache.http.protocol.HttpRequestHandlerRegistry._unregister33906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map Handlers
		{
			set
			{
				setHandlers(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHandlers33907;
		public virtual void setHandlers(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "setHandlers", "(Ljava/util/Map;)V", ref global::org.apache.http.protocol.HttpRequestHandlerRegistry._setHandlers33907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchUriRequestPattern33908;
		protected virtual bool matchUriRequestPattern(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z", ref global::org.apache.http.protocol.HttpRequestHandlerRegistry._matchUriRequestPattern33908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestHandlerRegistry33909;
		public HttpRequestHandlerRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpRequestHandlerRegistry._HttpRequestHandlerRegistry33909.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpRequestHandlerRegistry._HttpRequestHandlerRegistry33909 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass, global::org.apache.http.protocol.HttpRequestHandlerRegistry._HttpRequestHandlerRegistry33909);
			Init(@__env, handle);
		}
		static HttpRequestHandlerRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpRequestHandlerRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpRequestHandlerRegistry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
