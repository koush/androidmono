namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultConnectionKeepAliveStrategy : java.lang.Object, org.apache.http.conn.ConnectionKeepAliveStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultConnectionKeepAliveStrategy()
		{
			InitJNI();
		}
		protected DefaultConnectionKeepAliveStrategy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeepAliveDuration32881;
		public virtual long getKeepAliveDuration(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._getKeepAliveDuration32881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._getKeepAliveDuration32881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultConnectionKeepAliveStrategy32882;
		public DefaultConnectionKeepAliveStrategy() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._DefaultConnectionKeepAliveStrategy32882);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultConnectionKeepAliveStrategy"));
			global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._getKeepAliveDuration32881 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, "getKeepAliveDuration", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)J");
			global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy._DefaultConnectionKeepAliveStrategy32882 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultConnectionKeepAliveStrategy.staticClass, "<init>", "()V");
		}
	}
}
