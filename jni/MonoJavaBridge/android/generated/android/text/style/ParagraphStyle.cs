namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.ParagraphStyle_))]
	public interface ParagraphStyle  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ParagraphStyle))]
	public sealed partial class ParagraphStyle_ : java.lang.Object, ParagraphStyle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParagraphStyle_()
		{
			InitJNI();
		}
		internal ParagraphStyle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ParagraphStyle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ParagraphStyle"));
		}
	}
}
