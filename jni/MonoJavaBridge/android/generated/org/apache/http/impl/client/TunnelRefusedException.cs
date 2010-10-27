namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TunnelRefusedException : org.apache.http.HttpException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TunnelRefusedException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getResponse32955;
		public virtual global::org.apache.http.HttpResponse getResponse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.TunnelRefusedException._getResponse32955)) as org.apache.http.HttpResponse;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponse>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.TunnelRefusedException.staticClass, global::org.apache.http.impl.client.TunnelRefusedException._getResponse32955)) as org.apache.http.HttpResponse;
		}
		internal static global::MonoJavaBridge.MethodId _TunnelRefusedException32956;
		public TunnelRefusedException(java.lang.String arg0, org.apache.http.HttpResponse arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.TunnelRefusedException.staticClass, global::org.apache.http.impl.client.TunnelRefusedException._TunnelRefusedException32956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.TunnelRefusedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/TunnelRefusedException"));
			global::org.apache.http.impl.client.TunnelRefusedException._getResponse32955 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.TunnelRefusedException.staticClass, "getResponse", "()Lorg/apache/http/HttpResponse;");
			global::org.apache.http.impl.client.TunnelRefusedException._TunnelRefusedException32956 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.TunnelRefusedException.staticClass, "<init>", "(Ljava/lang/String;Lorg/apache/http/HttpResponse;)V");
		}
	}
}
