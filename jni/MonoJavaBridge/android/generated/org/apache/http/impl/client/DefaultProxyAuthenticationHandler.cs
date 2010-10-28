namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultProxyAuthenticationHandler : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultProxyAuthenticationHandler()
		{
			InitJNI();
		}
		protected DefaultProxyAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32908;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges32909;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultProxyAuthenticationHandler32910;
		public DefaultProxyAuthenticationHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._DefaultProxyAuthenticationHandler32910);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultProxyAuthenticationHandler"));
			global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
			global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._DefaultProxyAuthenticationHandler32910 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "<init>", "()V");
		}
	}
}
