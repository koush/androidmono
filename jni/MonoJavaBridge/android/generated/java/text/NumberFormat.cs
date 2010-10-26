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
			internal static global::MonoJavaBridge.MethodId _readResolve25553;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field._readResolve25553)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._readResolve25553)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field25554;
			protected Field(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._Field25554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INTEGER25555;
			public static global::java.text.NumberFormat.Field INTEGER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _INTEGER25555)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FRACTION25556;
			public static global::java.text.NumberFormat.Field FRACTION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _FRACTION25556)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT25557;
			public static global::java.text.NumberFormat.Field EXPONENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT25557)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_SEPARATOR25558;
			public static global::java.text.NumberFormat.Field DECIMAL_SEPARATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _DECIMAL_SEPARATOR25558)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGN25559;
			public static global::java.text.NumberFormat.Field SIGN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _SIGN25559)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GROUPING_SEPARATOR25560;
			public static global::java.text.NumberFormat.Field GROUPING_SEPARATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _GROUPING_SEPARATOR25560)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SYMBOL25561;
			public static global::java.text.NumberFormat.Field EXPONENT_SYMBOL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT_SYMBOL25561)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERCENT25562;
			public static global::java.text.NumberFormat.Field PERCENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _PERCENT25562)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERMILLE25563;
			public static global::java.text.NumberFormat.Field PERMILLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _PERMILLE25563)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY25564;
			public static global::java.text.NumberFormat.Field CURRENCY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _CURRENCY25564)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SIGN25565;
			public static global::java.text.NumberFormat.Field EXPONENT_SIGN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT_SIGN25565)) as java.text.NumberFormat.Field;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.NumberFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat$Field"));
				global::java.text.NumberFormat.Field._readResolve25553 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.NumberFormat.Field._Field25554 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::java.text.NumberFormat.Field._INTEGER25555 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "INTEGER", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._FRACTION25556 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "FRACTION", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT25557 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._DECIMAL_SEPARATOR25558 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "DECIMAL_SEPARATOR", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._SIGN25559 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "SIGN", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._GROUPING_SEPARATOR25560 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "GROUPING_SEPARATOR", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT_SYMBOL25561 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT_SYMBOL", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._PERCENT25562 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "PERCENT", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._PERMILLE25563 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "PERMILLE", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._CURRENCY25564 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "CURRENCY", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT_SIGN25565 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT_SIGN", "Ljava/text/NumberFormat$Field;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals25566;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._equals25566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._equals25566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25567;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._hashCode25567);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._hashCode25567);
		}
		internal static global::MonoJavaBridge.MethodId _clone25568;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._clone25568)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._clone25568)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25569;
		public virtual global::java.lang.String format(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format25570;
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format25571;
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format25572;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25573;
		public virtual global::java.lang.String format(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25574;
		public static global::java.text.NumberFormat getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance25574)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25575;
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance25575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _parse25576;
		public virtual global::java.lang.Number parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parse25576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parse25576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _parse25577;
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25578;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getAvailableLocales25578)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25579;
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parseObject25579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parseObject25579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode25580;
		public virtual global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getRoundingMode25580)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getRoundingMode25580)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _isParseIntegerOnly25581;
		public virtual bool isParseIntegerOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isParseIntegerOnly25581);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isParseIntegerOnly25581);
		}
		internal static global::MonoJavaBridge.MethodId _setParseIntegerOnly25582;
		public virtual void setParseIntegerOnly(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setParseIntegerOnly25582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setParseIntegerOnly25582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance25583;
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance25583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance25584;
		public static global::java.text.NumberFormat getNumberInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance25584)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance25585;
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance25585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance25586;
		public static global::java.text.NumberFormat getIntegerInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance25586)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance25587;
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance25587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance25588;
		public static global::java.text.NumberFormat getCurrencyInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance25588)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance25589;
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance25589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance25590;
		public static global::java.text.NumberFormat getPercentInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance25590)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _isGroupingUsed25591;
		public virtual bool isGroupingUsed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isGroupingUsed25591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isGroupingUsed25591);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingUsed25592;
		public virtual void setGroupingUsed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setGroupingUsed25592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setGroupingUsed25592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits25593;
		public virtual int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumIntegerDigits25593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumIntegerDigits25593);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits25594;
		public virtual void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumIntegerDigits25594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumIntegerDigits25594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits25595;
		public virtual int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumIntegerDigits25595);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumIntegerDigits25595);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits25596;
		public virtual void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumIntegerDigits25596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumIntegerDigits25596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits25597;
		public virtual int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumFractionDigits25597);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumFractionDigits25597);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits25598;
		public virtual void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumFractionDigits25598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumFractionDigits25598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits25599;
		public virtual int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumFractionDigits25599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumFractionDigits25599);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits25600;
		public virtual void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumFractionDigits25600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumFractionDigits25600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency25601;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getCurrency25601)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrency25601)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25602;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setCurrency25602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setCurrency25602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode25603;
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setRoundingMode25603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setRoundingMode25603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormat25604;
		protected NumberFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._NumberFormat25604);
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
			global::java.text.NumberFormat._equals25566 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.NumberFormat._hashCode25567 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "hashCode", "()I");
			global::java.text.NumberFormat._clone25568 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.NumberFormat._format25569 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;");
			global::java.text.NumberFormat._format25570 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25571 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25572 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25573 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;");
			global::java.text.NumberFormat._getInstance25574 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getInstance25575 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._parse25576 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;");
			global::java.text.NumberFormat._parse25577 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.NumberFormat._getAvailableLocales25578 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.NumberFormat._parseObject25579 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.NumberFormat._getRoundingMode25580 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.NumberFormat._isParseIntegerOnly25581 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z");
			global::java.text.NumberFormat._setParseIntegerOnly25582 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V");
			global::java.text.NumberFormat._getNumberInstance25583 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getNumberInstance25584 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance25585 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance25586 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance25587 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance25588 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance25589 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance25590 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._isGroupingUsed25591 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z");
			global::java.text.NumberFormat._setGroupingUsed25592 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V");
			global::java.text.NumberFormat._getMaximumIntegerDigits25593 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMaximumIntegerDigits25594 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumIntegerDigits25595 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMinimumIntegerDigits25596 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMaximumFractionDigits25597 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.NumberFormat._setMaximumFractionDigits25598 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumFractionDigits25599 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.NumberFormat._setMinimumFractionDigits25600 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getCurrency25601 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.NumberFormat._setCurrency25602 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.NumberFormat._setRoundingMode25603 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.NumberFormat._NumberFormat25604 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.NumberFormat))]
	internal sealed partial class NumberFormat_ : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NumberFormat_()
		{
			InitJNI();
		}
		internal NumberFormat_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format25607;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format25607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format25607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25608;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format25608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format25608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25609;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._parse25609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._parse25609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
			global::java.text.NumberFormat_._format25607 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._format25608 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._parse25609 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
		}
	}
}
