namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamCorruptedException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamCorruptedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StreamCorruptedException19575;
		public StreamCorruptedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._StreamCorruptedException19575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamCorruptedException19576;
		public StreamCorruptedException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._StreamCorruptedException19576);
			Init(@__env, handle);
		}
		static StreamCorruptedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamCorruptedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamCorruptedException"));
			global::java.io.StreamCorruptedException._StreamCorruptedException19575 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.StreamCorruptedException._StreamCorruptedException19576 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}