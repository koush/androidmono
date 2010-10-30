namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpTrace : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpTrace(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31958;
		public override global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._getMethod31958)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace31959;
		public HttpTrace() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace31959);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace31960;
		public HttpTrace(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace31960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace31961;
		public HttpTrace(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace31961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "TRACE";
			}
		}
		static HttpTrace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpTrace.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpTrace"));
			global::org.apache.http.client.methods.HttpTrace._getMethod31958 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace31959 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace31960 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace31961 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
