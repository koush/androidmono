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
		internal static global::MonoJavaBridge.MethodId _equals20024;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._equals20024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._equals20024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20025;
		public static global::java.lang.String toString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toString20025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20026;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Float._toString20026)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._toString20026)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20027;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._hashCode20027);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._hashCode20027);
		}
		internal static global::MonoJavaBridge.MethodId _floatToRawIntBits20028;
		public static int floatToRawIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToRawIntBits20028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floatToIntBits20029;
		public static int floatToIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToIntBits20029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intBitsToFloat20030;
		public static float intBitsToFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._intBitsToFloat20030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20031;
		public int compareTo(java.lang.Float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo20031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo20031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20032;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo20032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo20032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20033;
		public static global::java.lang.String toHexString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toHexString20033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20034;
		public static global::java.lang.Float valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf20034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20035;
		public static global::java.lang.Float valueOf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf20035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _compare20036;
		public static int compare(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._compare20036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20037;
		public static bool isNaN(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isNaN20037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN20038;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isNaN20038);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isNaN20038);
		}
		internal static global::MonoJavaBridge.MethodId _parseFloat20039;
		public static float parseFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._parseFloat20039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20040;
		public static bool isInfinite(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isInfinite20040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite20041;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isInfinite20041);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isInfinite20041);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20042;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Float._byteValue20042);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._byteValue20042);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20043;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Float._shortValue20043);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._shortValue20043);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20044;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._intValue20044);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._intValue20044);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20045;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Float._longValue20045);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._longValue20045);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20046;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Float._floatValue20046);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._floatValue20046);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20047;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Float._doubleValue20047);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._doubleValue20047);
		}
		internal static global::MonoJavaBridge.MethodId _Float20048;
		public Float(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float20049;
		public Float(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float20050;
		public Float(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float20050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Float.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Float"));
			global::java.lang.Float._equals20024 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Float._toString20025 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "(F)Ljava/lang/String;");
			global::java.lang.Float._toString20026 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Float._hashCode20027 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "hashCode", "()I");
			global::java.lang.Float._floatToRawIntBits20028 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToRawIntBits", "(F)I");
			global::java.lang.Float._floatToIntBits20029 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToIntBits", "(F)I");
			global::java.lang.Float._intBitsToFloat20030 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "intBitsToFloat", "(I)F");
			global::java.lang.Float._compareTo20031 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Float;)I");
			global::java.lang.Float._compareTo20032 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Float._toHexString20033 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toHexString", "(F)Ljava/lang/String;");
			global::java.lang.Float._valueOf20034 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::java.lang.Float._valueOf20035 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");
			global::java.lang.Float._compare20036 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "compare", "(FF)I");
			global::java.lang.Float._isNaN20037 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "(F)Z");
			global::java.lang.Float._isNaN20038 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "()Z");
			global::java.lang.Float._parseFloat20039 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "parseFloat", "(Ljava/lang/String;)F");
			global::java.lang.Float._isInfinite20040 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "(F)Z");
			global::java.lang.Float._isInfinite20041 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "()Z");
			global::java.lang.Float._byteValue20042 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "byteValue", "()B");
			global::java.lang.Float._shortValue20043 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "shortValue", "()S");
			global::java.lang.Float._intValue20044 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "intValue", "()I");
			global::java.lang.Float._longValue20045 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "longValue", "()J");
			global::java.lang.Float._floatValue20046 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "floatValue", "()F");
			global::java.lang.Float._doubleValue20047 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "doubleValue", "()D");
			global::java.lang.Float._Float20048 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(F)V");
			global::java.lang.Float._Float20049 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Float._Float20050 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(D)V");
		}
	}
}
