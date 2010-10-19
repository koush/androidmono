namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpTrace : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpTrace()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMethod25288;
		public override global::java.lang.String getMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpTrace._getMethod25288)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._getMethod25288)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace25289;
		public HttpTrace()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace25289);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace25290;
		public HttpTrace(java.net.URI arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace25290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpTrace25291;
		public HttpTrace(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpTrace.staticClass, global::org.apache.http.client.methods.HttpTrace._HttpTrace25291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "TRACE";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpTrace.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpTrace"));
			global::org.apache.http.client.methods.HttpTrace._getMethod25288 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace25289 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace25290 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpTrace._HttpTrace25291 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpTrace.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
