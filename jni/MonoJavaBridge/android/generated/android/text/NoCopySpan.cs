namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.NoCopySpan_))]
	public partial interface NoCopySpan  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.NoCopySpan))]
	public sealed partial class NoCopySpan_ : java.lang.Object, NoCopySpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoCopySpan_()
		{
			InitJNI();
		}
		internal NoCopySpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.NoCopySpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/NoCopySpan"));
		}
	}
}
