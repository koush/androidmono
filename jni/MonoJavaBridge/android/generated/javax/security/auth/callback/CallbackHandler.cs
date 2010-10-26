namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.security.auth.callback.CallbackHandler_))]
	public partial interface CallbackHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void handle(javax.security.auth.callback.Callback[] arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.auth.callback.CallbackHandler))]
	internal sealed partial class CallbackHandler_ : java.lang.Object, CallbackHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CallbackHandler_()
		{
			InitJNI();
		}
		internal CallbackHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handle30197;
		 void javax.security.auth.callback.CallbackHandler.handle(javax.security.auth.callback.Callback[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.callback.CallbackHandler_._handle30197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.callback.CallbackHandler_.staticClass, global::javax.security.auth.callback.CallbackHandler_._handle30197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.CallbackHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/CallbackHandler"));
			global::javax.security.auth.callback.CallbackHandler_._handle30197 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.CallbackHandler_.staticClass, "handle", "([Ljavax/security/auth/callback/Callback;)V");
		}
	}
}
