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
		internal static global::MonoJavaBridge.MethodId _equals25423;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._equals25423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._equals25423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25424;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._hashCode25424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._hashCode25424);
		}
		internal static global::MonoJavaBridge.MethodId _clone25425;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._clone25425)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._clone25425)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25426;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25427;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25428;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format25428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25429;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._parse25429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._parse25429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25430;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._formatToCharacterIterator25430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._formatToCharacterIterator25430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getRoundingMode25431;
		public override global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getRoundingMode25431)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getRoundingMode25431)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25432;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyPattern25432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyPattern25432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25433;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toPattern25433)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toPattern25433)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits25434;
		public override int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumIntegerDigits25434);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumIntegerDigits25434);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits25435;
		public override void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumIntegerDigits25435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumIntegerDigits25435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits25436;
		public override int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumIntegerDigits25436);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumIntegerDigits25436);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits25437;
		public override void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumIntegerDigits25437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumIntegerDigits25437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits25438;
		public override int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumFractionDigits25438);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumFractionDigits25438);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits25439;
		public override void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumFractionDigits25439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumFractionDigits25439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits25440;
		public override int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumFractionDigits25440);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumFractionDigits25440);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits25441;
		public override void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumFractionDigits25441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumFractionDigits25441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrency25442;
		public override global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getCurrency25442)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getCurrency25442)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25443;
		public override void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setCurrency25443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setCurrency25443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode25444;
		public override void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setRoundingMode25444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setRoundingMode25444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparatorAlwaysShown25445;
		public virtual void setDecimalSeparatorAlwaysShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDecimalFormatSymbols25446;
		public virtual global::java.text.DecimalFormatSymbols getDecimalFormatSymbols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getDecimalFormatSymbols25446)) as java.text.DecimalFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getDecimalFormatSymbols25446)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalFormatSymbols25447;
		public virtual void setDecimalFormatSymbols(java.text.DecimalFormatSymbols arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalFormatSymbols25447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalFormatSymbols25447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositivePrefix25448;
		public virtual global::java.lang.String getPositivePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositivePrefix25448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositivePrefix25448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositivePrefix25449;
		public virtual void setPositivePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositivePrefix25449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositivePrefix25449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativePrefix25450;
		public virtual global::java.lang.String getNegativePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativePrefix25450)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativePrefix25450)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePrefix25451;
		public virtual void setNegativePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativePrefix25451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativePrefix25451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositiveSuffix25452;
		public virtual global::java.lang.String getPositiveSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositiveSuffix25452)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositiveSuffix25452)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveSuffix25453;
		public virtual void setPositiveSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositiveSuffix25453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositiveSuffix25453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativeSuffix25454;
		public virtual global::java.lang.String getNegativeSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativeSuffix25454)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativeSuffix25454)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeSuffix25455;
		public virtual void setNegativeSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativeSuffix25455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativeSuffix25455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMultiplier25456;
		public virtual int getMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMultiplier25456);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMultiplier25456);
		}
		internal static global::MonoJavaBridge.MethodId _setMultiplier25457;
		public virtual void setMultiplier(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMultiplier25457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMultiplier25457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGroupingSize25458;
		public virtual int getGroupingSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getGroupingSize25458);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getGroupingSize25458);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSize25459;
		public virtual void setGroupingSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setGroupingSize25459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setGroupingSize25459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDecimalSeparatorAlwaysShown25460;
		public virtual bool isDecimalSeparatorAlwaysShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25460);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25460);
		}
		internal static global::MonoJavaBridge.MethodId _isParseBigDecimal25461;
		public virtual bool isParseBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isParseBigDecimal25461);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isParseBigDecimal25461);
		}
		internal static global::MonoJavaBridge.MethodId _setParseBigDecimal25462;
		public virtual void setParseBigDecimal(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setParseBigDecimal25462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setParseBigDecimal25462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern25463;
		public virtual global::java.lang.String toLocalizedPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toLocalizedPattern25463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toLocalizedPattern25463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern25464;
		public virtual void applyLocalizedPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyLocalizedPattern25464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyLocalizedPattern25464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25465;
		public DecimalFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25466;
		public DecimalFormat(java.lang.String arg0, java.text.DecimalFormatSymbols arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25467;
		public DecimalFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25467);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormat"));
			global::java.text.DecimalFormat._equals25423 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormat._hashCode25424 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormat._clone25425 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormat._format25426 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25427 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25428 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._parse25429 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.DecimalFormat._formatToCharacterIterator25430 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.DecimalFormat._getRoundingMode25431 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.DecimalFormat._applyPattern25432 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._toPattern25433 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._getMaximumIntegerDigits25434 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMaximumIntegerDigits25435 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumIntegerDigits25436 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMinimumIntegerDigits25437 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMaximumFractionDigits25438 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMaximumFractionDigits25439 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumFractionDigits25440 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMinimumFractionDigits25441 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getCurrency25442 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormat._setCurrency25443 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormat._setRoundingMode25444 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25445 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalSeparatorAlwaysShown", "(Z)V");
			global::java.text.DecimalFormat._getDecimalFormatSymbols25446 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormat._setDecimalFormatSymbols25447 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._getPositivePrefix25448 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositivePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositivePrefix25449 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositivePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativePrefix25450 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativePrefix25451 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getPositiveSuffix25452 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositiveSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositiveSuffix25453 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositiveSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativeSuffix25454 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativeSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativeSuffix25455 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativeSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getMultiplier25456 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMultiplier", "()I");
			global::java.text.DecimalFormat._setMultiplier25457 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMultiplier", "(I)V");
			global::java.text.DecimalFormat._getGroupingSize25458 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getGroupingSize", "()I");
			global::java.text.DecimalFormat._setGroupingSize25459 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setGroupingSize", "(I)V");
			global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25460 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isDecimalSeparatorAlwaysShown", "()Z");
			global::java.text.DecimalFormat._isParseBigDecimal25461 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isParseBigDecimal", "()Z");
			global::java.text.DecimalFormat._setParseBigDecimal25462 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setParseBigDecimal", "(Z)V");
			global::java.text.DecimalFormat._toLocalizedPattern25463 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._applyLocalizedPattern25464 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25465 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25466 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._DecimalFormat25467 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "()V");
		}
	}
}
