namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriPatternMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UriPatternMatcher()
		{
			InitJNI();
		}
		protected UriPatternMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register27157;
		public virtual void register(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher._register27157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._register27157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lookup27158;
		public virtual global::java.lang.Object lookup(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher._lookup27158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._lookup27158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _unregister27159;
		public virtual void unregister(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher._unregister27159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._unregister27159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandlers27160;
		public virtual void setHandlers(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher._setHandlers27160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._setHandlers27160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _matchUriRequestPattern27161;
		protected virtual bool matchUriRequestPattern(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher._matchUriRequestPattern27161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._matchUriRequestPattern27161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _UriPatternMatcher27162;
		public UriPatternMatcher()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.UriPatternMatcher.staticClass, global::org.apache.http.protocol.UriPatternMatcher._UriPatternMatcher27162);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.UriPatternMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/UriPatternMatcher"));
			global::org.apache.http.protocol.UriPatternMatcher._register27157 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "register", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.UriPatternMatcher._lookup27158 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "lookup", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.UriPatternMatcher._unregister27159 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.protocol.UriPatternMatcher._setHandlers27160 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "setHandlers", "(Ljava/util/Map;)V");
			global::org.apache.http.protocol.UriPatternMatcher._matchUriRequestPattern27161 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "matchUriRequestPattern", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.apache.http.protocol.UriPatternMatcher._UriPatternMatcher27162 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.UriPatternMatcher.staticClass, "<init>", "()V");
		}
	}
}
