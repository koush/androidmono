namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicSchemeFactory : java.lang.Object, org.apache.http.auth.AuthSchemeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicSchemeFactory()
		{
			InitJNI();
		}
		protected BasicSchemeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance32724;
		public virtual global::org.apache.http.auth.AuthScheme newInstance(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicSchemeFactory._newInstance32724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.AuthScheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass, global::org.apache.http.impl.auth.BasicSchemeFactory._newInstance32724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _BasicSchemeFactory32725;
		public BasicSchemeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.BasicSchemeFactory.staticClass, global::org.apache.http.impl.auth.BasicSchemeFactory._BasicSchemeFactory32725);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/BasicSchemeFactory"));
			global::org.apache.http.impl.auth.BasicSchemeFactory._newInstance32724 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.impl.auth.BasicSchemeFactory._BasicSchemeFactory32725 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicSchemeFactory.staticClass, "<init>", "()V");
		}
	}
}
