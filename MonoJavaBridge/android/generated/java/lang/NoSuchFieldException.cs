namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchFieldException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchFieldException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldException20346;
		public NoSuchFieldException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldException._NoSuchFieldException20346.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldException._NoSuchFieldException20346 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._NoSuchFieldException20346);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NoSuchFieldException20347;
		public NoSuchFieldException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldException._NoSuchFieldException20347.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldException._NoSuchFieldException20347 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._NoSuchFieldException20347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchFieldException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchFieldException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchFieldException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
