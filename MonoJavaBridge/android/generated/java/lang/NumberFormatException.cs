namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NumberFormatException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NumberFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormatException20365;
		public NumberFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NumberFormatException._NumberFormatException20365.native == global::System.IntPtr.Zero)
				global::java.lang.NumberFormatException._NumberFormatException20365 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._NumberFormatException20365);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormatException20366;
		public NumberFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NumberFormatException._NumberFormatException20366.native == global::System.IntPtr.Zero)
				global::java.lang.NumberFormatException._NumberFormatException20366 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._NumberFormatException20366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NumberFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NumberFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NumberFormatException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
