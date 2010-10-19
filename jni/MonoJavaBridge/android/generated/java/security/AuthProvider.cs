namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AuthProvider_))]
	public abstract partial class AuthProvider : java.security.Provider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthProvider()
		{
			InitJNI();
		}
		protected AuthProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _login17181;
		public abstract void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1);
		internal static global::MonoJavaBridge.MethodId _logout17182;
		public abstract void logout();
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler17183;
		public abstract void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0);
		internal static global::MonoJavaBridge.MethodId _AuthProvider17184;
		protected AuthProvider(java.lang.String arg0, double arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AuthProvider.staticClass, global::java.security.AuthProvider._AuthProvider17184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider._login17181 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._logout17182 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "logout", "()V");
			global::java.security.AuthProvider._setCallbackHandler17183 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._AuthProvider17184 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AuthProvider))]
	public sealed partial class AuthProvider_ : java.security.AuthProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthProvider_()
		{
			InitJNI();
		}
		internal AuthProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _login17185;
		public override void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._login17185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._login17185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _logout17186;
		public override void logout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._logout17186);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._logout17186);
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler17187;
		public override void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._setCallbackHandler17187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._setCallbackHandler17187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider_._login17185 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider_._logout17186 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "logout", "()V");
			global::java.security.AuthProvider_._setCallbackHandler17187 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
		}
	}
}
