namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TunnelRefusedException : org.apache.http.HttpException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TunnelRefusedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.apache.http.HttpResponse Response
		{
			get
			{
				return getResponse();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponse32956;
		public virtual global::org.apache.http.HttpResponse getResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.TunnelRefusedException._getResponse32956.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.TunnelRefusedException._getResponse32956 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.TunnelRefusedException.staticClass, "getResponse", "()Lorg/apache/http/HttpResponse;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponse>(this, global::org.apache.http.impl.client.TunnelRefusedException.staticClass, global::org.apache.http.impl.client.TunnelRefusedException._getResponse32956) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _TunnelRefusedException32957;
		public TunnelRefusedException(java.lang.String arg0, org.apache.http.HttpResponse arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.TunnelRefusedException._TunnelRefusedException32957.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.TunnelRefusedException._TunnelRefusedException32957 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.TunnelRefusedException.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/HttpResponse;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.TunnelRefusedException.staticClass, global::org.apache.http.impl.client.TunnelRefusedException._TunnelRefusedException32957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TunnelRefusedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.TunnelRefusedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/TunnelRefusedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
