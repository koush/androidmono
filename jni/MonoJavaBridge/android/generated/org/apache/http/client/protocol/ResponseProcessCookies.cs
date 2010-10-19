namespace org.apache.http.client.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseProcessCookies : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResponseProcessCookies()
		{
			InitJNI();
		}
		protected ResponseProcessCookies(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process25346;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ResponseProcessCookies._process25346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, global::org.apache.http.client.protocol.ResponseProcessCookies._process25346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseProcessCookies25347;
		public ResponseProcessCookies()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.protocol.ResponseProcessCookies.staticClass, global::org.apache.http.client.protocol.ResponseProcessCookies._ResponseProcessCookies25347);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/protocol/ResponseProcessCookies"));
			global::org.apache.http.client.protocol.ResponseProcessCookies._process25346 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.client.protocol.ResponseProcessCookies._ResponseProcessCookies25347 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.protocol.ResponseProcessCookies.staticClass, "<init>", "()V");
		}
	}
}
