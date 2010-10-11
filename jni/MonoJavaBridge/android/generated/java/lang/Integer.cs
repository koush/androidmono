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
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros12987;
		public static int numberOfLeadingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros12987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros12988;
		public static int numberOfTrailingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros12988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount12989;
		public static int bitCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._bitCount12989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals12990;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Integer._equals12990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._equals12990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12991;
		public static global::java.lang.String toString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString12991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12992;
		public static global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString12992, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12993;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Integer._toString12993)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._toString12993)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12994;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._hashCode12994);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._hashCode12994);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes12995;
		public static int reverseBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes12995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12996;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo12996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12997;
		public int compareTo(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo12997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString12998;
		public static global::java.lang.String toHexString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toHexString12998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12999;
		public static global::java.lang.Integer valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf12999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13000;
		public static global::java.lang.Integer valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf13000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13001;
		public static global::java.lang.Integer valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf13001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _decode13002;
		public static global::java.lang.Integer decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._decode13002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse13003;
		public static int reverse(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverse13003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue13004;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Integer._byteValue13004);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._byteValue13004);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue13005;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Integer._shortValue13005);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._shortValue13005);
		}
		internal static global::MonoJavaBridge.MethodId _intValue13006;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._intValue13006);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._intValue13006);
		}
		internal static global::MonoJavaBridge.MethodId _longValue13007;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Integer._longValue13007);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._longValue13007);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue13008;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Integer._floatValue13008);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._floatValue13008);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue13009;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Integer._doubleValue13009);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._doubleValue13009);
		}
		internal static global::MonoJavaBridge.MethodId _parseInt13010;
		public static int parseInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt13010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseInt13011;
		public static int parseInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt13011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString13012;
		public static global::java.lang.String toOctalString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString13012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString13013;
		public static global::java.lang.String toBinaryString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString13013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger13014;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger13014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger13015;
		public static global::java.lang.Integer getInteger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger13015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger13016;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger13016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit13017;
		public static int highestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit13017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit13018;
		public static int lowestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit13018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft13019;
		public static int rotateLeft(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft13019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight13020;
		public static int rotateRight(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight13020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum13021;
		public static int signum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._signum13021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Integer13022;
		public Integer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer13022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Integer13023;
		public Integer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer13023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE13024;
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
				return 32;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Integer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Integer"));
			global::java.lang.Integer._numberOfLeadingZeros12987 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
			global::java.lang.Integer._numberOfTrailingZeros12988 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
			global::java.lang.Integer._bitCount12989 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
			global::java.lang.Integer._equals12990 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Integer._toString12991 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
			global::java.lang.Integer._toString12992 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toString12993 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Integer._hashCode12994 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "hashCode", "()I");
			global::java.lang.Integer._reverseBytes12995 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
			global::java.lang.Integer._compareTo12996 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Integer._compareTo12997 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
			global::java.lang.Integer._toHexString12998 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._valueOf12999 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf13000 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf13001 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
			global::java.lang.Integer._decode13002 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._reverse13003 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverse", "(I)I");
			global::java.lang.Integer._byteValue13004 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "byteValue", "()B");
			global::java.lang.Integer._shortValue13005 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "shortValue", "()S");
			global::java.lang.Integer._intValue13006 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "intValue", "()I");
			global::java.lang.Integer._longValue13007 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "longValue", "()J");
			global::java.lang.Integer._floatValue13008 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "floatValue", "()F");
			global::java.lang.Integer._doubleValue13009 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "doubleValue", "()D");
			global::java.lang.Integer._parseInt13010 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
			global::java.lang.Integer._parseInt13011 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
			global::java.lang.Integer._toOctalString13012 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toBinaryString13013 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._getInteger13014 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger13015 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger13016 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._highestOneBit13017 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
			global::java.lang.Integer._lowestOneBit13018 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
			global::java.lang.Integer._rotateLeft13019 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
			global::java.lang.Integer._rotateRight13020 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
			global::java.lang.Integer._signum13021 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "signum", "(I)I");
			global::java.lang.Integer._Integer13022 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(I)V");
			global::java.lang.Integer._Integer13023 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
