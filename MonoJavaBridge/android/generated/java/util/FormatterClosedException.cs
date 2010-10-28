namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FormatterClosedException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FormatterClosedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _FormatterClosedException26212;
		public FormatterClosedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.FormatterClosedException.staticClass, global::java.util.FormatterClosedException._FormatterClosedException26212);
			Init(@__env, handle);
		}
		static FormatterClosedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.FormatterClosedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/FormatterClosedException"));
			global::java.util.FormatterClosedException._FormatterClosedException26212 = @__env.GetMethodIDNoThrow(global::java.util.FormatterClosedException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
