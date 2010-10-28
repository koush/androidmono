namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpPost : org.apache.http.client.methods.HttpEntityEnclosingRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpPost()
		{
			InitJNI();
		}
		protected HttpPost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31936;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPost._getMethod31936)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpPost.staticClass, global::org.apache.http.client.methods.HttpPost._getMethod31936)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpPost31937;
		public HttpPost() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPost.staticClass, global::org.apache.http.client.methods.HttpPost._HttpPost31937);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPost31938;
		public HttpPost(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPost.staticClass, global::org.apache.http.client.methods.HttpPost._HttpPost31938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpPost31939;
		public HttpPost(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpPost.staticClass, global::org.apache.http.client.methods.HttpPost._HttpPost31939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "POST";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpPost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpPost"));
			global::org.apache.http.client.methods.HttpPost._getMethod31936 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPost.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpPost._HttpPost31937 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPost.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpPost._HttpPost31938 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPost.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpPost._HttpPost31939 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpPost.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
