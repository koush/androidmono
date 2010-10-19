namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputMismatchException : java.util.NoSuchElementException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputMismatchException()
		{
			InitJNI();
		}
		protected InputMismatchException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InputMismatchException20384;
		public InputMismatchException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InputMismatchException.staticClass, global::java.util.InputMismatchException._InputMismatchException20384);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputMismatchException20385;
		public InputMismatchException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InputMismatchException.staticClass, global::java.util.InputMismatchException._InputMismatchException20385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.InputMismatchException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/InputMismatchException"));
			global::java.util.InputMismatchException._InputMismatchException20384 = @__env.GetMethodIDNoThrow(global::java.util.InputMismatchException.staticClass, "<init>", "()V");
			global::java.util.InputMismatchException._InputMismatchException20385 = @__env.GetMethodIDNoThrow(global::java.util.InputMismatchException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
