namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultConnectionKeepAliveStrategy : java.lang.Object, org.apache.http.conn.ConnectionKeepAliveStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultConnectionKeepAliveStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, "getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J", ref global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DefaultConnectionKeepAliveStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._m1);
			Init(@__env, handle);
		}
		static DefaultConnectionKeepAliveStrategy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultConnectionKeepAliveStrategy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
