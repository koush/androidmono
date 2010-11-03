namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormat : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DecimalFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.DecimalFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "hashCode", "()I", ref global::java.text.DecimalFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.DecimalFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.DecimalFormat.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.DecimalFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.DecimalFormat.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.DecimalFormat._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.DecimalFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.DecimalFormat._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", ref global::java.text.DecimalFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Number;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.text.AttributedCharacterIterator>(this, global::java.text.DecimalFormat.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", ref global::java.text.DecimalFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.text.AttributedCharacterIterator;
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
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.math.RoundingMode getRoundingMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.math.RoundingMode>(this, global::java.text.DecimalFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;", ref global::java.text.DecimalFormat._m8) as java.math.RoundingMode;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void applyPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "applyPattern", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String toPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "toPattern", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m10) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getMaximumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getMaximumIntegerDigits", "()I", ref global::java.text.DecimalFormat._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setMaximumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setMaximumIntegerDigits", "(I)V", ref global::java.text.DecimalFormat._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getMinimumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getMinimumIntegerDigits", "()I", ref global::java.text.DecimalFormat._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void setMinimumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setMinimumIntegerDigits", "(I)V", ref global::java.text.DecimalFormat._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m15;
		public override int getMaximumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getMaximumFractionDigits", "()I", ref global::java.text.DecimalFormat._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void setMaximumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setMaximumFractionDigits", "(I)V", ref global::java.text.DecimalFormat._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m17;
		public override int getMinimumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getMinimumFractionDigits", "()I", ref global::java.text.DecimalFormat._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void setMinimumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setMinimumFractionDigits", "(I)V", ref global::java.text.DecimalFormat._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m19;
		public override global::java.util.Currency getCurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Currency>(this, global::java.text.DecimalFormat.staticClass, "getCurrency", "()Ljava/util/Currency;", ref global::java.text.DecimalFormat._m19) as java.util.Currency;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void setCurrency(java.util.Currency arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V", ref global::java.text.DecimalFormat._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override void setRoundingMode(java.math.RoundingMode arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V", ref global::java.text.DecimalFormat._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool DecimalSeparatorAlwaysShown
		{
			set
			{
				setDecimalSeparatorAlwaysShown(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setDecimalSeparatorAlwaysShown(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setDecimalSeparatorAlwaysShown", "(Z)V", ref global::java.text.DecimalFormat._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::java.text.DecimalFormatSymbols getDecimalFormatSymbols()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormat.staticClass, "getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;", ref global::java.text.DecimalFormat._m23) as java.text.DecimalFormatSymbols;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setDecimalFormatSymbols(java.text.DecimalFormatSymbols arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", ref global::java.text.DecimalFormat._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.lang.String getPositivePrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "getPositivePrefix", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m25) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setPositivePrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setPositivePrefix", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.lang.String getNegativePrefix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "getNegativePrefix", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m27) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setNegativePrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setNegativePrefix", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.lang.String getPositiveSuffix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "getPositiveSuffix", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setPositiveSuffix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setPositiveSuffix", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.lang.String getNegativeSuffix()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "getNegativeSuffix", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m31) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setNegativeSuffix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setNegativeSuffix", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getMultiplier()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getMultiplier", "()I", ref global::java.text.DecimalFormat._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setMultiplier(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setMultiplier", "(I)V", ref global::java.text.DecimalFormat._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual int getGroupingSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormat.staticClass, "getGroupingSize", "()I", ref global::java.text.DecimalFormat._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setGroupingSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setGroupingSize", "(I)V", ref global::java.text.DecimalFormat._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool isDecimalSeparatorAlwaysShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, "isDecimalSeparatorAlwaysShown", "()Z", ref global::java.text.DecimalFormat._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool isParseBigDecimal()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormat.staticClass, "isParseBigDecimal", "()Z", ref global::java.text.DecimalFormat._m38);
		}
		public new bool ParseBigDecimal
		{
			set
			{
				setParseBigDecimal(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setParseBigDecimal(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "setParseBigDecimal", "(Z)V", ref global::java.text.DecimalFormat._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.String toLocalizedPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormat.staticClass, "toLocalizedPattern", "()Ljava/lang/String;", ref global::java.text.DecimalFormat._m40) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void applyLocalizedPattern(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormat.staticClass, "applyLocalizedPattern", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormat._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public DecimalFormat(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormat._m42.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormat._m42 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public DecimalFormat(java.lang.String arg0, java.text.DecimalFormatSymbols arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormat._m43.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormat._m43 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public DecimalFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormat._m44.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormat._m44 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormat.staticClass, global::java.text.DecimalFormat._m44);
			Init(@__env, handle);
		}
		static DecimalFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormat"));
		}
	}
}
