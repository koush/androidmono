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
			internal static global::MonoJavaBridge.MethodId _readResolve25205;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat.Field._readResolve25205)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._readResolve25205)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _ofCalendarField25206;
			public static global::java.text.DateFormat.Field ofCalendarField(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._ofCalendarField25206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat.Field;
			}
			public new int CalendarField
			{
				get
				{
					return getCalendarField();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getCalendarField25207;
			public virtual int getCalendarField() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormat.Field._getCalendarField25207);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._getCalendarField25207);
			}
			internal static global::MonoJavaBridge.MethodId _Field25208;
			protected Field(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.Field.staticClass, global::java.text.DateFormat.Field._Field25208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _ERA25209;
			public static global::java.text.DateFormat.Field ERA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _ERA25209)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YEAR25210;
			public static global::java.text.DateFormat.Field YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _YEAR25210)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONTH25211;
			public static global::java.text.DateFormat.Field MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MONTH25211)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_MONTH25212;
			public static global::java.text.DateFormat.Field DAY_OF_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_MONTH25212)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY125213;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR_OF_DAY125213)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR_OF_DAY025214;
			public static global::java.text.DateFormat.Field HOUR_OF_DAY0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR_OF_DAY025214)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MINUTE25215;
			public static global::java.text.DateFormat.Field MINUTE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MINUTE25215)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SECOND25216;
			public static global::java.text.DateFormat.Field SECOND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _SECOND25216)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MILLISECOND25217;
			public static global::java.text.DateFormat.Field MILLISECOND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _MILLISECOND25217)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK25218;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_WEEK25218)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_YEAR25219;
			public static global::java.text.DateFormat.Field DAY_OF_YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_YEAR25219)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DAY_OF_WEEK_IN_MONTH25220;
			public static global::java.text.DateFormat.Field DAY_OF_WEEK_IN_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _DAY_OF_WEEK_IN_MONTH25220)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_YEAR25221;
			public static global::java.text.DateFormat.Field WEEK_OF_YEAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _WEEK_OF_YEAR25221)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _WEEK_OF_MONTH25222;
			public static global::java.text.DateFormat.Field WEEK_OF_MONTH
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _WEEK_OF_MONTH25222)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _AM_PM25223;
			public static global::java.text.DateFormat.Field AM_PM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _AM_PM25223)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR125224;
			public static global::java.text.DateFormat.Field HOUR1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR125224)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HOUR025225;
			public static global::java.text.DateFormat.Field HOUR0
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _HOUR025225)) as java.text.DateFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIME_ZONE25226;
			public static global::java.text.DateFormat.Field TIME_ZONE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.DateFormat.Field.staticClass, _TIME_ZONE25226)) as java.text.DateFormat.Field;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.DateFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat$Field"));
				global::java.text.DateFormat.Field._readResolve25205 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.DateFormat.Field._ofCalendarField25206 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "ofCalendarField", "(I)Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._getCalendarField25207 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "getCalendarField", "()I");
				global::java.text.DateFormat.Field._Field25208 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.Field.staticClass, "<init>", "(Ljava/lang/String;I)V");
				global::java.text.DateFormat.Field._ERA25209 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "ERA", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._YEAR25210 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MONTH25211 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_MONTH25212 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR_OF_DAY125213 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR_OF_DAY1", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR_OF_DAY025214 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR_OF_DAY0", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MINUTE25215 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MINUTE", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._SECOND25216 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "SECOND", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._MILLISECOND25217 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "MILLISECOND", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_WEEK25218 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_WEEK", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_YEAR25219 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._DAY_OF_WEEK_IN_MONTH25220 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "DAY_OF_WEEK_IN_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._WEEK_OF_YEAR25221 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "WEEK_OF_YEAR", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._WEEK_OF_MONTH25222 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "WEEK_OF_MONTH", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._AM_PM25223 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "AM_PM", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR125224 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR1", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._HOUR025225 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "HOUR0", "Ljava/text/DateFormat$Field;");
				global::java.text.DateFormat.Field._TIME_ZONE25226 = @__env.GetStaticFieldIDNoThrow(global::java.text.DateFormat.Field.staticClass, "TIME_ZONE", "Ljava/text/DateFormat$Field;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals25227;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormat._equals25227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._equals25227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25228;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DateFormat._hashCode25228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._hashCode25228);
		}
		internal static global::MonoJavaBridge.MethodId _clone25229;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._clone25229)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._clone25229)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25230;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._format25230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format25230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25231;
		public abstract global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format25232;
		public virtual global::java.lang.String format(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._format25232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._format25232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25233;
		public static global::java.text.DateFormat getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getInstance25233)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _parse25234;
		public virtual global::java.util.Date parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._parse25234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parse25234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _parse25235;
		public abstract global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25236;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getAvailableLocales25236)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone25237;
		public virtual global::java.util.TimeZone getTimeZone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getTimeZone25237)) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeZone25237)) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setTimeZone25238;
		public virtual void setTimeZone(java.util.TimeZone arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setTimeZone25238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setTimeZone25238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance25239;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1, java.util.Locale arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance25239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance25240;
		public static global::java.text.DateFormat getDateTimeInstance(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance25240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateTimeInstance25241;
		public static global::java.text.DateFormat getDateTimeInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateTimeInstance25241)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _setLenient25242;
		public virtual void setLenient(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setLenient25242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setLenient25242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLenient25243;
		public virtual bool isLenient() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DateFormat._isLenient25243);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._isLenient25243);
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25244;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._parseObject25244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._parseObject25244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance25245;
		public static global::java.text.DateFormat getTimeInstance(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance25245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance25246;
		public static global::java.text.DateFormat getTimeInstance(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance25246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInstance25247;
		public static global::java.text.DateFormat getTimeInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getTimeInstance25247)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance25248;
		public static global::java.text.DateFormat getDateInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance25248)) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance25249;
		public static global::java.text.DateFormat getDateInstance(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance25249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getDateInstance25250;
		public static global::java.text.DateFormat getDateInstance(int arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DateFormat.staticClass, global::java.text.DateFormat._getDateInstance25250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.text.DateFormat;
		}
		internal static global::MonoJavaBridge.MethodId _setCalendar25251;
		public virtual void setCalendar(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setCalendar25251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setCalendar25251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCalendar25252;
		public virtual global::java.util.Calendar getCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getCalendar25252)) as java.util.Calendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getCalendar25252)) as java.util.Calendar;
		}
		internal static global::MonoJavaBridge.MethodId _setNumberFormat25253;
		public virtual void setNumberFormat(java.text.NumberFormat arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DateFormat._setNumberFormat25253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._setNumberFormat25253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberFormat25254;
		public virtual global::java.text.NumberFormat getNumberFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat._getNumberFormat25254)) as java.text.NumberFormat;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat.staticClass, global::java.text.DateFormat._getNumberFormat25254)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _DateFormat25255;
		protected DateFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DateFormat.staticClass, global::java.text.DateFormat._DateFormat25255);
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
			global::java.text.DateFormat._equals25227 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DateFormat._hashCode25228 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "hashCode", "()I");
			global::java.text.DateFormat._clone25229 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DateFormat._format25230 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format25231 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat._format25232 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "format", "(Ljava/util/Date;)Ljava/lang/String;");
			global::java.text.DateFormat._getInstance25233 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._parse25234 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/util/Date;");
			global::java.text.DateFormat._parse25235 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
			global::java.text.DateFormat._getAvailableLocales25236 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DateFormat._getTimeZone25237 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeZone", "()Ljava/util/TimeZone;");
			global::java.text.DateFormat._setTimeZone25238 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setTimeZone", "(Ljava/util/TimeZone;)V");
			global::java.text.DateFormat._getDateTimeInstance25239 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance25240 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "(II)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateTimeInstance25241 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._setLenient25242 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setLenient", "(Z)V");
			global::java.text.DateFormat._isLenient25243 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "isLenient", "()Z");
			global::java.text.DateFormat._parseObject25244 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.DateFormat._getTimeInstance25245 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance25246 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getTimeInstance25247 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getTimeInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance25248 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "()Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance25249 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(I)Ljava/text/DateFormat;");
			global::java.text.DateFormat._getDateInstance25250 = @__env.GetStaticMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;");
			global::java.text.DateFormat._setCalendar25251 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setCalendar", "(Ljava/util/Calendar;)V");
			global::java.text.DateFormat._getCalendar25252 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getCalendar", "()Ljava/util/Calendar;");
			global::java.text.DateFormat._setNumberFormat25253 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "setNumberFormat", "(Ljava/text/NumberFormat;)V");
			global::java.text.DateFormat._getNumberFormat25254 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "getNumberFormat", "()Ljava/text/NumberFormat;");
			global::java.text.DateFormat._DateFormat25255 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _format25279;
		public override global::java.lang.StringBuffer format(java.util.Date arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat_._format25279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat_.staticClass, global::java.text.DateFormat_._format25279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25280;
		public override global::java.util.Date parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DateFormat_._parse25280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DateFormat_.staticClass, global::java.text.DateFormat_._parse25280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DateFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DateFormat"));
			global::java.text.DateFormat_._format25279 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat_.staticClass, "format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DateFormat_._parse25280 = @__env.GetMethodIDNoThrow(global::java.text.DateFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;");
		}
	}
}
