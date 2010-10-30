namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.Calendar_))]
	public abstract partial class Calendar : java.lang.Object, java.io.Serializable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Calendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void add(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "get", "(I)I", ref global::java.util.Calendar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Calendar.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Calendar._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Calendar.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Calendar._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "hashCode", "()I", ref global::java.util.Calendar._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Calendar.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Calendar._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.Calendar._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int compareTo(java.util.Calendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "compareTo", "(Ljava/util/Calendar;)I", ref global::java.util.Calendar._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "clear", "()V", ref global::java.util.Calendar._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void clear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "clear", "(I)V", ref global::java.util.Calendar._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.Calendar getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m10.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "()Ljava/util/Calendar;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._m10)) as java.util.Calendar;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m11.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;Ljava/util/Locale;)Ljava/util/Calendar;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Calendar;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.Calendar getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m12.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Calendar;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.util.Calendar getInstance(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m13.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m13 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getInstance", "(Ljava/util/TimeZone;)Ljava/util/Calendar;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Calendar;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isSet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Calendar.staticClass, "isSet", "(I)Z", ref global::java.util.Calendar._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "set", "(IIIIII)V", ref global::java.util.Calendar._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "set", "(II)V", ref global::java.util.Calendar._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void set(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "set", "(III)V", ref global::java.util.Calendar._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void set(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "set", "(IIIII)V", ref global::java.util.Calendar._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool after(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Calendar.staticClass, "after", "(Ljava/lang/Object;)Z", ref global::java.util.Calendar._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool before(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Calendar.staticClass, "before", "(Ljava/lang/Object;)Z", ref global::java.util.Calendar._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected virtual void complete()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "complete", "()V", ref global::java.util.Calendar._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m22.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m22 = @__env.GetStaticMethodIDNoThrow(global::java.util.Calendar.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Calendar.staticClass, global::java.util.Calendar._m22)) as java.util.Locale[];
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.lang.String getDisplayName(int arg0, int arg1, java.util.Locale arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Calendar.staticClass, "getDisplayName", "(IILjava/util/Locale;)Ljava/lang/String;", ref global::java.util.Calendar._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setTime(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setTime", "(Ljava/util/Date;)V", ref global::java.util.Calendar._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.util.Date getTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Calendar.staticClass, "getTime", "()Ljava/util/Date;", ref global::java.util.Calendar._m25) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.util.TimeZone getTimeZone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Calendar.staticClass, "getTimeZone", "()Ljava/util/TimeZone;", ref global::java.util.Calendar._m26) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setTimeZone(java.util.TimeZone arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V", ref global::java.util.Calendar._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual long getTimeInMillis()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.Calendar.staticClass, "getTimeInMillis", "()J", ref global::java.util.Calendar._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected abstract void computeTime();
		private static global::MonoJavaBridge.MethodId _m30;
		protected abstract void computeFields();
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setTimeInMillis(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setTimeInMillis", "(J)V", ref global::java.util.Calendar._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		protected virtual int internalGet(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "internalGet", "(I)I", ref global::java.util.Calendar._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::java.util.Map getDisplayNames(int arg0, int arg1, java.util.Locale arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.util.Calendar.staticClass, "getDisplayNames", "(IILjava/util/Locale;)Ljava/util/Map;", ref global::java.util.Calendar._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void roll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "roll", "(II)V", ref global::java.util.Calendar._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract void roll(int arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setLenient(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setLenient", "(Z)V", ref global::java.util.Calendar._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool isLenient()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Calendar.staticClass, "isLenient", "()Z", ref global::java.util.Calendar._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void setFirstDayOfWeek(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setFirstDayOfWeek", "(I)V", ref global::java.util.Calendar._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual int getFirstDayOfWeek()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "getFirstDayOfWeek", "()I", ref global::java.util.Calendar._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void setMinimalDaysInFirstWeek(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar.staticClass, "setMinimalDaysInFirstWeek", "(I)V", ref global::java.util.Calendar._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual int getMinimalDaysInFirstWeek()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "getMinimalDaysInFirstWeek", "()I", ref global::java.util.Calendar._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public abstract int getMinimum(int arg0);
		private static global::MonoJavaBridge.MethodId _m43;
		public abstract int getMaximum(int arg0);
		private static global::MonoJavaBridge.MethodId _m44;
		public abstract int getGreatestMinimum(int arg0);
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract int getLeastMaximum(int arg0);
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual int getActualMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "getActualMinimum", "(I)I", ref global::java.util.Calendar._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual int getActualMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar.staticClass, "getActualMaximum", "(I)I", ref global::java.util.Calendar._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		protected Calendar(java.util.TimeZone arg0, java.util.Locale arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m48.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m48 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "(Ljava/util/TimeZone;Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		protected Calendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Calendar._m49.native == global::System.IntPtr.Zero)
				global::java.util.Calendar._m49 = @__env.GetMethodIDNoThrow(global::java.util.Calendar.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Calendar.staticClass, global::java.util.Calendar._m49);
			Init(@__env, handle);
		}
		public static int ERA
		{
			get
			{
				return 0;
			}
		}
		public static int YEAR
		{
			get
			{
				return 1;
			}
		}
		public static int MONTH
		{
			get
			{
				return 2;
			}
		}
		public static int WEEK_OF_YEAR
		{
			get
			{
				return 3;
			}
		}
		public static int WEEK_OF_MONTH
		{
			get
			{
				return 4;
			}
		}
		public static int DATE
		{
			get
			{
				return 5;
			}
		}
		public static int DAY_OF_MONTH
		{
			get
			{
				return 5;
			}
		}
		public static int DAY_OF_YEAR
		{
			get
			{
				return 6;
			}
		}
		public static int DAY_OF_WEEK
		{
			get
			{
				return 7;
			}
		}
		public static int DAY_OF_WEEK_IN_MONTH
		{
			get
			{
				return 8;
			}
		}
		public static int AM_PM
		{
			get
			{
				return 9;
			}
		}
		public static int HOUR
		{
			get
			{
				return 10;
			}
		}
		public static int HOUR_OF_DAY
		{
			get
			{
				return 11;
			}
		}
		public static int MINUTE
		{
			get
			{
				return 12;
			}
		}
		public static int SECOND
		{
			get
			{
				return 13;
			}
		}
		public static int MILLISECOND
		{
			get
			{
				return 14;
			}
		}
		public static int ZONE_OFFSET
		{
			get
			{
				return 15;
			}
		}
		public static int DST_OFFSET
		{
			get
			{
				return 16;
			}
		}
		public static int FIELD_COUNT
		{
			get
			{
				return 17;
			}
		}
		public static int SUNDAY
		{
			get
			{
				return 1;
			}
		}
		public static int MONDAY
		{
			get
			{
				return 2;
			}
		}
		public static int TUESDAY
		{
			get
			{
				return 3;
			}
		}
		public static int WEDNESDAY
		{
			get
			{
				return 4;
			}
		}
		public static int THURSDAY
		{
			get
			{
				return 5;
			}
		}
		public static int FRIDAY
		{
			get
			{
				return 6;
			}
		}
		public static int SATURDAY
		{
			get
			{
				return 7;
			}
		}
		public static int JANUARY
		{
			get
			{
				return 0;
			}
		}
		public static int FEBRUARY
		{
			get
			{
				return 1;
			}
		}
		public static int MARCH
		{
			get
			{
				return 2;
			}
		}
		public static int APRIL
		{
			get
			{
				return 3;
			}
		}
		public static int MAY
		{
			get
			{
				return 4;
			}
		}
		public static int JUNE
		{
			get
			{
				return 5;
			}
		}
		public static int JULY
		{
			get
			{
				return 6;
			}
		}
		public static int AUGUST
		{
			get
			{
				return 7;
			}
		}
		public static int SEPTEMBER
		{
			get
			{
				return 8;
			}
		}
		public static int OCTOBER
		{
			get
			{
				return 9;
			}
		}
		public static int NOVEMBER
		{
			get
			{
				return 10;
			}
		}
		public static int DECEMBER
		{
			get
			{
				return 11;
			}
		}
		public static int UNDECIMBER
		{
			get
			{
				return 12;
			}
		}
		public static int AM
		{
			get
			{
				return 0;
			}
		}
		public static int PM
		{
			get
			{
				return 1;
			}
		}
		public static int ALL_STYLES
		{
			get
			{
				return 0;
			}
		}
		public static int SHORT
		{
			get
			{
				return 1;
			}
		}
		public static int LONG
		{
			get
			{
				return 2;
			}
		}
		static Calendar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Calendar))]
	internal sealed partial class Calendar_ : java.util.Calendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Calendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar_.staticClass, "add", "(II)V", ref global::java.util.Calendar_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void computeTime()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar_.staticClass, "computeTime", "()V", ref global::java.util.Calendar_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void computeFields()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar_.staticClass, "computeFields", "()V", ref global::java.util.Calendar_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void roll(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Calendar_.staticClass, "roll", "(IZ)V", ref global::java.util.Calendar_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar_.staticClass, "getMinimum", "(I)I", ref global::java.util.Calendar_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar_.staticClass, "getMaximum", "(I)I", ref global::java.util.Calendar_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getGreatestMinimum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar_.staticClass, "getGreatestMinimum", "(I)I", ref global::java.util.Calendar_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getLeastMaximum(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Calendar_.staticClass, "getLeastMaximum", "(I)I", ref global::java.util.Calendar_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Calendar_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Calendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Calendar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
