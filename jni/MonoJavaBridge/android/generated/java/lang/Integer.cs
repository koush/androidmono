namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Integer : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Integer()
		{
			InitJNI();
		}
		internal Integer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros20077;
		public static int numberOfLeadingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros20077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros20078;
		public static int numberOfTrailingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros20078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount20079;
		public static int bitCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._bitCount20079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20080;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Integer._equals20080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._equals20080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20081;
		public static global::java.lang.String toString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString20081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20082;
		public static global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString20082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20083;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Integer._toString20083)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._toString20083)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20084;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._hashCode20084);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._hashCode20084);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20085;
		public static int reverseBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes20085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20086;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo20086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo20086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20087;
		public int compareTo(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo20087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo20087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20088;
		public static global::java.lang.String toHexString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toHexString20088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20089;
		public static global::java.lang.Integer valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20090;
		public static global::java.lang.Integer valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20091;
		public static global::java.lang.Integer valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _decode20092;
		public static global::java.lang.Integer decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._decode20092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20093;
		public static int reverse(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverse20093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20094;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Integer._byteValue20094);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._byteValue20094);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20095;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Integer._shortValue20095);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._shortValue20095);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20096;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._intValue20096);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._intValue20096);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20097;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Integer._longValue20097);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._longValue20097);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20098;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Integer._floatValue20098);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._floatValue20098);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20099;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Integer._doubleValue20099);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._doubleValue20099);
		}
		internal static global::MonoJavaBridge.MethodId _parseInt20100;
		public static int parseInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt20100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseInt20101;
		public static int parseInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt20101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString20102;
		public static global::java.lang.String toOctalString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString20102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString20103;
		public static global::java.lang.String toBinaryString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString20103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20104;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20105;
		public static global::java.lang.Integer getInteger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20106;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit20107;
		public static int highestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit20107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit20108;
		public static int lowestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit20108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft20109;
		public static int rotateLeft(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft20109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight20110;
		public static int rotateRight(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight20110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum20111;
		public static int signum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._signum20111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Integer20112;
		public Integer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer20112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Integer20113;
		public Integer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer20113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int MIN_VALUE
		{
			get
			{
				return -2147483648;
			}
		}
		public static int MAX_VALUE
		{
			get
			{
				return 2147483647;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20116;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Integer.staticClass, _TYPE20116)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 32;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Integer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Integer"));
			global::java.lang.Integer._numberOfLeadingZeros20077 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
			global::java.lang.Integer._numberOfTrailingZeros20078 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
			global::java.lang.Integer._bitCount20079 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
			global::java.lang.Integer._equals20080 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Integer._toString20081 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
			global::java.lang.Integer._toString20082 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toString20083 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Integer._hashCode20084 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "hashCode", "()I");
			global::java.lang.Integer._reverseBytes20085 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
			global::java.lang.Integer._compareTo20086 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Integer._compareTo20087 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
			global::java.lang.Integer._toHexString20088 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._valueOf20089 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf20090 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf20091 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
			global::java.lang.Integer._decode20092 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._reverse20093 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverse", "(I)I");
			global::java.lang.Integer._byteValue20094 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "byteValue", "()B");
			global::java.lang.Integer._shortValue20095 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "shortValue", "()S");
			global::java.lang.Integer._intValue20096 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "intValue", "()I");
			global::java.lang.Integer._longValue20097 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "longValue", "()J");
			global::java.lang.Integer._floatValue20098 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "floatValue", "()F");
			global::java.lang.Integer._doubleValue20099 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "doubleValue", "()D");
			global::java.lang.Integer._parseInt20100 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
			global::java.lang.Integer._parseInt20101 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
			global::java.lang.Integer._toOctalString20102 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toBinaryString20103 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._getInteger20104 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger20105 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger20106 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._highestOneBit20107 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
			global::java.lang.Integer._lowestOneBit20108 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
			global::java.lang.Integer._rotateLeft20109 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
			global::java.lang.Integer._rotateRight20110 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
			global::java.lang.Integer._signum20111 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "signum", "(I)I");
			global::java.lang.Integer._Integer20112 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(I)V");
			global::java.lang.Integer._Integer20113 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Integer._TYPE20116 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Integer.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
