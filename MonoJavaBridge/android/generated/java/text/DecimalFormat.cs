namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DecimalFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25424;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._equals25424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25425;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._hashCode25425);
		}
		internal static global::MonoJavaBridge.MethodId _clone25426;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._clone25426)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25427;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25428;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _format25429;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._format25429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parse25430;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._parse25430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25431;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._formatToCharacterIterator25431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
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
		internal static global::MonoJavaBridge.MethodId _getRoundingMode25432;
		public override global::java.math.RoundingMode getRoundingMode()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getRoundingMode25432)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _applyPattern25433;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyPattern25433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toPattern25434;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toPattern25434)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getMaximumIntegerDigits25435;
		public override int getMaximumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumIntegerDigits25435);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumIntegerDigits25436;
		public override void setMaximumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumIntegerDigits25436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumIntegerDigits25437;
		public override int getMinimumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumIntegerDigits25437);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumIntegerDigits25438;
		public override void setMinimumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumIntegerDigits25438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMaximumFractionDigits25439;
		public override int getMaximumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMaximumFractionDigits25439);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumFractionDigits25440;
		public override void setMaximumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMaximumFractionDigits25440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMinimumFractionDigits25441;
		public override int getMinimumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMinimumFractionDigits25441);
		}
		internal static global::MonoJavaBridge.MethodId _setMinimumFractionDigits25442;
		public override void setMinimumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMinimumFractionDigits25442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getCurrency25443;
		public override global::java.util.Currency getCurrency()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getCurrency25443)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency25444;
		public override void setCurrency(java.util.Currency arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setCurrency25444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRoundingMode25445;
		public override void setRoundingMode(java.math.RoundingMode arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setRoundingMode25445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool DecimalSeparatorAlwaysShown
		{
			set
			{
				setDecimalSeparatorAlwaysShown(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparatorAlwaysShown25446;
		public virtual void setDecimalSeparatorAlwaysShown(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDecimalFormatSymbols25447;
		public virtual global::java.text.DecimalFormatSymbols getDecimalFormatSymbols()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getDecimalFormatSymbols25447)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalFormatSymbols25448;
		public virtual void setDecimalFormatSymbols(java.text.DecimalFormatSymbols arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setDecimalFormatSymbols25448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositivePrefix25449;
		public virtual global::java.lang.String getPositivePrefix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositivePrefix25449)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositivePrefix25450;
		public virtual void setPositivePrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositivePrefix25450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativePrefix25451;
		public virtual global::java.lang.String getNegativePrefix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativePrefix25451)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativePrefix25452;
		public virtual void setNegativePrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativePrefix25452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPositiveSuffix25453;
		public virtual global::java.lang.String getPositiveSuffix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getPositiveSuffix25453)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPositiveSuffix25454;
		public virtual void setPositiveSuffix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setPositiveSuffix25454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNegativeSuffix25455;
		public virtual global::java.lang.String getNegativeSuffix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getNegativeSuffix25455)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setNegativeSuffix25456;
		public virtual void setNegativeSuffix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setNegativeSuffix25456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMultiplier25457;
		public virtual int getMultiplier()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getMultiplier25457);
		}
		internal static global::MonoJavaBridge.MethodId _setMultiplier25458;
		public virtual void setMultiplier(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setMultiplier25458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGroupingSize25459;
		public virtual int getGroupingSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._getGroupingSize25459);
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSize25460;
		public virtual void setGroupingSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setGroupingSize25460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDecimalSeparatorAlwaysShown25461;
		public virtual bool isDecimalSeparatorAlwaysShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25461);
		}
		internal static global::MonoJavaBridge.MethodId _isParseBigDecimal25462;
		public virtual bool isParseBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._isParseBigDecimal25462);
		}
		public new bool ParseBigDecimal
		{
			set
			{
				setParseBigDecimal(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setParseBigDecimal25463;
		public virtual void setParseBigDecimal(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._setParseBigDecimal25463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLocalizedPattern25464;
		public virtual global::java.lang.String toLocalizedPattern()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._toLocalizedPattern25464)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _applyLocalizedPattern25465;
		public virtual void applyLocalizedPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._applyLocalizedPattern25465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25466;
		public DecimalFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25467;
		public DecimalFormat(java.lang.String arg0, java.text.DecimalFormatSymbols arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormat25468;
		public DecimalFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._DecimalFormat25468);
			Init(@__env, handle);
		}
		static DecimalFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormat"));
			global::java.text.DecimalFormat._equals25424 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormat._hashCode25425 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormat._clone25426 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormat._format25427 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25428 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._format25429 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.DecimalFormat._parse25430 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;");
			global::java.text.DecimalFormat._formatToCharacterIterator25431 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.DecimalFormat._getRoundingMode25432 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.text.DecimalFormat._applyPattern25433 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._toPattern25434 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._getMaximumIntegerDigits25435 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMaximumIntegerDigits25436 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumIntegerDigits25437 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumIntegerDigits", "()I");
			global::java.text.DecimalFormat._setMinimumIntegerDigits25438 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumIntegerDigits", "(I)V");
			global::java.text.DecimalFormat._getMaximumFractionDigits25439 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMaximumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMaximumFractionDigits25440 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMaximumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getMinimumFractionDigits25441 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMinimumFractionDigits", "()I");
			global::java.text.DecimalFormat._setMinimumFractionDigits25442 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMinimumFractionDigits", "(I)V");
			global::java.text.DecimalFormat._getCurrency25443 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormat._setCurrency25444 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormat._setRoundingMode25445 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V");
			global::java.text.DecimalFormat._setDecimalSeparatorAlwaysShown25446 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalSeparatorAlwaysShown", "(Z)V");
			global::java.text.DecimalFormat._getDecimalFormatSymbols25447 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormat._setDecimalFormatSymbols25448 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._getPositivePrefix25449 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositivePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositivePrefix25450 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositivePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativePrefix25451 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativePrefix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativePrefix25452 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativePrefix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getPositiveSuffix25453 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getPositiveSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setPositiveSuffix25454 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setPositiveSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getNegativeSuffix25455 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getNegativeSuffix", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._setNegativeSuffix25456 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setNegativeSuffix", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._getMultiplier25457 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getMultiplier", "()I");
			global::java.text.DecimalFormat._setMultiplier25458 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setMultiplier", "(I)V");
			global::java.text.DecimalFormat._getGroupingSize25459 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "getGroupingSize", "()I");
			global::java.text.DecimalFormat._setGroupingSize25460 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setGroupingSize", "(I)V");
			global::java.text.DecimalFormat._isDecimalSeparatorAlwaysShown25461 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isDecimalSeparatorAlwaysShown", "()Z");
			global::java.text.DecimalFormat._isParseBigDecimal25462 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "isParseBigDecimal", "()Z");
			global::java.text.DecimalFormat._setParseBigDecimal25463 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "setParseBigDecimal", "(Z)V");
			global::java.text.DecimalFormat._toLocalizedPattern25464 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;");
			global::java.text.DecimalFormat._applyLocalizedPattern25465 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25466 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormat._DecimalFormat25467 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V");
			global::java.text.DecimalFormat._DecimalFormat25468 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
