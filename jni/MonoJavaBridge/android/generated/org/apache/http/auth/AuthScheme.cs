namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.AuthScheme_))]
	public partial interface AuthScheme  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getParameter(java.lang.String arg0);
		global::java.lang.String getSchemeName();
		void processChallenge(org.apache.http.Header arg0);
		global::java.lang.String getRealm();
		bool isConnectionBased();
		bool isComplete();
		global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.AuthScheme))]
	public sealed partial class AuthScheme_ : java.lang.Object, AuthScheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthScheme_()
		{
			InitJNI();
		}
		internal AuthScheme_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter31658;
		 global::java.lang.String org.apache.http.auth.AuthScheme.getParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getParameter31658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._getParameter31658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName31659;
		 global::java.lang.String org.apache.http.auth.AuthScheme.getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getSchemeName31659)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._getSchemeName31659)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge31660;
		 void org.apache.http.auth.AuthScheme.processChallenge(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._processChallenge31660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._processChallenge31660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRealm31661;
		 global::java.lang.String org.apache.http.auth.AuthScheme.getRealm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getRealm31661)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._getRealm31661)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased31662;
		 bool org.apache.http.auth.AuthScheme.isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._isConnectionBased31662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._isConnectionBased31662);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete31663;
		 bool org.apache.http.auth.AuthScheme.isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._isComplete31663);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._isComplete31663);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate31664;
		 global::org.apache.http.Header org.apache.http.auth.AuthScheme.authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._authenticate31664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_.staticClass, global::org.apache.http.auth.AuthScheme_._authenticate31664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScheme_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScheme"));
			global::org.apache.http.auth.AuthScheme_._getParameter31658 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._getSchemeName31659 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._processChallenge31660 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.auth.AuthScheme_._getRealm31661 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._isConnectionBased31662 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.auth.AuthScheme_._isComplete31663 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "isComplete", "()Z");
			global::org.apache.http.auth.AuthScheme_._authenticate31664 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
		}
	}
}
