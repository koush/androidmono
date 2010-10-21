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
		internal static global::MonoJavaBridge.MethodId _login22779;
		public abstract void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1);
		internal static global::MonoJavaBridge.MethodId _logout22780;
		public abstract void logout();
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler22781;
		public abstract void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0);
		internal static global::MonoJavaBridge.MethodId _AuthProvider22782;
		protected AuthProvider(java.lang.String arg0, double arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AuthProvider.staticClass, global::java.security.AuthProvider._AuthProvider22782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider._login22779 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._logout22780 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "logout", "()V");
			global::java.security.AuthProvider._setCallbackHandler22781 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._AuthProvider22782 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
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
		internal static global::MonoJavaBridge.MethodId _login22783;
		public override void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._login22783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._login22783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _logout22784;
		public override void logout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._logout22784);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._logout22784);
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler22785;
		public override void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._setCallbackHandler22785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._setCallbackHandler22785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider_._login22783 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider_._logout22784 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "logout", "()V");
			global::java.security.AuthProvider_._setCallbackHandler22785 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
		}
	}
}
