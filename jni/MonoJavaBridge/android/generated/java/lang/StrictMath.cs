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
		internal static global::MonoJavaBridge.MethodId _abs20423;
		public static long abs(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20424;
		public static double abs(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20425;
		public static float abs(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20426;
		public static int abs(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._abs20426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin20427;
		public static double sin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sin20427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos20428;
		public static double cos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cos20428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan20429;
		public static double tan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tan20429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan220430;
		public static double atan2(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan220430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt20431;
		public static double sqrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sqrt20431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log20432;
		public static double log(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log20432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1020433;
		public static double log10(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1020433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow20434;
		public static double pow(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._pow20434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp20435;
		public static double exp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._exp20435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min20436;
		public static double min(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20437;
		public static float min(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20438;
		public static long min(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20439;
		public static int min(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._min20439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20440;
		public static float max(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20441;
		public static long max(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20442;
		public static int max(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20443;
		public static double max(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._max20443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20444;
		public static float scalb(float arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb20444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20445;
		public static double scalb(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._scalb20445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20446;
		public static int getExponent(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent20446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20447;
		public static int getExponent(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._getExponent20447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20448;
		public static float signum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum20448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20449;
		public static double signum(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._signum20449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin20450;
		public static double asin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._asin20450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos20451;
		public static double acos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._acos20451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan20452;
		public static double atan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._atan20452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians20453;
		public static double toRadians(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toRadians20453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees20454;
		public static double toDegrees(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._toDegrees20454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt20455;
		public static double cbrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cbrt20455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder20456;
		public static double IEEEremainder(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._IEEEremainder20456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil20457;
		public static double ceil(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ceil20457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor20458;
		public static double floor(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._floor20458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint20459;
		public static double rint(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._rint20459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20460;
		public static int round(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round20460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20461;
		public static long round(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._round20461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random20462;
		public static double random() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._random20462);
		}
		internal static global::MonoJavaBridge.MethodId _ulp20463;
		public static double ulp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp20463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp20464;
		public static float ulp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._ulp20464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh20465;
		public static double sinh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._sinh20465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh20466;
		public static double cosh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._cosh20466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh20467;
		public static double tanh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._tanh20467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot20468;
		public static double hypot(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._hypot20468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm120469;
		public static double expm1(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._expm120469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p20470;
		public static double log1p(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._log1p20470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20471;
		public static float copySign(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign20471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20472;
		public static double copySign(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._copySign20472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20473;
		public static double nextAfter(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter20473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20474;
		public static float nextAfter(float arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextAfter20474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20475;
		public static float nextUp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp20475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20476;
		public static double nextUp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.StrictMath.staticClass, global::java.lang.StrictMath._nextUp20476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.lang.StrictMath._abs20423 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(J)J");
			global::java.lang.StrictMath._abs20424 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(D)D");
			global::java.lang.StrictMath._abs20425 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(F)F");
			global::java.lang.StrictMath._abs20426 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "abs", "(I)I");
			global::java.lang.StrictMath._sin20427 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sin", "(D)D");
			global::java.lang.StrictMath._cos20428 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cos", "(D)D");
			global::java.lang.StrictMath._tan20429 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tan", "(D)D");
			global::java.lang.StrictMath._atan220430 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan2", "(DD)D");
			global::java.lang.StrictMath._sqrt20431 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sqrt", "(D)D");
			global::java.lang.StrictMath._log20432 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log", "(D)D");
			global::java.lang.StrictMath._log1020433 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log10", "(D)D");
			global::java.lang.StrictMath._pow20434 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "pow", "(DD)D");
			global::java.lang.StrictMath._exp20435 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "exp", "(D)D");
			global::java.lang.StrictMath._min20436 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(DD)D");
			global::java.lang.StrictMath._min20437 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(FF)F");
			global::java.lang.StrictMath._min20438 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(JJ)J");
			global::java.lang.StrictMath._min20439 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "min", "(II)I");
			global::java.lang.StrictMath._max20440 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(FF)F");
			global::java.lang.StrictMath._max20441 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(JJ)J");
			global::java.lang.StrictMath._max20442 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(II)I");
			global::java.lang.StrictMath._max20443 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "max", "(DD)D");
			global::java.lang.StrictMath._scalb20444 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(FI)F");
			global::java.lang.StrictMath._scalb20445 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "scalb", "(DI)D");
			global::java.lang.StrictMath._getExponent20446 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(D)I");
			global::java.lang.StrictMath._getExponent20447 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "getExponent", "(F)I");
			global::java.lang.StrictMath._signum20448 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(F)F");
			global::java.lang.StrictMath._signum20449 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "signum", "(D)D");
			global::java.lang.StrictMath._asin20450 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "asin", "(D)D");
			global::java.lang.StrictMath._acos20451 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "acos", "(D)D");
			global::java.lang.StrictMath._atan20452 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "atan", "(D)D");
			global::java.lang.StrictMath._toRadians20453 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toRadians", "(D)D");
			global::java.lang.StrictMath._toDegrees20454 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "toDegrees", "(D)D");
			global::java.lang.StrictMath._cbrt20455 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cbrt", "(D)D");
			global::java.lang.StrictMath._IEEEremainder20456 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "IEEEremainder", "(DD)D");
			global::java.lang.StrictMath._ceil20457 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ceil", "(D)D");
			global::java.lang.StrictMath._floor20458 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "floor", "(D)D");
			global::java.lang.StrictMath._rint20459 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "rint", "(D)D");
			global::java.lang.StrictMath._round20460 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(F)I");
			global::java.lang.StrictMath._round20461 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "round", "(D)J");
			global::java.lang.StrictMath._random20462 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "random", "()D");
			global::java.lang.StrictMath._ulp20463 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(D)D");
			global::java.lang.StrictMath._ulp20464 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "ulp", "(F)F");
			global::java.lang.StrictMath._sinh20465 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "sinh", "(D)D");
			global::java.lang.StrictMath._cosh20466 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "cosh", "(D)D");
			global::java.lang.StrictMath._tanh20467 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "tanh", "(D)D");
			global::java.lang.StrictMath._hypot20468 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "hypot", "(DD)D");
			global::java.lang.StrictMath._expm120469 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "expm1", "(D)D");
			global::java.lang.StrictMath._log1p20470 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "log1p", "(D)D");
			global::java.lang.StrictMath._copySign20471 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(FF)F");
			global::java.lang.StrictMath._copySign20472 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "copySign", "(DD)D");
			global::java.lang.StrictMath._nextAfter20473 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(DD)D");
			global::java.lang.StrictMath._nextAfter20474 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextAfter", "(FD)F");
			global::java.lang.StrictMath._nextUp20475 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(F)F");
			global::java.lang.StrictMath._nextUp20476 = @__env.GetStaticMethodIDNoThrow(global::java.lang.StrictMath.staticClass, "nextUp", "(D)D");
		}
	}
}
