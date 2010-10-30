namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultTargetAuthenticationHandler : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultTargetAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32924;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z", ref global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler._isAuthenticationRequested32924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges32925;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;", ref global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler._getChallenges32925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultTargetAuthenticationHandler32926;
		public DefaultTargetAuthenticationHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler._DefaultTargetAuthenticationHandler32926.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler._DefaultTargetAuthenticationHandler32926 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultTargetAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler._DefaultTargetAuthenticationHandler32926);
			Init(@__env, handle);
		}
		static DefaultTargetAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultTargetAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultTargetAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
