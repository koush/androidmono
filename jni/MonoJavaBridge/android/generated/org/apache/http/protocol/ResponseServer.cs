namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseServer : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResponseServer()
		{
			InitJNI();
		}
		protected ResponseServer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33953;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseServer._process33953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseServer.staticClass, global::org.apache.http.protocol.ResponseServer._process33953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseServer33954;
		public ResponseServer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.ResponseServer.staticClass, global::org.apache.http.protocol.ResponseServer._ResponseServer33954);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ResponseServer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ResponseServer"));
			global::org.apache.http.protocol.ResponseServer._process33953 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseServer.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.ResponseServer._ResponseServer33954 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseServer.staticClass, "<init>", "()V");
		}
	}
}
