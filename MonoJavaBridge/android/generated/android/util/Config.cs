namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Config : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Config(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public Config() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Config._m0.native == global::System.IntPtr.Zero)
				global::android.util.Config._m0 = @__env.GetMethodIDNoThrow(global::android.util.Config.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Config.staticClass, global::android.util.Config._m0);
			Init(@__env, handle);
		}
		public static bool DEBUG
		{
			get
			{
				return false;
			}
		}
		public static bool RELEASE
		{
			get
			{
				return false;
			}
		}
		public static bool PROFILE
		{
			get
			{
				return false;
			}
		}
		public static bool LOGV
		{
			get
			{
				return false;
			}
		}
		public static bool LOGD
		{
			get
			{
				return true;
			}
		}
		static Config()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Config.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Config"));
		}
	}
}
