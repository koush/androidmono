namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDayOfWeekString13124;
		public static global::java.lang.String getDayOfWeekString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getDayOfWeekString13124.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getDayOfWeekString13124 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getDayOfWeekString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getDayOfWeekString13124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAMPMString13125;
		public static global::java.lang.String getAMPMString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getAMPMString13125.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getAMPMString13125 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getAMPMString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getAMPMString13125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMonthString13126;
		public static global::java.lang.String getMonthString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getMonthString13126.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getMonthString13126 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getMonthString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getMonthString13126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeTimeSpanString13127;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeTimeSpanString13127.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeTimeSpanString13127 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJ)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString13127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeTimeSpanString13128;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeTimeSpanString13128.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeTimeSpanString13128 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJI)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString13128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeTimeSpanString13129;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeTimeSpanString13129.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeTimeSpanString13129 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString13129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeTimeSpanString13130;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeTimeSpanString13130.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeTimeSpanString13130 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;JZ)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString13130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeTimeSpanString13131;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeTimeSpanString13131.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeTimeSpanString13131 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeTimeSpanString13131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getRelativeDateTimeString13132;
		public static global::java.lang.CharSequence getRelativeDateTimeString(android.content.Context arg0, long arg1, long arg2, long arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._getRelativeDateTimeString13132.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._getRelativeDateTimeString13132 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeDateTimeString", "(Landroid/content/Context;JJJI)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._getRelativeDateTimeString13132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _formatElapsedTime13133;
		public static global::java.lang.String formatElapsedTime(java.lang.StringBuilder arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatElapsedTime13133.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatElapsedTime13133 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(Ljava/lang/StringBuilder;J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatElapsedTime13133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatElapsedTime13134;
		public static global::java.lang.String formatElapsedTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatElapsedTime13134.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatElapsedTime13134 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatElapsedTime13134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatSameDayTime13135;
		public static global::java.lang.CharSequence formatSameDayTime(long arg0, long arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatSameDayTime13135.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatSameDayTime13135 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatSameDayTime", "(JJII)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatSameDayTime13135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _isToday13136;
		public static bool isToday(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._isToday13136.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._isToday13136 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "isToday", "(J)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._isToday13136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatDateRange13137;
		public static global::java.util.Formatter formatDateRange(android.content.Context arg0, java.util.Formatter arg1, long arg2, long arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatDateRange13137.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatDateRange13137 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJI)Ljava/util/Formatter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateRange13137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _formatDateRange13138;
		public static global::java.lang.String formatDateRange(android.content.Context arg0, long arg1, long arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatDateRange13138.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatDateRange13138 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;JJI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateRange13138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatDateTime13139;
		public static global::java.lang.String formatDateTime(android.content.Context arg0, long arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._formatDateTime13139.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._formatDateTime13139 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateTime", "(Landroid/content/Context;JI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._formatDateTime13139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DateUtils13140;
		public DateUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._DateUtils13140.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._DateUtils13140 = @__env.GetMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._DateUtils13140);
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _sameYearTable13178;
		public static int[] sameYearTable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.text.format.DateUtils.staticClass, _sameYearTable13178)) as int[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _sameMonthTable13179;
		public static int[] sameMonthTable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.text.format.DateUtils.staticClass, _sameMonthTable13179)) as int[];
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
		static DateUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.DateUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/DateUtils"));
			global::android.text.format.DateUtils._sameYearTable13178 = @__env.GetStaticFieldIDNoThrow(global::android.text.format.DateUtils.staticClass, "sameYearTable", "[I");
			global::android.text.format.DateUtils._sameMonthTable13179 = @__env.GetStaticFieldIDNoThrow(global::android.text.format.DateUtils.staticClass, "sameMonthTable", "[I");
		}
		internal static void InitJNI()
		{
		}
	}
}
