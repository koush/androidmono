namespace java.security.spec
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.spec.KeySpec_))]
	public partial interface KeySpec  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.KeySpec))]
	internal sealed partial class KeySpec_ : java.lang.Object, KeySpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeySpec_()
		{
			InitJNI();
		}
		internal KeySpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.KeySpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/KeySpec"));
		}
	}
}
