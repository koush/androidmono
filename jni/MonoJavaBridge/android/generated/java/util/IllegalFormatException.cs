namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalFormatException()
		{
			InitJNI();
		}
		protected IllegalFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatException"));
		}
	}
}
