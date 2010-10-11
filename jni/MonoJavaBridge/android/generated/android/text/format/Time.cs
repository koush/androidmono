namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Time()
		{
			InitJNI();
		}
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7988;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._toString7988)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._toString7988)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear7989;
		public virtual void clear(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._clear7989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._clear7989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _format7990;
		public virtual global::java.lang.String format(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format7990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format7990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compare7991;
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._compare7991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set7992;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set7992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set7993;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set7993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set7994;
		public virtual void set(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set7994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set7995;
		public virtual void set(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set7995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set7995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalize7996;
		public virtual long normalize(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._normalize7996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._normalize7996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after7997;
		public virtual bool after(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._after7997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._after7997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before7998;
		public virtual bool before(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._before7998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._before7998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse7999;
		public virtual bool parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._parse7999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse7999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMillis8000;
		public virtual long toMillis(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._toMillis8000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._toMillis8000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum8001;
		public virtual int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.format.Time._getActualMaximum8001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._getActualMaximum8001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _switchTimezone8002;
		public virtual void switchTimezone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._switchTimezone8002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._switchTimezone8002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse33398003;
		public virtual bool parse3339(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._parse33398003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse33398003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTimezone8004;
		public static global::java.lang.String getCurrentTimezone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getCurrentTimezone8004)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setToNow8005;
		public virtual void setToNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._setToNow8005);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._setToNow8005);
		}
		internal static global::MonoJavaBridge.MethodId _format24458006;
		public virtual global::java.lang.String format2445() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format24458006)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format24458006)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getWeekNumber8007;
		public virtual int getWeekNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.format.Time._getWeekNumber8007);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._getWeekNumber8007);
		}
		internal static global::MonoJavaBridge.MethodId _format33398008;
		public virtual global::java.lang.String format3339(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format33398008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format33398008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEpoch8009;
		public static bool isEpoch(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, global::android.text.format.Time._isEpoch8009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getJulianDay8010;
		public static int getJulianDay(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getJulianDay8010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setJulianDay8011;
		public virtual long setJulianDay(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._setJulianDay8011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._setJulianDay8011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Time8012;
		public Time(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time8013;
		public Time()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8013);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time8014;
		public Time(android.text.format.Time arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _allDay8015;
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
		internal static global::MonoJavaBridge.FieldId _second8016;
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
		internal static global::MonoJavaBridge.FieldId _minute8017;
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
		internal static global::MonoJavaBridge.FieldId _hour8018;
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
		internal static global::MonoJavaBridge.FieldId _monthDay8019;
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
		internal static global::MonoJavaBridge.FieldId _month8020;
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
		internal static global::MonoJavaBridge.FieldId _year8021;
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
		internal static global::MonoJavaBridge.FieldId _weekDay8022;
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
		internal static global::MonoJavaBridge.FieldId _yearDay8023;
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
		internal static global::MonoJavaBridge.FieldId _isDst8024;
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
		internal static global::MonoJavaBridge.FieldId _gmtoff8025;
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
		internal static global::MonoJavaBridge.FieldId _timezone8026;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/Time"));
			global::android.text.format.Time._toString7988 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.format.Time._clear7989 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.text.format.Time._format7990 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.format.Time._compare7991 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I");
			global::android.text.format.Time._set7992 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(IIIIII)V");
			global::android.text.format.Time._set7993 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(III)V");
			global::android.text.format.Time._set7994 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V");
			global::android.text.format.Time._set7995 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(J)V");
			global::android.text.format.Time._normalize7996 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "normalize", "(Z)J");
			global::android.text.format.Time._after7997 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._before7998 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._parse7999 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._toMillis8000 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "toMillis", "(Z)J");
			global::android.text.format.Time._getActualMaximum8001 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I");
			global::android.text.format.Time._switchTimezone8002 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V");
			global::android.text.format.Time._parse33398003 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._getCurrentTimezone8004 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;");
			global::android.text.format.Time._setToNow8005 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "setToNow", "()V");
			global::android.text.format.Time._format24458006 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;");
			global::android.text.format.Time._getWeekNumber8007 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "getWeekNumber", "()I");
			global::android.text.format.Time._format33398008 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;");
			global::android.text.format.Time._isEpoch8009 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._getJulianDay8010 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I");
			global::android.text.format.Time._setJulianDay8011 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "setJulianDay", "(I)J");
			global::android.text.format.Time._Time8012 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.format.Time._Time8013 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "()V");
			global::android.text.format.Time._Time8014 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V");
		}
	}
}
