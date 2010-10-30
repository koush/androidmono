namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.format.Time._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "clear", "(Ljava/lang/String;)V", ref global::android.text.format.Time._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String format(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.text.format.Time._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int compare(android.text.format.Time arg0, android.text.format.Time arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m3.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "compare", "(Landroid/text/format/Time;Landroid/text/format/Time;)I");
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(IIIIII)V", ref global::android.text.format.Time._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void set(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(III)V", ref global::android.text.format.Time._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void set(android.text.format.Time arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(Landroid/text/format/Time;)V", ref global::android.text.format.Time._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void set(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "set", "(J)V", ref global::android.text.format.Time._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long normalize(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "normalize", "(Z)J", ref global::android.text.format.Time._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool after(android.text.format.Time arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "after", "(Landroid/text/format/Time;)Z", ref global::android.text.format.Time._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool before(android.text.format.Time arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "before", "(Landroid/text/format/Time;)Z", ref global::android.text.format.Time._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "parse", "(Ljava/lang/String;)Z", ref global::android.text.format.Time._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual long toMillis(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "toMillis", "(Z)J", ref global::android.text.format.Time._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getActualMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.format.Time.staticClass, "getActualMaximum", "(I)I", ref global::android.text.format.Time._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void switchTimezone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "switchTimezone", "(Ljava/lang/String;)V", ref global::android.text.format.Time._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool parse3339(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.format.Time.staticClass, "parse3339", "(Ljava/lang/String;)Z", ref global::android.text.format.Time._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String CurrentTimezone
		{
			get
			{
				return getCurrentTimezone();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String getCurrentTimezone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m16.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m16 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getCurrentTimezone", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.Time.staticClass, global::android.text.format.Time._m16)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setToNow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.format.Time.staticClass, "setToNow", "()V", ref global::android.text.format.Time._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String format2445()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format2445", "()Ljava/lang/String;", ref global::android.text.format.Time._m18) as java.lang.String;
		}
		public new int WeekNumber
		{
			get
			{
				return getWeekNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getWeekNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.format.Time.staticClass, "getWeekNumber", "()I", ref global::android.text.format.Time._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String format3339(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.format.Time.staticClass, "format3339", "(Z)Ljava/lang/String;", ref global::android.text.format.Time._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static bool isEpoch(android.text.format.Time arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m21.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m21 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "isEpoch", "(Landroid/text/format/Time;)Z");
			return @__env.CallStaticBooleanMethod(android.text.format.Time.staticClass, global::android.text.format.Time._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static int getJulianDay(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m22.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m22 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Time.staticClass, "getJulianDay", "(JJ)I");
			return @__env.CallStaticIntMethod(android.text.format.Time.staticClass, global::android.text.format.Time._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int JulianDay
		{
			set
			{
				setJulianDay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual long setJulianDay(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.format.Time.staticClass, "setJulianDay", "(I)J", ref global::android.text.format.Time._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public Time(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m24.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m24 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public Time() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m25.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m25 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._m25);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public Time(android.text.format.Time arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Time._m26.native == global::System.IntPtr.Zero)
				global::android.text.format.Time._m26 = @__env.GetMethodIDNoThrow(global::android.text.format.Time.staticClass, "<init>", "(Landroid/text/format/Time;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Time.staticClass, global::android.text.format.Time._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _allDay5317;
		public bool allDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _allDay5317);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _second5318;
		public int second
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _second5318);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _minute5319;
		public int minute
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _minute5319);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _hour5320;
		public int hour
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _hour5320);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _monthDay5321;
		public int monthDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _monthDay5321);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _month5322;
		public int month
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _month5322);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _year5323;
		public int year
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _year5323);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _weekDay5324;
		public int weekDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _weekDay5324);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _yearDay5325;
		public int yearDay
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _yearDay5325);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _isDst5326;
		public int isDst
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _isDst5326);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gmtoff5327;
		public long gmtoff
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _gmtoff5327);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _timezone5328;
		public global::java.lang.String timezone
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _timezone5328)) as java.lang.String;
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
		static Time()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/Time"));
			global::android.text.format.Time._allDay5317 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "allDay", "Z");
			global::android.text.format.Time._second5318 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "second", "I");
			global::android.text.format.Time._minute5319 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "minute", "I");
			global::android.text.format.Time._hour5320 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "hour", "I");
			global::android.text.format.Time._monthDay5321 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "monthDay", "I");
			global::android.text.format.Time._month5322 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "month", "I");
			global::android.text.format.Time._year5323 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "year", "I");
			global::android.text.format.Time._weekDay5324 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "weekDay", "I");
			global::android.text.format.Time._yearDay5325 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "yearDay", "I");
			global::android.text.format.Time._isDst5326 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "isDst", "I");
			global::android.text.format.Time._gmtoff5327 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "gmtoff", "J");
			global::android.text.format.Time._timezone5328 = @__env.GetFieldIDNoThrow(global::android.text.format.Time.staticClass, "timezone", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
