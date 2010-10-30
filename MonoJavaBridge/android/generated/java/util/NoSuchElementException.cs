namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchElementException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchElementException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchElementException26525;
		public NoSuchElementException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.NoSuchElementException._NoSuchElementException26525.native == global::System.IntPtr.Zero)
				global::java.util.NoSuchElementException._NoSuchElementException26525 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._NoSuchElementException26525);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchElementException26526;
		public NoSuchElementException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.NoSuchElementException._NoSuchElementException26526.native == global::System.IntPtr.Zero)
				global::java.util.NoSuchElementException._NoSuchElementException26526 = @__env.GetMethodIDNoThrow(global::java.util.NoSuchElementException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.NoSuchElementException.staticClass, global::java.util.NoSuchElementException._NoSuchElementException26526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchElementException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.NoSuchElementException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/NoSuchElementException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
