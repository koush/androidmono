namespace android.provider
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.BaseColumns_))]
	public partial interface BaseColumns  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.BaseColumns))]
	internal sealed partial class BaseColumns_ : java.lang.Object, BaseColumns
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BaseColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static BaseColumns_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.BaseColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/BaseColumns"));
		}
	}
}
