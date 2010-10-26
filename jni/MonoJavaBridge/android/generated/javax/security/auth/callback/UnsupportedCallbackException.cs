namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnsupportedCallbackException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnsupportedCallbackException()
		{
			InitJNI();
		}
		protected UnsupportedCallbackException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::javax.security.auth.callback.Callback Callback
		{
			get
			{
				return getCallback();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallback30204;
		public virtual global::javax.security.auth.callback.Callback getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.Callback>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.callback.UnsupportedCallbackException._getCallback30204)) as javax.security.auth.callback.Callback;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.security.auth.callback.Callback>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.callback.UnsupportedCallbackException.staticClass, global::javax.security.auth.callback.UnsupportedCallbackException._getCallback30204)) as javax.security.auth.callback.Callback;
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedCallbackException30205;
		public UnsupportedCallbackException(javax.security.auth.callback.Callback arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.callback.UnsupportedCallbackException.staticClass, global::javax.security.auth.callback.UnsupportedCallbackException._UnsupportedCallbackException30205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnsupportedCallbackException30206;
		public UnsupportedCallbackException(javax.security.auth.callback.Callback arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.callback.UnsupportedCallbackException.staticClass, global::javax.security.auth.callback.UnsupportedCallbackException._UnsupportedCallbackException30206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.UnsupportedCallbackException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/UnsupportedCallbackException"));
			global::javax.security.auth.callback.UnsupportedCallbackException._getCallback30204 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.UnsupportedCallbackException.staticClass, "getCallback", "()Ljavax/security/auth/callback/Callback;");
			global::javax.security.auth.callback.UnsupportedCallbackException._UnsupportedCallbackException30205 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.UnsupportedCallbackException.staticClass, "<init>", "(Ljavax/security/auth/callback/Callback;)V");
			global::javax.security.auth.callback.UnsupportedCallbackException._UnsupportedCallbackException30206 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.UnsupportedCallbackException.staticClass, "<init>", "(Ljavax/security/auth/callback/Callback;Ljava/lang/String;)V");
		}
	}
}
