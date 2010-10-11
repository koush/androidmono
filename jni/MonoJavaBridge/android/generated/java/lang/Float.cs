namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Float : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Float()
		{
			InitJNI();
		}
		internal Float(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12958;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._equals12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._equals12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12959;
		public static global::java.lang.String toString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toString12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12960;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Float._toString12960)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._toString12960)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12961;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._hashCode12961);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._hashCode12961);
		}
		internal static global::MonoJavaBridge.MethodId _floatToRawIntBits12962;
		public static int floatToRawIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToRawIntBits12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floatToIntBits12963;
		public static int floatToIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToIntBits12963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intBitsToFloat12964;
		public static float intBitsToFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._intBitsToFloat12964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12965;
		public int compareTo(java.lang.Float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo12965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12966;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo12966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString12967;
		public static global::java.lang.String toHexString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toHexString12967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12968;
		public static global::java.lang.Float valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf12968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12969;
		public static global::java.lang.Float valueOf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf12969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _compare12970;
		public static int compare(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._compare12970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN12971;
		public static bool isNaN(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isNaN12971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN12972;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isNaN12972);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isNaN12972);
		}
		internal static global::MonoJavaBridge.MethodId _parseFloat12973;
		public static float parseFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._parseFloat12973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite12974;
		public static bool isInfinite(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isInfinite12974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite12975;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isInfinite12975);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isInfinite12975);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue12976;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Float._byteValue12976);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._byteValue12976);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue12977;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Float._shortValue12977);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._shortValue12977);
		}
		internal static global::MonoJavaBridge.MethodId _intValue12978;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._intValue12978);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._intValue12978);
		}
		internal static global::MonoJavaBridge.MethodId _longValue12979;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Float._longValue12979);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._longValue12979);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue12980;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Float._floatValue12980);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._floatValue12980);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue12981;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Float._doubleValue12981);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._doubleValue12981);
		}
		internal static global::MonoJavaBridge.MethodId _Float12982;
		public Float(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float12982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float12983;
		public Float(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float12983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float12984;
		public Float(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float12984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Float.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Float"));
			global::java.lang.Float._equals12958 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Float._toString12959 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "(F)Ljava/lang/String;");
			global::java.lang.Float._toString12960 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Float._hashCode12961 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "hashCode", "()I");
			global::java.lang.Float._floatToRawIntBits12962 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToRawIntBits", "(F)I");
			global::java.lang.Float._floatToIntBits12963 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToIntBits", "(F)I");
			global::java.lang.Float._intBitsToFloat12964 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "intBitsToFloat", "(I)F");
			global::java.lang.Float._compareTo12965 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Float;)I");
			global::java.lang.Float._compareTo12966 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Float._toHexString12967 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toHexString", "(F)Ljava/lang/String;");
			global::java.lang.Float._valueOf12968 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::java.lang.Float._valueOf12969 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");
			global::java.lang.Float._compare12970 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "compare", "(FF)I");
			global::java.lang.Float._isNaN12971 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "(F)Z");
			global::java.lang.Float._isNaN12972 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "()Z");
			global::java.lang.Float._parseFloat12973 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "parseFloat", "(Ljava/lang/String;)F");
			global::java.lang.Float._isInfinite12974 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "(F)Z");
			global::java.lang.Float._isInfinite12975 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "()Z");
			global::java.lang.Float._byteValue12976 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "byteValue", "()B");
			global::java.lang.Float._shortValue12977 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "shortValue", "()S");
			global::java.lang.Float._intValue12978 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "intValue", "()I");
			global::java.lang.Float._longValue12979 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "longValue", "()J");
			global::java.lang.Float._floatValue12980 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "floatValue", "()F");
			global::java.lang.Float._doubleValue12981 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "doubleValue", "()D");
			global::java.lang.Float._Float12982 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(F)V");
			global::java.lang.Float._Float12983 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Float._Float12984 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(D)V");
		}
	}
}
