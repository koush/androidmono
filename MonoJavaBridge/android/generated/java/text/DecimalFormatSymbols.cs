namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DecimalFormatSymbols : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DecimalFormatSymbols(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.DecimalFormatSymbols._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "hashCode", "()I", ref global::java.text.DecimalFormatSymbols._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.DecimalFormatSymbols._m2) as java.lang.Object;
		}
		public static global::java.text.DecimalFormatSymbols Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.text.DecimalFormatSymbols getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormatSymbols._m3.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormatSymbols._m3 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "()Ljava/text/DecimalFormatSymbols;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._m3)) as java.text.DecimalFormatSymbols;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.text.DecimalFormatSymbols getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormatSymbols._m4.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormatSymbols._m4 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.DecimalFormatSymbols;
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormatSymbols._m5.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormatSymbols._m5 = @__env.GetStaticMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._m5)) as java.util.Locale[];
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual char getZeroDigit()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getZeroDigit", "()C", ref global::java.text.DecimalFormatSymbols._m6);
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.util.Currency getCurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Currency>(this, global::java.text.DecimalFormatSymbols.staticClass, "getCurrency", "()Ljava/util/Currency;", ref global::java.text.DecimalFormatSymbols._m7) as java.util.Currency;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setCurrency(java.util.Currency arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setCurrency", "(Ljava/util/Currency;)V", ref global::java.text.DecimalFormatSymbols._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getNaN()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormatSymbols.staticClass, "getNaN", "()Ljava/lang/String;", ref global::java.text.DecimalFormatSymbols._m9) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getInfinity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormatSymbols.staticClass, "getInfinity", "()Ljava/lang/String;", ref global::java.text.DecimalFormatSymbols._m10) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual char getGroupingSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getGroupingSeparator", "()C", ref global::java.text.DecimalFormatSymbols._m11);
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual char getMonetaryDecimalSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getMonetaryDecimalSeparator", "()C", ref global::java.text.DecimalFormatSymbols._m12);
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
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual char getDecimalSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getDecimalSeparator", "()C", ref global::java.text.DecimalFormatSymbols._m13);
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getExponentSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormatSymbols.staticClass, "getExponentSeparator", "()Ljava/lang/String;", ref global::java.text.DecimalFormatSymbols._m14) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual char getMinusSign()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getMinusSign", "()C", ref global::java.text.DecimalFormatSymbols._m15);
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
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getInternationalCurrencySymbol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormatSymbols.staticClass, "getInternationalCurrencySymbol", "()Ljava/lang/String;", ref global::java.text.DecimalFormatSymbols._m16) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getCurrencySymbol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.DecimalFormatSymbols.staticClass, "getCurrencySymbol", "()Ljava/lang/String;", ref global::java.text.DecimalFormatSymbols._m17) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual char getPercent()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getPercent", "()C", ref global::java.text.DecimalFormatSymbols._m18);
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
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual char getPerMill()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getPerMill", "()C", ref global::java.text.DecimalFormatSymbols._m19);
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
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual char getDigit()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getDigit", "()C", ref global::java.text.DecimalFormatSymbols._m20);
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
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual char getPatternSeparator()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "getPatternSeparator", "()C", ref global::java.text.DecimalFormatSymbols._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setZeroDigit(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setZeroDigit", "(C)V", ref global::java.text.DecimalFormatSymbols._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setGroupingSeparator(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setGroupingSeparator", "(C)V", ref global::java.text.DecimalFormatSymbols._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setDecimalSeparator(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setDecimalSeparator", "(C)V", ref global::java.text.DecimalFormatSymbols._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setPerMill(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setPerMill", "(C)V", ref global::java.text.DecimalFormatSymbols._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setPercent(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setPercent", "(C)V", ref global::java.text.DecimalFormatSymbols._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setDigit(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setDigit", "(C)V", ref global::java.text.DecimalFormatSymbols._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setPatternSeparator(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setPatternSeparator", "(C)V", ref global::java.text.DecimalFormatSymbols._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setInfinity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setInfinity", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormatSymbols._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setNaN(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setNaN", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormatSymbols._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setMinusSign(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setMinusSign", "(C)V", ref global::java.text.DecimalFormatSymbols._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setCurrencySymbol(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setCurrencySymbol", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormatSymbols._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setInternationalCurrencySymbol(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setInternationalCurrencySymbol", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormatSymbols._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setMonetaryDecimalSeparator(char arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setMonetaryDecimalSeparator", "(C)V", ref global::java.text.DecimalFormatSymbols._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setExponentSeparator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.DecimalFormatSymbols.staticClass, "setExponentSeparator", "(Ljava/lang/String;)V", ref global::java.text.DecimalFormatSymbols._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public DecimalFormatSymbols() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormatSymbols._m36.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormatSymbols._m36 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._m36);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public DecimalFormatSymbols(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.DecimalFormatSymbols._m37.native == global::System.IntPtr.Zero)
				global::java.text.DecimalFormatSymbols._m37 = @__env.GetMethodIDNoThrow(global::java.text.DecimalFormatSymbols.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.DecimalFormatSymbols.staticClass, global::java.text.DecimalFormatSymbols._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DecimalFormatSymbols()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.DecimalFormatSymbols.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/DecimalFormatSymbols"));
		}
	}
}
