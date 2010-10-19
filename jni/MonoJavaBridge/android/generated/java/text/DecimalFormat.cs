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
		internal static global::MonoJavaBridge.MethodId _equals19531;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._equals19531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._equals19531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19532;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._hashCode19532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._hashCode19532);
		}
		internal static global::MonoJavaBridge.MethodId _clone19533;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._clone19533)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._clone19533)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format19534;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format19534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format19534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19535;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format19535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format19535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format19536;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._format19536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format19536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse19537;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._parse19537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._parse19537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator19538;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._formatToCharacterIterator19538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._formatToCharacterIterator19538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getRoundingMode19539;
		public override global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getRoundingMode19539)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getRoundingMode19539)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern19540;
		public virtual void applyPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyPattern19540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyPattern19540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern19541;
		public virtual global::java.lang.String toPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toPattern19541)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toPattern19541)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits19542;
		public override int getMaximumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumIntegerDigits19542);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumIntegerDigits19542);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits19543;
		public override void setMaximumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumIntegerDigits19543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumIntegerDigits19543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits19544;
		public override int getMinimumIntegerDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumIntegerDigits19544);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumIntegerDigits19544);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits19545;
		public override void setMinimumIntegerDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumIntegerDigits19545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumIntegerDigits19545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits19546;
		public override int getMaximumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMaximumFractionDigits19546);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumFractionDigits19546);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits19547;
		public override void setMaximumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMaximumFractionDigits19547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumFractionDigits19547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits19548;
		public override int getMinimumFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMinimumFractionDigits19548);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumFractionDigits19548);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits19549;
		public override void setMinimumFractionDigits(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMinimumFractionDigits19549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumFractionDigits19549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrency19550;
		public override global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getCurrency19550)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getCurrency19550)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency19551;
		public override void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setCurrency19551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setCurrency19551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode19552;
		public override void setRoundingMode(java.math.RoundingMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setRoundingMode19552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setRoundingMode19552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparatorAlwaysShown19553;
		public virtual void setDecimalSeparatorAlwaysShown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown19553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown19553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDecimalFormatSymbols19554;
		public virtual global::java.text.DecimalFormatSymbols getDecimalFormatSymbols() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getDecimalFormatSymbols19554)) as java.text.DecimalFormatSymbols;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getDecimalFormatSymbols19554)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalFormatSymbols19555;
		public virtual void setDecimalFormatSymbols(java.text.DecimalFormatSymbols arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setDecimalFormatSymbols19555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalFormatSymbols19555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositivePrefix19556;
		public virtual global::java.lang.String getPositivePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositivePrefix19556)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositivePrefix19556)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositivePrefix19557;
		public virtual void setPositivePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositivePrefix19557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositivePrefix19557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativePrefix19558;
		public virtual global::java.lang.String getNegativePrefix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativePrefix19558)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativePrefix19558)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePrefix19559;
		public virtual void setNegativePrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativePrefix19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativePrefix19559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositiveSuffix19560;
		public virtual global::java.lang.String getPositiveSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getPositiveSuffix19560)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositiveSuffix19560)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveSuffix19561;
		public virtual void setPositiveSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setPositiveSuffix19561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositiveSuffix19561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativeSuffix19562;
		public virtual global::java.lang.String getNegativeSuffix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._getNegativeSuffix19562)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativeSuffix19562)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeSuffix19563;
		public virtual void setNegativeSuffix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setNegativeSuffix19563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativeSuffix19563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMultiplier19564;
		public virtual int getMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getMultiplier19564);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMultiplier19564);
		}
		internal static global::MonoJavaBridge.MethodId _setMultiplier19565;
		public virtual void setMultiplier(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setMultiplier19565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMultiplier19565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGroupingSize19566;
		public virtual int getGroupingSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormat._getGroupingSize19566);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getGroupingSize19566);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSize19567;
		public virtual void setGroupingSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setGroupingSize19567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setGroupingSize19567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDecimalSeparatorAlwaysShown19568;
		public virtual bool isDecimalSeparatorAlwaysShown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown19568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown19568);
		}
		internal static global::MonoJavaBridge.MethodId _isParseBigDecimal19569;
		public virtual bool isParseBigDecimal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat._isParseBigDecimal19569);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isParseBigDecimal19569);
		}
		internal static global::MonoJavaBridge.MethodId _setParseBigDecimal19570;
		public virtual void setParseBigDecimal(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._setParseBigDecimal19570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setParseBigDecimal19570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern19571;
		public virtual global::java.lang.String toLocalizedPattern() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormat._toLocalizedPattern19571)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toLocalizedPattern19571)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern19572;
		public virtual void applyLocalizedPattern(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormat._applyLocalizedPattern19572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyLocalizedPattern19572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat19573;
		public DecimalFormat(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat19573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat19574;
		public DecimalFormat(java.lang.String arg0, java.text.DecimalFormatSymbols arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat19574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat19575;
		public DecimalFormat()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat19575);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormat"));
			global::java.text.DecimalFormat._equals19531 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormat._hashCode19532 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormat._clone19533 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormat._format19534 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format19535 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format19536 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._parse19537 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.DecimalFormat._formatToCharacterIterator19538 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.DecimalFormat._getRoundingMode19539 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.DecimalFormat._applyPattern19540 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._toPattern19541 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._getMaximumIntegerDigits19542 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMaximumIntegerDigits19543 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumIntegerDigits19544 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMinimumIntegerDigits19545 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMaximumFractionDigits19546 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMaximumFractionDigits19547 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumFractionDigits19548 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMinimumFractionDigits19549 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getCurrency19550 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormat._setCurrency19551 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormat._setRoundingMode19552 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown19553 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalSeparatorAlwaysShown", "(Z)V");
			global::java.text.DecimalFormat._getDecimalFormatSymbols19554 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormat._setDecimalFormatSymbols19555 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._getPositivePrefix19556 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositivePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositivePrefix19557 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositivePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativePrefix19558 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativePrefix19559 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getPositiveSuffix19560 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositiveSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositiveSuffix19561 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositiveSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativeSuffix19562 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativeSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativeSuffix19563 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativeSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getMultiplier19564 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMultiplier", "()I");
			global::java.text.DecimalFormat._setMultiplier19565 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMultiplier", "(I)V");
			global::java.text.DecimalFormat._getGroupingSize19566 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getGroupingSize", "()I");
			global::java.text.DecimalFormat._setGroupingSize19567 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setGroupingSize", "(I)V");
			global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown19568 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isDecimalSeparatorAlwaysShown", "()Z");
			global::java.text.DecimalFormat._isParseBigDecimal19569 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isParseBigDecimal", "()Z");
			global::java.text.DecimalFormat._setParseBigDecimal19570 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setParseBigDecimal", "(Z)V");
			global::java.text.DecimalFormat._toLocalizedPattern19571 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._applyLocalizedPattern19572 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat19573 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat19574 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._DecimalFormat19575 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "()V");
		}
	}
}
