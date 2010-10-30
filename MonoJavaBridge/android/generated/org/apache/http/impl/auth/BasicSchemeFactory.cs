namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicSchemeFactory : java.lang.Object, org.apache.http.auth.AuthSchemeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicSchemeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance32725;
		public virtual global::org.apache.http.auth.AuthScheme newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.impl.auth.BasicSchemeFactory._newInstance32725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _BasicSchemeFactory32726;
		public BasicSchemeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.BasicSchemeFactory._BasicSchemeFactory32726.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.BasicSchemeFactory._BasicSchemeFactory32726 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.BasicSchemeFactory.staticClass, global::org.apache.http.impl.auth.BasicSchemeFactory._BasicSchemeFactory32726);
			Init(@__env, handle);
		}
		static BasicSchemeFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/BasicSchemeFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
