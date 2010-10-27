namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaleDataException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StaleDataException()
		{
			InitJNI();
		}
		protected StaleDataException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StaleDataException4702;
		public StaleDataException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.StaleDataException.staticClass, global::android.database.StaleDataException._StaleDataException4702);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaleDataException4703;
		public StaleDataException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.StaleDataException.staticClass, global::android.database.StaleDataException._StaleDataException4703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.StaleDataException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/StaleDataException"));
			global::android.database.StaleDataException._StaleDataException4702 = @__env.GetMethodIDNoThrow(global::android.database.StaleDataException.staticClass, "<init>", "()V");
			global::android.database.StaleDataException._StaleDataException4703 = @__env.GetMethodIDNoThrow(global::android.database.StaleDataException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
