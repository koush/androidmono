namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestSchemeFactory : java.lang.Object, org.apache.http.auth.AuthSchemeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigestSchemeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.auth.AuthScheme newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.impl.auth.DigestSchemeFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.AuthScheme;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DigestSchemeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.DigestSchemeFactory._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.DigestSchemeFactory._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.DigestSchemeFactory.staticClass, global::org.apache.http.impl.auth.DigestSchemeFactory._m1);
			Init(@__env, handle);
		}
		static DigestSchemeFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.DigestSchemeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/DigestSchemeFactory"));
		}
	}
}
