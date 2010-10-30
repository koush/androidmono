namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String getDayOfWeekString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m0.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getDayOfWeekString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String getAMPMString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m1.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getAMPMString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String getMonthString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m2.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getMonthString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m3.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJ)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0, long arg1, long arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m4.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(JJJI)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m5.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m6.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;JZ)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.CharSequence getRelativeTimeSpanString(android.content.Context arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m7.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m7 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeTimeSpanString", "(Landroid/content/Context;J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.CharSequence getRelativeDateTimeString(android.content.Context arg0, long arg1, long arg2, long arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m8.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m8 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "getRelativeDateTimeString", "(Landroid/content/Context;JJJI)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String formatElapsedTime(java.lang.StringBuilder arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m9.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(Ljava/lang/StringBuilder;J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.String formatElapsedTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m10.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatElapsedTime", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.CharSequence formatSameDayTime(long arg0, long arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m11.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatSameDayTime", "(JJII)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isToday(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m12.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m12 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "isToday", "(J)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.util.Formatter formatDateRange(android.content.Context arg0, java.util.Formatter arg1, long arg2, long arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m13.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m13 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;Ljava/util/Formatter;JJI)Ljava/util/Formatter;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Formatter>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.Formatter;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.String formatDateRange(android.content.Context arg0, long arg1, long arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m14.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m14 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateRange", "(Landroid/content/Context;JJI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.String formatDateTime(android.content.Context arg0, long arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m15.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m15 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "formatDateTime", "(Landroid/content/Context;JI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public DateUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateUtils._m16.native == global::System.IntPtr.Zero)
				global::android.text.format.DateUtils._m16 = @__env.GetMethodIDNoThrow(global::android.text.format.DateUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateUtils.staticClass, global::android.text.format.DateUtils._m16);
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
		internal static global::MonoJavaBridge.FieldId _sameYearTable5308;
		public static int[] sameYearTable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.text.format.DateUtils.staticClass, _sameYearTable5308)) as int[];
			}
		}
		internal static global::MonoJavaBridge.FieldId _sameMonthTable5309;
		public static int[] sameMonthTable
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.text.format.DateUtils.staticClass, _sameMonthTable5309)) as int[];
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
			global::android.text.format.DateUtils._sameYearTable5308 = @__env.GetStaticFieldIDNoThrow(global::android.text.format.DateUtils.staticClass, "sameYearTable", "[I");
			global::android.text.format.DateUtils._sameMonthTable5309 = @__env.GetStaticFieldIDNoThrow(global::android.text.format.DateUtils.staticClass, "sameMonthTable", "[I");
		}
		internal static void InitJNI()
		{
		}
	}
}
