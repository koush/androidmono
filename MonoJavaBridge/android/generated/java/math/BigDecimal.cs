namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigDecimal : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BigDecimal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.math.BigDecimal add(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigDecimal.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.math.BigDecimal._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, "toString", "()Ljava/lang/String;", ref global::java.math.BigDecimal._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "hashCode", "()I", ref global::java.math.BigDecimal._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.math.BigDecimal abs()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "abs", "()Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m5) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.math.BigDecimal abs(java.math.MathContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "abs", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.math.BigDecimal pow(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "pow", "(I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.math.BigDecimal pow(int arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "pow", "(ILjava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.math.BigDecimal min(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.math.BigDecimal max(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int compareTo(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/math/BigDecimal;)I", ref global::java.math.BigDecimal._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.math.BigDecimal._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.math.BigDecimal valueOf(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m13.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m13 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(JI)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.math.BigDecimal valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m14.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m14 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(D)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.math.BigDecimal valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m15.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m15 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "valueOf", "(J)Ljava/math/BigDecimal;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "intValue", "()I", ref global::java.math.BigDecimal._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigDecimal.staticClass, "longValue", "()J", ref global::java.math.BigDecimal._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.math.BigDecimal.staticClass, "floatValue", "()F", ref global::java.math.BigDecimal._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.math.BigDecimal.staticClass, "doubleValue", "()D", ref global::java.math.BigDecimal._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int signum()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "signum", "()I", ref global::java.math.BigDecimal._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.math.BigDecimal round(java.math.MathContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "round", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.math.BigDecimal ulp()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "ulp", "()Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m22) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int scale()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "scale", "()I", ref global::java.math.BigDecimal._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.math.BigDecimal subtract(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "subtract", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.math.BigDecimal multiply(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, java.math.RoundingMode arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, java.math.RoundingMode arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;Ljava/math/RoundingMode;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::java.math.BigDecimal divide(java.math.BigDecimal arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigDecimal>(this, global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)[Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal[];
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.math.BigDecimal[] divideAndRemainder(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigDecimal>(this, global::java.math.BigDecimal.staticClass, "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal[];
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.math.BigDecimal remainder(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "remainder", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.math.BigDecimal negate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "negate", "()Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m38) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::java.math.BigDecimal negate(java.math.MathContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "negate", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.math.BigInteger toBigInteger()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "toBigInteger", "()Ljava/math/BigInteger;", ref global::java.math.BigDecimal._m40) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.math.BigDecimal setScale(int arg0, java.math.RoundingMode arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "setScale", "(ILjava/math/RoundingMode;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.math.BigDecimal setScale(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "setScale", "(II)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual global::java.math.BigDecimal setScale(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "setScale", "(I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual int precision()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "precision", "()I", ref global::java.math.BigDecimal._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0, java.math.MathContext arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual global::java.math.BigDecimal divideToIntegralValue(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual global::java.math.BigDecimal plus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "plus", "()Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m47) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::java.math.BigDecimal plus(java.math.MathContext arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "plus", "(Ljava/math/MathContext;)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual global::java.math.BigInteger unscaledValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "unscaledValue", "()Ljava/math/BigInteger;", ref global::java.math.BigDecimal._m49) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual global::java.math.BigDecimal movePointLeft(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "movePointLeft", "(I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::java.math.BigDecimal movePointRight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "movePointRight", "(I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual global::java.math.BigDecimal scaleByPowerOfTen(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual global::java.math.BigDecimal stripTrailingZeros()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "stripTrailingZeros", "()Ljava/math/BigDecimal;", ref global::java.math.BigDecimal._m53) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual global::java.lang.String toEngineeringString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, "toEngineeringString", "()Ljava/lang/String;", ref global::java.math.BigDecimal._m54) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::java.lang.String toPlainString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigDecimal.staticClass, "toPlainString", "()Ljava/lang/String;", ref global::java.math.BigDecimal._m55) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual global::java.math.BigInteger toBigIntegerExact()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigDecimal.staticClass, "toBigIntegerExact", "()Ljava/math/BigInteger;", ref global::java.math.BigDecimal._m56) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual long longValueExact()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigDecimal.staticClass, "longValueExact", "()J", ref global::java.math.BigDecimal._m57);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual int intValueExact()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigDecimal.staticClass, "intValueExact", "()I", ref global::java.math.BigDecimal._m58);
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual short shortValueExact()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.math.BigDecimal.staticClass, "shortValueExact", "()S", ref global::java.math.BigDecimal._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual byte byteValueExact()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.math.BigDecimal.staticClass, "byteValueExact", "()B", ref global::java.math.BigDecimal._m60);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public BigDecimal(char[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m61.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m61 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public BigDecimal(char[] arg0, int arg1, int arg2, java.math.MathContext arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m62.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m62 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CIILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public BigDecimal(char[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m63.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m63 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public BigDecimal(char[] arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m64.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m64 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "([CLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public BigDecimal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m65.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m65 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public BigDecimal(java.lang.String arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m66.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m66 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/lang/String;Ljava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public BigDecimal(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m67.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m67 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public BigDecimal(double arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m68.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m68 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(DLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public BigDecimal(java.math.BigInteger arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m69.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m69 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public BigDecimal(java.math.BigInteger arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m70.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m70 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;Ljava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public BigDecimal(java.math.BigInteger arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m71.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m71 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public BigDecimal(java.math.BigInteger arg0, int arg1, java.math.MathContext arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m72.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m72 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(Ljava/math/BigInteger;ILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public BigDecimal(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m73.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m73 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public BigDecimal(int arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m74.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m74 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(ILjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public BigDecimal(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m75.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m75 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public BigDecimal(long arg0, java.math.MathContext arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigDecimal._m76.native == global::System.IntPtr.Zero)
				global::java.math.BigDecimal._m76 = @__env.GetMethodIDNoThrow(global::java.math.BigDecimal.staticClass, "<init>", "(JLjava/math/MathContext;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigDecimal.staticClass, global::java.math.BigDecimal._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO6425;
		public static global::java.math.BigDecimal ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ZERO6425)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE6426;
		public static global::java.math.BigDecimal ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _ONE6426)) as java.math.BigDecimal;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN6427;
		public static global::java.math.BigDecimal TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigDecimal.staticClass, _TEN6427)) as java.math.BigDecimal;
			}
		}
		public static int ROUND_UP
		{
			get
			{
				return 0;
			}
		}
		public static int ROUND_DOWN
		{
			get
			{
				return 1;
			}
		}
		public static int ROUND_CEILING
		{
			get
			{
				return 2;
			}
		}
		public static int ROUND_FLOOR
		{
			get
			{
				return 3;
			}
		}
		public static int ROUND_HALF_UP
		{
			get
			{
				return 4;
			}
		}
		public static int ROUND_HALF_DOWN
		{
			get
			{
				return 5;
			}
		}
		public static int ROUND_HALF_EVEN
		{
			get
			{
				return 6;
			}
		}
		public static int ROUND_UNNECESSARY
		{
			get
			{
				return 7;
			}
		}
		static BigDecimal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigDecimal.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigDecimal"));
			global::java.math.BigDecimal._ZERO6425 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ZERO", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._ONE6426 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "ONE", "Ljava/math/BigDecimal;");
			global::java.math.BigDecimal._TEN6427 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigDecimal.staticClass, "TEN", "Ljava/math/BigDecimal;");
		}
	}
}
