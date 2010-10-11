namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FloatMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FloatMath()
		{
			InitJNI();
		}
		protected FloatMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _sin8518;
		public static float sin(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sin8518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos8519;
		public static float cos(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._cos8519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt8520;
		public static float sqrt(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._sqrt8520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ceil8521;
		public static float ceil(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._ceil8521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor8522;
		public static float floor(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.util.FloatMath.staticClass, global::android.util.FloatMath._floor8522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.FloatMath.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/FloatMath"));
			global::android.util.FloatMath._sin8518 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sin", "(F)F");
			global::android.util.FloatMath._cos8519 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "cos", "(F)F");
			global::android.util.FloatMath._sqrt8520 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "sqrt", "(F)F");
			global::android.util.FloatMath._ceil8521 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "ceil", "(F)F");
			global::android.util.FloatMath._floor8522 = @__env.GetStaticMethodIDNoThrow(global::android.util.FloatMath.staticClass, "floor", "(F)F");
		}
	}
}
