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
		internal static global::net.sf.jni4net.jni.MethodId _add12322;
		public virtual global::java.math.BigInteger add(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._add12322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._add12322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bitCount12323;
		public virtual int bitCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._bitCount12323);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitCount12323);
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals12324;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._equals12324, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._equals12324, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12325;
		public virtual global::java.lang.String toString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toString12325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString12325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12326;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toString12326));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toString12326));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12327;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._hashCode12327);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._hashCode12327);
		}
		internal static global::net.sf.jni4net.jni.MethodId _abs12328;
		public virtual global::java.math.BigInteger abs() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._abs12328));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._abs12328));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pow12329;
		public virtual global::java.math.BigInteger pow(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._pow12329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._pow12329, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _min12330;
		public virtual global::java.math.BigInteger min(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._min12330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._min12330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _max12331;
		public virtual global::java.math.BigInteger max(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._max12331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._max12331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12332;
		public virtual int compareTo(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._compareTo12332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo12332, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12333;
		public virtual int compareTo(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._compareTo12333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._compareTo12333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf12334;
		public static global::java.math.BigInteger valueOf(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, global::java.math.BigInteger._valueOf12334, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _intValue12335;
		public override int intValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._intValue12335);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._intValue12335);
		}
		internal static global::net.sf.jni4net.jni.MethodId _longValue12336;
		public override long longValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.math.BigInteger._longValue12336);
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._longValue12336);
		}
		internal static global::net.sf.jni4net.jni.MethodId _floatValue12337;
		public override float floatValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::java.math.BigInteger._floatValue12337);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._floatValue12337);
		}
		internal static global::net.sf.jni4net.jni.MethodId _doubleValue12338;
		public override double doubleValue() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::java.math.BigInteger._doubleValue12338);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._doubleValue12338);
		}
		internal static global::net.sf.jni4net.jni.MethodId _signum12339;
		public virtual int signum() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._signum12339);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._signum12339);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toByteArray12340;
		public virtual byte[] toByteArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._toByteArray12340));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._toByteArray12340));
		}
		internal static global::net.sf.jni4net.jni.MethodId _and12341;
		public virtual global::java.math.BigInteger and(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._and12341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._and12341, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _or12342;
		public virtual global::java.math.BigInteger or(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._or12342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._or12342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _xor12343;
		public virtual global::java.math.BigInteger xor(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._xor12343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._xor12343, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _andNot12344;
		public virtual global::java.math.BigInteger andNot(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._andNot12344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._andNot12344, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bitLength12345;
		public virtual int bitLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._bitLength12345);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._bitLength12345);
		}
		internal static global::net.sf.jni4net.jni.MethodId _probablePrime12346;
		public static global::java.math.BigInteger probablePrime(int arg0, java.util.Random arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, global::java.math.BigInteger._probablePrime12346, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _nextProbablePrime12347;
		public virtual global::java.math.BigInteger nextProbablePrime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._nextProbablePrime12347));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._nextProbablePrime12347));
		}
		internal static global::net.sf.jni4net.jni.MethodId _subtract12348;
		public virtual global::java.math.BigInteger subtract(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._subtract12348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._subtract12348, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _multiply12349;
		public virtual global::java.math.BigInteger multiply(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._multiply12349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._multiply12349, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _divide12350;
		public virtual global::java.math.BigInteger divide(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._divide12350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divide12350, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _divideAndRemainder12351;
		public virtual global::java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._divideAndRemainder12351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._divideAndRemainder12351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remainder12352;
		public virtual global::java.math.BigInteger remainder(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._remainder12352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._remainder12352, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _gcd12353;
		public virtual global::java.math.BigInteger gcd(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._gcd12353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._gcd12353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _negate12354;
		public virtual global::java.math.BigInteger negate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._negate12354));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._negate12354));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mod12355;
		public virtual global::java.math.BigInteger mod(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._mod12355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._mod12355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _modPow12356;
		public virtual global::java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._modPow12356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modPow12356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _modInverse12357;
		public virtual global::java.math.BigInteger modInverse(java.math.BigInteger arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._modInverse12357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._modInverse12357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shiftLeft12358;
		public virtual global::java.math.BigInteger shiftLeft(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._shiftLeft12358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftLeft12358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shiftRight12359;
		public virtual global::java.math.BigInteger shiftRight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._shiftRight12359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._shiftRight12359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _not12360;
		public virtual global::java.math.BigInteger not() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._not12360));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._not12360));
		}
		internal static global::net.sf.jni4net.jni.MethodId _testBit12361;
		public virtual bool testBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._testBit12361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._testBit12361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBit12362;
		public virtual global::java.math.BigInteger setBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._setBit12362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._setBit12362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearBit12363;
		public virtual global::java.math.BigInteger clearBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._clearBit12363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._clearBit12363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flipBit12364;
		public virtual global::java.math.BigInteger flipBit(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, global::java.math.BigInteger._flipBit12364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._flipBit12364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLowestSetBit12365;
		public virtual int getLowestSetBit() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.math.BigInteger._getLowestSetBit12365);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._getLowestSetBit12365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isProbablePrime12366;
		public virtual bool isProbablePrime(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.math.BigInteger._isProbablePrime12366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.math.BigInteger.staticClass, global::java.math.BigInteger._isProbablePrime12366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12367;
		public BigInteger(int arg0, byte[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12367, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12368;
		public BigInteger(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12368, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12369;
		public BigInteger(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12369, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12370;
		public BigInteger(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12370, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12371;
		public BigInteger(int arg0, java.util.Random arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12371, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger12372;
		public BigInteger(int arg0, int arg1, java.util.Random arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.math.BigInteger.staticClass, global::java.math.BigInteger._BigInteger12372, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.FieldId _ZERO12373;
		public static global::java.math.BigInteger ZERO
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ONE12374;
		public static global::java.math.BigInteger ONE
		{
			get
			{
				return default(global::java.math.BigInteger);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TEN12375;
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
			global::java.math.BigInteger._add12322 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitCount12323 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitCount", "()I");
			global::java.math.BigInteger._equals12324 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.BigInteger._toString12325 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.math.BigInteger._toString12326 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.BigInteger._hashCode12327 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "hashCode", "()I");
			global::java.math.BigInteger._abs12328 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._pow12329 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._min12330 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._max12331 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._compareTo12332 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.math.BigInteger._compareTo12333 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I");
			global::java.math.BigInteger._valueOf12334 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;");
			global::java.math.BigInteger._intValue12335 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "intValue", "()I");
			global::java.math.BigInteger._longValue12336 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "longValue", "()J");
			global::java.math.BigInteger._floatValue12337 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "floatValue", "()F");
			global::java.math.BigInteger._doubleValue12338 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "doubleValue", "()D");
			global::java.math.BigInteger._signum12339 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "signum", "()I");
			global::java.math.BigInteger._toByteArray12340 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toByteArray", "()[B");
			global::java.math.BigInteger._and12341 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._or12342 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._xor12343 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._andNot12344 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._bitLength12345 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitLength", "()I");
			global::java.math.BigInteger._probablePrime12346 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._nextProbablePrime12347 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._subtract12348 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._multiply12349 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divide12350 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._divideAndRemainder12351 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;");
			global::java.math.BigInteger._remainder12352 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._gcd12353 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._negate12354 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._mod12355 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modPow12356 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._modInverse12357 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftLeft12358 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._shiftRight12359 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._not12360 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;");
			global::java.math.BigInteger._testBit12361 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "testBit", "(I)Z");
			global::java.math.BigInteger._setBit12362 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._clearBit12363 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._flipBit12364 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;");
			global::java.math.BigInteger._getLowestSetBit12365 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I");
			global::java.math.BigInteger._isProbablePrime12366 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z");
			global::java.math.BigInteger._BigInteger12367 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V");
			global::java.math.BigInteger._BigInteger12368 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.math.BigInteger._BigInteger12369 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "([B)V");
			global::java.math.BigInteger._BigInteger12370 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.math.BigInteger._BigInteger12371 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V");
			global::java.math.BigInteger._BigInteger12372 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V");
		}
	}
}
