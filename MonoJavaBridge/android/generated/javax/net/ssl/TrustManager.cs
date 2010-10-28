namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.TrustManager_))]
	public partial interface TrustManager  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.TrustManager))]
	internal sealed partial class TrustManager_ : java.lang.Object, TrustManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TrustManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static TrustManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
