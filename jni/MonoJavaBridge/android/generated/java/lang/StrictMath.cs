namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StrictMath : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StrictMath()
		{
			InitJNI();
		}
		internal StrictMath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abs14906;
		public static long abs(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs14906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14907;
		public static double abs(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs14907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14908;
		public static float abs(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs14908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14909;
		public static int abs(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs14909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin14910;
		public static double sin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sin14910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos14911;
		public static double cos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cos14911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan14912;
		public static double tan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tan14912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan214913;
		public static double atan2(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan214913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt14914;
		public static double sqrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sqrt14914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log14915;
		public static double log(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log14915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1014916;
		public static double log10(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1014916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow14917;
		public static double pow(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._pow14917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp14918;
		public static double exp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._exp14918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min14919;
		public static double min(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min14919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14920;
		public static float min(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min14920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14921;
		public static long min(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min14921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14922;
		public static int min(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min14922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14923;
		public static float max(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max14923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14924;
		public static long max(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max14924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14925;
		public static int max(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max14925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14926;
		public static double max(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max14926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb14927;
		public static float scalb(float arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb14927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb14928;
		public static double scalb(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb14928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent14929;
		public static int getExponent(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent14929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent14930;
		public static int getExponent(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent14930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum14931;
		public static float signum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum14931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum14932;
		public static double signum(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum14932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin14933;
		public static double asin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._asin14933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos14934;
		public static double acos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._acos14934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan14935;
		public static double atan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan14935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians14936;
		public static double toRadians(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toRadians14936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees14937;
		public static double toDegrees(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toDegrees14937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt14938;
		public static double cbrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cbrt14938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder14939;
		public static double IEEEremainder(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._IEEEremainder14939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil14940;
		public static double ceil(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ceil14940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor14941;
		public static double floor(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._floor14941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint14942;
		public static double rint(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._rint14942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round14943;
		public static int round(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round14943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round14944;
		public static long round(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round14944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random14945;
		public static double random() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._random14945);
		}
		internal static global::MonoJavaBridge.MethodId _ulp14946;
		public static double ulp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp14946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp14947;
		public static float ulp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp14947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh14948;
		public static double sinh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sinh14948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh14949;
		public static double cosh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cosh14949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh14950;
		public static double tanh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tanh14950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot14951;
		public static double hypot(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._hypot14951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm114952;
		public static double expm1(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._expm114952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p14953;
		public static double log1p(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1p14953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign14954;
		public static float copySign(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign14954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign14955;
		public static double copySign(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign14955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter14956;
		public static double nextAfter(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter14956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter14957;
		public static float nextAfter(float arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter14957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp14958;
		public static float nextUp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp14958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp14959;
		public static double nextUp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp14959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StrictMath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StrictMath"));
			global::java.lang.StrictMath._abs14906 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(J)J");
			global::java.lang.StrictMath._abs14907 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(D)D");
			global::java.lang.StrictMath._abs14908 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(F)F");
			global::java.lang.StrictMath._abs14909 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(I)I");
			global::java.lang.StrictMath._sin14910 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sin", "(D)D");
			global::java.lang.StrictMath._cos14911 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cos", "(D)D");
			global::java.lang.StrictMath._tan14912 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tan", "(D)D");
			global::java.lang.StrictMath._atan214913 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan2", "(DD)D");
			global::java.lang.StrictMath._sqrt14914 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sqrt", "(D)D");
			global::java.lang.StrictMath._log14915 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log", "(D)D");
			global::java.lang.StrictMath._log1014916 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log10", "(D)D");
			global::java.lang.StrictMath._pow14917 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "pow", "(DD)D");
			global::java.lang.StrictMath._exp14918 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "exp", "(D)D");
			global::java.lang.StrictMath._min14919 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(DD)D");
			global::java.lang.StrictMath._min14920 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(FF)F");
			global::java.lang.StrictMath._min14921 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(JJ)J");
			global::java.lang.StrictMath._min14922 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(II)I");
			global::java.lang.StrictMath._max14923 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(FF)F");
			global::java.lang.StrictMath._max14924 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(JJ)J");
			global::java.lang.StrictMath._max14925 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(II)I");
			global::java.lang.StrictMath._max14926 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(DD)D");
			global::java.lang.StrictMath._scalb14927 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(FI)F");
			global::java.lang.StrictMath._scalb14928 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(DI)D");
			global::java.lang.StrictMath._getExponent14929 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(D)I");
			global::java.lang.StrictMath._getExponent14930 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(F)I");
			global::java.lang.StrictMath._signum14931 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(F)F");
			global::java.lang.StrictMath._signum14932 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(D)D");
			global::java.lang.StrictMath._asin14933 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "asin", "(D)D");
			global::java.lang.StrictMath._acos14934 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "acos", "(D)D");
			global::java.lang.StrictMath._atan14935 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan", "(D)D");
			global::java.lang.StrictMath._toRadians14936 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toRadians", "(D)D");
			global::java.lang.StrictMath._toDegrees14937 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toDegrees", "(D)D");
			global::java.lang.StrictMath._cbrt14938 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cbrt", "(D)D");
			global::java.lang.StrictMath._IEEEremainder14939 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "IEEEremainder", "(DD)D");
			global::java.lang.StrictMath._ceil14940 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ceil", "(D)D");
			global::java.lang.StrictMath._floor14941 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "floor", "(D)D");
			global::java.lang.StrictMath._rint14942 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "rint", "(D)D");
			global::java.lang.StrictMath._round14943 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(F)I");
			global::java.lang.StrictMath._round14944 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(D)J");
			global::java.lang.StrictMath._random14945 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "random", "()D");
			global::java.lang.StrictMath._ulp14946 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(D)D");
			global::java.lang.StrictMath._ulp14947 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(F)F");
			global::java.lang.StrictMath._sinh14948 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sinh", "(D)D");
			global::java.lang.StrictMath._cosh14949 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cosh", "(D)D");
			global::java.lang.StrictMath._tanh14950 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tanh", "(D)D");
			global::java.lang.StrictMath._hypot14951 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "hypot", "(DD)D");
			global::java.lang.StrictMath._expm114952 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "expm1", "(D)D");
			global::java.lang.StrictMath._log1p14953 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log1p", "(D)D");
			global::java.lang.StrictMath._copySign14954 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(FF)F");
			global::java.lang.StrictMath._copySign14955 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(DD)D");
			global::java.lang.StrictMath._nextAfter14956 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(DD)D");
			global::java.lang.StrictMath._nextAfter14957 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(FD)F");
			global::java.lang.StrictMath._nextUp14958 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(F)F");
			global::java.lang.StrictMath._nextUp14959 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(D)D");
		}
	}
}
