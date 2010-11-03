namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.DateFormat_))]
	public abstract partial class DateFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class Field : java.text.Format.Field
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			protected override global::java.lang.Object readResolve()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DateFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.text.DateFormat.Field._m0) as java.lang.Object;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.text.DateFormat.Field ofCalendarField(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.text.DateFormat.Field._m1.native == global::System.IntPtr.Zero)
					global::java.text.DateFormat.Field._m1 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "ofCalendarField", "(I)Ljava/text/DateFormat$Field;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat.Field;
			}
			public new int CalendarField
			{
				get
				{
					return getCalendarField();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual int getCalendarField()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DateFormat.Field.staticClass, "getCalendarField", "()I", ref global::java.text.DateFormat.Field._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			protected Field(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.text.DateFormat.Field._m3.native == global::System.IntPtr.Zero)
					global::java.text.DateFormat.Field._m3 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "<init>", "(Ljava/lang/String;I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ERA6694;
			public static global::java.text.DateFormat.Field ERA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _ERA6694)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YEAR6695;
			public static global::java.text.DateFormat.Field YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _YEAR6695)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONTH6696;
			public static global::java.text.DateFormat.Field MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MONTH6696)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_MONTH6697;
			public static global::java.text.DateFormat.Field DAY_OF_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_MONTH6697)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY16698;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR_OF_DAY16698)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY06699;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR_OF_DAY06699)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MINUTE6700;
			public static global::java.text.DateFormat.Field MINUTE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MINUTE6700)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SECOND6701;
			public static global::java.text.DateFormat.Field SECOND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _SECOND6701)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MILLISECOND6702;
			public static global::java.text.DateFormat.Field MILLISECOND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MILLISECOND6702)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK6703;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_WEEK6703)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_YEAR6704;
			public static global::java.text.DateFormat.Field DAY_OF_YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_YEAR6704)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK_IN_MONTH6705;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK_IN_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_WEEK_IN_MONTH6705)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_YEAR6706;
			public static global::java.text.DateFormat.Field WEEK_OF_YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _WEEK_OF_YEAR6706)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_MONTH6707;
			public static global::java.text.DateFormat.Field WEEK_OF_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _WEEK_OF_MONTH6707)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _AM_PM6708;
			public static global::java.text.DateFormat.Field AM_PM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _AM_PM6708)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR16709;
			public static global::java.text.DateFormat.Field HOUR1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR16709)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR06710;
			public static global::java.text.DateFormat.Field HOUR0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR06710)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIME_ZONE6711;
			public static global::java.text.DateFormat.Field TIME_ZONE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _TIME_ZONE6711)) as java.text.DateFormat.Field;
				}
			}
			static Field()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.DateFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat$Field"));
				global::java.text.DateFormat.Field._ERA6694 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "ERA", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._YEAR6695 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MONTH6696 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_MONTH6697 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR_OF_DAY16698 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR_OF_DAY1", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR_OF_DAY06699 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR_OF_DAY0", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MINUTE6700 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MINUTE", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._SECOND6701 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "SECOND", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MILLISECOND6702 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MILLISECOND", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_WEEK6703 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_WEEK", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_YEAR6704 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_WEEK_IN_MONTH6705 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_WEEK_IN_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._WEEK_OF_YEAR6706 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "WEEK_OF_YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._WEEK_OF_MONTH6707 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "WEEK_OF_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._AM_PM6708 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "AM_PM", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR16709 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR1", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR06710 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR0", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._TIME_ZONE6711 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "TIME_ZONE", "Ljava/text/DateFormat$Field;");
			}
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
	}
}
