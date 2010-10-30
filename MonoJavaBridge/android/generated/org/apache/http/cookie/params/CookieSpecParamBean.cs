namespace org.apache.http.cookie.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CookieSpecParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CookieSpecParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.util.Collection DatePatterns
		{
			set
			{
				setDatePatterns(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setDatePatterns(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "setDatePatterns", "(Ljava/util/Collection;)V", ref global::org.apache.http.cookie.@params.CookieSpecParamBean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool SingleHeader
		{
			set
			{
				setSingleHeader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setSingleHeader(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "setSingleHeader", "(Z)V", ref global::org.apache.http.cookie.@params.CookieSpecParamBean._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public CookieSpecParamBean(org.apache.http.@params.HttpParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.@params.CookieSpecParamBean._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.@params.CookieSpecParamBean._m2 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, global::org.apache.http.cookie.@params.CookieSpecParamBean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CookieSpecParamBean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/params/CookieSpecParamBean"));
		}
		internal static void InitJNI()
		{
		}
	}
}
