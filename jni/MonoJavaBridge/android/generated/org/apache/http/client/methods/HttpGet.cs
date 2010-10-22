namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpGet : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpGet()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMethod31801;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpGet._getMethod31801)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._getMethod31801)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31802;
		public HttpGet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31802);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31803;
		public HttpGet(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpGet31804;
		public HttpGet(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpGet.staticClass, global::org.apache.http.client.methods.HttpGet._HttpGet31804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "GET";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpGet.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpGet"));
			global::org.apache.http.client.methods.HttpGet._getMethod31801 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpGet._HttpGet31802 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpGet._HttpGet31803 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpGet._HttpGet31804 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpGet.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
