namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpContext : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpContext()
		{
			InitJNI();
		}
		protected BasicHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33814;
		public virtual global::java.lang.Object getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext._getAttribute33814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._getAttribute33814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33815;
		public virtual global::java.lang.Object removeAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext._removeAttribute33815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._removeAttribute33815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33816;
		public virtual void setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext._setAttribute33816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._setAttribute33816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpContext33817;
		public BasicHttpContext()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33817);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpContext33818;
		public BasicHttpContext(org.apache.http.protocol.HttpContext arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpContext"));
			global::org.apache.http.protocol.BasicHttpContext._getAttribute33814 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpContext._removeAttribute33815 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpContext._setAttribute33816 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33817 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "<init>", "()V");
			global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33818 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
		}
	}
}
