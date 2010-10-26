namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DebugUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DebugUtils()
		{
			InitJNI();
		}
		protected DebugUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isObjectSelected13732;
		public static bool isObjectSelected(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._isObjectSelected13732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DebugUtils13733;
		public DebugUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.DebugUtils.staticClass, global::android.util.DebugUtils._DebugUtils13733);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.DebugUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/DebugUtils"));
			global::android.util.DebugUtils._isObjectSelected13732 = @__env.GetStaticMethodIDNoThrow(global::android.util.DebugUtils.staticClass, "isObjectSelected", "(Ljava/lang/Object;)Z");
			global::android.util.DebugUtils._DebugUtils13733 = @__env.GetMethodIDNoThrow(global::android.util.DebugUtils.staticClass, "<init>", "()V");
		}
	}
}
