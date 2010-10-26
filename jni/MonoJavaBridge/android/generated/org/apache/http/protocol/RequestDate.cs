namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestDate : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RequestDate()
		{
			InitJNI();
		}
		protected RequestDate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33939;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestDate._process33939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.RequestDate.staticClass, global::org.apache.http.protocol.RequestDate._process33939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestDate33940;
		public RequestDate()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestDate.staticClass, global::org.apache.http.protocol.RequestDate._RequestDate33940);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestDate.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestDate"));
			global::org.apache.http.protocol.RequestDate._process33939 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestDate.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.RequestDate._RequestDate33940 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestDate.staticClass, "<init>", "()V");
		}
	}
}
