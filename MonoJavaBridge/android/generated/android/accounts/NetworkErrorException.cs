namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetworkErrorException : android.accounts.AccountsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetworkErrorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NetworkErrorException1380;
		public NetworkErrorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._NetworkErrorException1380.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._NetworkErrorException1380 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._NetworkErrorException1380);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetworkErrorException1381;
		public NetworkErrorException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._NetworkErrorException1381.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._NetworkErrorException1381 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._NetworkErrorException1381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetworkErrorException1382;
		public NetworkErrorException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._NetworkErrorException1382.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._NetworkErrorException1382 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._NetworkErrorException1382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetworkErrorException1383;
		public NetworkErrorException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._NetworkErrorException1383.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._NetworkErrorException1383 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._NetworkErrorException1383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NetworkErrorException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.NetworkErrorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/NetworkErrorException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
