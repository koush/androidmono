namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.UpdateLayout_))]
	public interface UpdateLayout : UpdateAppearance
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.UpdateLayout))]
	public sealed partial class UpdateLayout_ : java.lang.Object, UpdateLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UpdateLayout_()
		{
			InitJNI();
		}
		internal UpdateLayout_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.UpdateLayout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/UpdateLayout"));
		}
	}
}
