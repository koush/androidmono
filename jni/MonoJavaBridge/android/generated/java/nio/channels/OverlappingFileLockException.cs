namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OverlappingFileLockException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OverlappingFileLockException()
		{
			InitJNI();
		}
		protected OverlappingFileLockException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _OverlappingFileLockException22400;
		public OverlappingFileLockException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.OverlappingFileLockException.staticClass, global::java.nio.channels.OverlappingFileLockException._OverlappingFileLockException22400);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.OverlappingFileLockException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/OverlappingFileLockException"));
			global::java.nio.channels.OverlappingFileLockException._OverlappingFileLockException22400 = @__env.GetMethodIDNoThrow(global::java.nio.channels.OverlappingFileLockException.staticClass, "<init>", "()V");
		}
	}
}
