namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.AuthenticationHandler_))]
	public partial interface AuthenticationHandler  : global::MonoJavaBridge.IJavaObject 
	{
		bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		global::org.apache.http.auth.AuthScheme selectScheme(java.util.Map arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.AuthenticationHandler))]
	internal sealed partial class AuthenticationHandler_ : java.lang.Object, AuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticationHandler_()
		{
			InitJNI();
		}
		internal AuthenticationHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested31863;
		bool org.apache.http.client.AuthenticationHandler.isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_._isAuthenticationRequested31863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_.staticClass, global::org.apache.http.client.AuthenticationHandler_._isAuthenticationRequested31863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges31864;
		global::java.util.Map org.apache.http.client.AuthenticationHandler.getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_._getChallenges31864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_.staticClass, global::org.apache.http.client.AuthenticationHandler_._getChallenges31864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _selectScheme31865;
		global::org.apache.http.auth.AuthScheme org.apache.http.client.AuthenticationHandler.selectScheme(java.util.Map arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_._selectScheme31865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.auth.AuthScheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.client.AuthenticationHandler_.staticClass, global::org.apache.http.client.AuthenticationHandler_._selectScheme31865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.auth.AuthScheme;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.AuthenticationHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/AuthenticationHandler"));
			global::org.apache.http.client.AuthenticationHandler_._isAuthenticationRequested31863 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.AuthenticationHandler_.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.client.AuthenticationHandler_._getChallenges31864 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.AuthenticationHandler_.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
			global::org.apache.http.client.AuthenticationHandler_._selectScheme31865 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.AuthenticationHandler_.staticClass, "selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme;");
		}
	}
}
