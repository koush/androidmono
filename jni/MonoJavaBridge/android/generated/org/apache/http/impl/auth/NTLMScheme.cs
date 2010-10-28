namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTLMScheme : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NTLMScheme()
		{
			InitJNI();
		}
		protected NTLMScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32742;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getParameter32742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getParameter32742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32743;
		public override global::java.lang.String getSchemeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getSchemeName32743)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getSchemeName32743)) as java.lang.String;
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRealm32744;
		public override global::java.lang.String getRealm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getRealm32744)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getRealm32744)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32745;
		public override bool isConnectionBased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased32745);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased32745);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32746;
		public override bool isComplete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._isComplete32746);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._isComplete32746);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32747;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._authenticate32747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._authenticate32747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32748;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._parseChallenge32748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._parseChallenge32748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _NTLMScheme32749;
		public NTLMScheme(org.apache.http.impl.auth.NTLMEngine arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._NTLMScheme32749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMScheme"));
			global::org.apache.http.impl.auth.NTLMScheme._getParameter32742 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._getSchemeName32743 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._getRealm32744 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased32745 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.NTLMScheme._isComplete32746 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.NTLMScheme._authenticate32747 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.NTLMScheme._parseChallenge32748 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.impl.auth.NTLMScheme._NTLMScheme32749 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "<init>", "(Lorg/apache/http/impl/auth/NTLMEngine;)V");
		}
	}
}
