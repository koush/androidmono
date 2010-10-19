namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DefaultedHttpContext : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultedHttpContext()
		{
			InitJNI();
		}
		internal DefaultedHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute27078;
		public global::java.lang.Object getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext._getAttribute27078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._getAttribute27078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute27079;
		public global::java.lang.Object removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute27079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute27079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute27080;
		public void setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext._setAttribute27080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._setAttribute27080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.apache.http.protocol.HttpContext Defaults
		{
			get
			{
				return getDefaults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaults27081;
		public global::org.apache.http.protocol.HttpContext getDefaults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext._getDefaults27081)) as org.apache.http.protocol.HttpContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._getDefaults27081)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultedHttpContext27082;
		public DefaultedHttpContext(org.apache.http.protocol.HttpContext arg0, org.apache.http.protocol.HttpContext arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._DefaultedHttpContext27082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.DefaultedHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/DefaultedHttpContext"));
			global::org.apache.http.protocol.DefaultedHttpContext._getAttribute27078 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute27079 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.DefaultedHttpContext._setAttribute27080 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.DefaultedHttpContext._getDefaults27081 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "getDefaults", "()Lorg/apache/http/protocol/HttpContext;");
			global::org.apache.http.protocol.DefaultedHttpContext._DefaultedHttpContext27082 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
