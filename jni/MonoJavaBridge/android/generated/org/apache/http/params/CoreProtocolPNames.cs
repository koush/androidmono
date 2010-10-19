namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.@params.CoreProtocolPNames_))]
	public interface CoreProtocolPNames  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.@params.CoreProtocolPNames))]
	public sealed partial class CoreProtocolPNames_ : java.lang.Object, CoreProtocolPNames
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CoreProtocolPNames_()
		{
			InitJNI();
		}
		internal CoreProtocolPNames_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.CoreProtocolPNames_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/@params/CoreProtocolPNames"));
		}
	}
}
