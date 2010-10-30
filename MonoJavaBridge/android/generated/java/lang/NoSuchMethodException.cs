namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchMethodException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchMethodException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodException20350;
		public NoSuchMethodException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchMethodException._NoSuchMethodException20350.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchMethodException._NoSuchMethodException20350 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodException.staticClass, global::java.lang.NoSuchMethodException._NoSuchMethodException20350);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchMethodException20351;
		public NoSuchMethodException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchMethodException._NoSuchMethodException20351.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchMethodException._NoSuchMethodException20351 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchMethodException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchMethodException.staticClass, global::java.lang.NoSuchMethodException._NoSuchMethodException20351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchMethodException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchMethodException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchMethodException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
