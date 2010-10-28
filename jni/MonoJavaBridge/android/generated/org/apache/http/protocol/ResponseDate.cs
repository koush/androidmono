namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResponseDate : java.lang.Object, HttpResponseInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResponseDate(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33952;
		public virtual void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseDate._process33952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.ResponseDate.staticClass, global::org.apache.http.protocol.ResponseDate._process33952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResponseDate33953;
		public ResponseDate() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.ResponseDate.staticClass, global::org.apache.http.protocol.ResponseDate._ResponseDate33953);
			Init(@__env, handle);
		}
		static ResponseDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.ResponseDate.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/ResponseDate"));
			global::org.apache.http.protocol.ResponseDate._process33952 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseDate.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.ResponseDate._ResponseDate33953 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.ResponseDate.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
