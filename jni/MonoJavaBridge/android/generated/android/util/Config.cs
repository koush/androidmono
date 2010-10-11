namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Config : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Config()
		{
			InitJNI();
		}
		internal Config(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _Config8485;
		public Config()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Config.staticClass, global::android.util.Config._Config8485);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Config.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Config"));
			global::android.util.Config._Config8485 = @__env.GetMethodIDNoThrow(global::android.util.Config.staticClass, "<init>", "()V");
		}
	}
}
