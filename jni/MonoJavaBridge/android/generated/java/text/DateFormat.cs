namespace java.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class DateFormat : java.text.Format
	{
		internal new static global::java.lang.Class staticClass;
		static DateFormat()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.text.DateFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected DateFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13394;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.DateFormat._equals13394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._equals13394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13395;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.text.DateFormat._hashCode13395);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._hashCode13395);
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13396;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._format13396, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format13396, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format13397;
		public abstract global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::net.sf.jni4net.jni.MethodId _format13398;
		public virtual global::java.lang.String format(java.util.Date arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._format13398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format13398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13399;
		public static global::java.text.DateFormat getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getInstance13399));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13400;
		public virtual global::java.util.Date parse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._parse13400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parse13400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse13401;
		public abstract global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales13402;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getAvailableLocales13402));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone13403;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._getTimeZone13403));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeZone13403));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone13404;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.DateFormat._setTimeZone13404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setTimeZone13404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance13405;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance13405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance13406;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance13406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance13407;
		public static global::java.text.DateFormat getDateTimeInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance13407));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLenient13408;
		public virtual void setLenient(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.DateFormat._setLenient13408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setLenient13408, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLenient13409;
		public virtual bool isLenient() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.text.DateFormat._isLenient13409);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._isLenient13409);
		}
		internal static global::net.sf.jni4net.jni.MethodId _parseObject13410;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._parseObject13410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parseObject13410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance13411;
		public static global::java.text.DateFormat getTimeInstance(int arg0, java.util.Locale arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance13411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance13412;
		public static global::java.text.DateFormat getTimeInstance(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance13412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance13413;
		public static global::java.text.DateFormat getTimeInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance13413));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance13414;
		public static global::java.text.DateFormat getDateInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance13414));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance13415;
		public static global::java.text.DateFormat getDateInstance(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance13415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance13416;
		public static global::java.text.DateFormat getDateInstance(int arg0, java.util.Locale arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance13416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCalendar13417;
		public virtual void setCalendar(java.util.Calendar arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.DateFormat._setCalendar13417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setCalendar13417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCalendar13418;
		public virtual global::java.util.Calendar getCalendar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._getCalendar13418));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getCalendar13418));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNumberFormat13419;
		public virtual void setNumberFormat(java.text.NumberFormat arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.text.DateFormat._setNumberFormat13419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setNumberFormat13419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberFormat13420;
		public virtual global::java.text.NumberFormat getNumberFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallObjectMethodPtr(this, global::java.text.DateFormat._getNumberFormat13420));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getNumberFormat13420));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DateFormat13421;
		protected DateFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.text.DateFormat.staticClass, global::java.text.DateFormat._DateFormat13421, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.text.DateFormat.staticClass = @__class;
			global::java.text.DateFormat._equals13394 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormat._hashCode13395 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "hashCode", "()I");
			global::java.text.DateFormat._format13396 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format13397 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format13398 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			global::java.text.DateFormat._getInstance13399 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._parse13400 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.text.DateFormat._parse13401 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.DateFormat._getAvailableLocales13402 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormat._getTimeZone13403 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.text.DateFormat._setTimeZone13404 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.text.DateFormat._getDateTimeInstance13405 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance13406 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(II)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance13407 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._setLenient13408 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setLenient", "(Z)V");
			global::java.text.DateFormat._isLenient13409 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "isLenient", "()Z");
			global::java.text.DateFormat._parseObject13410 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.DateFormat._getTimeInstance13411 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance13412 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance13413 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance13414 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance13415 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance13416 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._setCalendar13417 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setCalendar", "(Ljava/util/Calendar;)V");
			global::java.text.DateFormat._getCalendar13418 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getCalendar", "()Ljava/util/Calendar;");
			global::java.text.DateFormat._setNumberFormat13419 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setNumberFormat", "(Ljava/text/NumberFormat;)V");
			global::java.text.DateFormat._getNumberFormat13420 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getNumberFormat", "()Ljava/text/NumberFormat;");
			global::java.text.DateFormat._DateFormat13421 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "<init>", "()V");
		}
	}
}
