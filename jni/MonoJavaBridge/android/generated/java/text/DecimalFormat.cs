namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DecimalFormat()
		{
			InitJNI();
		}
		protected DecimalFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25305;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._equals25305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._equals25305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25306;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._hashCode25306);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._hashCode25306);
		}
		internal static global::MonoJavaBridge.MethodId _clone25307;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._clone25307)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._clone25307)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25308;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25309;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25310;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25311;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._parse25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._parse25311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25312;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._formatToCharacterIterator25312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._formatToCharacterIterator25312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		public new global::java.math.RoundingMode RoundingMode
		{
			get
			{
				return getRoundingMode();
			}
			set
			{
				setRoundingMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode25313;
		public override global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getRoundingMode25313)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getRoundingMode25313)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25314;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyPattern25314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyPattern25314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25315;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toPattern25315)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toPattern25315)) as java.lang.String;
		}
		public new int MaximumIntegerDigits
		{
			get
			{
				return getMaximumIntegerDigits();
			}
			set
			{
				setMaximumIntegerDigits(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits25316;
		public override int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumIntegerDigits25316);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumIntegerDigits25316);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits25317;
		public override void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumIntegerDigits25317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumIntegerDigits25317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumIntegerDigits
		{
			get
			{
				return getMinimumIntegerDigits();
			}
			set
			{
				setMinimumIntegerDigits(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits25318;
		public override int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumIntegerDigits25318);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumIntegerDigits25318);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits25319;
		public override void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumIntegerDigits25319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumIntegerDigits25319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaximumFractionDigits
		{
			get
			{
				return getMaximumFractionDigits();
			}
			set
			{
				setMaximumFractionDigits(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits25320;
		public override int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumFractionDigits25320);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumFractionDigits25320);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits25321;
		public override void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumFractionDigits25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumFractionDigits25321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumFractionDigits
		{
			get
			{
				return getMinimumFractionDigits();
			}
			set
			{
				setMinimumFractionDigits(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits25322;
		public override int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumFractionDigits25322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumFractionDigits25322);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits25323;
		public override void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumFractionDigits25323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumFractionDigits25323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Currency Currency
		{
			get
			{
				return getCurrency();
			}
			set
			{
				setCurrency(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrency25324;
		public override global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getCurrency25324)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getCurrency25324)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25325;
		public override void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setCurrency25325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setCurrency25325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode25326;
		public override void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setRoundingMode25326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setRoundingMode25326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparatorAlwaysShown25327;
		public virtual void setDecimalSeparatorAlwaysShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.text.DecimalFormatSymbols DecimalFormatSymbols
		{
			get
			{
				return getDecimalFormatSymbols();
			}
			set
			{
				setDecimalFormatSymbols(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDecimalFormatSymbols25328;
		public virtual global::java.text.DecimalFormatSymbols getDecimalFormatSymbols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getDecimalFormatSymbols25328)) as java.text.DecimalFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getDecimalFormatSymbols25328)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalFormatSymbols25329;
		public virtual void setDecimalFormatSymbols(java.text.DecimalFormatSymbols arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalFormatSymbols25329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalFormatSymbols25329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PositivePrefix
		{
			get
			{
				return getPositivePrefix();
			}
			set
			{
				setPositivePrefix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositivePrefix25330;
		public virtual global::java.lang.String getPositivePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositivePrefix25330)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositivePrefix25330)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositivePrefix25331;
		public virtual void setPositivePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositivePrefix25331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositivePrefix25331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String NegativePrefix
		{
			get
			{
				return getNegativePrefix();
			}
			set
			{
				setNegativePrefix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNegativePrefix25332;
		public virtual global::java.lang.String getNegativePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativePrefix25332)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativePrefix25332)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePrefix25333;
		public virtual void setNegativePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativePrefix25333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativePrefix25333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PositiveSuffix
		{
			get
			{
				return getPositiveSuffix();
			}
			set
			{
				setPositiveSuffix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositiveSuffix25334;
		public virtual global::java.lang.String getPositiveSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositiveSuffix25334)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositiveSuffix25334)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveSuffix25335;
		public virtual void setPositiveSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositiveSuffix25335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositiveSuffix25335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String NegativeSuffix
		{
			get
			{
				return getNegativeSuffix();
			}
			set
			{
				setNegativeSuffix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNegativeSuffix25336;
		public virtual global::java.lang.String getNegativeSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativeSuffix25336)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativeSuffix25336)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeSuffix25337;
		public virtual void setNegativeSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativeSuffix25337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativeSuffix25337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Multiplier
		{
			get
			{
				return getMultiplier();
			}
			set
			{
				setMultiplier(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMultiplier25338;
		public virtual int getMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMultiplier25338);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMultiplier25338);
		}
		internal static global::MonoJavaBridge.MethodId _setMultiplier25339;
		public virtual void setMultiplier(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMultiplier25339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMultiplier25339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int GroupingSize
		{
			get
			{
				return getGroupingSize();
			}
			set
			{
				setGroupingSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGroupingSize25340;
		public virtual int getGroupingSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getGroupingSize25340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getGroupingSize25340);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSize25341;
		public virtual void setGroupingSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setGroupingSize25341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setGroupingSize25341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDecimalSeparatorAlwaysShown25342;
		public virtual bool isDecimalSeparatorAlwaysShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25342);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25342);
		}
		internal static global::MonoJavaBridge.MethodId _isParseBigDecimal25343;
		public virtual bool isParseBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isParseBigDecimal25343);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isParseBigDecimal25343);
		}
		internal static global::MonoJavaBridge.MethodId _setParseBigDecimal25344;
		public virtual void setParseBigDecimal(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setParseBigDecimal25344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setParseBigDecimal25344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern25345;
		public virtual global::java.lang.String toLocalizedPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toLocalizedPattern25345)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toLocalizedPattern25345)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern25346;
		public virtual void applyLocalizedPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyLocalizedPattern25346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyLocalizedPattern25346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25347;
		public DecimalFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25348;
		public DecimalFormat(java.lang.String arg0, java.text.DecimalFormatSymbols arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25349;
		public DecimalFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25349);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormat"));
			global::java.text.DecimalFormat._equals25305 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormat._hashCode25306 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormat._clone25307 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormat._format25308 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25309 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25310 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._parse25311 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.DecimalFormat._formatToCharacterIterator25312 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.DecimalFormat._getRoundingMode25313 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.DecimalFormat._applyPattern25314 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._toPattern25315 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._getMaximumIntegerDigits25316 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMaximumIntegerDigits25317 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumIntegerDigits25318 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMinimumIntegerDigits25319 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMaximumFractionDigits25320 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMaximumFractionDigits25321 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumFractionDigits25322 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMinimumFractionDigits25323 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getCurrency25324 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormat._setCurrency25325 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormat._setRoundingMode25326 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25327 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalSeparatorAlwaysShown", "(Z)V");
			global::java.text.DecimalFormat._getDecimalFormatSymbols25328 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormat._setDecimalFormatSymbols25329 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._getPositivePrefix25330 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositivePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositivePrefix25331 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositivePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativePrefix25332 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativePrefix25333 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getPositiveSuffix25334 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositiveSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositiveSuffix25335 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositiveSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativeSuffix25336 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativeSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativeSuffix25337 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativeSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getMultiplier25338 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMultiplier", "()I");
			global::java.text.DecimalFormat._setMultiplier25339 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMultiplier", "(I)V");
			global::java.text.DecimalFormat._getGroupingSize25340 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getGroupingSize", "()I");
			global::java.text.DecimalFormat._setGroupingSize25341 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setGroupingSize", "(I)V");
			global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25342 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isDecimalSeparatorAlwaysShown", "()Z");
			global::java.text.DecimalFormat._isParseBigDecimal25343 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isParseBigDecimal", "()Z");
			global::java.text.DecimalFormat._setParseBigDecimal25344 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setParseBigDecimal", "(Z)V");
			global::java.text.DecimalFormat._toLocalizedPattern25345 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._applyLocalizedPattern25346 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25347 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25348 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._DecimalFormat25349 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "()V");
		}
	}
}
