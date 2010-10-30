namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoConnectionReuseStrategy : java.lang.Object, ConnectionReuseStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoConnectionReuseStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool keepAlive(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "keepAlive", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.NoConnectionReuseStrategy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoConnectionReuseStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.NoConnectionReuseStrategy._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.NoConnectionReuseStrategy._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.NoConnectionReuseStrategy.staticClass, global::org.apache.http.impl.NoConnectionReuseStrategy._m1);
			Init(@__env, handle);
		}
		static NoConnectionReuseStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.NoConnectionReuseStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/NoConnectionReuseStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
