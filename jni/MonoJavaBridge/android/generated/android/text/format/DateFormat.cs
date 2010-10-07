namespace android.text.format
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DateFormat : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DateFormat()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.format.DateFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.format.DateFormat(@__env);
			}
		}
		protected DateFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _format7663;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Calendar arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7663, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format7664;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7664, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format7665;
		public static global::java.lang.CharSequence format(java.lang.CharSequence arg0, java.util.Date arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._format7665, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _is24HourFormat7666;
		public static bool is24HourFormat(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._is24HourFormat7666, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeFormat7667;
		public static global::java.text.DateFormat getTimeFormat(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getTimeFormat7667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateFormat7668;
		public static global::java.text.DateFormat getDateFormat(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormat7668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongDateFormat7669;
		public static global::java.text.DateFormat getLongDateFormat(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getLongDateFormat7669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMediumDateFormat7670;
		public static global::java.text.DateFormat getMediumDateFormat(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getMediumDateFormat7670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateFormatOrder7671;
		public static char[] getDateFormatOrder(android.content.Context arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._getDateFormatOrder7671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DateFormat7672;
		public DateFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.format.DateFormat.staticClass, global::android.text.format.DateFormat._DateFormat7672, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.format.DateFormat.staticClass = @__class;
			global::android.text.format.DateFormat._format7663 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Calendar;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format7664 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;J)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._format7665 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "format", "(Ljava/lang/CharSequence;Ljava/util/Date;)Ljava/lang/CharSequence;");
			global::android.text.format.DateFormat._is24HourFormat7666 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "is24HourFormat", "(Landroid/content/Context;)Z");
			global::android.text.format.DateFormat._getTimeFormat7667 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "getTimeFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormat7668 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "getDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getLongDateFormat7669 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "getLongDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getMediumDateFormat7670 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "getMediumDateFormat", "(Landroid/content/Context;)Ljava/text/DateFormat;");
			global::android.text.format.DateFormat._getDateFormatOrder7671 = @__env.GetStaticMethodID(global::android.text.format.DateFormat.staticClass, "getDateFormatOrder", "(Landroid/content/Context;)[C");
			global::android.text.format.DateFormat._DateFormat7672 = @__env.GetMethodID(global::android.text.format.DateFormat.staticClass, "<init>", "()V");
		}
	}
}
