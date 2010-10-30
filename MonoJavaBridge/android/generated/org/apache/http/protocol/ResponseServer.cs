namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseServer : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseServer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33954;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.ResponseServer.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.ResponseServer._process33954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseServer33955;
		public ResponseServer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.ResponseServer._ResponseServer33955.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.ResponseServer._ResponseServer33955 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseServer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.ResponseServer.staticClass, global::org.apache.http.protocol.ResponseServer._ResponseServer33955);
			Init(@__env, handle);
		}
		static ResponseServer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ResponseServer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ResponseServer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
