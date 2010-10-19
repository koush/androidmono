namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArithmeticException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArithmeticException()
		{
			InitJNI();
		}
		protected ArithmeticException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ArithmeticException14086;
		public ArithmeticException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArithmeticException.staticClass, global::java.lang.ArithmeticException._ArithmeticException14086);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArithmeticException14087;
		public ArithmeticException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArithmeticException.staticClass, global::java.lang.ArithmeticException._ArithmeticException14087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArithmeticException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArithmeticException"));
			global::java.lang.ArithmeticException._ArithmeticException14086 = @__env.GetMethodIDNoThrow(global::java.lang.ArithmeticException.staticClass, "<init>", "()V");
			global::java.lang.ArithmeticException._ArithmeticException14087 = @__env.GetMethodIDNoThrow(global::java.lang.ArithmeticException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
