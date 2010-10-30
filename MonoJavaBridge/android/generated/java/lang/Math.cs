namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Math : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Math(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abs20284;
		public static long abs(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._abs20284.native == global::System.IntPtr.Zero)
				global::java.lang.Math._abs20284 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20285;
		public static double abs(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._abs20285.native == global::System.IntPtr.Zero)
				global::java.lang.Math._abs20285 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20286;
		public static float abs(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._abs20286.native == global::System.IntPtr.Zero)
				global::java.lang.Math._abs20286 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20287;
		public static int abs(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._abs20287.native == global::System.IntPtr.Zero)
				global::java.lang.Math._abs20287 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin20288;
		public static double sin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._sin20288.native == global::System.IntPtr.Zero)
				global::java.lang.Math._sin20288 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sin", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sin20288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos20289;
		public static double cos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._cos20289.native == global::System.IntPtr.Zero)
				global::java.lang.Math._cos20289 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cos", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cos20289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan20290;
		public static double tan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._tan20290.native == global::System.IntPtr.Zero)
				global::java.lang.Math._tan20290 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tan", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tan20290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan220291;
		public static double atan2(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._atan220291.native == global::System.IntPtr.Zero)
				global::java.lang.Math._atan220291 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan2", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan220291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt20292;
		public static double sqrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._sqrt20292.native == global::System.IntPtr.Zero)
				global::java.lang.Math._sqrt20292 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sqrt", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sqrt20292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log20293;
		public static double log(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._log20293.native == global::System.IntPtr.Zero)
				global::java.lang.Math._log20293 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log20293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1020294;
		public static double log10(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._log1020294.native == global::System.IntPtr.Zero)
				global::java.lang.Math._log1020294 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log10", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1020294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow20295;
		public static double pow(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._pow20295.native == global::System.IntPtr.Zero)
				global::java.lang.Math._pow20295 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "pow", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._pow20295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp20296;
		public static double exp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._exp20296.native == global::System.IntPtr.Zero)
				global::java.lang.Math._exp20296 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "exp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._exp20296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min20297;
		public static double min(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._min20297.native == global::System.IntPtr.Zero)
				global::java.lang.Math._min20297 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._min20297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20298;
		public static float min(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._min20298.native == global::System.IntPtr.Zero)
				global::java.lang.Math._min20298 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._min20298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20299;
		public static long min(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._min20299.native == global::System.IntPtr.Zero)
				global::java.lang.Math._min20299 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(JJ)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._min20299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20300;
		public static int min(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._min20300.native == global::System.IntPtr.Zero)
				global::java.lang.Math._min20300 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._min20300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20301;
		public static float max(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._max20301.native == global::System.IntPtr.Zero)
				global::java.lang.Math._max20301 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._max20301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20302;
		public static long max(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._max20302.native == global::System.IntPtr.Zero)
				global::java.lang.Math._max20302 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(JJ)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._max20302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20303;
		public static int max(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._max20303.native == global::System.IntPtr.Zero)
				global::java.lang.Math._max20303 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._max20303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20304;
		public static double max(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._max20304.native == global::System.IntPtr.Zero)
				global::java.lang.Math._max20304 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._max20304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20305;
		public static float scalb(float arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._scalb20305.native == global::System.IntPtr.Zero)
				global::java.lang.Math._scalb20305 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(FI)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb20305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20306;
		public static double scalb(double arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._scalb20306.native == global::System.IntPtr.Zero)
				global::java.lang.Math._scalb20306 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(DI)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb20306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20307;
		public static int getExponent(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._getExponent20307.native == global::System.IntPtr.Zero)
				global::java.lang.Math._getExponent20307 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(D)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent20307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20308;
		public static int getExponent(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._getExponent20308.native == global::System.IntPtr.Zero)
				global::java.lang.Math._getExponent20308 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent20308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20309;
		public static float signum(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._signum20309.native == global::System.IntPtr.Zero)
				global::java.lang.Math._signum20309 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._signum20309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20310;
		public static double signum(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._signum20310.native == global::System.IntPtr.Zero)
				global::java.lang.Math._signum20310 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._signum20310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin20311;
		public static double asin(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._asin20311.native == global::System.IntPtr.Zero)
				global::java.lang.Math._asin20311 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "asin", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._asin20311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos20312;
		public static double acos(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._acos20312.native == global::System.IntPtr.Zero)
				global::java.lang.Math._acos20312 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "acos", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._acos20312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan20313;
		public static double atan(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._atan20313.native == global::System.IntPtr.Zero)
				global::java.lang.Math._atan20313 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan20313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians20314;
		public static double toRadians(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._toRadians20314.native == global::System.IntPtr.Zero)
				global::java.lang.Math._toRadians20314 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toRadians", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toRadians20314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees20315;
		public static double toDegrees(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._toDegrees20315.native == global::System.IntPtr.Zero)
				global::java.lang.Math._toDegrees20315 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toDegrees", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toDegrees20315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt20316;
		public static double cbrt(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._cbrt20316.native == global::System.IntPtr.Zero)
				global::java.lang.Math._cbrt20316 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cbrt", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cbrt20316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder20317;
		public static double IEEEremainder(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._IEEEremainder20317.native == global::System.IntPtr.Zero)
				global::java.lang.Math._IEEEremainder20317 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "IEEEremainder", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._IEEEremainder20317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil20318;
		public static double ceil(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._ceil20318.native == global::System.IntPtr.Zero)
				global::java.lang.Math._ceil20318 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ceil", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ceil20318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor20319;
		public static double floor(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._floor20319.native == global::System.IntPtr.Zero)
				global::java.lang.Math._floor20319 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "floor", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._floor20319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint20320;
		public static double rint(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._rint20320.native == global::System.IntPtr.Zero)
				global::java.lang.Math._rint20320 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "rint", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._rint20320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20321;
		public static int round(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._round20321.native == global::System.IntPtr.Zero)
				global::java.lang.Math._round20321 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._round20321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20322;
		public static long round(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._round20322.native == global::System.IntPtr.Zero)
				global::java.lang.Math._round20322 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._round20322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random20323;
		public static double random()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._random20323.native == global::System.IntPtr.Zero)
				global::java.lang.Math._random20323 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "random", "()D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._random20323);
		}
		internal static global::MonoJavaBridge.MethodId _ulp20324;
		public static double ulp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._ulp20324.native == global::System.IntPtr.Zero)
				global::java.lang.Math._ulp20324 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp20324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp20325;
		public static float ulp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._ulp20325.native == global::System.IntPtr.Zero)
				global::java.lang.Math._ulp20325 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp20325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh20326;
		public static double sinh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._sinh20326.native == global::System.IntPtr.Zero)
				global::java.lang.Math._sinh20326 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sinh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sinh20326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh20327;
		public static double cosh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._cosh20327.native == global::System.IntPtr.Zero)
				global::java.lang.Math._cosh20327 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cosh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cosh20327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh20328;
		public static double tanh(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._tanh20328.native == global::System.IntPtr.Zero)
				global::java.lang.Math._tanh20328 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tanh", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tanh20328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot20329;
		public static double hypot(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._hypot20329.native == global::System.IntPtr.Zero)
				global::java.lang.Math._hypot20329 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "hypot", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._hypot20329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm120330;
		public static double expm1(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._expm120330.native == global::System.IntPtr.Zero)
				global::java.lang.Math._expm120330 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "expm1", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._expm120330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p20331;
		public static double log1p(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._log1p20331.native == global::System.IntPtr.Zero)
				global::java.lang.Math._log1p20331 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log1p", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1p20331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20332;
		public static float copySign(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._copySign20332.native == global::System.IntPtr.Zero)
				global::java.lang.Math._copySign20332 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(FF)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign20332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20333;
		public static double copySign(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._copySign20333.native == global::System.IntPtr.Zero)
				global::java.lang.Math._copySign20333 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign20333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20334;
		public static double nextAfter(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._nextAfter20334.native == global::System.IntPtr.Zero)
				global::java.lang.Math._nextAfter20334 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(DD)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter20334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20335;
		public static float nextAfter(float arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._nextAfter20335.native == global::System.IntPtr.Zero)
				global::java.lang.Math._nextAfter20335 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(FD)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter20335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20336;
		public static float nextUp(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._nextUp20336.native == global::System.IntPtr.Zero)
				global::java.lang.Math._nextUp20336 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(F)F");
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp20336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20337;
		public static double nextUp(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Math._nextUp20337.native == global::System.IntPtr.Zero)
				global::java.lang.Math._nextUp20337 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(D)D");
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp20337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static void InitJNI()
		{
		}
	}
}
