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
		internal static global::MonoJavaBridge.MethodId _abs20166;
		public static long abs(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20167;
		public static double abs(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20168;
		public static float abs(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abs20169;
		public static int abs(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._abs20169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sin20170;
		public static double sin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sin20170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cos20171;
		public static double cos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cos20171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tan20172;
		public static double tan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tan20172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan220173;
		public static double atan2(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan220173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sqrt20174;
		public static double sqrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sqrt20174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log20175;
		public static double log(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log20175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1020176;
		public static double log10(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1020176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pow20177;
		public static double pow(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._pow20177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _exp20178;
		public static double exp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._exp20178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _min20179;
		public static double min(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._min20179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20180;
		public static float min(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._min20180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20181;
		public static long min(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._min20181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _min20182;
		public static int min(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._min20182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20183;
		public static float max(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._max20183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20184;
		public static long max(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._max20184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20185;
		public static int max(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._max20185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _max20186;
		public static double max(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._max20186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20187;
		public static float scalb(float arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb20187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scalb20188;
		public static double scalb(double arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._scalb20188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20189;
		public static int getExponent(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent20189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getExponent20190;
		public static int getExponent(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._getExponent20190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20191;
		public static float signum(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._signum20191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _signum20192;
		public static double signum(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._signum20192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _asin20193;
		public static double asin(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._asin20193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acos20194;
		public static double acos(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._acos20194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _atan20195;
		public static double atan(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._atan20195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toRadians20196;
		public static double toRadians(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toRadians20196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toDegrees20197;
		public static double toDegrees(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._toDegrees20197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cbrt20198;
		public static double cbrt(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cbrt20198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _IEEEremainder20199;
		public static double IEEEremainder(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._IEEEremainder20199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ceil20200;
		public static double ceil(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ceil20200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floor20201;
		public static double floor(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._floor20201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rint20202;
		public static double rint(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._rint20202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20203;
		public static int round(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Math.staticClass, global::java.lang.Math._round20203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _round20204;
		public static long round(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Math.staticClass, global::java.lang.Math._round20204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _random20205;
		public static double random() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._random20205);
		}
		internal static global::MonoJavaBridge.MethodId _ulp20206;
		public static double ulp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp20206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ulp20207;
		public static float ulp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._ulp20207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sinh20208;
		public static double sinh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._sinh20208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cosh20209;
		public static double cosh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._cosh20209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _tanh20210;
		public static double tanh(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._tanh20210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hypot20211;
		public static double hypot(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._hypot20211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _expm120212;
		public static double expm1(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._expm120212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _log1p20213;
		public static double log1p(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._log1p20213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20214;
		public static float copySign(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign20214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _copySign20215;
		public static double copySign(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._copySign20215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20216;
		public static double nextAfter(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter20216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextAfter20217;
		public static float nextAfter(float arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextAfter20217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20218;
		public static float nextUp(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp20218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextUp20219;
		public static double nextUp(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Math.staticClass, global::java.lang.Math._nextUp20219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::java.lang.Math._abs20166 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(J)J");
			global::java.lang.Math._abs20167 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(D)D");
			global::java.lang.Math._abs20168 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(F)F");
			global::java.lang.Math._abs20169 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "abs", "(I)I");
			global::java.lang.Math._sin20170 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sin", "(D)D");
			global::java.lang.Math._cos20171 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cos", "(D)D");
			global::java.lang.Math._tan20172 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tan", "(D)D");
			global::java.lang.Math._atan220173 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan2", "(DD)D");
			global::java.lang.Math._sqrt20174 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sqrt", "(D)D");
			global::java.lang.Math._log20175 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log", "(D)D");
			global::java.lang.Math._log1020176 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log10", "(D)D");
			global::java.lang.Math._pow20177 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "pow", "(DD)D");
			global::java.lang.Math._exp20178 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "exp", "(D)D");
			global::java.lang.Math._min20179 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(DD)D");
			global::java.lang.Math._min20180 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(FF)F");
			global::java.lang.Math._min20181 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(JJ)J");
			global::java.lang.Math._min20182 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "min", "(II)I");
			global::java.lang.Math._max20183 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(FF)F");
			global::java.lang.Math._max20184 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(JJ)J");
			global::java.lang.Math._max20185 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(II)I");
			global::java.lang.Math._max20186 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "max", "(DD)D");
			global::java.lang.Math._scalb20187 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(FI)F");
			global::java.lang.Math._scalb20188 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "scalb", "(DI)D");
			global::java.lang.Math._getExponent20189 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(D)I");
			global::java.lang.Math._getExponent20190 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "getExponent", "(F)I");
			global::java.lang.Math._signum20191 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(F)F");
			global::java.lang.Math._signum20192 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "signum", "(D)D");
			global::java.lang.Math._asin20193 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "asin", "(D)D");
			global::java.lang.Math._acos20194 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "acos", "(D)D");
			global::java.lang.Math._atan20195 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "atan", "(D)D");
			global::java.lang.Math._toRadians20196 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toRadians", "(D)D");
			global::java.lang.Math._toDegrees20197 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "toDegrees", "(D)D");
			global::java.lang.Math._cbrt20198 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cbrt", "(D)D");
			global::java.lang.Math._IEEEremainder20199 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "IEEEremainder", "(DD)D");
			global::java.lang.Math._ceil20200 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ceil", "(D)D");
			global::java.lang.Math._floor20201 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "floor", "(D)D");
			global::java.lang.Math._rint20202 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "rint", "(D)D");
			global::java.lang.Math._round20203 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(F)I");
			global::java.lang.Math._round20204 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "round", "(D)J");
			global::java.lang.Math._random20205 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "random", "()D");
			global::java.lang.Math._ulp20206 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(D)D");
			global::java.lang.Math._ulp20207 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "ulp", "(F)F");
			global::java.lang.Math._sinh20208 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "sinh", "(D)D");
			global::java.lang.Math._cosh20209 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "cosh", "(D)D");
			global::java.lang.Math._tanh20210 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "tanh", "(D)D");
			global::java.lang.Math._hypot20211 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "hypot", "(DD)D");
			global::java.lang.Math._expm120212 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "expm1", "(D)D");
			global::java.lang.Math._log1p20213 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "log1p", "(D)D");
			global::java.lang.Math._copySign20214 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(FF)F");
			global::java.lang.Math._copySign20215 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "copySign", "(DD)D");
			global::java.lang.Math._nextAfter20216 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(DD)D");
			global::java.lang.Math._nextAfter20217 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextAfter", "(FD)F");
			global::java.lang.Math._nextUp20218 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(F)F");
			global::java.lang.Math._nextUp20219 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Math.staticClass, "nextUp", "(D)D");
		}
	}
}
