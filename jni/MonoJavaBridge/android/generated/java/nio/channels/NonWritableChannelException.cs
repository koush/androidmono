namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NonWritableChannelException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NonWritableChannelException()
		{
			InitJNI();
		}
		protected NonWritableChannelException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NonWritableChannelException22397;
		public NonWritableChannelException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.NonWritableChannelException.staticClass, global::java.nio.channels.NonWritableChannelException._NonWritableChannelException22397);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.NonWritableChannelException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/NonWritableChannelException"));
			global::java.nio.channels.NonWritableChannelException._NonWritableChannelException22397 = @__env.GetMethodIDNoThrow(global::java.nio.channels.NonWritableChannelException.staticClass, "<init>", "()V");
		}
	}
}
