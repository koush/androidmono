namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaleDataException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StaleDataException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StaleDataException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.StaleDataException._m0.native == global::System.IntPtr.Zero)
				global::android.database.StaleDataException._m0 = @__env.GetMethodIDNoThrow(global::android.database.StaleDataException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.StaleDataException.staticClass, global::android.database.StaleDataException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StaleDataException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.StaleDataException._m1.native == global::System.IntPtr.Zero)
				global::android.database.StaleDataException._m1 = @__env.GetMethodIDNoThrow(global::android.database.StaleDataException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.StaleDataException.staticClass, global::android.database.StaleDataException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StaleDataException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.StaleDataException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/StaleDataException"));
		}
	}
}
