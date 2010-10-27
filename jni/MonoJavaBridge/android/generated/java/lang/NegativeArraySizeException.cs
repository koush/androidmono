namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NegativeArraySizeException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NegativeArraySizeException()
		{
			InitJNI();
		}
		protected NegativeArraySizeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NegativeArraySizeException20340;
		public NegativeArraySizeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NegativeArraySizeException.staticClass, global::java.lang.NegativeArraySizeException._NegativeArraySizeException20340);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NegativeArraySizeException20341;
		public NegativeArraySizeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NegativeArraySizeException.staticClass, global::java.lang.NegativeArraySizeException._NegativeArraySizeException20341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NegativeArraySizeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NegativeArraySizeException"));
			global::java.lang.NegativeArraySizeException._NegativeArraySizeException20340 = @__env.GetMethodIDNoThrow(global::java.lang.NegativeArraySizeException.staticClass, "<init>", "()V");
			global::java.lang.NegativeArraySizeException._NegativeArraySizeException20341 = @__env.GetMethodIDNoThrow(global::java.lang.NegativeArraySizeException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
