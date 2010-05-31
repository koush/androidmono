namespace android.text.format
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Time : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Time()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.format.Time), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.format.Time(@__env);
			}
		}
		protected Time(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear7070;
		public virtual void clear(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._clear7070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._clear7070, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7071;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.format.Time._toString7071));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._toString7071));
		}
		internal static global::net.sf.jni4net.jni.MethodId _format7072;
		public virtual global::java.lang.String format(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.format.Time._format7072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._format7072, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compare7073;
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._compare7073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set7074;
		public virtual void set(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._set7074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set7075;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._set7075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set7076;
		public virtual void set(android.text.format.Time arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._set7076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7076, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set7077;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._set7077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _normalize7078;
		public virtual long normalize(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.text.format.Time._normalize7078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._normalize7078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _after7079;
		public virtual bool after(android.text.format.Time arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.format.Time._after7079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._after7079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _before7080;
		public virtual bool before(android.text.format.Time arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.format.Time._before7080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._before7080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse7081;
		public virtual bool parse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.format.Time._parse7081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse7081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toMillis7082;
		public virtual long toMillis(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.text.format.Time._toMillis7082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._toMillis7082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActualMaximum7083;
		public virtual int getActualMaximum(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.format.Time._getActualMaximum7083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._getActualMaximum7083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _switchTimezone7084;
		public virtual void switchTimezone(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._switchTimezone7084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._switchTimezone7084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse33397085;
		public virtual bool parse3339(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.format.Time._parse33397085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse33397085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentTimezone7086;
		public static global::java.lang.String getCurrentTimezone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.text.format.Time.staticClass, global::android.text.format.Time._getCurrentTimezone7086));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setToNow7087;
		public virtual void setToNow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.format.Time._setToNow7087);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._setToNow7087);
		}
		internal static global::net.sf.jni4net.jni.MethodId _format24457088;
		public virtual global::java.lang.String format2445() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.format.Time._format24457088));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._format24457088));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWeekNumber7089;
		public virtual int getWeekNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.format.Time._getWeekNumber7089);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._getWeekNumber7089);
		}
		internal static global::net.sf.jni4net.jni.MethodId _format33397090;
		public virtual global::java.lang.String format3339(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.format.Time._format33397090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._format33397090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEpoch7091;
		public static bool isEpoch(android.text.format.Time arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, global::android.text.format.Time._isEpoch7091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getJulianDay7092;
		public static int getJulianDay(long arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getJulianDay7092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setJulianDay7093;
		public virtual long setJulianDay(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.text.format.Time._setJulianDay7093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.text.format.Time.staticClass, global::android.text.format.Time._setJulianDay7093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Time7094;
		public Time(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time7094, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Time7095;
		public Time()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time7095, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Time7096;
		public Time(android.text.format.Time arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time7096, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static global::java.lang.String TIMEZONE_UTC
		{
			get
			{
				return "UTC";
			}
		}
		public static int EPOCH_JULIAN_DAY
		{
			get
			{
				return 2440588;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _allDay7097;
		public bool allDay
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _second7098;
		public int second
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _minute7099;
		public int minute
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _hour7100;
		public int hour
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _monthDay7101;
		public int monthDay
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _month7102;
		public int month
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _year7103;
		public int year
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _weekDay7104;
		public int weekDay
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _yearDay7105;
		public int yearDay
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _isDst7106;
		public int isDst
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _gmtoff7107;
		public long gmtoff
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _timezone7108;
		public global::java.lang.String timezone
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		public static int SECOND
		{
			get
			{
				return 1;
			}
		}
		public static int MINUTE
		{
			get
			{
				return 2;
			}
		}
		public static int HOUR
		{
			get
			{
				return 3;
			}
		}
		public static int MONTH_DAY
		{
			get
			{
				return 4;
			}
		}
		public static int MONTH
		{
			get
			{
				return 5;
			}
		}
		public static int YEAR
		{
			get
			{
				return 6;
			}
		}
		public static int WEEK_DAY
		{
			get
			{
				return 7;
			}
		}
		public static int YEAR_DAY
		{
			get
			{
				return 8;
			}
		}
		public static int WEEK_NUM
		{
			get
			{
				return 9;
			}
		}
		public static int SUNDAY
		{
			get
			{
				return 0;
			}
		}
		public static int MONDAY
		{
			get
			{
				return 1;
			}
		}
		public static int TUESDAY
		{
			get
			{
				return 2;
			}
		}
		public static int WEDNESDAY
		{
			get
			{
				return 3;
			}
		}
		public static int THURSDAY
		{
			get
			{
				return 4;
			}
		}
		public static int FRIDAY
		{
			get
			{
				return 5;
			}
		}
		public static int SATURDAY
		{
			get
			{
				return 6;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.format.Time.staticClass = @__class;
			global::android.text.format.Time._clear7070 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.text.format.Time._toString7071 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.format.Time._format7072 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.format.Time._compare7073 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I");
			global::android.text.format.Time._set7074 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(J)V");
			global::android.text.format.Time._set7075 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(IIIIII)V");
			global::android.text.format.Time._set7076 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V");
			global::android.text.format.Time._set7077 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "set", "(III)V");
			global::android.text.format.Time._normalize7078 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "normalize", "(Z)J");
			global::android.text.format.Time._after7079 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._before7080 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._parse7081 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._toMillis7082 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "toMillis", "(Z)J");
			global::android.text.format.Time._getActualMaximum7083 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I");
			global::android.text.format.Time._switchTimezone7084 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V");
			global::android.text.format.Time._parse33397085 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._getCurrentTimezone7086 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;");
			global::android.text.format.Time._setToNow7087 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "setToNow", "()V");
			global::android.text.format.Time._format24457088 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;");
			global::android.text.format.Time._getWeekNumber7089 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "getWeekNumber", "()I");
			global::android.text.format.Time._format33397090 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;");
			global::android.text.format.Time._isEpoch7091 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._getJulianDay7092 = @__env.GetStaticMethodID(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I");
			global::android.text.format.Time._setJulianDay7093 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "setJulianDay", "(I)J");
			global::android.text.format.Time._Time7094 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.format.Time._Time7095 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "()V");
			global::android.text.format.Time._Time7096 = @__env.GetMethodID(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V");
		}
	}
}
