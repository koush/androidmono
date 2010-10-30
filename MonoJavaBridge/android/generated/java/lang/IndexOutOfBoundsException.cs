namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IndexOutOfBoundsException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _IndexOutOfBoundsException20187;
		public IndexOutOfBoundsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20187.native == global::System.IntPtr.Zero)
				global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20187 = @__env.GetMethodIDNoThrow(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20187);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IndexOutOfBoundsException20188;
		public IndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20188.native == global::System.IntPtr.Zero)
				global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20188 = @__env.GetMethodIDNoThrow(global::java.lang.IndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.IndexOutOfBoundsException.staticClass, global::java.lang.IndexOutOfBoundsException._IndexOutOfBoundsException20188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IndexOutOfBoundsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.IndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/IndexOutOfBoundsException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
