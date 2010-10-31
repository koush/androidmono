namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpResponseFactory : java.lang.Object, HttpResponseFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpResponseFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.ProtocolVersion arg0, int arg1, org.apache.http.protocol.HttpContext arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "newHttpResponse", "(Lorg/apache/http/ProtocolVersion;ILorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.DefaultHttpResponseFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.HttpResponse newHttpResponse(org.apache.http.StatusLine arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "newHttpResponse", "(Lorg/apache/http/StatusLine;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/HttpResponse;", ref global::org.apache.http.impl.DefaultHttpResponseFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HttpResponse;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::java.util.Locale determineLocale(org.apache.http.protocol.HttpContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "determineLocale", "(Lorg/apache/http/protocol/HttpContext;)Ljava/util/Locale;", ref global::org.apache.http.impl.DefaultHttpResponseFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public DefaultHttpResponseFactory(org.apache.http.ReasonPhraseCatalog arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpResponseFactory._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpResponseFactory._m3 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "<init>", "(Lorg/apache/http/ReasonPhraseCatalog;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DefaultHttpResponseFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.DefaultHttpResponseFactory._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.DefaultHttpResponseFactory._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpResponseFactory.staticClass, global::org.apache.http.impl.DefaultHttpResponseFactory._m4);
			Init(@__env, handle);
		}
		static DefaultHttpResponseFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpResponseFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpResponseFactory"));
		}
	}
}
