namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpGet : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpGet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31920;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpGet._getMethod31920.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpGet._getMethod31920 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "getMethod", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._getMethod31920) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31921;
		public HttpGet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpGet._HttpGet31921.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpGet._HttpGet31921 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31921);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31922;
		public HttpGet(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpGet._HttpGet31922.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpGet._HttpGet31922 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31923;
		public HttpGet(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpGet._HttpGet31923.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpGet._HttpGet31923 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "GET";
			}
		}
		static HttpGet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpGet.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpGet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
