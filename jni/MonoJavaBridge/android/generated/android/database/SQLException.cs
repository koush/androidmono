namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLException()
		{
			InitJNI();
		}
		protected SQLException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLException2784;
		public SQLException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException2784);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLException2785;
		public SQLException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.SQLException.staticClass, global::android.database.SQLException._SQLException2785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.SQLException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/SQLException"));
			global::android.database.SQLException._SQLException2784 = @__env.GetMethodIDNoThrow(global::android.database.SQLException.staticClass, "<init>", "()V");
			global::android.database.SQLException._SQLException2785 = @__env.GetMethodIDNoThrow(global::android.database.SQLException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
