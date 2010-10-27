namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OperationCanceledException : android.accounts.AccountsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OperationCanceledException()
		{
			InitJNI();
		}
		protected OperationCanceledException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _OperationCanceledException1386;
		public OperationCanceledException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OperationCanceledException.staticClass, global::android.accounts.OperationCanceledException._OperationCanceledException1386);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationCanceledException1387;
		public OperationCanceledException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OperationCanceledException.staticClass, global::android.accounts.OperationCanceledException._OperationCanceledException1387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationCanceledException1388;
		public OperationCanceledException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OperationCanceledException.staticClass, global::android.accounts.OperationCanceledException._OperationCanceledException1388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OperationCanceledException1389;
		public OperationCanceledException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.OperationCanceledException.staticClass, global::android.accounts.OperationCanceledException._OperationCanceledException1389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.OperationCanceledException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/OperationCanceledException"));
			global::android.accounts.OperationCanceledException._OperationCanceledException1386 = @__env.GetMethodIDNoThrow(global::android.accounts.OperationCanceledException.staticClass, "<init>", "()V");
			global::android.accounts.OperationCanceledException._OperationCanceledException1387 = @__env.GetMethodIDNoThrow(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.accounts.OperationCanceledException._OperationCanceledException1388 = @__env.GetMethodIDNoThrow(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.accounts.OperationCanceledException._OperationCanceledException1389 = @__env.GetMethodIDNoThrow(global::android.accounts.OperationCanceledException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
