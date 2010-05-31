namespace android.text.format
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DateUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DateUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.format.DateUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.format.DateUtils(@__env);
			}
		}
		protected DateUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDayOfWeekString7047;
		public static global::java.lang.String getDayOfWeekString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getDayOfWeekString7047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAMPMString7048;
		public static global::java.lang.String getAMPMString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getAMPMString7048, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMonthString7049;
		public static global::java.lang.String getMonthString(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getMonthString7049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeTimeSpanString7050;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString7050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeTimeSpanString7051;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString7051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeTimeSpanString7052;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString7052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeTimeSpanString7053;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString7053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeTimeSpanString7054;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString7054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRelativeDateTimeString7055;
		public static global::java.lang.CharSequence getRelativeDateTimeString(android.content.Context arg0, long arg1, long arg2, long arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeDateTimeString7055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatElapsedTime7056;
		public static global::java.lang.String formatElapsedTime(java.lang.StringBuilder arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatElapsedTime7056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatElapsedTime7057;
		public static global::java.lang.String formatElapsedTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatElapsedTime7057, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatSameDayTime7058;
		public static global::java.lang.CharSequence formatSameDayTime(long arg0, long arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatSameDayTime7058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isToday7059;
		public static bool isToday(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._isToday7059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatDateRange7060;
		public static global::java.util.Formatter formatDateRange(android.content.Context arg0, java.util.Formatter arg1, long arg2, long arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Formatter>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateRange7060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatDateRange7061;
		public static global::java.lang.String formatDateRange(android.content.Context arg0, long arg1, long arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateRange7061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatDateTime7062;
		public static global::java.lang.String formatDateTime(android.content.Context arg0, long arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateTime7062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DateUtils7063;
		public DateUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._DateUtils7063, this);
		}
		public static long SECOND_IN_MILLIS
		{
			get
			{
				return 1000L;
			}
		}
		public static long MINUTE_IN_MILLIS
		{
			get
			{
				return 60000L;
			}
		}
		public static long HOUR_IN_MILLIS
		{
			get
			{
				return 3600000L;
			}
		}
		public static long DAY_IN_MILLIS
		{
			get
			{
				return 86400000L;
			}
		}
		public static long WEEK_IN_MILLIS
		{
			get
			{
				return 604800000L;
			}
		}
		public static long YEAR_IN_MILLIS
		{
			get
			{
				return 31449600000L;
			}
		}
		public static int FORMAT_SHOW_TIME
		{
			get
			{
				return 1;
			}
		}
		public static int FORMAT_SHOW_WEEKDAY
		{
			get
			{
				return 2;
			}
		}
		public static int FORMAT_SHOW_YEAR
		{
			get
			{
				return 4;
			}
		}
		public static int FORMAT_NO_YEAR
		{
			get
			{
				return 8;
			}
		}
		public static int FORMAT_SHOW_DATE
		{
			get
			{
				return 16;
			}
		}
		public static int FORMAT_NO_MONTH_DAY
		{
			get
			{
				return 32;
			}
		}
		public static int FORMAT_12HOUR
		{
			get
			{
				return 64;
			}
		}
		public static int FORMAT_24HOUR
		{
			get
			{
				return 128;
			}
		}
		public static int FORMAT_CAP_AMPM
		{
			get
			{
				return 256;
			}
		}
		public static int FORMAT_NO_NOON
		{
			get
			{
				return 512;
			}
		}
		public static int FORMAT_CAP_NOON
		{
			get
			{
				return 1024;
			}
		}
		public static int FORMAT_NO_MIDNIGHT
		{
			get
			{
				return 2048;
			}
		}
		public static int FORMAT_CAP_MIDNIGHT
		{
			get
			{
				return 4096;
			}
		}
		public static int FORMAT_UTC
		{
			get
			{
				return 8192;
			}
		}
		public static int FORMAT_ABBREV_TIME
		{
			get
			{
				return 16384;
			}
		}
		public static int FORMAT_ABBREV_WEEKDAY
		{
			get
			{
				return 32768;
			}
		}
		public static int FORMAT_ABBREV_MONTH
		{
			get
			{
				return 65536;
			}
		}
		public static int FORMAT_NUMERIC_DATE
		{
			get
			{
				return 131072;
			}
		}
		public static int FORMAT_ABBREV_RELATIVE
		{
			get
			{
				return 262144;
			}
		}
		public static int FORMAT_ABBREV_ALL
		{
			get
			{
				return 524288;
			}
		}
		public static int FORMAT_CAP_NOON_MIDNIGHT
		{
			get
			{
				return 5120;
			}
		}
		public static int FORMAT_NO_NOON_MIDNIGHT
		{
			get
			{
				return 2560;
			}
		}
		public static global::java.lang.String HOUR_MINUTE_24
		{
			get
			{
				return "%H:%M";
			}
		}
		public static global::java.lang.String MONTH_FORMAT
		{
			get
			{
				return "%B";
			}
		}
		public static global::java.lang.String ABBREV_MONTH_FORMAT
		{
			get
			{
				return "%b";
			}
		}
		public static global::java.lang.String NUMERIC_MONTH_FORMAT
		{
			get
			{
				return "%m";
			}
		}
		public static global::java.lang.String MONTH_DAY_FORMAT
		{
			get
			{
				return "%-d";
			}
		}
		public static global::java.lang.String YEAR_FORMAT
		{
			get
			{
				return "%Y";
			}
		}
		public static global::java.lang.String YEAR_FORMAT_TWO_DIGITS
		{
			get
			{
				return "%g";
			}
		}
		public static global::java.lang.String WEEKDAY_FORMAT
		{
			get
			{
				return "%A";
			}
		}
		public static global::java.lang.String ABBREV_WEEKDAY_FORMAT
		{
			get
			{
				return "%a";
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _sameYearTable7064;
		public static int[] sameYearTable
		{
			get
			{
				return default(int[]);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _sameMonthTable7065;
		public static int[] sameMonthTable
		{
			get
			{
				return default(int[]);
			}
		}
		public static int LENGTH_LONG
		{
			get
			{
				return 10;
			}
		}
		public static int LENGTH_MEDIUM
		{
			get
			{
				return 20;
			}
		}
		public static int LENGTH_SHORT
		{
			get
			{
				return 30;
			}
		}
		public static int LENGTH_SHORTER
		{
			get
			{
				return 40;
			}
		}
		public static int LENGTH_SHORTEST
		{
			get
			{
				return 50;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.format.DateUtils.staticClass = @__class;
			global::android.text.format.DateUtils._getDayOfWeekString7047 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getDayOfWeekString", "(II)Ljava/lang/String;");
			global::android.text.format.DateUtils._getAMPMString7048 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getAMPMString", "(I)Ljava/lang/String;");
			global::android.text.format.DateUtils._getMonthString7049 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getMonthString", "(II)Ljava/lang/String;");
			global::android.text.format.DateUtils._getRelativeTimeSpanString7050 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJ)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._getRelativeTimeSpanString7051 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJI)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._getRelativeTimeSpanString7052 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(J)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._getRelativeTimeSpanString7053 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;JZ)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._getRelativeTimeSpanString7054 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;J)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._getRelativeDateTimeString7055 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "getRelativeDateTimeString", "(Landroid/content/Context;JJJI)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._formatElapsedTime7056 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(Ljava/lang/StringBuilder;J)Ljava/lang/String;");
			global::android.text.format.DateUtils._formatElapsedTime7057 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(J)Ljava/lang/String;");
			global::android.text.format.DateUtils._formatSameDayTime7058 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatSameDayTime", "(JJII)Ljava/lang/CharSequence;");
			global::android.text.format.DateUtils._isToday7059 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "isToday", "(J)Z");
			global::android.text.format.DateUtils._formatDateRange7060 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJI)Ljava/util/Formatter;");
			global::android.text.format.DateUtils._formatDateRange7061 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;JJI)Ljava/lang/String;");
			global::android.text.format.DateUtils._formatDateTime7062 = @__env.GetStaticMethodID(global::android.text.format.DateUtils.staticClass, "formatDateTime", "(Landroid/content/Context;JI)Ljava/lang/String;");
			global::android.text.format.DateUtils._DateUtils7063 = @__env.GetMethodID(global::android.text.format.DateUtils.staticClass, "<init>", "()V");
		}
	}
}
