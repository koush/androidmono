namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetworkErrorException : android.accounts.AccountsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetworkErrorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NetworkErrorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._m0.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._m0 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NetworkErrorException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._m1.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._m1 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public NetworkErrorException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._m2.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._m2 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public NetworkErrorException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.accounts.NetworkErrorException._m3.native == global::System.IntPtr.Zero)
				global::android.accounts.NetworkErrorException._m3 = @__env.GetMethodIDNoThrow(global::android.accounts.NetworkErrorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.NetworkErrorException.staticClass, global::android.accounts.NetworkErrorException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
