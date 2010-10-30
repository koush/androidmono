namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DateFormat : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Calendar arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m0.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, java.util.Calendar arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m1.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, long arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Date arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m2.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		public static java.lang.CharSequence format(string arg0, java.util.Date arg1)
		{
			return format((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool is24HourFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m3.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "is24HourFormat", "(Landroid/content/Context;)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.text.DateFormat getTimeFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m4.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.text.DateFormat getDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m5.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.text.DateFormat getLongDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m6.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m6 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.text.DateFormat getMediumDateFormat(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m7.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m7 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static char[] getDateFormatOrder(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m8.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m8 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "getDateFormatOrder", "(Landroid/content/Context;)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public DateFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.DateFormat._m9.native == global::System.IntPtr.Zero)
				global::android.text.format.DateFormat._m9 = @__env.GetMethodIDNoThrow(global::android.text.format.DateFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._m9);
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
