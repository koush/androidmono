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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpTrace.staticClass, "getMethod", "()Ljava/lang/String;", ref global::org.apache.http.client.methods.HttpTrace._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public HttpTrace() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpTrace._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpTrace._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._m1);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public HttpTrace(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpTrace._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpTrace._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public HttpTrace(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpTrace._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpTrace._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
