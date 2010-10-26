namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidMarkException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidMarkException()
		{
			InitJNI();
		}
		protected InvalidMarkException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidMarkException22278;
		public InvalidMarkException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.InvalidMarkException.staticClass, global::java.nio.InvalidMarkException._InvalidMarkException22278);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.InvalidMarkException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/InvalidMarkException"));
			global::java.nio.InvalidMarkException._InvalidMarkException22278 = @__env.GetMethodIDNoThrow(global::java.nio.InvalidMarkException.staticClass, "<init>", "()V");
		}
	}
}
