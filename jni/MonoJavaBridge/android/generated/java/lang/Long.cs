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
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros20125;
		public static int numberOfLeadingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfLeadingZeros20125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros20126;
		public static int numberOfTrailingZeros(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._numberOfTrailingZeros20126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount20127;
		public static int bitCount(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._bitCount20127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20128;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Long._equals20128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._equals20128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20129;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Long._toString20129)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._toString20129)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20130;
		public static global::java.lang.String toString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString20130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20131;
		public static global::java.lang.String toString(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toString20131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20132;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._hashCode20132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._hashCode20132);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20133;
		public static long reverseBytes(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverseBytes20133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20134;
		public int compareTo(java.lang.Long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo20134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo20134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20135;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._compareTo20135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._compareTo20135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong20136;
		public static global::java.lang.Long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong20137;
		public static global::java.lang.Long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getLong20138;
		public static global::java.lang.Long getLong(java.lang.String arg0, java.lang.Long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._getLong20138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20139;
		public static global::java.lang.String toHexString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toHexString20139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20140;
		public static global::java.lang.Long valueOf(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20141;
		public static global::java.lang.Long valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20142;
		public static global::java.lang.Long valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._valueOf20142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _decode20143;
		public static global::java.lang.Long decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._decode20143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20144;
		public static long reverse(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._reverse20144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20145;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Long._byteValue20145);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._byteValue20145);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20146;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Long._shortValue20146);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._shortValue20146);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20147;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Long._intValue20147);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._intValue20147);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20148;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Long._longValue20148);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._longValue20148);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20149;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Long._floatValue20149);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._floatValue20149);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20150;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Long._doubleValue20150);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Long.staticClass, global::java.lang.Long._doubleValue20150);
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString20151;
		public static global::java.lang.String toOctalString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toOctalString20151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString20152;
		public static global::java.lang.String toBinaryString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._toBinaryString20152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit20153;
		public static long highestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._highestOneBit20153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit20154;
		public static long lowestOneBit(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._lowestOneBit20154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft20155;
		public static long rotateLeft(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateLeft20155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight20156;
		public static long rotateRight(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._rotateRight20156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum20157;
		public static int signum(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._signum20157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong20158;
		public static long parseLong(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong20158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseLong20159;
		public static long parseLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._parseLong20159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Long20160;
		public Long(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long20160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Long20161;
		public Long(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._Long20161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE20164;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Long.staticClass, _TYPE20164)) as java.lang.Class;
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
			global::java.lang.Long._numberOfLeadingZeros20125 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
			global::java.lang.Long._numberOfTrailingZeros20126 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
			global::java.lang.Long._bitCount20127 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "bitCount", "(J)I");
			global::java.lang.Long._equals20128 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Long._toString20129 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Long._toString20130 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toString20131 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
			global::java.lang.Long._hashCode20132 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "hashCode", "()I");
			global::java.lang.Long._reverseBytes20133 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
			global::java.lang.Long._compareTo20134 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I");
			global::java.lang.Long._compareTo20135 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Long._getLong20136 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._getLong20137 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
			global::java.lang.Long._getLong20138 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			global::java.lang.Long._toHexString20139 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
			global::java.lang.Long._valueOf20140 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
			global::java.lang.Long._valueOf20141 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._valueOf20142 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
			global::java.lang.Long._decode20143 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
			global::java.lang.Long._reverse20144 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverse", "(J)J");
			global::java.lang.Long._byteValue20145 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "byteValue", "()B");
			global::java.lang.Long._shortValue20146 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "shortValue", "()S");
			global::java.lang.Long._intValue20147 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "intValue", "()I");
			global::java.lang.Long._longValue20148 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "longValue", "()J");
			global::java.lang.Long._floatValue20149 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "floatValue", "()F");
			global::java.lang.Long._doubleValue20150 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "doubleValue", "()D");
			global::java.lang.Long._toOctalString20151 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
			global::java.lang.Long._toBinaryString20152 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
			global::java.lang.Long._highestOneBit20153 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
			global::java.lang.Long._lowestOneBit20154 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
			global::java.lang.Long._rotateLeft20155 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
			global::java.lang.Long._rotateRight20156 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
			global::java.lang.Long._signum20157 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "signum", "(J)I");
			global::java.lang.Long._parseLong20158 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
			global::java.lang.Long._parseLong20159 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
			global::java.lang.Long._Long20160 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(J)V");
			global::java.lang.Long._Long20161 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Long._TYPE20164 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Long.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
