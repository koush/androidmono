namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler_))]
	public abstract partial class AbstractAuthenticationHandler : java.lang.Object, org.apache.http.client.AuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32762;
		public abstract bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		internal static global::MonoJavaBridge.MethodId _getChallenges32763;
		public abstract global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		internal static global::MonoJavaBridge.MethodId _selectScheme32764;
		public virtual global::org.apache.http.auth.AuthScheme selectScheme(java.util.Map arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32764.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32764 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenges32765;
		protected virtual global::java.util.Map parseChallenges(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32765.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32765 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "parseChallenges", "([Lorg/apache/http/Header;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthPreferences32766;
		protected virtual global::java.util.List getAuthPreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32766.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32766 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "getAuthPreferences", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32766) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractAuthenticationHandler32767;
		public AbstractAuthenticationHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler._AbstractAuthenticationHandler32767.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler._AbstractAuthenticationHandler32767 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._AbstractAuthenticationHandler32767);
			Init(@__env, handle);
		}
		static AbstractAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler))]
	internal sealed partial class AbstractAuthenticationHandler_ : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractAuthenticationHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32768;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32768.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32768 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges32769;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32769.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32769 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		static AbstractAuthenticationHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
