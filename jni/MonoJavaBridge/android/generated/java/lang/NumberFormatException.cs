namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NumberFormatException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NumberFormatException()
		{
			InitJNI();
		}
		protected NumberFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormatException20247;
		public NumberFormatException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._NumberFormatException20247);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormatException20248;
		public NumberFormatException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NumberFormatException.staticClass, global::java.lang.NumberFormatException._NumberFormatException20248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NumberFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NumberFormatException"));
			global::java.lang.NumberFormatException._NumberFormatException20247 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "()V");
			global::java.lang.NumberFormatException._NumberFormatException20248 = @__env.GetMethodIDNoThrow(global::java.lang.NumberFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
