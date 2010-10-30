namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DefaultedHttpContext : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DefaultedHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33843;
		public global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.DefaultedHttpContext._getAttribute33843.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.DefaultedHttpContext._getAttribute33843 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._getAttribute33843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33844;
		public global::java.lang.Object removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute33844.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute33844 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._removeAttribute33844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33845;
		public void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.DefaultedHttpContext._setAttribute33845.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.DefaultedHttpContext._setAttribute33845 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._setAttribute33845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.apache.http.protocol.HttpContext Defaults
		{
			get
			{
				return getDefaults();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaults33846;
		public global::org.apache.http.protocol.HttpContext getDefaults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.DefaultedHttpContext._getDefaults33846.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.DefaultedHttpContext._getDefaults33846 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "getDefaults", "()Lorg/apache/http/protocol/HttpContext;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.protocol.HttpContext>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._getDefaults33846)) as org.apache.http.protocol.HttpContext;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultedHttpContext33847;
		public DefaultedHttpContext(org.apache.http.protocol.HttpContext arg0, org.apache.http.protocol.HttpContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.DefaultedHttpContext._DefaultedHttpContext33847.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.DefaultedHttpContext._DefaultedHttpContext33847 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.DefaultedHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.DefaultedHttpContext.staticClass, global::org.apache.http.protocol.DefaultedHttpContext._DefaultedHttpContext33847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DefaultedHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.DefaultedHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/DefaultedHttpContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
