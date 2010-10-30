namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DebugUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DebugUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isObjectSelected(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.DebugUtils._m0.native == global::System.IntPtr.Zero)
				global::android.util.DebugUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.DebugUtils.staticClass, "isObjectSelected", "(Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DebugUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.DebugUtils._m1.native == global::System.IntPtr.Zero)
				global::android.util.DebugUtils._m1 = @__env.GetMethodIDNoThrow(global::android.util.DebugUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._m1);
			Init(@__env, handle);
		}
		static DebugUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DebugUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DebugUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
