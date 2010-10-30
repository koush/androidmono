namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PasswordCallback : java.lang.Object, Callback, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PasswordCallback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setPassword30199;
		public virtual void setPassword(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._setPassword30199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPassword30200;
		public virtual char[] getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._getPassword30200)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _clearPassword30201;
		public virtual void clearPassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._clearPassword30201);
		}
		public new global::java.lang.String Prompt
		{
			get
			{
				return getPrompt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrompt30202;
		public virtual global::java.lang.String getPrompt()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._getPrompt30202)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEchoOn30203;
		public virtual bool isEchoOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._isEchoOn30203);
		}
		internal static global::MonoJavaBridge.MethodId _PasswordCallback30204;
		public PasswordCallback(java.lang.String arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._PasswordCallback30204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PasswordCallback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.PasswordCallback.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/PasswordCallback"));
			global::javax.security.auth.callback.PasswordCallback._setPassword30199 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "setPassword", "([C)V");
			global::javax.security.auth.callback.PasswordCallback._getPassword30200 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "getPassword", "()[C");
			global::javax.security.auth.callback.PasswordCallback._clearPassword30201 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "clearPassword", "()V");
			global::javax.security.auth.callback.PasswordCallback._getPrompt30202 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "getPrompt", "()Ljava/lang/String;");
			global::javax.security.auth.callback.PasswordCallback._isEchoOn30203 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "isEchoOn", "()Z");
			global::javax.security.auth.callback.PasswordCallback._PasswordCallback30204 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "<init>", "(Ljava/lang/String;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
