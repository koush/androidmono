namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.KeyManager_))]
	public partial interface KeyManager  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.KeyManager))]
	internal sealed partial class KeyManager_ : java.lang.Object, KeyManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyManager_()
		{
			InitJNI();
		}
		internal KeyManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManager"));
		}
	}
}
