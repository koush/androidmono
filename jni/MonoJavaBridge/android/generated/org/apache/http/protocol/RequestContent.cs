namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestContent : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestContent()
		{
			InitJNI();
		}
		protected RequestContent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process27135;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestContent._process27135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestContent.staticClass, global::org.apache.http.protocol.RequestContent._process27135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestContent27136;
		public RequestContent()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestContent.staticClass, global::org.apache.http.protocol.RequestContent._RequestContent27136);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestContent.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestContent"));
			global::org.apache.http.protocol.RequestContent._process27135 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestContent.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.RequestContent._RequestContent27136 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestContent.staticClass, "<init>", "()V");
		}
	}
}
