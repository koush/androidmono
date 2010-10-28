namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.WrapTogetherSpan_))]
	public partial interface WrapTogetherSpan : ParagraphStyle
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.WrapTogetherSpan))]
	internal sealed partial class WrapTogetherSpan_ : java.lang.Object, WrapTogetherSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WrapTogetherSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static WrapTogetherSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.WrapTogetherSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/WrapTogetherSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
