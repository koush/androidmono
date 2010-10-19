namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthSchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthSchemeRegistry()
		{
			InitJNI();
		}
		internal AuthSchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _register25123;
		public void register(java.lang.String arg0, org.apache.http.auth.AuthSchemeFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry._register25123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._register25123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setItems25124;
		public void setItems(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry._setItems25124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._setItems25124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregister25125;
		public void unregister(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry._unregister25125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._unregister25125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScheme25126;
		public global::org.apache.http.auth.AuthScheme getAuthScheme(java.lang.String arg0, org.apache.http.@params.HttpParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry._getAuthScheme25126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.auth.AuthScheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.auth.AuthScheme>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._getAuthScheme25126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.auth.AuthScheme;
		}
		public new global::java.util.List SchemeNames
		{
			get
			{
				return getSchemeNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeNames25127;
		public global::java.util.List getSchemeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry._getSchemeNames25127)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._getSchemeNames25127)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _AuthSchemeRegistry25128;
		public AuthSchemeRegistry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthSchemeRegistry.staticClass, global::org.apache.http.auth.AuthSchemeRegistry._AuthSchemeRegistry25128);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthSchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthSchemeRegistry"));
			global::org.apache.http.auth.AuthSchemeRegistry._register25123 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "register", "(Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._setItems25124 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._unregister25125 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthSchemeRegistry._getAuthScheme25126 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getAuthScheme", "(Ljava/lang/String;Lorg/apache/http/@params/HttpParams;)Lorg/apache/http/auth/AuthScheme;");
			global::org.apache.http.auth.AuthSchemeRegistry._getSchemeNames25127 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;");
			global::org.apache.http.auth.AuthSchemeRegistry._AuthSchemeRegistry25128 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthSchemeRegistry.staticClass, "<init>", "()V");
		}
	}
}
