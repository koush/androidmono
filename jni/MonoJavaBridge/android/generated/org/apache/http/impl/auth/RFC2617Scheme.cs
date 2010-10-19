namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.RFC2617Scheme_))]
	public abstract partial class RFC2617Scheme : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2617Scheme()
		{
			InitJNI();
		}
		protected RFC2617Scheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameters26008;
		protected virtual global::java.util.Map getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme._getParameters26008)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getParameters26008)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter26009;
		public override global::java.lang.String getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme._getParameter26009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getParameter26009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRealm26010;
		public override global::java.lang.String getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme._getRealm26010)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getRealm26010)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge26011;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2617Scheme26012;
		public RFC2617Scheme()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._RFC2617Scheme26012);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.RFC2617Scheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/RFC2617Scheme"));
			global::org.apache.http.impl.auth.RFC2617Scheme._getParameters26008 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameters", "()Ljava/util/Map;");
			global::org.apache.http.impl.auth.RFC2617Scheme._getParameter26009 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.RFC2617Scheme._getRealm26010 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge26011 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.impl.auth.RFC2617Scheme._RFC2617Scheme26012 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.RFC2617Scheme))]
	public sealed partial class RFC2617Scheme_ : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2617Scheme_()
		{
			InitJNI();
		}
		internal RFC2617Scheme_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName26013;
		public override global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName26013)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName26013)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased26014;
		public override bool isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased26014);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased26014);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete26015;
		public override bool isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete26015);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete26015);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate26016;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate26016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate26016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/RFC2617Scheme"));
			global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName26013 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased26014 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete26015 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate26016 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
		}
	}
}
