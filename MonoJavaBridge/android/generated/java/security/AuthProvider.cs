namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AuthProvider_))]
	public abstract partial class AuthProvider : java.security.Provider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void logout();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected AuthProvider(java.lang.String arg0, double arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AuthProvider._m3.native == global::System.IntPtr.Zero)
				global::java.security.AuthProvider._m3 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AuthProvider.staticClass, global::java.security.AuthProvider._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AuthProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AuthProvider))]
	internal sealed partial class AuthProvider_ : java.security.AuthProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AuthProvider_.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V", ref global::java.security.AuthProvider_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void logout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AuthProvider_.staticClass, "logout", "()V", ref global::java.security.AuthProvider_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AuthProvider_.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V", ref global::java.security.AuthProvider_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AuthProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
		}
	}
}
