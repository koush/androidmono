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
		internal static global::MonoJavaBridge.MethodId _equals12916;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._equals12916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._equals12916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12917;
		public static global::java.lang.String toString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toString12917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12918;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Double._toString12918)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._toString12918)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12919;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._hashCode12919);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._hashCode12919);
		}
		internal static global::MonoJavaBridge.MethodId _doubleToRawLongBits12920;
		public static long doubleToRawLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToRawLongBits12920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doubleToLongBits12921;
		public static long doubleToLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToLongBits12921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _longBitsToDouble12922;
		public static double longBitsToDouble(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._longBitsToDouble12922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12923;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo12923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo12923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12924;
		public int compareTo(java.lang.Double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString12925;
		public static global::java.lang.String toHexString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toHexString12925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12926;
		public static global::java.lang.Double valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf12926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12927;
		public static global::java.lang.Double valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _compare12928;
		public static int compare(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Double.staticClass, global::java.lang.Double._compare12928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN12929;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isNaN12929);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isNaN12929);
		}
		internal static global::MonoJavaBridge.MethodId _isNaN12930;
		public static bool isNaN(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isNaN12930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite12931;
		public static bool isInfinite(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isInfinite12931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite12932;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isInfinite12932);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isInfinite12932);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue12933;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Double._byteValue12933);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._byteValue12933);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue12934;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Double._shortValue12934);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._shortValue12934);
		}
		internal static global::MonoJavaBridge.MethodId _intValue12935;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._intValue12935);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._intValue12935);
		}
		internal static global::MonoJavaBridge.MethodId _longValue12936;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Double._longValue12936);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._longValue12936);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue12937;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Double._floatValue12937);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._floatValue12937);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue12938;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Double._doubleValue12938);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._doubleValue12938);
		}
		internal static global::MonoJavaBridge.MethodId _parseDouble12939;
		public static double parseDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._parseDouble12939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Double12940;
		public Double(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double12940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Double12941;
		public Double(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double12941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Double.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Double"));
			global::java.lang.Double._equals12916 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Double._toString12917 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
			global::java.lang.Double._toString12918 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Double._hashCode12919 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "hashCode", "()I");
			global::java.lang.Double._doubleToRawLongBits12920 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
			global::java.lang.Double._doubleToLongBits12921 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
			global::java.lang.Double._longBitsToDouble12922 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
			global::java.lang.Double._compareTo12923 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Double._compareTo12924 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I");
			global::java.lang.Double._toHexString12925 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
			global::java.lang.Double._valueOf12926 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::java.lang.Double._valueOf12927 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
			global::java.lang.Double._compare12928 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "compare", "(DD)I");
			global::java.lang.Double._isNaN12929 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "()Z");
			global::java.lang.Double._isNaN12930 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
			global::java.lang.Double._isInfinite12931 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
			global::java.lang.Double._isInfinite12932 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "()Z");
			global::java.lang.Double._byteValue12933 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "byteValue", "()B");
			global::java.lang.Double._shortValue12934 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "shortValue", "()S");
			global::java.lang.Double._intValue12935 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "intValue", "()I");
			global::java.lang.Double._longValue12936 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "longValue", "()J");
			global::java.lang.Double._floatValue12937 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "floatValue", "()F");
			global::java.lang.Double._doubleValue12938 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleValue", "()D");
			global::java.lang.Double._parseDouble12939 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
			global::java.lang.Double._Double12940 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(D)V");
			global::java.lang.Double._Double12941 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
