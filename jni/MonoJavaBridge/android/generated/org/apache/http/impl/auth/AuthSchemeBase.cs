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
		internal static global::MonoJavaBridge.MethodId _getParameter25959;
		public abstract global::java.lang.String getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSchemeName25960;
		public abstract global::java.lang.String getSchemeName();
		internal static global::MonoJavaBridge.MethodId _getRealm25961;
		public abstract global::java.lang.String getRealm();
		internal static global::MonoJavaBridge.MethodId _isConnectionBased25962;
		public abstract bool isConnectionBased();
		internal static global::MonoJavaBridge.MethodId _isComplete25963;
		public abstract bool isComplete();
		internal static global::MonoJavaBridge.MethodId _authenticate25964;
		public abstract global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
		internal static global::MonoJavaBridge.MethodId _isProxy25965;
		public virtual bool isProxy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase._isProxy25965);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._isProxy25965);
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge25966;
		public virtual void processChallenge(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge25966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge25966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge25967;
		protected abstract void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _AuthSchemeBase25968;
		public AuthSchemeBase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase25968);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
			global::org.apache.http.impl.auth.AuthSchemeBase._getParameter25959 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._getSchemeName25960 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._getRealm25961 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase._isConnectionBased25962 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._isComplete25963 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._authenticate25964 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.AuthSchemeBase._isProxy25965 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isProxy", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge25966 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.impl.auth.AuthSchemeBase._parseChallenge25967 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase25968 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.AuthSchemeBase))]
	public sealed partial class AuthSchemeBase_ : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthSchemeBase_()
		{
			InitJNI();
		}
		internal AuthSchemeBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter25969;
		public override global::java.lang.String getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter25969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter25969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName25970;
		public override global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName25970)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName25970)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRealm25971;
		public override global::java.lang.String getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm25971)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm25971)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased25972;
		public override bool isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased25972);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased25972);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete25973;
		public override bool isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete25973);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete25973);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate25974;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate25974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate25974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge25975;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge25975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge25975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
			global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter25969 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName25970 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm25971 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased25972 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete25973 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate25974 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge25975 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
		}
	}
}
