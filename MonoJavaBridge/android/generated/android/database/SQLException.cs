namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLException4700;
		public SQLException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.SQLException._SQLException4700.native == global::System.IntPtr.Zero)
				global::android.database.SQLException._SQLException4700 = @__env.GetMethodIDNoThrow(global::android.database.SQLException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException4700);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException4701;
		public SQLException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.SQLException._SQLException4701.native == global::System.IntPtr.Zero)
				global::android.database.SQLException._SQLException4701 = @__env.GetMethodIDNoThrow(global::android.database.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException4701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SQLException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.SQLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/SQLException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
