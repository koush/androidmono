namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.UpdateAppearance_))]
	public partial interface UpdateAppearance  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.UpdateAppearance))]
	internal sealed partial class UpdateAppearance_ : java.lang.Object, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UpdateAppearance_()
		{
			InitJNI();
		}
		internal UpdateAppearance_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.UpdateAppearance_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/UpdateAppearance"));
		}
	}
}
