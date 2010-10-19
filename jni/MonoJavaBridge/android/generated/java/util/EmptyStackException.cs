namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EmptyStackException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EmptyStackException()
		{
			InitJNI();
		}
		protected EmptyStackException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _EmptyStackException20200;
		public EmptyStackException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EmptyStackException.staticClass, global::java.util.EmptyStackException._EmptyStackException20200);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EmptyStackException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EmptyStackException"));
			global::java.util.EmptyStackException._EmptyStackException20200 = @__env.GetMethodIDNoThrow(global::java.util.EmptyStackException.staticClass, "<init>", "()V");
		}
	}
}
