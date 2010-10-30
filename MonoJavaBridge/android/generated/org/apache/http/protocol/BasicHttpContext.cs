namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpContext : java.lang.Object, HttpContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHttpContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute33815;
		public virtual global::java.lang.Object getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._getAttribute33815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _removeAttribute33816;
		public virtual global::java.lang.Object removeAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._removeAttribute33816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute33817;
		public virtual void setAttribute(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._setAttribute33817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpContext33818;
		public BasicHttpContext() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33818);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpContext33819;
		public BasicHttpContext(org.apache.http.protocol.HttpContext arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpContext.staticClass, global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicHttpContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpContext"));
			global::org.apache.http.protocol.BasicHttpContext._getAttribute33815 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpContext._removeAttribute33816 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "removeAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpContext._setAttribute33817 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33818 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "<init>", "()V");
			global::org.apache.http.protocol.BasicHttpContext._BasicHttpContext33819 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpContext.staticClass, "<init>", "(Lorg/apache/http/protocol/HttpContext;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
