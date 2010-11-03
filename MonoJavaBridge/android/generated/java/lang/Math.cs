namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Math : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Math(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static long abs(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static double abs(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static float abs(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int abs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m3.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static double sin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sin", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static double cos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m5.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cos", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static double tan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tan", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static double atan2(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m7.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan2", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static double sqrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sqrt", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static double log(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m9.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static double log10(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m10.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log10", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static double pow(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "pow", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static double exp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "exp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static double min(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static float min(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static long min(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(JJ)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int min(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static float max(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static long max(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m18.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(JJ)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int max(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m19.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m19 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static double max(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m20.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m20 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static float scalb(float arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m21.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m21 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(FI)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static double scalb(double arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m22.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m22 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(DI)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int getExponent(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m23.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m23 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(D)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int getExponent(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m24 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static float signum(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m25 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static double signum(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m26.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m26 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static double asin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m27.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m27 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "asin", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static double acos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m28.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m28 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "acos", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static double atan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m29.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m29 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static double toRadians(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m30.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m30 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toRadians", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static double toDegrees(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m31.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m31 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toDegrees", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static double cbrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m32.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m32 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cbrt", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static double IEEEremainder(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m33.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m33 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "IEEEremainder", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static double ceil(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m34.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m34 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ceil", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static double floor(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m35.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m35 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "floor", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static double rint(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m36.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m36 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "rint", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static int round(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m37.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m37 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static long round(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m38.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m38 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static double random()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m39.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m39 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "random", "()D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static double ulp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m40.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m40 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static float ulp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m41.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m41 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static double sinh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m42.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m42 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sinh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static double cosh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m43.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m43 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cosh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static double tanh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m44.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m44 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tanh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static double hypot(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m45.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m45 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "hypot", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static double expm1(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m46.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m46 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "expm1", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static double log1p(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m47.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m47 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log1p", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static float copySign(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m48.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m48 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static double copySign(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m49.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m49 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static double nextAfter(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m50.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m50 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static float nextAfter(float arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m51.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m51 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(FD)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static float nextUp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m52.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m52 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static double nextUp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._m53.native == global::System.IntPtr.Zero)
				global::java.lang.Math._m53 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static double E
		{
			get
			{
				return 2.718281828459045;
			}
		}
		public static double PI
		{
			get
			{
				return 3.141592653589793;
			}
		}
		static Math()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Math.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Math"));
		}
	}
}
