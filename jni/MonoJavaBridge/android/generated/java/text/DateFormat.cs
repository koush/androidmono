namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.DateFormat_))]
	public abstract partial class DateFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateFormat()
		{
			InitJNI();
		}
		protected DateFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class Field : java.text.Format.Field
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Field()
			{
				InitJNI();
			}
			protected Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _readResolve19454;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat.Field._readResolve19454)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._readResolve19454)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _ofCalendarField19455;
			public static global::java.text.DateFormat.Field ofCalendarField(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._ofCalendarField19455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat.Field;
			}
			public new int CalendarField
			{
				get
				{
					return getCalendarField();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCalendarField19456;
			public virtual int getCalendarField() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormat.Field._getCalendarField19456);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._getCalendarField19456);
			}
			internal static global::MonoJavaBridge.MethodId _Field19457;
			protected Field(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._Field19457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ERA19458;
			public static global::java.text.DateFormat.Field ERA
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _YEAR19459;
			public static global::java.text.DateFormat.Field YEAR
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONTH19460;
			public static global::java.text.DateFormat.Field MONTH
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_MONTH19461;
			public static global::java.text.DateFormat.Field DAY_OF_MONTH
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY119462;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY1
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY019463;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY0
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MINUTE19464;
			public static global::java.text.DateFormat.Field MINUTE
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SECOND19465;
			public static global::java.text.DateFormat.Field SECOND
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MILLISECOND19466;
			public static global::java.text.DateFormat.Field MILLISECOND
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK19467;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_YEAR19468;
			public static global::java.text.DateFormat.Field DAY_OF_YEAR
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK_IN_MONTH19469;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK_IN_MONTH
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_YEAR19470;
			public static global::java.text.DateFormat.Field WEEK_OF_YEAR
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_MONTH19471;
			public static global::java.text.DateFormat.Field WEEK_OF_MONTH
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _AM_PM19472;
			public static global::java.text.DateFormat.Field AM_PM
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR119473;
			public static global::java.text.DateFormat.Field HOUR1
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR019474;
			public static global::java.text.DateFormat.Field HOUR0
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIME_ZONE19475;
			public static global::java.text.DateFormat.Field TIME_ZONE
			{
				get
				{
					return default(global::java.text.DateFormat.Field);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.DateFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat$Field"));
				global::java.text.DateFormat.Field._readResolve19454 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.DateFormat.Field._ofCalendarField19455 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "ofCalendarField", "(I)Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._getCalendarField19456 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "getCalendarField", "()I");
				global::java.text.DateFormat.Field._Field19457 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "<init>", "(Ljava/lang/String;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals19476;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormat._equals19476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._equals19476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19477;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormat._hashCode19477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._hashCode19477);
		}
		internal static global::MonoJavaBridge.MethodId _clone19478;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._clone19478)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._clone19478)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19479;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._format19479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format19479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19480;
		public abstract global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format19481;
		public virtual global::java.lang.String format(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._format19481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format19481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19482;
		public static global::java.text.DateFormat getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getInstance19482)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _parse19483;
		public virtual global::java.util.Date parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._parse19483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parse19483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _parse19484;
		public abstract global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales19485;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getAvailableLocales19485)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone19486;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getTimeZone19486)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeZone19486)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone19487;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setTimeZone19487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setTimeZone19487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance19488;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance19488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance19489;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance19489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance19490;
		public static global::java.text.DateFormat getDateTimeInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance19490)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _setLenient19491;
		public virtual void setLenient(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setLenient19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setLenient19491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLenient19492;
		public virtual bool isLenient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormat._isLenient19492);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._isLenient19492);
		}
		internal static global::MonoJavaBridge.MethodId _parseObject19493;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._parseObject19493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parseObject19493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance19494;
		public static global::java.text.DateFormat getTimeInstance(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance19494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance19495;
		public static global::java.text.DateFormat getTimeInstance(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance19495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance19496;
		public static global::java.text.DateFormat getTimeInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance19496)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance19497;
		public static global::java.text.DateFormat getDateInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance19497)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance19498;
		public static global::java.text.DateFormat getDateInstance(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance19498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance19499;
		public static global::java.text.DateFormat getDateInstance(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance19499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _setCalendar19500;
		public virtual void setCalendar(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setCalendar19500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setCalendar19500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCalendar19501;
		public virtual global::java.util.Calendar getCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getCalendar19501)) as java.util.Calendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getCalendar19501)) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _setNumberFormat19502;
		public virtual void setNumberFormat(java.text.NumberFormat arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setNumberFormat19502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setNumberFormat19502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberFormat19503;
		public virtual global::java.text.NumberFormat getNumberFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getNumberFormat19503)) as java.text.NumberFormat;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getNumberFormat19503)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _DateFormat19504;
		protected DateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.staticClass, global::java.text.DateFormat._DateFormat19504);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat"));
			global::java.text.DateFormat._equals19476 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormat._hashCode19477 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "hashCode", "()I");
			global::java.text.DateFormat._clone19478 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DateFormat._format19479 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format19480 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format19481 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			global::java.text.DateFormat._getInstance19482 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._parse19483 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.text.DateFormat._parse19484 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.DateFormat._getAvailableLocales19485 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormat._getTimeZone19486 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.text.DateFormat._setTimeZone19487 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.text.DateFormat._getDateTimeInstance19488 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance19489 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(II)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance19490 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._setLenient19491 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setLenient", "(Z)V");
			global::java.text.DateFormat._isLenient19492 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "isLenient", "()Z");
			global::java.text.DateFormat._parseObject19493 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.DateFormat._getTimeInstance19494 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance19495 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance19496 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance19497 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance19498 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance19499 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._setCalendar19500 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setCalendar", "(Ljava/util/Calendar;)V");
			global::java.text.DateFormat._getCalendar19501 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getCalendar", "()Ljava/util/Calendar;");
			global::java.text.DateFormat._setNumberFormat19502 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setNumberFormat", "(Ljava/text/NumberFormat;)V");
			global::java.text.DateFormat._getNumberFormat19503 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getNumberFormat", "()Ljava/text/NumberFormat;");
			global::java.text.DateFormat._DateFormat19504 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.DateFormat))]
	public sealed partial class DateFormat_ : java.text.DateFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateFormat_()
		{
			InitJNI();
		}
		internal DateFormat_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format19505;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat_._format19505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat_.staticClass, global::java.text.DateFormat_._format19505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse19506;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat_._parse19506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat_.staticClass, global::java.text.DateFormat_._parse19506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat"));
			global::java.text.DateFormat_._format19505 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat_.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat_._parse19506 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
		}
	}
}
