namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpHead : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpHead()
		{
			InitJNI();
		}
		protected HttpHead(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Method
		{
			get
			{
				return getMethod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31925;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpHead._getMethod31925)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpHead.staticClass, global::org.apache.http.client.methods.HttpHead._getMethod31925)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpHead31926;
		public HttpHead() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpHead.staticClass, global::org.apache.http.client.methods.HttpHead._HttpHead31926);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHead31927;
		public HttpHead(java.net.URI arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpHead.staticClass, global::org.apache.http.client.methods.HttpHead._HttpHead31927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpHead31928;
		public HttpHead(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpHead.staticClass, global::org.apache.http.client.methods.HttpHead._HttpHead31928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String METHOD_NAME
		{
			get
			{
				return "HEAD";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpHead.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpHead"));
			global::org.apache.http.client.methods.HttpHead._getMethod31925 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpHead.staticClass, "getMethod", "()Ljava/lang/String;");
			global::org.apache.http.client.methods.HttpHead._HttpHead31926 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpHead.staticClass, "<init>", "()V");
			global::org.apache.http.client.methods.HttpHead._HttpHead31927 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpHead.staticClass, "<init>", "(Ljava/net/URI;)V");
			global::org.apache.http.client.methods.HttpHead._HttpHead31928 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpHead.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
