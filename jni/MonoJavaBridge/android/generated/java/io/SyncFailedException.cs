namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncFailedException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncFailedException()
		{
			InitJNI();
		}
		protected SyncFailedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SyncFailedException14006;
		public SyncFailedException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SyncFailedException.staticClass, global::java.io.SyncFailedException._SyncFailedException14006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.SyncFailedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/SyncFailedException"));
			global::java.io.SyncFailedException._SyncFailedException14006 = @__env.GetMethodIDNoThrow(global::java.io.SyncFailedException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
