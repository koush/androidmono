namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.InputType_))]
	public interface InputType  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.InputType))]
	public sealed partial class InputType_ : java.lang.Object, InputType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputType_()
		{
			InitJNI();
		}
		internal InputType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.InputType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/InputType"));
		}
	}
}
