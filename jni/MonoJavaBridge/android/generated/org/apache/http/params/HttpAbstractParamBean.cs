namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.@params.HttpAbstractParamBean_))]
	public abstract partial class HttpAbstractParamBean : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpAbstractParamBean()
		{
			InitJNI();
		}
		protected HttpAbstractParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _HttpAbstractParamBean33764;
		public HttpAbstractParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.HttpAbstractParamBean.staticClass, global::org.apache.http.@params.HttpAbstractParamBean._HttpAbstractParamBean33764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpAbstractParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpAbstractParamBean"));
			global::org.apache.http.@params.HttpAbstractParamBean._HttpAbstractParamBean33764 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.HttpAbstractParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.HttpAbstractParamBean))]
	internal sealed partial class HttpAbstractParamBean_ : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpAbstractParamBean_()
		{
			InitJNI();
		}
		internal HttpAbstractParamBean_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.HttpAbstractParamBean_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/HttpAbstractParamBean"));
		}
	}
}
