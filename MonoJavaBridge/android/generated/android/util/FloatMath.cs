namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FloatMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FloatMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sin13768;
		public static float sin(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._sin13768.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._sin13768 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sin13768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos13769;
		public static float cos(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._cos13769.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._cos13769 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._cos13769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt13770;
		public static float sqrt(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._sqrt13770.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._sqrt13770 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sqrt13770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ceil13771;
		public static float ceil(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._ceil13771.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._ceil13771 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._ceil13771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor13772;
		public static float floor(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._floor13772.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._floor13772 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "floor", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._floor13772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static FloatMath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.FloatMath.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/FloatMath"));
		}
		internal static void InitJNI()
		{
		}
	}
}
