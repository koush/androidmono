namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PasswordCallback : java.lang.Object, Callback, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PasswordCallback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setPassword(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, "setPassword", "([C)V", ref global::javax.security.auth.callback.PasswordCallback._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
			set
			{
				setPassword(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual char[] getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::javax.security.auth.callback.PasswordCallback.staticClass, "getPassword", "()[C", ref global::javax.security.auth.callback.PasswordCallback._m1) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void clearPassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, "clearPassword", "()V", ref global::javax.security.auth.callback.PasswordCallback._m2);
		}
		public new global::java.lang.String Prompt
		{
			get
			{
				return getPrompt();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getPrompt()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.callback.PasswordCallback.staticClass, "getPrompt", "()Ljava/lang/String;", ref global::javax.security.auth.callback.PasswordCallback._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isEchoOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, "isEchoOn", "()Z", ref global::javax.security.auth.callback.PasswordCallback._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PasswordCallback(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.callback.PasswordCallback._m5.native == global::System.IntPtr.Zero)
				global::javax.security.auth.callback.PasswordCallback._m5 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "<init>", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PasswordCallback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.PasswordCallback.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/PasswordCallback"));
		}
		internal static void InitJNI()
		{
		}
	}
}
