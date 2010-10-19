namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateFormat()
		{
			InitJNI();
		}
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format8501;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format8501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _format8502;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format8502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _format8503;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format8503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _is24HourFormat8504;
		public static bool is24HourFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._is24HourFormat8504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeFormat8505;
		public static global::java.text.DateFormat getTimeFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getTimeFormat8505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormat8506;
		public static global::java.text.DateFormat getDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormat8506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getLongDateFormat8507;
		public static global::java.text.DateFormat getLongDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getLongDateFormat8507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getMediumDateFormat8508;
		public static global::java.text.DateFormat getMediumDateFormat(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getMediumDateFormat8508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateFormatOrder8509;
		public static char[] getDateFormatOrder(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormatOrder8509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _DateFormat8510;
		public DateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._DateFormat8510);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.DateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/DateFormat"));
			global::android.text.format.DateFormat._format8501 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format8502 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format8503 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._is24HourFormat8504 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "is24HourFormat", "(Landroid/content/Context;)Z");
			global::android.text.format.DateFormat._getTimeFormat8505 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormat8506 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getLongDateFormat8507 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getMediumDateFormat8508 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormatOrder8509 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormatOrder", "(Landroid/content/Context;)[C");
			global::android.text.format.DateFormat._DateFormat8510 = @__env.GetMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "<init>", "()V");
		}
	}
}
