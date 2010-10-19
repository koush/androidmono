namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Math : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Math()
		{
			InitJNI();
		}
		internal Math(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _abs14654;
		public static long abs(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._abs14654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14655;
		public static double abs(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._abs14655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14656;
		public static float abs(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._abs14656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs14657;
		public static int abs(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._abs14657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin14658;
		public static double sin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sin14658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos14659;
		public static double cos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cos14659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan14660;
		public static double tan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tan14660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan214661;
		public static double atan2(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan214661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt14662;
		public static double sqrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sqrt14662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log14663;
		public static double log(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log14663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1014664;
		public static double log10(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1014664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow14665;
		public static double pow(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._pow14665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp14666;
		public static double exp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._exp14666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min14667;
		public static double min(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._min14667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14668;
		public static float min(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._min14668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14669;
		public static long min(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._min14669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min14670;
		public static int min(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._min14670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14671;
		public static float max(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._max14671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14672;
		public static long max(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._max14672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14673;
		public static int max(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._max14673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max14674;
		public static double max(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._max14674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb14675;
		public static float scalb(float arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb14675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb14676;
		public static double scalb(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb14676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent14677;
		public static int getExponent(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent14677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent14678;
		public static int getExponent(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent14678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum14679;
		public static float signum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._signum14679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum14680;
		public static double signum(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._signum14680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin14681;
		public static double asin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._asin14681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos14682;
		public static double acos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._acos14682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan14683;
		public static double atan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan14683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians14684;
		public static double toRadians(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toRadians14684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees14685;
		public static double toDegrees(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toDegrees14685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt14686;
		public static double cbrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cbrt14686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder14687;
		public static double IEEEremainder(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._IEEEremainder14687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil14688;
		public static double ceil(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ceil14688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor14689;
		public static double floor(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._floor14689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint14690;
		public static double rint(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._rint14690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round14691;
		public static int round(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._round14691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round14692;
		public static long round(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._round14692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random14693;
		public static double random() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._random14693);
		}
		internal static global::MonoJavaBridge.MethodId _ulp14694;
		public static double ulp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp14694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp14695;
		public static float ulp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp14695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh14696;
		public static double sinh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sinh14696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh14697;
		public static double cosh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cosh14697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh14698;
		public static double tanh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tanh14698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot14699;
		public static double hypot(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._hypot14699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm114700;
		public static double expm1(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._expm114700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p14701;
		public static double log1p(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1p14701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign14702;
		public static float copySign(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign14702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign14703;
		public static double copySign(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign14703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter14704;
		public static double nextAfter(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter14704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter14705;
		public static float nextAfter(float arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter14705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp14706;
		public static float nextUp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp14706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp14707;
		public static double nextUp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp14707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.lang.Math.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Math"));
			global::java.lang.Math._abs14654 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(J)J");
			global::java.lang.Math._abs14655 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(D)D");
			global::java.lang.Math._abs14656 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(F)F");
			global::java.lang.Math._abs14657 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(I)I");
			global::java.lang.Math._sin14658 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sin", "(D)D");
			global::java.lang.Math._cos14659 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cos", "(D)D");
			global::java.lang.Math._tan14660 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tan", "(D)D");
			global::java.lang.Math._atan214661 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan2", "(DD)D");
			global::java.lang.Math._sqrt14662 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sqrt", "(D)D");
			global::java.lang.Math._log14663 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log", "(D)D");
			global::java.lang.Math._log1014664 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log10", "(D)D");
			global::java.lang.Math._pow14665 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "pow", "(DD)D");
			global::java.lang.Math._exp14666 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "exp", "(D)D");
			global::java.lang.Math._min14667 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(DD)D");
			global::java.lang.Math._min14668 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(FF)F");
			global::java.lang.Math._min14669 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(JJ)J");
			global::java.lang.Math._min14670 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(II)I");
			global::java.lang.Math._max14671 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(FF)F");
			global::java.lang.Math._max14672 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(JJ)J");
			global::java.lang.Math._max14673 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(II)I");
			global::java.lang.Math._max14674 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(DD)D");
			global::java.lang.Math._scalb14675 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(FI)F");
			global::java.lang.Math._scalb14676 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(DI)D");
			global::java.lang.Math._getExponent14677 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(D)I");
			global::java.lang.Math._getExponent14678 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(F)I");
			global::java.lang.Math._signum14679 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(F)F");
			global::java.lang.Math._signum14680 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(D)D");
			global::java.lang.Math._asin14681 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "asin", "(D)D");
			global::java.lang.Math._acos14682 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "acos", "(D)D");
			global::java.lang.Math._atan14683 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan", "(D)D");
			global::java.lang.Math._toRadians14684 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toRadians", "(D)D");
			global::java.lang.Math._toDegrees14685 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toDegrees", "(D)D");
			global::java.lang.Math._cbrt14686 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cbrt", "(D)D");
			global::java.lang.Math._IEEEremainder14687 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "IEEEremainder", "(DD)D");
			global::java.lang.Math._ceil14688 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ceil", "(D)D");
			global::java.lang.Math._floor14689 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "floor", "(D)D");
			global::java.lang.Math._rint14690 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "rint", "(D)D");
			global::java.lang.Math._round14691 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(F)I");
			global::java.lang.Math._round14692 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(D)J");
			global::java.lang.Math._random14693 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "random", "()D");
			global::java.lang.Math._ulp14694 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(D)D");
			global::java.lang.Math._ulp14695 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(F)F");
			global::java.lang.Math._sinh14696 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sinh", "(D)D");
			global::java.lang.Math._cosh14697 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cosh", "(D)D");
			global::java.lang.Math._tanh14698 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tanh", "(D)D");
			global::java.lang.Math._hypot14699 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "hypot", "(DD)D");
			global::java.lang.Math._expm114700 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "expm1", "(D)D");
			global::java.lang.Math._log1p14701 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log1p", "(D)D");
			global::java.lang.Math._copySign14702 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(FF)F");
			global::java.lang.Math._copySign14703 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(DD)D");
			global::java.lang.Math._nextAfter14704 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(DD)D");
			global::java.lang.Math._nextAfter14705 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(FD)F");
			global::java.lang.Math._nextUp14706 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(F)F");
			global::java.lang.Math._nextUp14707 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(D)D");
		}
	}
}
