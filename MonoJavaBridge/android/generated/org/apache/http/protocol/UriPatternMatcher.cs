namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriPatternMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UriPatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register33960;
		public virtual void register(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._register33960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lookup33961;
		public virtual global::java.lang.Object lookup(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._lookup33961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _unregister33962;
		public virtual void unregister(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._unregister33962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Map Handlers
		{
			set
			{
				setHandlers(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHandlers33963;
		public virtual void setHandlers(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._setHandlers33963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchUriRequestPattern33964;
		protected virtual bool matchUriRequestPattern(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._matchUriRequestPattern33964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _UriPatternMatcher33965;
		public UriPatternMatcher() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._UriPatternMatcher33965);
			Init(@__env, handle);
		}
		static UriPatternMatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.UriPatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/UriPatternMatcher"));
			global::org.apache.http.protocol.UriPatternMatcher._register33960 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "register", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.UriPatternMatcher._lookup33961 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "lookup", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.UriPatternMatcher._unregister33962 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.protocol.UriPatternMatcher._setHandlers33963 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "setHandlers", "(Ljava/util/Map;)V");
			global::org.apache.http.protocol.UriPatternMatcher._matchUriRequestPattern33964 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.apache.http.protocol.UriPatternMatcher._UriPatternMatcher33965 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
