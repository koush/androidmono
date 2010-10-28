namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AuthProvider_))]
	public abstract partial class AuthProvider : java.security.Provider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _login22898;
		public abstract void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1);
		internal static global::MonoJavaBridge.MethodId _logout22899;
		public abstract void logout();
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler22900;
		public abstract void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0);
		internal static global::MonoJavaBridge.MethodId _AuthProvider22901;
		protected AuthProvider(java.lang.String arg0, double arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AuthProvider.staticClass, global::java.security.AuthProvider._AuthProvider22901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AuthProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider._login22898 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._logout22899 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "logout", "()V");
			global::java.security.AuthProvider._setCallbackHandler22900 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider._AuthProvider22901 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AuthProvider))]
	internal sealed partial class AuthProvider_ : java.security.AuthProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _login22902;
		public override void login(javax.security.auth.Subject arg0, javax.security.auth.callback.CallbackHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._login22902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._login22902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _logout22903;
		public override void logout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._logout22903);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._logout22903);
		}
		internal static global::MonoJavaBridge.MethodId _setCallbackHandler22904;
		public override void setCallbackHandler(javax.security.auth.callback.CallbackHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.AuthProvider_._setCallbackHandler22904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.AuthProvider_.staticClass, global::java.security.AuthProvider_._setCallbackHandler22904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AuthProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AuthProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AuthProvider"));
			global::java.security.AuthProvider_._login22902 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V");
			global::java.security.AuthProvider_._logout22903 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "logout", "()V");
			global::java.security.AuthProvider_._setCallbackHandler22904 = @__env.GetMethodIDNoThrow(global::java.security.AuthProvider_.staticClass, "setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
