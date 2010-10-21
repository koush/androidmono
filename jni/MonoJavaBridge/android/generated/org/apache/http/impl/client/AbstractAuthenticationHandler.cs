namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler_))]
	public abstract partial class AbstractAuthenticationHandler : java.lang.Object, org.apache.http.client.AuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractAuthenticationHandler()
		{
			InitJNI();
		}
		protected AbstractAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32643;
		public abstract bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		internal static global::MonoJavaBridge.MethodId _getChallenges32644;
		public abstract global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1);
		internal static global::MonoJavaBridge.MethodId _selectScheme32645;
		public virtual global::org.apache.http.auth.AuthScheme selectScheme(java.util.Map arg0, org.apache.http.HttpResponse arg1, org.apache.http.protocol.HttpContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.auth.AuthScheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenges32646;
		protected virtual global::java.util.Map parseChallenges(org.apache.http.Header[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthPreferences32647;
		protected virtual global::java.util.List getAuthPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32647)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32647)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractAuthenticationHandler32648;
		public AbstractAuthenticationHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler._AbstractAuthenticationHandler32648);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._isAuthenticationRequested32643 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._getChallenges32644 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._selectScheme32645 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "selectScheme", "(Ljava/util/Map;Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._parseChallenges32646 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "parseChallenges", "([Lorg/apache/http/Header;)Ljava/util/Map;");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._getAuthPreferences32647 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "getAuthPreferences", "()Ljava/util/List;");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler._AbstractAuthenticationHandler32648 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.client.AbstractAuthenticationHandler))]
	public sealed partial class AbstractAuthenticationHandler_ : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractAuthenticationHandler_()
		{
			InitJNI();
		}
		internal AbstractAuthenticationHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32649;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges32650;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/AbstractAuthenticationHandler"));
			global::org.apache.http.impl.client.AbstractAuthenticationHandler_._isAuthenticationRequested32649 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			global::org.apache.http.impl.client.AbstractAuthenticationHandler_._getChallenges32650 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.AbstractAuthenticationHandler_.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
		}
	}
}
