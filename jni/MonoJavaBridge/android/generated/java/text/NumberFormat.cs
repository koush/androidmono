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
			internal static global::MonoJavaBridge.MethodId _readResolve25435;
			protected override global::java.lang.Object readResolve() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field._readResolve25435)) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._readResolve25435)) as java.lang.Object;
			}
			internal static global::MonoJavaBridge.MethodId _Field25436;
			protected Field(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.Field.staticClass, global::java.text.NumberFormat.Field._Field25436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _INTEGER25437;
			public static global::java.text.NumberFormat.Field INTEGER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _INTEGER25437)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FRACTION25438;
			public static global::java.text.NumberFormat.Field FRACTION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _FRACTION25438)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT25439;
			public static global::java.text.NumberFormat.Field EXPONENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT25439)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DECIMAL_SEPARATOR25440;
			public static global::java.text.NumberFormat.Field DECIMAL_SEPARATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _DECIMAL_SEPARATOR25440)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SIGN25441;
			public static global::java.text.NumberFormat.Field SIGN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _SIGN25441)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GROUPING_SEPARATOR25442;
			public static global::java.text.NumberFormat.Field GROUPING_SEPARATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _GROUPING_SEPARATOR25442)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SYMBOL25443;
			public static global::java.text.NumberFormat.Field EXPONENT_SYMBOL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT_SYMBOL25443)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERCENT25444;
			public static global::java.text.NumberFormat.Field PERCENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _PERCENT25444)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PERMILLE25445;
			public static global::java.text.NumberFormat.Field PERMILLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _PERMILLE25445)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY25446;
			public static global::java.text.NumberFormat.Field CURRENCY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _CURRENCY25446)) as java.text.NumberFormat.Field;
				}
			}
			internal static global::MonoJavaBridge.FieldId _EXPONENT_SIGN25447;
			public static global::java.text.NumberFormat.Field EXPONENT_SIGN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.text.NumberFormat.Field.staticClass, _EXPONENT_SIGN25447)) as java.text.NumberFormat.Field;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.NumberFormat.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat$Field"));
				global::java.text.NumberFormat.Field._readResolve25435 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "readResolve", "()Ljava/lang/Object;");
				global::java.text.NumberFormat.Field._Field25436 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::java.text.NumberFormat.Field._INTEGER25437 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "INTEGER", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._FRACTION25438 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "FRACTION", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT25439 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._DECIMAL_SEPARATOR25440 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "DECIMAL_SEPARATOR", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._SIGN25441 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "SIGN", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._GROUPING_SEPARATOR25442 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "GROUPING_SEPARATOR", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT_SYMBOL25443 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT_SYMBOL", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._PERCENT25444 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "PERCENT", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._PERMILLE25445 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "PERMILLE", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._CURRENCY25446 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "CURRENCY", "Ljava/text/NumberFormat$Field;");
				global::java.text.NumberFormat.Field._EXPONENT_SIGN25447 = @__env.GetStaticFieldIDNoThrow(global::java.text.NumberFormat.Field.staticClass, "EXPONENT_SIGN", "Ljava/text/NumberFormat$Field;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals25448;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._equals25448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._equals25448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25449;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._hashCode25449);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._hashCode25449);
		}
		internal static global::MonoJavaBridge.MethodId _clone25450;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._clone25450)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._clone25450)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25451;
		public virtual global::java.lang.String format(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format25452;
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format25453;
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _format25454;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25455;
		public virtual global::java.lang.String format(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._format25455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._format25455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25456;
		public static global::java.text.NumberFormat getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance25456)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25457;
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getInstance25457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _parse25458;
		public virtual global::java.lang.Number parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parse25458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parse25458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _parse25459;
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales25460;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getAvailableLocales25460)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25461;
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._parseObject25461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._parseObject25461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode25462;
		public virtual global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getRoundingMode25462)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getRoundingMode25462)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _isParseIntegerOnly25463;
		public virtual bool isParseIntegerOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isParseIntegerOnly25463);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isParseIntegerOnly25463);
		}
		internal static global::MonoJavaBridge.MethodId _setParseIntegerOnly25464;
		public virtual void setParseIntegerOnly(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setParseIntegerOnly25464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setParseIntegerOnly25464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance25465;
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance25465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getNumberInstance25466;
		public static global::java.text.NumberFormat getNumberInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getNumberInstance25466)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance25467;
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance25467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerInstance25468;
		public static global::java.text.NumberFormat getIntegerInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getIntegerInstance25468)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance25469;
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance25469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyInstance25470;
		public static global::java.text.NumberFormat getCurrencyInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrencyInstance25470)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance25471;
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance25471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _getPercentInstance25472;
		public static global::java.text.NumberFormat getPercentInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getPercentInstance25472)) as java.text.NumberFormat;
		}
		internal static global::MonoJavaBridge.MethodId _isGroupingUsed25473;
		public virtual bool isGroupingUsed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.NumberFormat._isGroupingUsed25473);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._isGroupingUsed25473);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingUsed25474;
		public virtual void setGroupingUsed(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setGroupingUsed25474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setGroupingUsed25474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits25475;
		public virtual int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumIntegerDigits25475);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumIntegerDigits25475);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits25476;
		public virtual void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumIntegerDigits25476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumIntegerDigits25476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits25477;
		public virtual int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumIntegerDigits25477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumIntegerDigits25477);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits25478;
		public virtual void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumIntegerDigits25478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumIntegerDigits25478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits25479;
		public virtual int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMaximumFractionDigits25479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMaximumFractionDigits25479);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits25480;
		public virtual void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMaximumFractionDigits25480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMaximumFractionDigits25480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits25481;
		public virtual int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.NumberFormat._getMinimumFractionDigits25481);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getMinimumFractionDigits25481);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits25482;
		public virtual void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setMinimumFractionDigits25482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setMinimumFractionDigits25482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency25483;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat._getCurrency25483)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._getCurrency25483)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25484;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setCurrency25484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setCurrency25484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode25485;
		public virtual void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.NumberFormat._setRoundingMode25485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.NumberFormat.staticClass, global::java.text.NumberFormat._setRoundingMode25485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NumberFormat25486;
		protected NumberFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._NumberFormat25486);
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
			global::java.text.NumberFormat._equals25448 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.NumberFormat._hashCode25449 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "hashCode", "()I");
			global::java.text.NumberFormat._clone25450 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.NumberFormat._format25451 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;");
			global::java.text.NumberFormat._format25452 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25453 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25454 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat._format25455 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;");
			global::java.text.NumberFormat._getInstance25456 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getInstance25457 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._parse25458 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;");
			global::java.text.NumberFormat._parse25459 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.NumberFormat._getAvailableLocales25460 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.NumberFormat._parseObject25461 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.NumberFormat._getRoundingMode25462 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.NumberFormat._isParseIntegerOnly25463 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z");
			global::java.text.NumberFormat._setParseIntegerOnly25464 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V");
			global::java.text.NumberFormat._getNumberInstance25465 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getNumberInstance25466 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance25467 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getIntegerInstance25468 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance25469 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getCurrencyInstance25470 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance25471 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._getPercentInstance25472 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;");
			global::java.text.NumberFormat._isGroupingUsed25473 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z");
			global::java.text.NumberFormat._setGroupingUsed25474 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V");
			global::java.text.NumberFormat._getMaximumIntegerDigits25475 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMaximumIntegerDigits25476 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumIntegerDigits25477 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.NumberFormat._setMinimumIntegerDigits25478 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.NumberFormat._getMaximumFractionDigits25479 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.NumberFormat._setMaximumFractionDigits25480 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getMinimumFractionDigits25481 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.NumberFormat._setMinimumFractionDigits25482 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.NumberFormat._getCurrency25483 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.NumberFormat._setCurrency25484 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.NumberFormat._setRoundingMode25485 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.NumberFormat._NumberFormat25486 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _format25489;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format25489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format25489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25490;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._format25490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._format25490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25491;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.NumberFormat_._parse25491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.NumberFormat_.staticClass, global::java.text.NumberFormat_._parse25491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
			global::java.text.NumberFormat_._format25489 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._format25490 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.NumberFormat_._parse25491 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
		}
	}
}
