namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.DateFormat_))]
	public abstract partial class DateFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.DateFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DateFormat.staticClass, "hashCode", "()I", ref global::java.text.DateFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.DateFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.DateFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.DateFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String format(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;)Ljava/lang/String;", ref global::java.text.DateFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.text.DateFormat getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m6.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m6 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getInstance", "()Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m6)) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Date parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;", ref global::java.text.DateFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1);
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m9.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m9 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m9)) as java.util.Locale[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.util.TimeZone getTimeZone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "getTimeZone", "()Ljava/util/TimeZone;", ref global::java.text.DateFormat._m10) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormat.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V", ref global::java.text.DateFormat._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1, java.util.Locale arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m12.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m12 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m13.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m13 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(II)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.text.DateFormat getDateTimeInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m14.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m14 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "()Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m14)) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setLenient(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormat.staticClass, "setLenient", "(Z)V", ref global::java.text.DateFormat._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool isLenient()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DateFormat.staticClass, "isLenient", "()Z", ref global::java.text.DateFormat._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", ref global::java.text.DateFormat._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.text.DateFormat getTimeInstance(int arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m18.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m18 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.text.DateFormat getTimeInstance(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m19.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m19 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(I)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.text.DateFormat getTimeInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m20.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m20 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "()Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m20)) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.text.DateFormat getDateInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m21.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m21 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "()Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m21)) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static global::java.text.DateFormat getDateInstance(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m22.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m22 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(I)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::java.text.DateFormat getDateInstance(int arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m23.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m23 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setCalendar(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormat.staticClass, "setCalendar", "(Ljava/util/Calendar;)V", ref global::java.text.DateFormat._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.util.Calendar getCalendar()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "getCalendar", "()Ljava/util/Calendar;", ref global::java.text.DateFormat._m25) as java.util.Calendar;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setNumberFormat(java.text.NumberFormat arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DateFormat.staticClass, "setNumberFormat", "(Ljava/text/NumberFormat;)V", ref global::java.text.DateFormat._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.text.NumberFormat getNumberFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.staticClass, "getNumberFormat", "()Ljava/text/NumberFormat;", ref global::java.text.DateFormat._m27) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		protected DateFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DateFormat._m28.native == global::System.IntPtr.Zero)
				global::java.text.DateFormat._m28 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.staticClass, global::java.text.DateFormat._m28);
			Init(@__env, handle);
		}
		public static int ERA_FIELD
		{
			get
			{
				return 0;
			}
		}
		public static int YEAR_FIELD
		{
			get
			{
				return 1;
			}
		}
		public static int MONTH_FIELD
		{
			get
			{
				return 2;
			}
		}
		public static int DATE_FIELD
		{
			get
			{
				return 3;
			}
		}
		public static int HOUR_OF_DAY1_FIELD
		{
			get
			{
				return 4;
			}
		}
		public static int HOUR_OF_DAY0_FIELD
		{
			get
			{
				return 5;
			}
		}
		public static int MINUTE_FIELD
		{
			get
			{
				return 6;
			}
		}
		public static int SECOND_FIELD
		{
			get
			{
				return 7;
			}
		}
		public static int MILLISECOND_FIELD
		{
			get
			{
				return 8;
			}
		}
		public static int DAY_OF_WEEK_FIELD
		{
			get
			{
				return 9;
			}
		}
		public static int DAY_OF_YEAR_FIELD
		{
			get
			{
				return 10;
			}
		}
		public static int DAY_OF_WEEK_IN_MONTH_FIELD
		{
			get
			{
				return 11;
			}
		}
		public static int WEEK_OF_YEAR_FIELD
		{
			get
			{
				return 12;
			}
		}
		public static int WEEK_OF_MONTH_FIELD
		{
			get
			{
				return 13;
			}
		}
		public static int AM_PM_FIELD
		{
			get
			{
				return 14;
			}
		}
		public static int HOUR1_FIELD
		{
			get
			{
				return 15;
			}
		}
		public static int HOUR0_FIELD
		{
			get
			{
				return 16;
			}
		}
		public static int TIMEZONE_FIELD
		{
			get
			{
				return 17;
			}
		}
		public static int FULL
		{
			get
			{
				return 0;
			}
		}
		public static int LONG
		{
			get
			{
				return 1;
			}
		}
		public static int MEDIUM
		{
			get
			{
				return 2;
			}
		}
		public static int SHORT
		{
			get
			{
				return 3;
			}
		}
		public static int DEFAULT
		{
			get
			{
				return 2;
			}
		}
		static DateFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.DateFormat))]
	internal sealed partial class DateFormat_ : java.text.DateFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DateFormat_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.DateFormat_.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.DateFormat_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", ref global::java.text.DateFormat_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Date;
		}
		static DateFormat_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat"));
		}
		internal static void InitJNI()
		{
		}
	}
}
