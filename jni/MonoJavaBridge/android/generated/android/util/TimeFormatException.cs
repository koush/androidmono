namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeFormatException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static TimeFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimeFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimeFormatException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
