namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.ParagraphStyle_))]
	public partial interface ParagraphStyle  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ParagraphStyle))]
	internal sealed partial class ParagraphStyle_ : java.lang.Object, ParagraphStyle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParagraphStyle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ParagraphStyle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ParagraphStyle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ParagraphStyle"));
		}
		internal static void InitJNI()
		{
		}
	}
}
