namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Long : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Long(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros20243;
		public static int numberOfLeadingZeros(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfLeadingZeros20243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros20244;
		public static int numberOfTrailingZeros(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfTrailingZeros20244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount20245;
		public static int bitCount(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._bitCount20245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20246;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._equals20246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20247;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._toString20247)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20248;
		public static global::java.lang.String toString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString20248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20249;
		public static global::java.lang.String toString(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString20249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20250;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._hashCode20250);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20251;
		public static long reverseBytes(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverseBytes20251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20252;
		public int compareTo(java.lang.Long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo20252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20253;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo20253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong20254;
		public static global::java.lang.Long getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong20255;
		public static global::java.lang.Long getLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong20256;
		public static global::java.lang.Long getLong(java.lang.String arg0, java.lang.Long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20257;
		public static global::java.lang.String toHexString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toHexString20257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20258;
		public static global::java.lang.Long valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20259;
		public static global::java.lang.Long valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20260;
		public static global::java.lang.Long valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _decode20261;
		public static global::java.lang.Long decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._decode20261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20262;
		public static long reverse(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverse20262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20263;
		public sealed override byte byteValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._byteValue20263);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20264;
		public sealed override short shortValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._shortValue20264);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20265;
		public sealed override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._intValue20265);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20266;
		public sealed override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._longValue20266);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20267;
		public sealed override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._floatValue20267);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20268;
		public sealed override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._doubleValue20268);
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString20269;
		public static global::java.lang.String toOctalString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toOctalString20269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString20270;
		public static global::java.lang.String toBinaryString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toBinaryString20270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit20271;
		public static long highestOneBit(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._highestOneBit20271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit20272;
		public static long lowestOneBit(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._lowestOneBit20272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft20273;
		public static long rotateLeft(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateLeft20273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight20274;
		public static long rotateRight(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateRight20274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum20275;
		public static int signum(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._signum20275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong20276;
		public static long parseLong(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong20276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong20277;
		public static long parseLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong20277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Long20278;
		public Long(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long20278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Long20279;
		public Long(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long20279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE20282;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Long.staticClass, _TYPE20282)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 64;
			}
		}
		static Long()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Long.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Long"));
			global::java.lang.Long._numberOfLeadingZeros20243 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
			global::java.lang.Long._numberOfTrailingZeros20244 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
			global::java.lang.Long._bitCount20245 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "bitCount", "(J)I");
			global::java.lang.Long._equals20246 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Long._toString20247 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Long._toString20248 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toString20249 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
			global::java.lang.Long._hashCode20250 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "hashCode", "()I");
			global::java.lang.Long._reverseBytes20251 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
			global::java.lang.Long._compareTo20252 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I");
			global::java.lang.Long._compareTo20253 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Long._getLong20254 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._getLong20255 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
			global::java.lang.Long._getLong20256 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			global::java.lang.Long._toHexString20257 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
			global::java.lang.Long._valueOf20258 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
			global::java.lang.Long._valueOf20259 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._valueOf20260 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
			global::java.lang.Long._decode20261 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._reverse20262 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverse", "(J)J");
			global::java.lang.Long._byteValue20263 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "byteValue", "()B");
			global::java.lang.Long._shortValue20264 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "shortValue", "()S");
			global::java.lang.Long._intValue20265 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "intValue", "()I");
			global::java.lang.Long._longValue20266 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "longValue", "()J");
			global::java.lang.Long._floatValue20267 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "floatValue", "()F");
			global::java.lang.Long._doubleValue20268 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "doubleValue", "()D");
			global::java.lang.Long._toOctalString20269 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toBinaryString20270 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
			global::java.lang.Long._highestOneBit20271 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
			global::java.lang.Long._lowestOneBit20272 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
			global::java.lang.Long._rotateLeft20273 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
			global::java.lang.Long._rotateRight20274 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
			global::java.lang.Long._signum20275 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "signum", "(J)I");
			global::java.lang.Long._parseLong20276 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
			global::java.lang.Long._parseLong20277 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
			global::java.lang.Long._Long20278 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(J)V");
			global::java.lang.Long._Long20279 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Long._TYPE20282 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Long.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
