namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.TrustManager_))]
	public interface TrustManager  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.TrustManager))]
	public sealed partial class TrustManager_ : java.lang.Object, TrustManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TrustManager_()
		{
			InitJNI();
		}
		internal TrustManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManager"));
		}
	}
}
