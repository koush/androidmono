namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ReadOnlyBufferException : java.lang.UnsupportedOperationException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReadOnlyBufferException()
		{
			InitJNI();
		}
		protected ReadOnlyBufferException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ReadOnlyBufferException22359;
		public ReadOnlyBufferException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.ReadOnlyBufferException.staticClass, global::java.nio.ReadOnlyBufferException._ReadOnlyBufferException22359);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.ReadOnlyBufferException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/ReadOnlyBufferException"));
			global::java.nio.ReadOnlyBufferException._ReadOnlyBufferException22359 = @__env.GetMethodIDNoThrow(global::java.nio.ReadOnlyBufferException.staticClass, "<init>", "()V");
		}
	}
}
