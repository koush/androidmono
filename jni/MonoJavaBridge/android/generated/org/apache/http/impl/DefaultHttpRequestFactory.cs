namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpRequestFactory : java.lang.Object, HttpRequestFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultHttpRequestFactory()
		{
			InitJNI();
		}
		protected DefaultHttpRequestFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newHttpRequest32639;
		public virtual global::org.apache.http.HttpRequest newHttpRequest(org.apache.http.RequestLine arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _newHttpRequest32640;
		public virtual global::org.apache.http.HttpRequest newHttpRequest(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequest>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HttpRequest;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpRequestFactory32641;
		public DefaultHttpRequestFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpRequestFactory.staticClass, global::org.apache.http.impl.DefaultHttpRequestFactory._DefaultHttpRequestFactory32641);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpRequestFactory"));
			global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32639 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "newHttpRequest", "(Lorg/apache/http/RequestLine;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.DefaultHttpRequestFactory._newHttpRequest32640 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "newHttpRequest", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/HttpRequest;");
			global::org.apache.http.impl.DefaultHttpRequestFactory._DefaultHttpRequestFactory32641 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpRequestFactory.staticClass, "<init>", "()V");
		}
	}
}
