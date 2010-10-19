namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Long : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Long()
		{
			InitJNI();
		}
		internal Long(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros14616;
		public static int numberOfLeadingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfLeadingZeros14616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros14617;
		public static int numberOfTrailingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfTrailingZeros14617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount14618;
		public static int bitCount(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._bitCount14618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals14619;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Long._equals14619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._equals14619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14620;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Long._toString14620)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._toString14620)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14621;
		public static global::java.lang.String toString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString14621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14622;
		public static global::java.lang.String toString(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString14622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14623;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._hashCode14623);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._hashCode14623);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes14624;
		public static long reverseBytes(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverseBytes14624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14625;
		public int compareTo(java.lang.Long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo14625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo14625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14626;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo14626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo14626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong14627;
		public static global::java.lang.Long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong14627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong14628;
		public static global::java.lang.Long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong14628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong14629;
		public static global::java.lang.Long getLong(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong14629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _toHexString14630;
		public static global::java.lang.String toHexString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toHexString14630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14631;
		public static global::java.lang.Long valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf14631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14632;
		public static global::java.lang.Long valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf14632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14633;
		public static global::java.lang.Long valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf14633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _decode14634;
		public static global::java.lang.Long decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._decode14634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _reverse14635;
		public static long reverse(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverse14635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14636;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Long._byteValue14636);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._byteValue14636);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14637;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Long._shortValue14637);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._shortValue14637);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14638;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._intValue14638);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._intValue14638);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14639;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Long._longValue14639);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._longValue14639);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14640;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Long._floatValue14640);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._floatValue14640);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14641;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Long._doubleValue14641);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._doubleValue14641);
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString14642;
		public static global::java.lang.String toOctalString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toOctalString14642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString14643;
		public static global::java.lang.String toBinaryString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toBinaryString14643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit14644;
		public static long highestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._highestOneBit14644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit14645;
		public static long lowestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._lowestOneBit14645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft14646;
		public static long rotateLeft(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateLeft14646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight14647;
		public static long rotateRight(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateRight14647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum14648;
		public static int signum(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._signum14648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong14649;
		public static long parseLong(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong14649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong14650;
		public static long parseLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong14650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Long14651;
		public Long(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long14651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Long14652;
		public Long(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long14652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static long MIN_VALUE
		{
			get
			{
				return -9223372036854775808L;
			}
		}
		public static long MAX_VALUE
		{
			get
			{
				return 9223372036854775807L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE14653;
		public static global::java.lang.Class TYPE
		{
			get
			{
				return default(global::java.lang.Class);
			}
		}
		public static int SIZE
		{
			get
			{
				return 64;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Long.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Long"));
			global::java.lang.Long._numberOfLeadingZeros14616 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
			global::java.lang.Long._numberOfTrailingZeros14617 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
			global::java.lang.Long._bitCount14618 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "bitCount", "(J)I");
			global::java.lang.Long._equals14619 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Long._toString14620 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Long._toString14621 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toString14622 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
			global::java.lang.Long._hashCode14623 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "hashCode", "()I");
			global::java.lang.Long._reverseBytes14624 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
			global::java.lang.Long._compareTo14625 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I");
			global::java.lang.Long._compareTo14626 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Long._getLong14627 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._getLong14628 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
			global::java.lang.Long._getLong14629 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			global::java.lang.Long._toHexString14630 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
			global::java.lang.Long._valueOf14631 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
			global::java.lang.Long._valueOf14632 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._valueOf14633 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
			global::java.lang.Long._decode14634 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._reverse14635 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverse", "(J)J");
			global::java.lang.Long._byteValue14636 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "byteValue", "()B");
			global::java.lang.Long._shortValue14637 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "shortValue", "()S");
			global::java.lang.Long._intValue14638 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "intValue", "()I");
			global::java.lang.Long._longValue14639 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "longValue", "()J");
			global::java.lang.Long._floatValue14640 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "floatValue", "()F");
			global::java.lang.Long._doubleValue14641 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "doubleValue", "()D");
			global::java.lang.Long._toOctalString14642 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toBinaryString14643 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
			global::java.lang.Long._highestOneBit14644 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
			global::java.lang.Long._lowestOneBit14645 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
			global::java.lang.Long._rotateLeft14646 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
			global::java.lang.Long._rotateRight14647 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
			global::java.lang.Long._signum14648 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "signum", "(J)I");
			global::java.lang.Long._parseLong14649 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
			global::java.lang.Long._parseLong14650 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
			global::java.lang.Long._Long14651 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(J)V");
			global::java.lang.Long._Long14652 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
