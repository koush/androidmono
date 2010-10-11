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
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros13026;
		public static int numberOfLeadingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfLeadingZeros13026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros13027;
		public static int numberOfTrailingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfTrailingZeros13027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount13028;
		public static int bitCount(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._bitCount13028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals13029;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Long._equals13029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._equals13029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13030;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Long._toString13030)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._toString13030)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString13031;
		public static global::java.lang.String toString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString13031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString13032;
		public static global::java.lang.String toString(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString13032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13033;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._hashCode13033);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._hashCode13033);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes13034;
		public static long reverseBytes(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverseBytes13034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13035;
		public int compareTo(java.lang.Long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo13035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo13035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13036;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo13036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo13036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong13037;
		public static global::java.lang.Long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong13037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong13038;
		public static global::java.lang.Long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong13038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong13039;
		public static global::java.lang.Long getLong(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong13039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _toHexString13040;
		public static global::java.lang.String toHexString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toHexString13040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13041;
		public static global::java.lang.Long valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf13041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13042;
		public static global::java.lang.Long valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf13042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13043;
		public static global::java.lang.Long valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf13043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _decode13044;
		public static global::java.lang.Long decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._decode13044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _reverse13045;
		public static long reverse(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverse13045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue13046;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Long._byteValue13046);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._byteValue13046);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue13047;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Long._shortValue13047);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._shortValue13047);
		}
		internal static global::MonoJavaBridge.MethodId _intValue13048;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._intValue13048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._intValue13048);
		}
		internal static global::MonoJavaBridge.MethodId _longValue13049;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Long._longValue13049);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._longValue13049);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue13050;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Long._floatValue13050);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._floatValue13050);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue13051;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Long._doubleValue13051);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._doubleValue13051);
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString13052;
		public static global::java.lang.String toOctalString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toOctalString13052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString13053;
		public static global::java.lang.String toBinaryString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toBinaryString13053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit13054;
		public static long highestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._highestOneBit13054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit13055;
		public static long lowestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._lowestOneBit13055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft13056;
		public static long rotateLeft(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateLeft13056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight13057;
		public static long rotateRight(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateRight13057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum13058;
		public static int signum(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._signum13058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong13059;
		public static long parseLong(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong13059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong13060;
		public static long parseLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong13060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Long13061;
		public Long(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long13061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Long13062;
		public Long(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long13062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE13063;
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
			global::java.lang.Long._numberOfLeadingZeros13026 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
			global::java.lang.Long._numberOfTrailingZeros13027 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
			global::java.lang.Long._bitCount13028 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "bitCount", "(J)I");
			global::java.lang.Long._equals13029 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Long._toString13030 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Long._toString13031 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toString13032 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
			global::java.lang.Long._hashCode13033 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "hashCode", "()I");
			global::java.lang.Long._reverseBytes13034 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
			global::java.lang.Long._compareTo13035 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I");
			global::java.lang.Long._compareTo13036 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Long._getLong13037 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._getLong13038 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
			global::java.lang.Long._getLong13039 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			global::java.lang.Long._toHexString13040 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
			global::java.lang.Long._valueOf13041 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
			global::java.lang.Long._valueOf13042 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._valueOf13043 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
			global::java.lang.Long._decode13044 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._reverse13045 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverse", "(J)J");
			global::java.lang.Long._byteValue13046 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "byteValue", "()B");
			global::java.lang.Long._shortValue13047 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "shortValue", "()S");
			global::java.lang.Long._intValue13048 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "intValue", "()I");
			global::java.lang.Long._longValue13049 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "longValue", "()J");
			global::java.lang.Long._floatValue13050 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "floatValue", "()F");
			global::java.lang.Long._doubleValue13051 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "doubleValue", "()D");
			global::java.lang.Long._toOctalString13052 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toBinaryString13053 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
			global::java.lang.Long._highestOneBit13054 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
			global::java.lang.Long._lowestOneBit13055 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
			global::java.lang.Long._rotateLeft13056 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
			global::java.lang.Long._rotateRight13057 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
			global::java.lang.Long._signum13058 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "signum", "(J)I");
			global::java.lang.Long._parseLong13059 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
			global::java.lang.Long._parseLong13060 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
			global::java.lang.Long._Long13061 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(J)V");
			global::java.lang.Long._Long13062 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
