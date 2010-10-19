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
		internal static global::MonoJavaBridge.MethodId _equals14518;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._equals14518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._equals14518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14519;
		public static global::java.lang.String toString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toString14519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14520;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Float._toString14520)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._toString14520)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14521;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._hashCode14521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._hashCode14521);
		}
		internal static global::MonoJavaBridge.MethodId _floatToRawIntBits14522;
		public static int floatToRawIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToRawIntBits14522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _floatToIntBits14523;
		public static int floatToIntBits(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._floatToIntBits14523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intBitsToFloat14524;
		public static float intBitsToFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._intBitsToFloat14524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14525;
		public int compareTo(java.lang.Float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14526;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._compareTo14526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._compareTo14526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString14527;
		public static global::java.lang.String toHexString(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._toHexString14527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14528;
		public static global::java.lang.Float valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf14528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14529;
		public static global::java.lang.Float valueOf(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._valueOf14529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _compare14530;
		public static int compare(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._compare14530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN14531;
		public static bool isNaN(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isNaN14531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN14532;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isNaN14532);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isNaN14532);
		}
		internal static global::MonoJavaBridge.MethodId _parseFloat14533;
		public static float parseFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._parseFloat14533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite14534;
		public static bool isInfinite(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._isInfinite14534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite14535;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Float._isInfinite14535);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._isInfinite14535);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14536;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Float._byteValue14536);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._byteValue14536);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14537;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Float._shortValue14537);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._shortValue14537);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14538;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Float._intValue14538);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._intValue14538);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14539;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Float._longValue14539);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._longValue14539);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14540;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Float._floatValue14540);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._floatValue14540);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14541;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Float._doubleValue14541);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Float.staticClass, global::java.lang.Float._doubleValue14541);
		}
		internal static global::MonoJavaBridge.MethodId _Float14542;
		public Float(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float14542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float14543;
		public Float(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float14543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Float14544;
		public Float(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._Float14544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Float.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Float"));
			global::java.lang.Float._equals14518 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Float._toString14519 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "(F)Ljava/lang/String;");
			global::java.lang.Float._toString14520 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Float._hashCode14521 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "hashCode", "()I");
			global::java.lang.Float._floatToRawIntBits14522 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToRawIntBits", "(F)I");
			global::java.lang.Float._floatToIntBits14523 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToIntBits", "(F)I");
			global::java.lang.Float._intBitsToFloat14524 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "intBitsToFloat", "(I)F");
			global::java.lang.Float._compareTo14525 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Float;)I");
			global::java.lang.Float._compareTo14526 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Float._toHexString14527 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toHexString", "(F)Ljava/lang/String;");
			global::java.lang.Float._valueOf14528 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
			global::java.lang.Float._valueOf14529 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");
			global::java.lang.Float._compare14530 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "compare", "(FF)I");
			global::java.lang.Float._isNaN14531 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "(F)Z");
			global::java.lang.Float._isNaN14532 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "()Z");
			global::java.lang.Float._parseFloat14533 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "parseFloat", "(Ljava/lang/String;)F");
			global::java.lang.Float._isInfinite14534 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "(F)Z");
			global::java.lang.Float._isInfinite14535 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "()Z");
			global::java.lang.Float._byteValue14536 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "byteValue", "()B");
			global::java.lang.Float._shortValue14537 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "shortValue", "()S");
			global::java.lang.Float._intValue14538 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "intValue", "()I");
			global::java.lang.Float._longValue14539 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "longValue", "()J");
			global::java.lang.Float._floatValue14540 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "floatValue", "()F");
			global::java.lang.Float._doubleValue14541 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "doubleValue", "()D");
			global::java.lang.Float._Float14542 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(F)V");
			global::java.lang.Float._Float14543 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Float._Float14544 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(D)V");
		}
	}
}
