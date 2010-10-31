namespace android.provider
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.provider.OpenableColumns_))]
	public partial interface OpenableColumns  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.provider.OpenableColumns))]
	internal sealed partial class OpenableColumns_ : java.lang.Object, OpenableColumns
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal OpenableColumns_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static OpenableColumns_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.provider.OpenableColumns_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/provider/OpenableColumns"));
		}
	}
}
