namespace org.apache.http.cookie.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CookieSpecParamBean : org.apache.http.@params.HttpAbstractParamBean
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSpecParamBean()
		{
			InitJNI();
		}
		protected CookieSpecParamBean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setDatePatterns25747;
		public virtual void setDatePatterns(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.@params.CookieSpecParamBean._setDatePatterns25747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, global::org.apache.http.cookie.@params.CookieSpecParamBean._setDatePatterns25747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSingleHeader25748;
		public virtual void setSingleHeader(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.@params.CookieSpecParamBean._setSingleHeader25748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, global::org.apache.http.cookie.@params.CookieSpecParamBean._setSingleHeader25748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CookieSpecParamBean25749;
		public CookieSpecParamBean(org.apache.http.@params.HttpParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, global::org.apache.http.cookie.@params.CookieSpecParamBean._CookieSpecParamBean25749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/@params/CookieSpecParamBean"));
			global::org.apache.http.cookie.@params.CookieSpecParamBean._setDatePatterns25747 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "setDatePatterns", "(Ljava/util/Collection;)V");
			global::org.apache.http.cookie.@params.CookieSpecParamBean._setSingleHeader25748 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "setSingleHeader", "(Z)V");
			global::org.apache.http.cookie.@params.CookieSpecParamBean._CookieSpecParamBean25749 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.@params.CookieSpecParamBean.staticClass, "<init>", "(Lorg/apache/http/@params/HttpParams;)V");
		}
	}
}
