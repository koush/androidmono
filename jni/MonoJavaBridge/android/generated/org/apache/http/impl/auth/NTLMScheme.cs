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
		internal static global::MonoJavaBridge.MethodId _getParameter26000;
		public override global::java.lang.String getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getParameter26000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getParameter26000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName26001;
		public override global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getSchemeName26001)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getSchemeName26001)) as java.lang.String;
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRealm26002;
		public override global::java.lang.String getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._getRealm26002)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._getRealm26002)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased26003;
		public override bool isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased26003);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased26003);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete26004;
		public override bool isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._isComplete26004);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._isComplete26004);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate26005;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._authenticate26005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._authenticate26005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge26006;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme._parseChallenge26006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._parseChallenge26006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _NTLMScheme26007;
		public NTLMScheme(org.apache.http.impl.auth.NTLMEngine arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.NTLMScheme.staticClass, global::org.apache.http.impl.auth.NTLMScheme._NTLMScheme26007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.NTLMScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/NTLMScheme"));
			global::org.apache.http.impl.auth.NTLMScheme._getParameter26000 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._getSchemeName26001 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._getRealm26002 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.NTLMScheme._isConnectionBased26003 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.NTLMScheme._isComplete26004 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.NTLMScheme._authenticate26005 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.NTLMScheme._parseChallenge26006 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::org.apache.http.impl.auth.NTLMScheme._NTLMScheme26007 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.NTLMScheme.staticClass, "<init>", "(Lorg/apache/http/impl/auth/NTLMEngine;)V");
		}
	}
}
