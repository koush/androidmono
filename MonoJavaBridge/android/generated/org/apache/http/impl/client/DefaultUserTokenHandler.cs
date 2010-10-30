namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultUserTokenHandler : java.lang.Object, org.apache.http.client.UserTokenHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultUserTokenHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object getUserToken(org.apache.http.protocol.HttpContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, "getUserToken", "(Lorg/apache/http/protocol/HttpContext;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.DefaultUserTokenHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DefaultUserTokenHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultUserTokenHandler._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultUserTokenHandler._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultUserTokenHandler.staticClass, global::org.apache.http.impl.client.DefaultUserTokenHandler._m1);
			Init(@__env, handle);
		}
		static DefaultUserTokenHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultUserTokenHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultUserTokenHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
