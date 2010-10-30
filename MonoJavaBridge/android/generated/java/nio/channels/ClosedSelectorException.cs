namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClosedSelectorException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClosedSelectorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ClosedSelectorException22419;
		public ClosedSelectorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.ClosedSelectorException._ClosedSelectorException22419.native == global::System.IntPtr.Zero)
				global::java.nio.channels.ClosedSelectorException._ClosedSelectorException22419 = @__env.GetMethodIDNoThrow(global::java.nio.channels.ClosedSelectorException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.ClosedSelectorException.staticClass, global::java.nio.channels.ClosedSelectorException._ClosedSelectorException22419);
			Init(@__env, handle);
		}
		static ClosedSelectorException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.ClosedSelectorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/ClosedSelectorException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
