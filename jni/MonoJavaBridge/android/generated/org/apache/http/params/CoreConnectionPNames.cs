namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.@params.CoreConnectionPNames_))]
	public partial interface CoreConnectionPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.CoreConnectionPNames))]
	internal sealed partial class CoreConnectionPNames_ : java.lang.Object, CoreConnectionPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CoreConnectionPNames_()
		{
			InitJNI();
		}
		internal CoreConnectionPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.CoreConnectionPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/CoreConnectionPNames"));
		}
	}
}
