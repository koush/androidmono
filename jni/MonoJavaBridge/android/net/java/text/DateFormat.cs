namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DateFormat : java.text.Format
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DateFormat() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.text.DateFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DateFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11658; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return @__env.CallIntMethod(this, _hashCode11658); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.text.DateFormat.staticClass, _hashCode11658); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11659; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return @__env.CallBooleanMethod(this, _equals11659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.DateFormat.staticClass, _equals11659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11660; 
		public sealed override java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallObjectMethodPtr(this, _format11660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.StringBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _format11660, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _format11661; 
		public abstract java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _format11662; 
		public virtual java.lang.String format(java.util.Date arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _format11662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _format11662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11663; 
		public static java.text.DateFormat getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getInstance11663)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse11664; 
		public virtual java.util.Date parse(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallObjectMethodPtr(this, _parse11664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Date>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _parse11664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parse11665; 
		public abstract java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales11666; 
		public static java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getAvailableLocales11666)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeZone11667; 
		public virtual java.util.TimeZone getTimeZone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallObjectMethodPtr(this, _getTimeZone11667)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.TimeZone>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _getTimeZone11667)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTimeZone11668; 
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				@__env.CallVoidMethod(this, _setTimeZone11668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.DateFormat.staticClass, _setTimeZone11668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance11669; 
		public static java.text.DateFormat getDateTimeInstance(int arg0, int arg1, java.util.Locale arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateTimeInstance11669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance11670; 
		public static java.text.DateFormat getDateTimeInstance(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateTimeInstance11670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateTimeInstance11671; 
		public static java.text.DateFormat getDateTimeInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateTimeInstance11671)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLenient11672; 
		public virtual void setLenient(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				@__env.CallVoidMethod(this, _setLenient11672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.DateFormat.staticClass, _setLenient11672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLenient11673; 
		public virtual bool isLenient() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return @__env.CallBooleanMethod(this, _isLenient11673); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.text.DateFormat.staticClass, _isLenient11673); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _parseObject11674; 
		public override java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _parseObject11674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _parseObject11674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance11675; 
		public static java.text.DateFormat getTimeInstance(int arg0, java.util.Locale arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getTimeInstance11675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance11676; 
		public static java.text.DateFormat getTimeInstance(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getTimeInstance11676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTimeInstance11677; 
		public static java.text.DateFormat getTimeInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getTimeInstance11677)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance11678; 
		public static java.text.DateFormat getDateInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateInstance11678)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance11679; 
		public static java.text.DateFormat getDateInstance(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateInstance11679, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDateInstance11680; 
		public static java.text.DateFormat getDateInstance(int arg0, java.util.Locale arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.DateFormat>(@__env, @__env.CallStaticObjectMethodPtr(java.text.DateFormat.staticClass, _getDateInstance11680, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCalendar11681; 
		public virtual void setCalendar(java.util.Calendar arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				@__env.CallVoidMethod(this, _setCalendar11681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.DateFormat.staticClass, _setCalendar11681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCalendar11682; 
		public virtual java.util.Calendar getCalendar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallObjectMethodPtr(this, _getCalendar11682)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Calendar>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _getCalendar11682)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNumberFormat11683; 
		public virtual void setNumberFormat(java.text.NumberFormat arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				@__env.CallVoidMethod(this, _setNumberFormat11683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.text.DateFormat.staticClass, _setNumberFormat11683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberFormat11684; 
		public virtual java.text.NumberFormat getNumberFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.text.DateFormat)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallObjectMethodPtr(this, _getNumberFormat11684)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.text.NumberFormat>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.text.DateFormat.staticClass, _getNumberFormat11684)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DateFormat11685; 
		protected DateFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.text.DateFormat.staticClass, _DateFormat11685, this); 
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
			global::java.text.DateFormat._hashCode11658 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "hashCode", "()I"); 
			global::java.text.DateFormat._equals11659 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.text.DateFormat._format11660 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.DateFormat._format11661 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"); 
			global::java.text.DateFormat._format11662 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;)Ljava/lang/String;"); 
			global::java.text.DateFormat._getInstance11663 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getInstance", "()Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._parse11664 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;"); 
			global::java.text.DateFormat._parse11665 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;"); 
			global::java.text.DateFormat._getAvailableLocales11666 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.text.DateFormat._getTimeZone11667 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getTimeZone", "()Ljava/util/TimeZone;"); 
			global::java.text.DateFormat._setTimeZone11668 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V"); 
			global::java.text.DateFormat._getDateTimeInstance11669 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getDateTimeInstance11670 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(II)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getDateTimeInstance11671 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "()Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._setLenient11672 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setLenient", "(Z)V"); 
			global::java.text.DateFormat._isLenient11673 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "isLenient", "()Z"); 
			global::java.text.DateFormat._parseObject11674 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"); 
			global::java.text.DateFormat._getTimeInstance11675 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getTimeInstance11676 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "(I)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getTimeInstance11677 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getTimeInstance", "()Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getDateInstance11678 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "()Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getDateInstance11679 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "(I)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._getDateInstance11680 = @__env.GetStaticMethodID(global::java.text.DateFormat.staticClass, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;"); 
			global::java.text.DateFormat._setCalendar11681 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setCalendar", "(Ljava/util/Calendar;)V"); 
			global::java.text.DateFormat._getCalendar11682 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getCalendar", "()Ljava/util/Calendar;"); 
			global::java.text.DateFormat._setNumberFormat11683 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "setNumberFormat", "(Ljava/text/NumberFormat;)V"); 
			global::java.text.DateFormat._getNumberFormat11684 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "getNumberFormat", "()Ljava/text/NumberFormat;"); 
			global::java.text.DateFormat._DateFormat11685 = @__env.GetMethodID(global::java.text.DateFormat.staticClass, "<init>", "()V"); 
		} 
	} 
} 
