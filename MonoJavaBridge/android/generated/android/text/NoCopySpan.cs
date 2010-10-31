namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.NoCopySpan_))]
	public partial interface NoCopySpan  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.NoCopySpan))]
	internal sealed partial class NoCopySpan_ : java.lang.Object, NoCopySpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NoCopySpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static NoCopySpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.NoCopySpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/NoCopySpan"));
		}
	}
}
