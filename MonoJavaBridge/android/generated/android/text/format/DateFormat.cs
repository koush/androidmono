namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format13102;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._format13102.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._format13102 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format13102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, java.util.Calendar arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _format13103;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._format13103.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._format13103 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format13103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, long arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _format13104;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._format13104.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._format13104 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format13104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, java.util.Date arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _is24HourFormat13105;
		public static bool is24HourFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._is24HourFormat13105.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._is24HourFormat13105 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "is24HourFormat", "(Landroid/content/Context;)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._is24HourFormat13105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeFormat13106;
		public static global::java.text.DateFormat getTimeFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._getTimeFormat13106.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._getTimeFormat13106 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getTimeFormat13106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormat13107;
		public static global::java.text.DateFormat getDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._getDateFormat13107.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._getDateFormat13107 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormat13107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getLongDateFormat13108;
		public static global::java.text.DateFormat getLongDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._getLongDateFormat13108.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._getLongDateFormat13108 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getLongDateFormat13108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getMediumDateFormat13109;
		public static global::java.text.DateFormat getMediumDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._getMediumDateFormat13109.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._getMediumDateFormat13109 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getMediumDateFormat13109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormatOrder13110;
		public static char[] getDateFormatOrder(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._getDateFormatOrder13110.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._getDateFormatOrder13110 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormatOrder", "(Landroid/content/Context;)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormatOrder13110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateFormat13111;
		public DateFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._DateFormat13111.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._DateFormat13111 = @__env.GetMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._DateFormat13111);
			Init(@__env, handle);
		}
		public static char QUOTE
		{
			get
			{
				return '\'';
			}
		}
		public static char AM_PM
		{
			get
			{
				return 'a';
			}
		}
		public static char CAPITAL_AM_PM
		{
			get
			{
				return 'A';
			}
		}
		public static char DATE
		{
			get
			{
				return 'd';
			}
		}
		public static char DAY
		{
			get
			{
				return 'E';
			}
		}
		public static char HOUR
		{
			get
			{
				return 'h';
			}
		}
		public static char HOUR_OF_DAY
		{
			get
			{
				return 'k';
			}
		}
		public static char MINUTE
		{
			get
			{
				return 'm';
			}
		}
		public static char MONTH
		{
			get
			{
				return 'M';
			}
		}
		public static char SECONDS
		{
			get
			{
				return 's';
			}
		}
		public static char TIME_ZONE
		{
			get
			{
				return 'z';
			}
		}
		public static char YEAR
		{
			get
			{
				return 'y';
			}
		}
		static DateFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.DateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/DateFormat"));
		}
		internal static void InitJNI()
		{
		}
	}
}
