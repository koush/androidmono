namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftSpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetscapeDraftSpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance33319;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", ref global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._newInstance33319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpecFactory33320;
		public NetscapeDraftSpecFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._NetscapeDraftSpecFactory33320.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._NetscapeDraftSpecFactory33320 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._NetscapeDraftSpecFactory33320);
			Init(@__env, handle);
		}
		static NetscapeDraftSpecFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftSpecFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
