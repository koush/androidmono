namespace javax.security.auth.callback
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.security.auth.callback.Callback_))]
	public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.security.auth.callback.Callback))]
	internal sealed partial class Callback_ : java.lang.Object, Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Callback_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.callback.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/callback/Callback"));
		}
		internal static void InitJNI()
		{
		}
	}
}
