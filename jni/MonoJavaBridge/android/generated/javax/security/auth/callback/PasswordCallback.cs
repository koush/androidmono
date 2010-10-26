namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PasswordCallback : java.lang.Object, Callback, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PasswordCallback()
		{
			InitJNI();
		}
		protected PasswordCallback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setPassword30198;
		public virtual void setPassword(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback._setPassword30198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._setPassword30198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPassword30199;
		public virtual char[] getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback._getPassword30199)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._getPassword30199)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _clearPassword30200;
		public virtual void clearPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback._clearPassword30200);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._clearPassword30200);
		}
		public new global::java.lang.String Prompt
		{
			get
			{
				return getPrompt();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrompt30201;
		public virtual global::java.lang.String getPrompt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback._getPrompt30201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._getPrompt30201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEchoOn30202;
		public virtual bool isEchoOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback._isEchoOn30202);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._isEchoOn30202);
		}
		internal static global::MonoJavaBridge.MethodId _PasswordCallback30203;
		public PasswordCallback(java.lang.String arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.callback.PasswordCallback.staticClass, global::javax.security.auth.callback.PasswordCallback._PasswordCallback30203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.PasswordCallback.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/PasswordCallback"));
			global::javax.security.auth.callback.PasswordCallback._setPassword30198 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "setPassword", "([C)V");
			global::javax.security.auth.callback.PasswordCallback._getPassword30199 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "getPassword", "()[C");
			global::javax.security.auth.callback.PasswordCallback._clearPassword30200 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "clearPassword", "()V");
			global::javax.security.auth.callback.PasswordCallback._getPrompt30201 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "getPrompt", "()Ljava/lang/String;");
			global::javax.security.auth.callback.PasswordCallback._isEchoOn30202 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "isEchoOn", "()Z");
			global::javax.security.auth.callback.PasswordCallback._PasswordCallback30203 = @__env.GetMethodIDNoThrow(global::javax.security.auth.callback.PasswordCallback.staticClass, "<init>", "(Ljava/lang/String;Z)V");
		}
	}
}
