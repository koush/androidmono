namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Double : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Double()
		{
			InitJNI();
		}
		internal Double(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals14464;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._equals14464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._equals14464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14465;
		public static global::java.lang.String toString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toString14465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14466;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Double._toString14466)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._toString14466)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14467;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._hashCode14467);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._hashCode14467);
		}
		internal static global::MonoJavaBridge.MethodId _doubleToRawLongBits14468;
		public static long doubleToRawLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToRawLongBits14468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doubleToLongBits14469;
		public static long doubleToLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToLongBits14469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _longBitsToDouble14470;
		public static double longBitsToDouble(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._longBitsToDouble14470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14471;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo14471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo14471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14472;
		public int compareTo(java.lang.Double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo14472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo14472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString14473;
		public static global::java.lang.String toHexString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toHexString14473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14474;
		public static global::java.lang.Double valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf14474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14475;
		public static global::java.lang.Double valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf14475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _compare14476;
		public static int compare(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Double.staticClass, global::java.lang.Double._compare14476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN14477;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isNaN14477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isNaN14477);
		}
		internal static global::MonoJavaBridge.MethodId _isNaN14478;
		public static bool isNaN(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isNaN14478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite14479;
		public static bool isInfinite(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isInfinite14479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite14480;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isInfinite14480);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isInfinite14480);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14481;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Double._byteValue14481);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._byteValue14481);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14482;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Double._shortValue14482);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._shortValue14482);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14483;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._intValue14483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._intValue14483);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14484;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Double._longValue14484);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._longValue14484);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14485;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Double._floatValue14485);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._floatValue14485);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14486;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Double._doubleValue14486);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._doubleValue14486);
		}
		internal static global::MonoJavaBridge.MethodId _parseDouble14487;
		public static double parseDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._parseDouble14487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Double14488;
		public Double(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double14488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Double14489;
		public Double(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double14489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Double.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Double"));
			global::java.lang.Double._equals14464 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Double._toString14465 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
			global::java.lang.Double._toString14466 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Double._hashCode14467 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "hashCode", "()I");
			global::java.lang.Double._doubleToRawLongBits14468 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
			global::java.lang.Double._doubleToLongBits14469 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
			global::java.lang.Double._longBitsToDouble14470 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
			global::java.lang.Double._compareTo14471 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Double._compareTo14472 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I");
			global::java.lang.Double._toHexString14473 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
			global::java.lang.Double._valueOf14474 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::java.lang.Double._valueOf14475 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
			global::java.lang.Double._compare14476 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "compare", "(DD)I");
			global::java.lang.Double._isNaN14477 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "()Z");
			global::java.lang.Double._isNaN14478 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
			global::java.lang.Double._isInfinite14479 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
			global::java.lang.Double._isInfinite14480 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "()Z");
			global::java.lang.Double._byteValue14481 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "byteValue", "()B");
			global::java.lang.Double._shortValue14482 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "shortValue", "()S");
			global::java.lang.Double._intValue14483 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "intValue", "()I");
			global::java.lang.Double._longValue14484 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "longValue", "()J");
			global::java.lang.Double._floatValue14485 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "floatValue", "()F");
			global::java.lang.Double._doubleValue14486 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleValue", "()D");
			global::java.lang.Double._parseDouble14487 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
			global::java.lang.Double._Double14488 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(D)V");
			global::java.lang.Double._Double14489 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
