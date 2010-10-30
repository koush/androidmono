namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputMismatchException : java.util.NoSuchElementException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InputMismatchException26328;
		public InputMismatchException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InputMismatchException._InputMismatchException26328.native == global::System.IntPtr.Zero)
				global::java.util.InputMismatchException._InputMismatchException26328 = @__env.GetMethodIDNoThrow(global::java.util.InputMismatchException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InputMismatchException.staticClass, global::java.util.InputMismatchException._InputMismatchException26328);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputMismatchException26329;
		public InputMismatchException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InputMismatchException._InputMismatchException26329.native == global::System.IntPtr.Zero)
				global::java.util.InputMismatchException._InputMismatchException26329 = @__env.GetMethodIDNoThrow(global::java.util.InputMismatchException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InputMismatchException.staticClass, global::java.util.InputMismatchException._InputMismatchException26329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InputMismatchException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.InputMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/InputMismatchException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
