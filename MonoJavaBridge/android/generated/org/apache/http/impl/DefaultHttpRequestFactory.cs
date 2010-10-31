namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpRequestFactory : java.lang.Object, HttpRequestFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpRequestFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HttpRequest newHttpRequest(org.apache.http.RequestLine arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.DefaultHttpRequestFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.HttpRequest newHttpRequest(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequest>(this, global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;", ref global::org.apache.http.impl.DefaultHttpRequestFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpRequest;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DefaultHttpRequestFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpRequestFactory._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpRequestFactory._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpRequestFactory.staticClass, global::org.apache.http.impl.DefaultHttpRequestFactory._m2);
			Init(@__env, handle);
		}
		static DefaultHttpRequestFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpRequestFactory"));
		}
	}
}
