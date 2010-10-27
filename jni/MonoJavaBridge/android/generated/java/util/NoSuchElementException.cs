namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchElementException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NoSuchElementException()
		{
			InitJNI();
		}
		protected NoSuchElementException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchElementException26524;
		public NoSuchElementException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._NoSuchElementException26524);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchElementException26525;
		public NoSuchElementException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._NoSuchElementException26525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.NoSuchElementException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/NoSuchElementException"));
			global::java.util.NoSuchElementException._NoSuchElementException26524 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "()V");
			global::java.util.NoSuchElementException._NoSuchElementException26525 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
