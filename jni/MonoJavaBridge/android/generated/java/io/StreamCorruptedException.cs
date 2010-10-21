namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamCorruptedException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StreamCorruptedException()
		{
			InitJNI();
		}
		protected StreamCorruptedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StreamCorruptedException19457;
		public StreamCorruptedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._StreamCorruptedException19457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamCorruptedException19458;
		public StreamCorruptedException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.StreamCorruptedException.staticClass, global::java.io.StreamCorruptedException._StreamCorruptedException19458);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.StreamCorruptedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/StreamCorruptedException"));
			global::java.io.StreamCorruptedException._StreamCorruptedException19457 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.StreamCorruptedException._StreamCorruptedException19458 = @__env.GetMethodIDNoThrow(global::java.io.StreamCorruptedException.staticClass, "<init>", "()V");
		}
	}
}
