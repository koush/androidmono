namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.NumberFormat_))]
	public abstract partial class NumberFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NumberFormat()
		{
			InitJNI();
		}
		protected NumberFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			internal static global::MonoJavaBridge.MethodId _readResolve19661;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field._readResolve19661)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._readResolve19661)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field19662;
			protected Field(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._Field19662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INTEGER19663;
			public static global::java.text.NumberFormat.Field INTEGER
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FRACTION19664;
			public static global::java.text.NumberFormat.Field FRACTION
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT19665;
			public static global::java.text.NumberFormat.Field EXPONENT
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_SEPARATOR19666;
			public static global::java.text.NumberFormat.Field DECIMAL_SEPARATOR
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGN19667;
			public static global::java.text.NumberFormat.Field SIGN
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _GROUPING_SEPARATOR19668;
			public static global::java.text.NumberFormat.Field GROUPING_SEPARATOR
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SYMBOL19669;
			public static global::java.text.NumberFormat.Field EXPONENT_SYMBOL
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERCENT19670;
			public static global::java.text.NumberFormat.Field PERCENT
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERMILLE19671;
			public static global::java.text.NumberFormat.Field PERMILLE
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY19672;
			public static global::java.text.NumberFormat.Field CURRENCY
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SIGN19673;
			public static global::java.text.NumberFormat.Field EXPONENT_SIGN
			{
				get
				{
					return default(global::java.text.NumberFormat.Field);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.NumberFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat$Field"));
				global::java.text.NumberFormat.Field._readResolve19661 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.NumberFormat.Field._Field19662 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals19674;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._equals19674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._equals19674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19675;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._hashCode19675);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._hashCode19675);
		}
		internal static global::MonoJavaBridge.MethodId _clone19676;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._clone19676)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._clone19676)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19677;
		public virtual global::java.lang.String format(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format19677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format19677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format19678;
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format19679;
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format19680;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format19680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format19680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19681;
		public virtual global::java.lang.String format(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format19681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format19681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19682;
		public static global::java.text.NumberFormat getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance19682)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19683;
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance19683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _parse19684;
		public virtual global::java.lang.Number parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parse19684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parse19684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _parse19685;
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales19686;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getAvailableLocales19686)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _parseObject19687;
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parseObject19687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parseObject19687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode19688;
		public virtual global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getRoundingMode19688)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getRoundingMode19688)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _isParseIntegerOnly19689;
		public virtual bool isParseIntegerOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isParseIntegerOnly19689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isParseIntegerOnly19689);
		}
		internal static global::MonoJavaBridge.MethodId _setParseIntegerOnly19690;
		public virtual void setParseIntegerOnly(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setParseIntegerOnly19690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setParseIntegerOnly19690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance19691;
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance19691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance19692;
		public static global::java.text.NumberFormat getNumberInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance19692)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance19693;
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance19693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance19694;
		public static global::java.text.NumberFormat getIntegerInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance19694)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance19695;
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance19695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance19696;
		public static global::java.text.NumberFormat getCurrencyInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance19696)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance19697;
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance19697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance19698;
		public static global::java.text.NumberFormat getPercentInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance19698)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _isGroupingUsed19699;
		public virtual bool isGroupingUsed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isGroupingUsed19699);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isGroupingUsed19699);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingUsed19700;
		public virtual void setGroupingUsed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setGroupingUsed19700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setGroupingUsed19700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits19701;
		public virtual int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumIntegerDigits19701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumIntegerDigits19701);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits19702;
		public virtual void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumIntegerDigits19702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumIntegerDigits19702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits19703;
		public virtual int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumIntegerDigits19703);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumIntegerDigits19703);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits19704;
		public virtual void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumIntegerDigits19704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumIntegerDigits19704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits19705;
		public virtual int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumFractionDigits19705);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumFractionDigits19705);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits19706;
		public virtual void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumFractionDigits19706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumFractionDigits19706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits19707;
		public virtual int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumFractionDigits19707);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumFractionDigits19707);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits19708;
		public virtual void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumFractionDigits19708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumFractionDigits19708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency19709;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getCurrency19709)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrency19709)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency19710;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setCurrency19710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setCurrency19710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode19711;
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setRoundingMode19711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setRoundingMode19711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormat19712;
		protected NumberFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._NumberFormat19712);
			Init(@__env, handle);
		}
		public static int INTEGER_FIELD
		{
			get
			{
				return 0;
			}
		}
		public static int FRACTION_FIELD
		{
			get
			{
				return 1;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
			global::java.text.NumberFormat._equals19674 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.NumberFormat._hashCode19675 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "hashCode", "()I");
			global::java.text.NumberFormat._clone19676 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.NumberFormat._format19677 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;");
			global::java.text.NumberFormat._format19678 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format19679 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format19680 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format19681 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;");
			global::java.text.NumberFormat._getInstance19682 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getInstance19683 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._parse19684 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;");
			global::java.text.NumberFormat._parse19685 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.NumberFormat._getAvailableLocales19686 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.NumberFormat._parseObject19687 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.NumberFormat._getRoundingMode19688 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.NumberFormat._isParseIntegerOnly19689 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z");
			global::java.text.NumberFormat._setParseIntegerOnly19690 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V");
			global::java.text.NumberFormat._getNumberInstance19691 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getNumberInstance19692 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance19693 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance19694 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance19695 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance19696 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance19697 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance19698 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._isGroupingUsed19699 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z");
			global::java.text.NumberFormat._setGroupingUsed19700 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V");
			global::java.text.NumberFormat._getMaximumIntegerDigits19701 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMaximumIntegerDigits19702 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumIntegerDigits19703 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMinimumIntegerDigits19704 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMaximumFractionDigits19705 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.NumberFormat._setMaximumFractionDigits19706 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumFractionDigits19707 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.NumberFormat._setMinimumFractionDigits19708 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getCurrency19709 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.NumberFormat._setCurrency19710 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.NumberFormat._setRoundingMode19711 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.NumberFormat._NumberFormat19712 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.NumberFormat))]
	public sealed partial class NumberFormat_ : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NumberFormat_()
		{
			InitJNI();
		}
		internal NumberFormat_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format19713;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format19713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format19713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19714;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format19714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format19714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse19715;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._parse19715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._parse19715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
			global::java.text.NumberFormat_._format19713 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._format19714 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._parse19715 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
		}
	}
}
