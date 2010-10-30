namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RequestConnControl : java.lang.Object, HttpRequestInterceptor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RequestConnControl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _process33936;
		public virtual void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestConnControl._process33936.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestConnControl._process33936 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestConnControl.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.RequestConnControl.staticClass, global::org.apache.http.protocol.RequestConnControl._process33936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RequestConnControl33937;
		public RequestConnControl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.RequestConnControl._RequestConnControl33937.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.RequestConnControl._RequestConnControl33937 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.RequestConnControl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.RequestConnControl.staticClass, global::org.apache.http.protocol.RequestConnControl._RequestConnControl33937);
			Init(@__env, handle);
		}
		static RequestConnControl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.RequestConnControl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/RequestConnControl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
