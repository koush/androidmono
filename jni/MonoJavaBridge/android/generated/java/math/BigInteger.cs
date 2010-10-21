namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BigInteger : java.lang.Number, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BigInteger()
		{
			InitJNI();
		}
		protected BigInteger(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21133;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._add21133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._add21133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitCount21134;
		public virtual int bitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._bitCount21134);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitCount21134);
		}
		internal static global::MonoJavaBridge.MethodId _equals21135;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._equals21135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._equals21135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21136;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toString21136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString21136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString21137;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toString21137)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString21137)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21138;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._hashCode21138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._hashCode21138);
		}
		internal static global::MonoJavaBridge.MethodId _abs21139;
		public virtual global::java.math.BigInteger abs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._abs21139)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._abs21139)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _pow21140;
		public virtual global::java.math.BigInteger pow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._pow21140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._pow21140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _min21141;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._min21141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._min21141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _max21142;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._max21142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._max21142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21143;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._compareTo21143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo21143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo21144;
		public virtual int compareTo(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._compareTo21144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo21144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21145;
		public static global::java.math.BigInteger valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._valueOf21145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _intValue21146;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._intValue21146);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._intValue21146);
		}
		internal static global::MonoJavaBridge.MethodId _longValue21147;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigInteger._longValue21147);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._longValue21147);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue21148;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.math.BigInteger._floatValue21148);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._floatValue21148);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue21149;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.math.BigInteger._doubleValue21149);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._doubleValue21149);
		}
		internal static global::MonoJavaBridge.MethodId _signum21150;
		public virtual int signum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._signum21150);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._signum21150);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray21151;
		public virtual byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toByteArray21151)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toByteArray21151)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _and21152;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._and21152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._and21152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _or21153;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._or21153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._or21153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _xor21154;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._xor21154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._xor21154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _andNot21155;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._andNot21155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._andNot21155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitLength21156;
		public virtual int bitLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._bitLength21156);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitLength21156);
		}
		internal static global::MonoJavaBridge.MethodId _probablePrime21157;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._probablePrime21157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextProbablePrime21158;
		public virtual global::java.math.BigInteger nextProbablePrime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._nextProbablePrime21158)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._nextProbablePrime21158)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _subtract21159;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._subtract21159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._subtract21159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _multiply21160;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._multiply21160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._multiply21160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divide21161;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._divide21161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divide21161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder21162;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigInteger>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._divideAndRemainder21162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigInteger>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divideAndRemainder21162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder21163;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._remainder21163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._remainder21163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _gcd21164;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._gcd21164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._gcd21164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _negate21165;
		public virtual global::java.math.BigInteger negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._negate21165)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._negate21165)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _mod21166;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._mod21166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._mod21166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modPow21167;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._modPow21167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modPow21167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modInverse21168;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._modInverse21168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modInverse21168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftLeft21169;
		public virtual global::java.math.BigInteger shiftLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._shiftLeft21169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftLeft21169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftRight21170;
		public virtual global::java.math.BigInteger shiftRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._shiftRight21170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftRight21170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _not21171;
		public virtual global::java.math.BigInteger not() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._not21171)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._not21171)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _testBit21172;
		public virtual bool testBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._testBit21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._testBit21172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBit21173;
		public virtual global::java.math.BigInteger setBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._setBit21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._setBit21173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _clearBit21174;
		public virtual global::java.math.BigInteger clearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._clearBit21174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._clearBit21174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _flipBit21175;
		public virtual global::java.math.BigInteger flipBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._flipBit21175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._flipBit21175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		public new int LowestSetBit
		{
			get
			{
				return getLowestSetBit();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowestSetBit21176;
		public virtual int getLowestSetBit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._getLowestSetBit21176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._getLowestSetBit21176);
		}
		internal static global::MonoJavaBridge.MethodId _isProbablePrime21177;
		public virtual bool isProbablePrime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._isProbablePrime21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._isProbablePrime21177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21178;
		public BigInteger(int arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21179;
		public BigInteger(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21180;
		public BigInteger(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21181;
		public BigInteger(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21182;
		public BigInteger(int arg0, java.util.Random arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger21183;
		public BigInteger(int arg0, int arg1, java.util.Random arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger21183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO21184;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ZERO21184)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE21185;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _ONE21185)) as java.math.BigInteger;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN21186;
		public static global::java.math.BigInteger TEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.math.BigInteger.staticClass, _TEN21186)) as java.math.BigInteger;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigInteger"));
			global::java.math.BigInteger._add21133 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitCount21134 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "bitCount", "()I");
			global::java.math.BigInteger._equals21135 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigInteger._toString21136 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.math.BigInteger._toString21137 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigInteger._hashCode21138 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "hashCode", "()I");
			global::java.math.BigInteger._abs21139 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._pow21140 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._min21141 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._max21142 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._compareTo21143 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigInteger._compareTo21144 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I");
			global::java.math.BigInteger._valueOf21145 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			global::java.math.BigInteger._intValue21146 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "intValue", "()I");
			global::java.math.BigInteger._longValue21147 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "longValue", "()J");
			global::java.math.BigInteger._floatValue21148 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "floatValue", "()F");
			global::java.math.BigInteger._doubleValue21149 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "doubleValue", "()D");
			global::java.math.BigInteger._signum21150 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "signum", "()I");
			global::java.math.BigInteger._toByteArray21151 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toByteArray", "()[B");
			global::java.math.BigInteger._and21152 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._or21153 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._xor21154 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._andNot21155 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitLength21156 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "bitLength", "()I");
			global::java.math.BigInteger._probablePrime21157 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._nextProbablePrime21158 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._subtract21159 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._multiply21160 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divide21161 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divideAndRemainder21162 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;");
			global::java.math.BigInteger._remainder21163 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._gcd21164 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._negate21165 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._mod21166 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modPow21167 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modInverse21168 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftLeft21169 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftRight21170 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._not21171 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._testBit21172 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "testBit", "(I)Z");
			global::java.math.BigInteger._setBit21173 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._clearBit21174 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._flipBit21175 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._getLowestSetBit21176 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I");
			global::java.math.BigInteger._isProbablePrime21177 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z");
			global::java.math.BigInteger._BigInteger21178 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::java.math.BigInteger._BigInteger21179 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.math.BigInteger._BigInteger21180 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::java.math.BigInteger._BigInteger21181 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigInteger._BigInteger21182 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::java.math.BigInteger._BigInteger21183 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
			global::java.math.BigInteger._ZERO21184 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ZERO", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._ONE21185 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "ONE", "Ljava/math/BigInteger;");
			global::java.math.BigInteger._TEN21186 = @__env.GetStaticFieldIDNoThrow(global::java.math.BigInteger.staticClass, "TEN", "Ljava/math/BigInteger;");
		}
	}
}
