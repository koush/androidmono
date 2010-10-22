namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.ManagerFactoryParameters_))]
	public partial interface ManagerFactoryParameters  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.ManagerFactoryParameters))]
	public sealed partial class ManagerFactoryParameters_ : java.lang.Object, ManagerFactoryParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ManagerFactoryParameters_()
		{
			InitJNI();
		}
		internal ManagerFactoryParameters_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.ManagerFactoryParameters_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/ManagerFactoryParameters"));
		}
	}
}
