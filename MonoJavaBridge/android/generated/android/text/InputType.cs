namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.InputType_))]
	public partial interface InputType  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.InputType))]
	internal sealed partial class InputType_ : java.lang.Object, InputType
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal InputType_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static InputType_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.InputType_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/InputType"));
		}
	}
}
