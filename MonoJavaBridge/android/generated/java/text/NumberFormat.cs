namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.NumberFormat_))]
	public abstract partial class NumberFormat : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NumberFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.NumberFormat.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.NumberFormat._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.NumberFormat.staticClass, "hashCode", "()I", ref global::java.text.NumberFormat._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.NumberFormat.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.text.NumberFormat._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String format(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.NumberFormat.staticClass, "format", "(J)Ljava/lang/String;", ref global::java.text.NumberFormat._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.NumberFormat.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.NumberFormat._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String format(double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.NumberFormat.staticClass, "format", "(D)Ljava/lang/String;", ref global::java.text.NumberFormat._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.text.NumberFormat getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m8.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m8 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "()Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m8)) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.text.NumberFormat getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m9.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m9 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.Number parse(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.NumberFormat.staticClass, "parse", "(Ljava/lang/String;)Ljava/lang/Number;", ref global::java.text.NumberFormat._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Number;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m12.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m12 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m12)) as java.util.Locale[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.NumberFormat.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", ref global::java.text.NumberFormat._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.math.RoundingMode getRoundingMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.math.RoundingMode>(this, global::java.text.NumberFormat.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;", ref global::java.text.NumberFormat._m14) as java.math.RoundingMode;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isParseIntegerOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.NumberFormat.staticClass, "isParseIntegerOnly", "()Z", ref global::java.text.NumberFormat._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setParseIntegerOnly(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setParseIntegerOnly", "(Z)V", ref global::java.text.NumberFormat._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.text.NumberFormat getNumberInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m17.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m17 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.text.NumberFormat getNumberInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m18.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m18 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getNumberInstance", "()Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m18)) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.text.NumberFormat getIntegerInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m19.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m19 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.text.NumberFormat getIntegerInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m20.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m20 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getIntegerInstance", "()Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m20)) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static global::java.text.NumberFormat getCurrencyInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m21.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m21 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static global::java.text.NumberFormat getCurrencyInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m22.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m22 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getCurrencyInstance", "()Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m22)) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::java.text.NumberFormat getPercentInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m23.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m23 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static global::java.text.NumberFormat getPercentInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m24.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m24 = @__env.GetStaticMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "getPercentInstance", "()Ljava/text/NumberFormat;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m24)) as java.text.NumberFormat;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isGroupingUsed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.NumberFormat.staticClass, "isGroupingUsed", "()Z", ref global::java.text.NumberFormat._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setGroupingUsed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setGroupingUsed", "(Z)V", ref global::java.text.NumberFormat._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getMaximumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.NumberFormat.staticClass, "getMaximumIntegerDigits", "()I", ref global::java.text.NumberFormat._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setMaximumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setMaximumIntegerDigits", "(I)V", ref global::java.text.NumberFormat._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getMinimumIntegerDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.NumberFormat.staticClass, "getMinimumIntegerDigits", "()I", ref global::java.text.NumberFormat._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setMinimumIntegerDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setMinimumIntegerDigits", "(I)V", ref global::java.text.NumberFormat._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int getMaximumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.NumberFormat.staticClass, "getMaximumFractionDigits", "()I", ref global::java.text.NumberFormat._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setMaximumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setMaximumFractionDigits", "(I)V", ref global::java.text.NumberFormat._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getMinimumFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.NumberFormat.staticClass, "getMinimumFractionDigits", "()I", ref global::java.text.NumberFormat._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setMinimumFractionDigits(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setMinimumFractionDigits", "(I)V", ref global::java.text.NumberFormat._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.util.Currency getCurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Currency>(this, global::java.text.NumberFormat.staticClass, "getCurrency", "()Ljava/util/Currency;", ref global::java.text.NumberFormat._m35) as java.util.Currency;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setCurrency(java.util.Currency arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setCurrency", "(Ljava/util/Currency;)V", ref global::java.text.NumberFormat._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setRoundingMode(java.math.RoundingMode arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.NumberFormat.staticClass, "setRoundingMode", "(Ljava/math/RoundingMode;)V", ref global::java.text.NumberFormat._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		protected NumberFormat() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.NumberFormat._m38.native == global::System.IntPtr.Zero)
				global::java.text.NumberFormat._m38 = @__env.GetMethodIDNoThrow(global::java.text.NumberFormat.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.NumberFormat.staticClass, global::java.text.NumberFormat._m38);
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
		static NumberFormat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.NumberFormat))]
	internal sealed partial class NumberFormat_ : java.text.NumberFormat
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NumberFormat_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.StringBuffer format(double arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.NumberFormat_.staticClass, "format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.NumberFormat_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.StringBuffer format(long arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.StringBuffer>(this, global::java.text.NumberFormat_.staticClass, "format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", ref global::java.text.NumberFormat_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.StringBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Number parse(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.NumberFormat_.staticClass, "parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", ref global::java.text.NumberFormat_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Number;
		}
		static NumberFormat_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.NumberFormat_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/NumberFormat"));
		}
	}
}
