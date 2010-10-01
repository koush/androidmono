namespace java.math
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BigInteger : java.lang.Number, java.lang.Comparable
	{
		internal static global::java.lang.Class staticClass;
		static BigInteger()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.math.BigInteger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.math.BigInteger(@__env);
			}
		}
		protected BigInteger(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _add11593;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._add11593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._add11593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bitCount11594;
		public virtual int bitCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._bitCount11594);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitCount11594);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals11595;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._equals11595, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._equals11595, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString11596;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toString11596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString11596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString11597;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toString11597));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString11597));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11598;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._hashCode11598);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._hashCode11598);
		}
		internal static global::net.sf.jni4net.jni.MethodId _abs11599;
		public virtual global::java.math.BigInteger abs() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._abs11599));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._abs11599));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pow11600;
		public virtual global::java.math.BigInteger pow(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._pow11600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._pow11600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _min11601;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._min11601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._min11601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _max11602;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._max11602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._max11602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11603;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._compareTo11603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo11603, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11604;
		public virtual int compareTo(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._compareTo11604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo11604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf11605;
		public static global::java.math.BigInteger valueOf(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, global::java.math.BigInteger._valueOf11605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intValue11606;
		public override int intValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._intValue11606);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._intValue11606);
		}
		internal static global::net.sf.jni4net.jni.MethodId _longValue11607;
		public override long longValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.math.BigInteger._longValue11607);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._longValue11607);
		}
		internal static global::net.sf.jni4net.jni.MethodId _floatValue11608;
		public override float floatValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.math.BigInteger._floatValue11608);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._floatValue11608);
		}
		internal static global::net.sf.jni4net.jni.MethodId _doubleValue11609;
		public override double doubleValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::java.math.BigInteger._doubleValue11609);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._doubleValue11609);
		}
		internal static global::net.sf.jni4net.jni.MethodId _signum11610;
		public virtual int signum() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._signum11610);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._signum11610);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toByteArray11611;
		public virtual byte[] toByteArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toByteArray11611));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toByteArray11611));
		}
		internal static global::net.sf.jni4net.jni.MethodId _and11612;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._and11612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._and11612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _or11613;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._or11613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._or11613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _xor11614;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._xor11614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._xor11614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _andNot11615;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._andNot11615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._andNot11615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bitLength11616;
		public virtual int bitLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._bitLength11616);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitLength11616);
		}
		internal static global::net.sf.jni4net.jni.MethodId _probablePrime11617;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, global::java.math.BigInteger._probablePrime11617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextProbablePrime11618;
		public virtual global::java.math.BigInteger nextProbablePrime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._nextProbablePrime11618));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._nextProbablePrime11618));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subtract11619;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._subtract11619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._subtract11619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _multiply11620;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._multiply11620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._multiply11620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _divide11621;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._divide11621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divide11621, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _divideAndRemainder11622;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._divideAndRemainder11622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divideAndRemainder11622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remainder11623;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._remainder11623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._remainder11623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gcd11624;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._gcd11624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._gcd11624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _negate11625;
		public virtual global::java.math.BigInteger negate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._negate11625));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._negate11625));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mod11626;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._mod11626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._mod11626, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _modPow11627;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._modPow11627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modPow11627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _modInverse11628;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._modInverse11628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modInverse11628, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shiftLeft11629;
		public virtual global::java.math.BigInteger shiftLeft(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._shiftLeft11629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftLeft11629, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shiftRight11630;
		public virtual global::java.math.BigInteger shiftRight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._shiftRight11630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftRight11630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _not11631;
		public virtual global::java.math.BigInteger not() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._not11631));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._not11631));
		}
		internal static global::net.sf.jni4net.jni.MethodId _testBit11632;
		public virtual bool testBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._testBit11632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._testBit11632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBit11633;
		public virtual global::java.math.BigInteger setBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._setBit11633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._setBit11633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearBit11634;
		public virtual global::java.math.BigInteger clearBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._clearBit11634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._clearBit11634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flipBit11635;
		public virtual global::java.math.BigInteger flipBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._flipBit11635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._flipBit11635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLowestSetBit11636;
		public virtual int getLowestSetBit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._getLowestSetBit11636);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._getLowestSetBit11636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isProbablePrime11637;
		public virtual bool isProbablePrime(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._isProbablePrime11637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._isProbablePrime11637, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11638;
		public BigInteger(int arg0, byte[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11638, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11639;
		public BigInteger(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11639, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11640;
		public BigInteger(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11640, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11641;
		public BigInteger(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11641, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11642;
		public BigInteger(int arg0, java.util.Random arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11642, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger11643;
		public BigInteger(int arg0, int arg1, java.util.Random arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger11643, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.FieldId _ZERO11644;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ONE11645;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TEN11646;
		public static global::java.math.BigInteger TEN
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.math.BigInteger.staticClass = @__class;
			global::java.math.BigInteger._add11593 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitCount11594 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitCount", "()I");
			global::java.math.BigInteger._equals11595 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigInteger._toString11596 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.math.BigInteger._toString11597 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigInteger._hashCode11598 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "hashCode", "()I");
			global::java.math.BigInteger._abs11599 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._pow11600 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._min11601 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._max11602 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._compareTo11603 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigInteger._compareTo11604 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I");
			global::java.math.BigInteger._valueOf11605 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			global::java.math.BigInteger._intValue11606 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "intValue", "()I");
			global::java.math.BigInteger._longValue11607 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "longValue", "()J");
			global::java.math.BigInteger._floatValue11608 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "floatValue", "()F");
			global::java.math.BigInteger._doubleValue11609 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "doubleValue", "()D");
			global::java.math.BigInteger._signum11610 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "signum", "()I");
			global::java.math.BigInteger._toByteArray11611 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toByteArray", "()[B");
			global::java.math.BigInteger._and11612 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._or11613 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._xor11614 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._andNot11615 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitLength11616 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitLength", "()I");
			global::java.math.BigInteger._probablePrime11617 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._nextProbablePrime11618 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._subtract11619 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._multiply11620 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divide11621 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divideAndRemainder11622 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;");
			global::java.math.BigInteger._remainder11623 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._gcd11624 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._negate11625 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._mod11626 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modPow11627 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modInverse11628 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftLeft11629 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftRight11630 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._not11631 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._testBit11632 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "testBit", "(I)Z");
			global::java.math.BigInteger._setBit11633 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._clearBit11634 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._flipBit11635 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._getLowestSetBit11636 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I");
			global::java.math.BigInteger._isProbablePrime11637 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z");
			global::java.math.BigInteger._BigInteger11638 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::java.math.BigInteger._BigInteger11639 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.math.BigInteger._BigInteger11640 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::java.math.BigInteger._BigInteger11641 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigInteger._BigInteger11642 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::java.math.BigInteger._BigInteger11643 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
		}
	}
}
