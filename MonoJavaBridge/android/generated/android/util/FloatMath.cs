namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FloatMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FloatMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static float sin(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._m0.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static float cos(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._m1.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static float sqrt(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._m2.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static float ceil(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._m3.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static float floor(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.FloatMath._m4.native == global::System.IntPtr.Zero)
				global::android.util.FloatMath._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "floor", "(F)F");
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
