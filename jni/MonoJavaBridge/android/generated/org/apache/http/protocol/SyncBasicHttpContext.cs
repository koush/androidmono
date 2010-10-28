namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncBasicHttpContext : org.apache.http.protocol.BasicHttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncBasicHttpContext()
		{
			InitJNI();
		}
		protected SyncBasicHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33956;
		public override global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext._getAttribute33956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, global::org.apache.http.protocol.SyncBasicHttpContext._getAttribute33956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33957;
		public override global::java.lang.Object removeAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext._removeAttribute33957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, global::org.apache.http.protocol.SyncBasicHttpContext._removeAttribute33957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33958;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext._setAttribute33958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, global::org.apache.http.protocol.SyncBasicHttpContext._setAttribute33958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _SyncBasicHttpContext33959;
		public SyncBasicHttpContext(org.apache.http.protocol.HttpContext arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.SyncBasicHttpContext.staticClass, global::org.apache.http.protocol.SyncBasicHttpContext._SyncBasicHttpContext33959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.SyncBasicHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/SyncBasicHttpContext"));
			global::org.apache.http.protocol.SyncBasicHttpContext._getAttribute33956 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.SyncBasicHttpContext._removeAttribute33957 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.SyncBasicHttpContext._setAttribute33958 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.SyncBasicHttpContext._SyncBasicHttpContext33959 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.SyncBasicHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
