namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncBasicHttpContext : org.apache.http.protocol.BasicHttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncBasicHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.protocol.SyncBasicHttpContext._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object removeAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.protocol.SyncBasicHttpContext._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.protocol.SyncBasicHttpContext._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public SyncBasicHttpContext(org.apache.http.protocol.HttpContext arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.SyncBasicHttpContext._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.SyncBasicHttpContext._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.SyncBasicHttpContext.staticClass, global::org.apache.http.protocol.SyncBasicHttpContext._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SyncBasicHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.SyncBasicHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/SyncBasicHttpContext"));
		}
	}
}
