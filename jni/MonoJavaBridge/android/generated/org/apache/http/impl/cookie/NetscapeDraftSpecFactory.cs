namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftSpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NetscapeDraftSpecFactory()
		{
			InitJNI();
		}
		protected NetscapeDraftSpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance26573;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._newInstance26573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.cookie.CookieSpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._newInstance26573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpecFactory26574;
		public NetscapeDraftSpecFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._NetscapeDraftSpecFactory26574);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftSpecFactory"));
			global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._newInstance26573 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, "newInstance", "(Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory._NetscapeDraftSpecFactory26574 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpecFactory.staticClass, "<init>", "()V");
		}
	}
}
