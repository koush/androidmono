namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.HttpAbstractParamBean_))]
	public abstract partial class HttpAbstractParamBean : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpAbstractParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public HttpAbstractParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.HttpAbstractParamBean._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.HttpAbstractParamBean._m0 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpAbstractParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpAbstractParamBean.staticClass, global::org.apache.http.@params.HttpAbstractParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HttpAbstractParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpAbstractParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpAbstractParamBean"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.HttpAbstractParamBean))]
	internal sealed partial class HttpAbstractParamBean_ : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpAbstractParamBean_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static HttpAbstractParamBean_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpAbstractParamBean_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpAbstractParamBean"));
		}
	}
}
