namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigInteger : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BigInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int bitCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "bitCount", "()I", ref global::java.math.BigInteger._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.math.BigInteger._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String toString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;", ref global::java.math.BigInteger._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;", ref global::java.math.BigInteger._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "hashCode", "()I", ref global::java.math.BigInteger._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.math.BigInteger abs()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._m6) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.math.BigInteger pow(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.math.BigInteger._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int compareTo(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I", ref global::java.math.BigInteger._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.math.BigInteger valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m12.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m12 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "intValue", "()I", ref global::java.math.BigInteger._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.math.BigInteger.staticClass, "longValue", "()J", ref global::java.math.BigInteger._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.math.BigInteger.staticClass, "floatValue", "()F", ref global::java.math.BigInteger._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.math.BigInteger.staticClass, "doubleValue", "()D", ref global::java.math.BigInteger._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int signum()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "signum", "()I", ref global::java.math.BigInteger._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.math.BigInteger.staticClass, "toByteArray", "()[B", ref global::java.math.BigInteger._m18) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int bitLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "bitLength", "()I", ref global::java.math.BigInteger._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m24.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m24 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::java.math.BigInteger nextProbablePrime()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._m25) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.math.BigInteger>(this, global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;", ref global::java.math.BigInteger._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger[];
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::java.math.BigInteger negate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._m32) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::java.math.BigInteger shiftLeft(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.math.BigInteger shiftRight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.math.BigInteger not()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;", ref global::java.math.BigInteger._m38) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool testBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "testBit", "(I)Z", ref global::java.math.BigInteger._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Bit
		{
			set
			{
				setBit(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.math.BigInteger setBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.math.BigInteger clearBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::java.math.BigInteger flipBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;", ref global::java.math.BigInteger._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigInteger;
		}
		public new int LowestSetBit
		{
			get
			{
				return getLowestSetBit();
			}
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual int getLowestSetBit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I", ref global::java.math.BigInteger._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool isProbablePrime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z", ref global::java.math.BigInteger._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public BigInteger(int arg0, byte[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m45.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m45 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public BigInteger(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m46.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m46 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public BigInteger(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m47.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m47 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public BigInteger(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m48.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m48 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public BigInteger(int arg0, java.util.Random arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m49.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m49 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public BigInteger(int arg0, int arg1, java.util.Random arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.BigInteger._m50.native == global::System.IntPtr.Zero)
				global::java.math.BigInteger._m50 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO6421;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ZERO6421)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE6422;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ONE6422)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN6423;
		public static global::java.math.BigInteger TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _TEN6423)) as java.math.BigInteger;
			}
		}
		static BigInteger()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigInteger"));
			global::java.math.BigInteger._ZERO6421 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ZERO", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._ONE6422 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ONE", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._TEN6423 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "TEN", "Ljava/math/BigInteger;");
		}
	}
}
