namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.AuthSchemeBase_))]
	public abstract partial class AuthSchemeBase : java.lang.Object, org.apache.http.auth.AuthScheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthSchemeBase()
		{
			InitJNI();
		}
		protected AuthSchemeBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32700;
		public abstract global::java.lang.String getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSchemeName32701;
		public abstract global::java.lang.String getSchemeName();
		internal static global::MonoJavaBridge.MethodId _getRealm32702;
		public abstract global::java.lang.String getRealm();
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32703;
		public abstract bool isConnectionBased();
		internal static global::MonoJavaBridge.MethodId _isComplete32704;
		public abstract bool isComplete();
		internal static global::MonoJavaBridge.MethodId _authenticate32705;
		public abstract global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
		internal static global::MonoJavaBridge.MethodId _isProxy32706;
		public virtual bool isProxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase._isProxy32706);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._isProxy32706);
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32707;
		public virtual void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge32707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge32707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32708;
		protected abstract void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _AuthSchemeBase32709;
		public AuthSchemeBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase32709);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
			global::org.apache.http.impl.auth.AuthSchemeBase._getParameter32700 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._getSchemeName32701 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._getRealm32702 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._isConnectionBased32703 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._isComplete32704 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._authenticate32705 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.AuthSchemeBase._isProxy32706 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isProxy", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge32707 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.impl.auth.AuthSchemeBase._parseChallenge32708 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase32709 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.AuthSchemeBase))]
	internal sealed partial class AuthSchemeBase_ : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthSchemeBase_()
		{
			InitJNI();
		}
		internal AuthSchemeBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32710;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter32710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter32710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32711;
		public override global::java.lang.String getSchemeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName32711)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName32711)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRealm32712;
		public override global::java.lang.String getRealm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm32712)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm32712)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32713;
		public override bool isConnectionBased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased32713);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased32713);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32714;
		public override bool isComplete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete32714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete32714);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32715;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate32715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate32715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32716;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge32716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge32716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
			global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter32710 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName32711 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm32712 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased32713 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete32714 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate32715 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge32716 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
		}
	}
}
