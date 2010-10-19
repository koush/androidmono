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
		internal static global::MonoJavaBridge.MethodId _toString8534;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._toString8534)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._toString8534)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear8535;
		public virtual void clear(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._clear8535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._clear8535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _format8536;
		public virtual global::java.lang.String format(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format8536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format8536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compare8537;
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._compare8537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set8538;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set8538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set8538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _set8539;
		public virtual void set(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set8539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set8539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _set8540;
		public virtual void set(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set8540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set8540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set8541;
		public virtual void set(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._set8541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._set8541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalize8542;
		public virtual long normalize(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._normalize8542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._normalize8542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _after8543;
		public virtual bool after(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._after8543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._after8543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _before8544;
		public virtual bool before(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._before8544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._before8544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse8545;
		public virtual bool parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._parse8545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse8545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toMillis8546;
		public virtual long toMillis(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._toMillis8546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._toMillis8546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getActualMaximum8547;
		public virtual int getActualMaximum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.format.Time._getActualMaximum8547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._getActualMaximum8547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _switchTimezone8548;
		public virtual void switchTimezone(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._switchTimezone8548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._switchTimezone8548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse33398549;
		public virtual bool parse3339(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.format.Time._parse33398549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._parse33398549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String CurrentTimezone
		{
			get
			{
				return getCurrentTimezone();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentTimezone8550;
		public static global::java.lang.String getCurrentTimezone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getCurrentTimezone8550)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setToNow8551;
		public virtual void setToNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.format.Time._setToNow8551);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._setToNow8551);
		}
		internal static global::MonoJavaBridge.MethodId _format24458552;
		public virtual global::java.lang.String format2445() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format24458552)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format24458552)) as java.lang.String;
		}
		public new int WeekNumber
		{
			get
			{
				return getWeekNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWeekNumber8553;
		public virtual int getWeekNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.format.Time._getWeekNumber8553);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._getWeekNumber8553);
		}
		internal static global::MonoJavaBridge.MethodId _format33398554;
		public virtual global::java.lang.String format3339(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.format.Time._format33398554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._format33398554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isEpoch8555;
		public static bool isEpoch(android.text.format.Time arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, global::android.text.format.Time._isEpoch8555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getJulianDay8556;
		public static int getJulianDay(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._getJulianDay8556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setJulianDay8557;
		public virtual long setJulianDay(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.format.Time._setJulianDay8557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.format.Time.staticClass, global::android.text.format.Time._setJulianDay8557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Time8558;
		public Time(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time8559;
		public Time()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8559);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time8560;
		public Time(android.text.format.Time arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._Time8560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _allDay8561;
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
		internal static global::MonoJavaBridge.FieldId _second8562;
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
		internal static global::MonoJavaBridge.FieldId _minute8563;
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
		internal static global::MonoJavaBridge.FieldId _hour8564;
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
		internal static global::MonoJavaBridge.FieldId _monthDay8565;
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
		internal static global::MonoJavaBridge.FieldId _month8566;
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
		internal static global::MonoJavaBridge.FieldId _year8567;
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
		internal static global::MonoJavaBridge.FieldId _weekDay8568;
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
		internal static global::MonoJavaBridge.FieldId _yearDay8569;
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
		internal static global::MonoJavaBridge.FieldId _isDst8570;
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
		internal static global::MonoJavaBridge.FieldId _gmtoff8571;
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
		internal static global::MonoJavaBridge.FieldId _timezone8572;
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
			global::android.text.format.Time._toString8534 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.format.Time._clear8535 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V");
			global::android.text.format.Time._format8536 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.format.Time._compare8537 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I");
			global::android.text.format.Time._set8538 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(IIIIII)V");
			global::android.text.format.Time._set8539 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(III)V");
			global::android.text.format.Time._set8540 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V");
			global::android.text.format.Time._set8541 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "set", "(J)V");
			global::android.text.format.Time._normalize8542 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "normalize", "(Z)J");
			global::android.text.format.Time._after8543 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._before8544 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._parse8545 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._toMillis8546 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "toMillis", "(Z)J");
			global::android.text.format.Time._getActualMaximum8547 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I");
			global::android.text.format.Time._switchTimezone8548 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V");
			global::android.text.format.Time._parse33398549 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z");
			global::android.text.format.Time._getCurrentTimezone8550 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;");
			global::android.text.format.Time._setToNow8551 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "setToNow", "()V");
			global::android.text.format.Time._format24458552 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;");
			global::android.text.format.Time._getWeekNumber8553 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "getWeekNumber", "()I");
			global::android.text.format.Time._format33398554 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;");
			global::android.text.format.Time._isEpoch8555 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z");
			global::android.text.format.Time._getJulianDay8556 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I");
			global::android.text.format.Time._setJulianDay8557 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "setJulianDay", "(I)J");
			global::android.text.format.Time._Time8558 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.format.Time._Time8559 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "()V");
			global::android.text.format.Time._Time8560 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V");
		}
	}
}
