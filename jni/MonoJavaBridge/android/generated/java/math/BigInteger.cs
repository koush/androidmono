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
		internal static global::MonoJavaBridge.MethodId _add15589;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._add15589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._add15589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitCount15590;
		public virtual int bitCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._bitCount15590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitCount15590);
		}
		internal static global::MonoJavaBridge.MethodId _equals15591;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._equals15591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._equals15591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15592;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toString15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString15593;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toString15593)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString15593)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15594;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._hashCode15594);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._hashCode15594);
		}
		internal static global::MonoJavaBridge.MethodId _abs15595;
		public virtual global::java.math.BigInteger abs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._abs15595)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._abs15595)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _pow15596;
		public virtual global::java.math.BigInteger pow(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._pow15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._pow15596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _min15597;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._min15597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._min15597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _max15598;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._max15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._max15598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15599;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._compareTo15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo15599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo15600;
		public virtual int compareTo(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._compareTo15600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo15600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15601;
		public static global::java.math.BigInteger valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._valueOf15601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _intValue15602;
		public override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._intValue15602);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._intValue15602);
		}
		internal static global::MonoJavaBridge.MethodId _longValue15603;
		public override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.math.BigInteger._longValue15603);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._longValue15603);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue15604;
		public override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.math.BigInteger._floatValue15604);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._floatValue15604);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue15605;
		public override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.math.BigInteger._doubleValue15605);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._doubleValue15605);
		}
		internal static global::MonoJavaBridge.MethodId _signum15606;
		public virtual int signum() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._signum15606);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._signum15606);
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray15607;
		public virtual byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._toByteArray15607)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toByteArray15607)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _and15608;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._and15608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._and15608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _or15609;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._or15609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._or15609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _xor15610;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._xor15610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._xor15610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _andNot15611;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._andNot15611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._andNot15611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _bitLength15612;
		public virtual int bitLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._bitLength15612);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitLength15612);
		}
		internal static global::MonoJavaBridge.MethodId _probablePrime15613;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.BigInteger.staticClass, global::java.math.BigInteger._probablePrime15613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _nextProbablePrime15614;
		public virtual global::java.math.BigInteger nextProbablePrime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._nextProbablePrime15614)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._nextProbablePrime15614)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _subtract15615;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._subtract15615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._subtract15615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _multiply15616;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._multiply15616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._multiply15616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divide15617;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._divide15617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divide15617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _divideAndRemainder15618;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigInteger>(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._divideAndRemainder15618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.BigInteger>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divideAndRemainder15618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger[];
		}
		internal static global::MonoJavaBridge.MethodId _remainder15619;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._remainder15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._remainder15619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _gcd15620;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._gcd15620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._gcd15620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _negate15621;
		public virtual global::java.math.BigInteger negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._negate15621)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._negate15621)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _mod15622;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._mod15622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._mod15622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modPow15623;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._modPow15623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modPow15623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _modInverse15624;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._modInverse15624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modInverse15624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftLeft15625;
		public virtual global::java.math.BigInteger shiftLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._shiftLeft15625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftLeft15625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _shiftRight15626;
		public virtual global::java.math.BigInteger shiftRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._shiftRight15626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftRight15626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _not15627;
		public virtual global::java.math.BigInteger not() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._not15627)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._not15627)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _testBit15628;
		public virtual bool testBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._testBit15628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._testBit15628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBit15629;
		public virtual global::java.math.BigInteger setBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._setBit15629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._setBit15629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _clearBit15630;
		public virtual global::java.math.BigInteger clearBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._clearBit15630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._clearBit15630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _flipBit15631;
		public virtual global::java.math.BigInteger flipBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.BigInteger._flipBit15631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._flipBit15631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigInteger;
		}
		public new int LowestSetBit
		{
			get
			{
				return getLowestSetBit();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLowestSetBit15632;
		public virtual int getLowestSetBit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.BigInteger._getLowestSetBit15632);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._getLowestSetBit15632);
		}
		internal static global::MonoJavaBridge.MethodId _isProbablePrime15633;
		public virtual bool isProbablePrime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.BigInteger._isProbablePrime15633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._isProbablePrime15633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15634;
		public BigInteger(int arg0, byte[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15635;
		public BigInteger(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15636;
		public BigInteger(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15637;
		public BigInteger(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15638;
		public BigInteger(int arg0, java.util.Random arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BigInteger15639;
		public BigInteger(int arg0, int arg1, java.util.Random arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger15639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ZERO15640;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ONE15641;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TEN15642;
		public static global::java.math.BigInteger TEN
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.BigInteger.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/BigInteger"));
			global::java.math.BigInteger._add15589 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitCount15590 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "bitCount", "()I");
			global::java.math.BigInteger._equals15591 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigInteger._toString15592 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.math.BigInteger._toString15593 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigInteger._hashCode15594 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "hashCode", "()I");
			global::java.math.BigInteger._abs15595 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._pow15596 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._min15597 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._max15598 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._compareTo15599 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigInteger._compareTo15600 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I");
			global::java.math.BigInteger._valueOf15601 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			global::java.math.BigInteger._intValue15602 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "intValue", "()I");
			global::java.math.BigInteger._longValue15603 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "longValue", "()J");
			global::java.math.BigInteger._floatValue15604 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "floatValue", "()F");
			global::java.math.BigInteger._doubleValue15605 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "doubleValue", "()D");
			global::java.math.BigInteger._signum15606 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "signum", "()I");
			global::java.math.BigInteger._toByteArray15607 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "toByteArray", "()[B");
			global::java.math.BigInteger._and15608 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._or15609 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._xor15610 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._andNot15611 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitLength15612 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "bitLength", "()I");
			global::java.math.BigInteger._probablePrime15613 = @__env.GetStaticMethodIDNoThrow(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._nextProbablePrime15614 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._subtract15615 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._multiply15616 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divide15617 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divideAndRemainder15618 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;");
			global::java.math.BigInteger._remainder15619 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._gcd15620 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._negate15621 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._mod15622 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modPow15623 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modInverse15624 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftLeft15625 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftRight15626 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._not15627 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._testBit15628 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "testBit", "(I)Z");
			global::java.math.BigInteger._setBit15629 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._clearBit15630 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._flipBit15631 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._getLowestSetBit15632 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I");
			global::java.math.BigInteger._isProbablePrime15633 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z");
			global::java.math.BigInteger._BigInteger15634 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::java.math.BigInteger._BigInteger15635 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.math.BigInteger._BigInteger15636 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::java.math.BigInteger._BigInteger15637 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigInteger._BigInteger15638 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::java.math.BigInteger._BigInteger15639 = @__env.GetMethodIDNoThrow(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
		}
	}
}
