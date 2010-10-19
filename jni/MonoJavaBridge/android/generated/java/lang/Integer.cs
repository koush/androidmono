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
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros14571;
		public static int numberOfLeadingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros14571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros14572;
		public static int numberOfTrailingZeros(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros14572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount14573;
		public static int bitCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._bitCount14573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals14574;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Integer._equals14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._equals14574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14575;
		public static global::java.lang.String toString(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString14575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14576;
		public static global::java.lang.String toString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString14576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14577;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Integer._toString14577)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._toString14577)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14578;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._hashCode14578);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._hashCode14578);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes14579;
		public static int reverseBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes14579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14580;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo14580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14581;
		public int compareTo(java.lang.Integer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo14581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo14581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString14582;
		public static global::java.lang.String toHexString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toHexString14582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14583;
		public static global::java.lang.Integer valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf14583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14584;
		public static global::java.lang.Integer valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf14584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14585;
		public static global::java.lang.Integer valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf14585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _decode14586;
		public static global::java.lang.Integer decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._decode14586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse14587;
		public static int reverse(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverse14587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14588;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Integer._byteValue14588);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._byteValue14588);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14589;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Integer._shortValue14589);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._shortValue14589);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14590;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._intValue14590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._intValue14590);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14591;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Integer._longValue14591);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._longValue14591);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14592;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Integer._floatValue14592);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._floatValue14592);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14593;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Integer._doubleValue14593);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._doubleValue14593);
		}
		internal static global::MonoJavaBridge.MethodId _parseInt14594;
		public static int parseInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt14594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseInt14595;
		public static int parseInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt14595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString14596;
		public static global::java.lang.String toOctalString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString14596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString14597;
		public static global::java.lang.String toBinaryString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString14597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger14598;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, java.lang.Integer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger14598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger14599;
		public static global::java.lang.Integer getInteger(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger14599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger14600;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger14600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit14601;
		public static int highestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit14601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit14602;
		public static int lowestOneBit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit14602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft14603;
		public static int rotateLeft(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft14603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight14604;
		public static int rotateRight(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight14604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum14605;
		public static int signum(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._signum14605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Integer14606;
		public Integer(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer14606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Integer14607;
		public Integer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer14607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE14608;
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
			global::java.lang.Integer._numberOfLeadingZeros14571 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
			global::java.lang.Integer._numberOfTrailingZeros14572 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
			global::java.lang.Integer._bitCount14573 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
			global::java.lang.Integer._equals14574 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Integer._toString14575 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
			global::java.lang.Integer._toString14576 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toString14577 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Integer._hashCode14578 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "hashCode", "()I");
			global::java.lang.Integer._reverseBytes14579 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
			global::java.lang.Integer._compareTo14580 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Integer._compareTo14581 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
			global::java.lang.Integer._toHexString14582 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._valueOf14583 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf14584 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf14585 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
			global::java.lang.Integer._decode14586 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._reverse14587 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverse", "(I)I");
			global::java.lang.Integer._byteValue14588 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "byteValue", "()B");
			global::java.lang.Integer._shortValue14589 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "shortValue", "()S");
			global::java.lang.Integer._intValue14590 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "intValue", "()I");
			global::java.lang.Integer._longValue14591 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "longValue", "()J");
			global::java.lang.Integer._floatValue14592 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "floatValue", "()F");
			global::java.lang.Integer._doubleValue14593 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "doubleValue", "()D");
			global::java.lang.Integer._parseInt14594 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
			global::java.lang.Integer._parseInt14595 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
			global::java.lang.Integer._toOctalString14596 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toBinaryString14597 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._getInteger14598 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger14599 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger14600 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._highestOneBit14601 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
			global::java.lang.Integer._lowestOneBit14602 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
			global::java.lang.Integer._rotateLeft14603 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
			global::java.lang.Integer._rotateRight14604 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
			global::java.lang.Integer._signum14605 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "signum", "(I)I");
			global::java.lang.Integer._Integer14606 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(I)V");
			global::java.lang.Integer._Integer14607 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
