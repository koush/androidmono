namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormatSymbols : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DecimalFormatSymbols()
		{
			InitJNI();
		}
		protected DecimalFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19576;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._equals19576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._equals19576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19577;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._hashCode19577);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._hashCode19577);
		}
		internal static global::MonoJavaBridge.MethodId _clone19578;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._clone19578)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._clone19578)) as java.lang.Object;
		}
		public static global::java.text.DecimalFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19579;
		public static global::java.text.DecimalFormatSymbols getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance19579)) as java.text.DecimalFormatSymbols;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance19580;
		public static global::java.text.DecimalFormatSymbols getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInstance19580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DecimalFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales19581;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getAvailableLocales19581)) as java.util.Locale[];
		}
		public new char ZeroDigit
		{
			get
			{
				return getZeroDigit();
			}
			set
			{
				setZeroDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZeroDigit19582;
		public virtual char getZeroDigit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getZeroDigit19582);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getZeroDigit19582);
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
		internal static global::MonoJavaBridge.MethodId _getCurrency19583;
		public virtual global::java.util.Currency getCurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrency19583)) as java.util.Currency;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrency19583)) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _setCurrency19584;
		public virtual void setCurrency(java.util.Currency arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrency19584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrency19584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String NaN
		{
			get
			{
				return getNaN();
			}
			set
			{
				setNaN(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNaN19585;
		public virtual global::java.lang.String getNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getNaN19585)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getNaN19585)) as java.lang.String;
		}
		public new global::java.lang.String Infinity
		{
			get
			{
				return getInfinity();
			}
			set
			{
				setInfinity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInfinity19586;
		public virtual global::java.lang.String getInfinity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInfinity19586)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInfinity19586)) as java.lang.String;
		}
		public new char GroupingSeparator
		{
			get
			{
				return getGroupingSeparator();
			}
			set
			{
				setGroupingSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGroupingSeparator19587;
		public virtual char getGroupingSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getGroupingSeparator19587);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getGroupingSeparator19587);
		}
		public new char MonetaryDecimalSeparator
		{
			get
			{
				return getMonetaryDecimalSeparator();
			}
			set
			{
				setMonetaryDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonetaryDecimalSeparator19588;
		public virtual char getMonetaryDecimalSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator19588);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator19588);
		}
		public new char DecimalSeparator
		{
			get
			{
				return getDecimalSeparator();
			}
			set
			{
				setDecimalSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDecimalSeparator19589;
		public virtual char getDecimalSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDecimalSeparator19589);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDecimalSeparator19589);
		}
		public new global::java.lang.String ExponentSeparator
		{
			get
			{
				return getExponentSeparator();
			}
			set
			{
				setExponentSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExponentSeparator19590;
		public virtual global::java.lang.String getExponentSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getExponentSeparator19590)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getExponentSeparator19590)) as java.lang.String;
		}
		public new char MinusSign
		{
			get
			{
				return getMinusSign();
			}
			set
			{
				setMinusSign(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinusSign19591;
		public virtual char getMinusSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getMinusSign19591);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getMinusSign19591);
		}
		public new global::java.lang.String InternationalCurrencySymbol
		{
			get
			{
				return getInternationalCurrencySymbol();
			}
			set
			{
				setInternationalCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInternationalCurrencySymbol19592;
		public virtual global::java.lang.String getInternationalCurrencySymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol19592)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol19592)) as java.lang.String;
		}
		public new global::java.lang.String CurrencySymbol
		{
			get
			{
				return getCurrencySymbol();
			}
			set
			{
				setCurrencySymbol(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencySymbol19593;
		public virtual global::java.lang.String getCurrencySymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getCurrencySymbol19593)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getCurrencySymbol19593)) as java.lang.String;
		}
		public new char Percent
		{
			get
			{
				return getPercent();
			}
			set
			{
				setPercent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPercent19594;
		public virtual char getPercent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPercent19594);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPercent19594);
		}
		public new char PerMill
		{
			get
			{
				return getPerMill();
			}
			set
			{
				setPerMill(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPerMill19595;
		public virtual char getPerMill() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPerMill19595);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPerMill19595);
		}
		public new char Digit
		{
			get
			{
				return getDigit();
			}
			set
			{
				setDigit(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDigit19596;
		public virtual char getDigit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getDigit19596);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getDigit19596);
		}
		public new char PatternSeparator
		{
			get
			{
				return getPatternSeparator();
			}
			set
			{
				setPatternSeparator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPatternSeparator19597;
		public virtual char getPatternSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._getPatternSeparator19597);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._getPatternSeparator19597);
		}
		internal static global::MonoJavaBridge.MethodId _setZeroDigit19598;
		public virtual void setZeroDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setZeroDigit19598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setZeroDigit19598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGroupingSeparator19599;
		public virtual void setGroupingSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setGroupingSeparator19599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setGroupingSeparator19599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDecimalSeparator19600;
		public virtual void setDecimalSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDecimalSeparator19600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDecimalSeparator19600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPerMill19601;
		public virtual void setPerMill(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPerMill19601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPerMill19601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPercent19602;
		public virtual void setPercent(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPercent19602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPercent19602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDigit19603;
		public virtual void setDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setDigit19603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setDigit19603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPatternSeparator19604;
		public virtual void setPatternSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setPatternSeparator19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setPatternSeparator19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInfinity19605;
		public virtual void setInfinity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInfinity19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInfinity19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNaN19606;
		public virtual void setNaN(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setNaN19606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setNaN19606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinusSign19607;
		public virtual void setMinusSign(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMinusSign19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMinusSign19607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCurrencySymbol19608;
		public virtual void setCurrencySymbol(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setCurrencySymbol19608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setCurrencySymbol19608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInternationalCurrencySymbol19609;
		public virtual void setInternationalCurrencySymbol(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol19609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonetaryDecimalSeparator19610;
		public virtual void setMonetaryDecimalSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator19610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator19610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExponentSeparator19611;
		public virtual void setExponentSeparator(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols._setExponentSeparator19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._setExponentSeparator19611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols19612;
		public DecimalFormatSymbols()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols19612);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DecimalFormatSymbols19613;
		public DecimalFormatSymbols(java.util.Locale arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._DecimalFormatSymbols19613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormatSymbols"));
			global::java.text.DecimalFormatSymbols._equals19576 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.DecimalFormatSymbols._hashCode19577 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "hashCode", "()I");
			global::java.text.DecimalFormatSymbols._clone19578 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.DecimalFormatSymbols._getInstance19579 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "()Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getInstance19580 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;");
			global::java.text.DecimalFormatSymbols._getAvailableLocales19581 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.text.DecimalFormatSymbols._getZeroDigit19582 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getZeroDigit", "()C");
			global::java.text.DecimalFormatSymbols._getCurrency19583 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrency", "()Ljava/util/Currency;");
			global::java.text.DecimalFormatSymbols._setCurrency19584 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrency", "(Ljava/util/Currency;)V");
			global::java.text.DecimalFormatSymbols._getNaN19585 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getNaN", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getInfinity19586 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInfinity", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getGroupingSeparator19587 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getGroupingSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getMonetaryDecimalSeparator19588 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMonetaryDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getDecimalSeparator19589 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDecimalSeparator", "()C");
			global::java.text.DecimalFormatSymbols._getExponentSeparator19590 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getExponentSeparator", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getMinusSign19591 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getMinusSign", "()C");
			global::java.text.DecimalFormatSymbols._getInternationalCurrencySymbol19592 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInternationalCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getCurrencySymbol19593 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getCurrencySymbol", "()Ljava/lang/String;");
			global::java.text.DecimalFormatSymbols._getPercent19594 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPercent", "()C");
			global::java.text.DecimalFormatSymbols._getPerMill19595 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPerMill", "()C");
			global::java.text.DecimalFormatSymbols._getDigit19596 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getDigit", "()C");
			global::java.text.DecimalFormatSymbols._getPatternSeparator19597 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getPatternSeparator", "()C");
			global::java.text.DecimalFormatSymbols._setZeroDigit19598 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setZeroDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setGroupingSeparator19599 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setGroupingSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setDecimalSeparator19600 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setPerMill19601 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPerMill", "(C)V");
			global::java.text.DecimalFormatSymbols._setPercent19602 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPercent", "(C)V");
			global::java.text.DecimalFormatSymbols._setDigit19603 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setDigit", "(C)V");
			global::java.text.DecimalFormatSymbols._setPatternSeparator19604 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setPatternSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setInfinity19605 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInfinity", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setNaN19606 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setNaN", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMinusSign19607 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMinusSign", "(C)V");
			global::java.text.DecimalFormatSymbols._setCurrencySymbol19608 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setInternationalCurrencySymbol19609 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setInternationalCurrencySymbol", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._setMonetaryDecimalSeparator19610 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setMonetaryDecimalSeparator", "(C)V");
			global::java.text.DecimalFormatSymbols._setExponentSeparator19611 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "setExponentSeparator", "(Ljava/lang/String;)V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols19612 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "()V");
			global::java.text.DecimalFormatSymbols._DecimalFormatSymbols19613 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
