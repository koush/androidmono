namespace java.math 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BigInteger : java.lang.Number, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BigInteger() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.math.BigInteger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _add10768; 
		public virtual java.math.BigInteger add(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _add10768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _add10768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10769; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _hashCode10769); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _hashCode10769); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _abs10770; 
		public virtual java.math.BigInteger abs() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _abs10770)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _abs10770)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pow10771; 
		public virtual java.math.BigInteger pow(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _pow10771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _pow10771, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _min10772; 
		public virtual java.math.BigInteger min(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _min10772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _min10772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _max10773; 
		public virtual java.math.BigInteger max(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _max10773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _max10773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals10774; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallBooleanMethod(this, _equals10774, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.math.BigInteger.staticClass, _equals10774, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo10775; 
		public virtual int compareTo(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _compareTo10775, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _compareTo10775, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo10776; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _compareTo10776, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _compareTo10776, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10777; 
		public virtual java.lang.String toString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _toString10777, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10778; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10778)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _toString10778)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf10779; 
		public static java.math.BigInteger valueOf(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, _valueOf10779, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _intValue10780; 
		public override int intValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _intValue10780); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _intValue10780); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _longValue10781; 
		public override long longValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallLongMethod(this, _longValue10781); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.math.BigInteger.staticClass, _longValue10781); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _floatValue10782; 
		public override float floatValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallFloatMethod(this, _floatValue10782); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, java.math.BigInteger.staticClass, _floatValue10782); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doubleValue10783; 
		public override double doubleValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallDoubleMethod(this, _doubleValue10783); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, java.math.BigInteger.staticClass, _doubleValue10783); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bitCount10784; 
		public virtual int bitCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _bitCount10784); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _bitCount10784); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _signum10785; 
		public virtual int signum() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _signum10785); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _signum10785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toByteArray10786; 
		public virtual byte[] toByteArray() 
		{ 
			if (GetType() == typeof(java.math.BigInteger)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toByteArray10786)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _toByteArray10786)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _and10787; 
		public virtual java.math.BigInteger and(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _and10787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _and10787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _or10788; 
		public virtual java.math.BigInteger or(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _or10788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _or10788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _xor10789; 
		public virtual java.math.BigInteger xor(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _xor10789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _xor10789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _andNot10790; 
		public virtual java.math.BigInteger andNot(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _andNot10790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _andNot10790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bitLength10791; 
		public virtual int bitLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _bitLength10791); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _bitLength10791); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _probablePrime10792; 
		public static java.math.BigInteger probablePrime(int arg0, java.util.Random arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallStaticObjectMethodPtr(java.math.BigInteger.staticClass, _probablePrime10792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nextProbablePrime10793; 
		public virtual java.math.BigInteger nextProbablePrime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _nextProbablePrime10793)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _nextProbablePrime10793)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _subtract10794; 
		public virtual java.math.BigInteger subtract(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _subtract10794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _subtract10794, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _multiply10795; 
		public virtual java.math.BigInteger multiply(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _multiply10795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _multiply10795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _divide10796; 
		public virtual java.math.BigInteger divide(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _divide10796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _divide10796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _divideAndRemainder10797; 
		public virtual java.math.BigInteger[] divideAndRemainder(java.math.BigInteger arg0) 
		{ 
			if (GetType() == typeof(java.math.BigInteger)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _divideAndRemainder10797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _divideAndRemainder10797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remainder10798; 
		public virtual java.math.BigInteger remainder(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _remainder10798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _remainder10798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gcd10799; 
		public virtual java.math.BigInteger gcd(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _gcd10799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _gcd10799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _negate10800; 
		public virtual java.math.BigInteger negate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _negate10800)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _negate10800)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mod10801; 
		public virtual java.math.BigInteger mod(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _mod10801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _mod10801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _modPow10802; 
		public virtual java.math.BigInteger modPow(java.math.BigInteger arg0, java.math.BigInteger arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _modPow10802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _modPow10802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _modInverse10803; 
		public virtual java.math.BigInteger modInverse(java.math.BigInteger arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _modInverse10803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _modInverse10803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shiftLeft10804; 
		public virtual java.math.BigInteger shiftLeft(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _shiftLeft10804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _shiftLeft10804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shiftRight10805; 
		public virtual java.math.BigInteger shiftRight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _shiftRight10805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _shiftRight10805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _not10806; 
		public virtual java.math.BigInteger not() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _not10806)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _not10806)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _testBit10807; 
		public virtual bool testBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallBooleanMethod(this, _testBit10807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.math.BigInteger.staticClass, _testBit10807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBit10808; 
		public virtual java.math.BigInteger setBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _setBit10808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _setBit10808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearBit10809; 
		public virtual java.math.BigInteger clearBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _clearBit10809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _clearBit10809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flipBit10810; 
		public virtual java.math.BigInteger flipBit(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallObjectMethodPtr(this, _flipBit10810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.BigInteger>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.math.BigInteger.staticClass, _flipBit10810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLowestSetBit10811; 
		public virtual int getLowestSetBit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallIntMethod(this, _getLowestSetBit10811); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.math.BigInteger.staticClass, _getLowestSetBit10811); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProbablePrime10812; 
		public virtual bool isProbablePrime(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.math.BigInteger)) 
				return @__env.CallBooleanMethod(this, _isProbablePrime10812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.math.BigInteger.staticClass, _isProbablePrime10812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10813; 
		public BigInteger(int arg0, byte[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10813, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10814; 
		public BigInteger(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10814, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10815; 
		public BigInteger(int arg0, java.util.Random arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10815, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10816; 
		public BigInteger(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10816, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10817; 
		public BigInteger(int arg0, int arg1, java.util.Random arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10817, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BigInteger10818; 
		public BigInteger(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.math.BigInteger.staticClass, _BigInteger10818, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ZERO10819; 
		public static java.math.BigInteger ZERO
		{ 
			get 
			{ 
				return default(java.math.BigInteger); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ONE10820; 
		public static java.math.BigInteger ONE
		{ 
			get 
			{ 
				return default(java.math.BigInteger); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TEN10821; 
		public static java.math.BigInteger TEN
		{ 
			get 
			{ 
				return default(java.math.BigInteger); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.math.BigInteger.staticClass = @__class; 
			global::java.math.BigInteger._add10768 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "add", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._hashCode10769 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "hashCode", "()I"); 
			global::java.math.BigInteger._abs10770 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "abs", "()Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._pow10771 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "pow", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._min10772 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "min", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._max10773 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "max", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._equals10774 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.math.BigInteger._compareTo10775 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/math/BigInteger;)I"); 
			global::java.math.BigInteger._compareTo10776 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.math.BigInteger._toString10777 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "(I)Ljava/lang/String;"); 
			global::java.math.BigInteger._toString10778 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.math.BigInteger._valueOf10779 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "valueOf", "(J)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._intValue10780 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "intValue", "()I"); 
			global::java.math.BigInteger._longValue10781 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "longValue", "()J"); 
			global::java.math.BigInteger._floatValue10782 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "floatValue", "()F"); 
			global::java.math.BigInteger._doubleValue10783 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "doubleValue", "()D"); 
			global::java.math.BigInteger._bitCount10784 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitCount", "()I"); 
			global::java.math.BigInteger._signum10785 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "signum", "()I"); 
			global::java.math.BigInteger._toByteArray10786 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "toByteArray", "()[B"); 
			global::java.math.BigInteger._and10787 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "and", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._or10788 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "or", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._xor10789 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "xor", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._andNot10790 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "andNot", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._bitLength10791 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "bitLength", "()I"); 
			global::java.math.BigInteger._probablePrime10792 = @__env.GetStaticMethodID(global::java.math.BigInteger.staticClass, "probablePrime", "(ILjava/util/Random;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._nextProbablePrime10793 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "nextProbablePrime", "()Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._subtract10794 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "subtract", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._multiply10795 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "multiply", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._divide10796 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divide", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._divideAndRemainder10797 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "divideAndRemainder", "(Ljava/math/BigInteger;)[Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._remainder10798 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "remainder", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._gcd10799 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "gcd", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._negate10800 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "negate", "()Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._mod10801 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "mod", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._modPow10802 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modPow", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._modInverse10803 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "modInverse", "(Ljava/math/BigInteger;)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._shiftLeft10804 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftLeft", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._shiftRight10805 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "shiftRight", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._not10806 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "not", "()Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._testBit10807 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "testBit", "(I)Z"); 
			global::java.math.BigInteger._setBit10808 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "setBit", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._clearBit10809 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "clearBit", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._flipBit10810 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "flipBit", "(I)Ljava/math/BigInteger;"); 
			global::java.math.BigInteger._getLowestSetBit10811 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "getLowestSetBit", "()I"); 
			global::java.math.BigInteger._isProbablePrime10812 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "isProbablePrime", "(I)Z"); 
			global::java.math.BigInteger._BigInteger10813 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(I[B)V"); 
			global::java.math.BigInteger._BigInteger10814 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
			global::java.math.BigInteger._BigInteger10815 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(ILjava/util/Random;)V"); 
			global::java.math.BigInteger._BigInteger10816 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "([B)V"); 
			global::java.math.BigInteger._BigInteger10817 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(IILjava/util/Random;)V"); 
			global::java.math.BigInteger._BigInteger10818 = @__env.GetMethodID(global::java.math.BigInteger.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
