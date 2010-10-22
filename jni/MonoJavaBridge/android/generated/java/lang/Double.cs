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
		internal static global::MonoJavaBridge.MethodId _equals19970;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._equals19970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._equals19970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19971;
		public static global::java.lang.String toString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toString19971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19972;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Double._toString19972)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._toString19972)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19973;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._hashCode19973);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._hashCode19973);
		}
		internal static global::MonoJavaBridge.MethodId _doubleToRawLongBits19974;
		public static long doubleToRawLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToRawLongBits19974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doubleToLongBits19975;
		public static long doubleToLongBits(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._doubleToLongBits19975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _longBitsToDouble19976;
		public static double longBitsToDouble(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._longBitsToDouble19976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19977;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo19977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo19977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19978;
		public int compareTo(java.lang.Double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._compareTo19978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._compareTo19978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString19979;
		public static global::java.lang.String toHexString(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._toHexString19979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19980;
		public static global::java.lang.Double valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf19980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19981;
		public static global::java.lang.Double valueOf(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._valueOf19981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _compare19982;
		public static int compare(double arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Double.staticClass, global::java.lang.Double._compare19982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNaN19983;
		public bool isNaN() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isNaN19983);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isNaN19983);
		}
		internal static global::MonoJavaBridge.MethodId _isNaN19984;
		public static bool isNaN(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isNaN19984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite19985;
		public static bool isInfinite(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._isInfinite19985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInfinite19986;
		public bool isInfinite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Double._isInfinite19986);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._isInfinite19986);
		}
		internal static global::MonoJavaBridge.MethodId _byteValue19987;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Double._byteValue19987);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._byteValue19987);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue19988;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Double._shortValue19988);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._shortValue19988);
		}
		internal static global::MonoJavaBridge.MethodId _intValue19989;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Double._intValue19989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._intValue19989);
		}
		internal static global::MonoJavaBridge.MethodId _longValue19990;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Double._longValue19990);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._longValue19990);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue19991;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Double._floatValue19991);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._floatValue19991);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue19992;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Double._doubleValue19992);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Double.staticClass, global::java.lang.Double._doubleValue19992);
		}
		internal static global::MonoJavaBridge.MethodId _parseDouble19993;
		public static double parseDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._parseDouble19993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Double19994;
		public Double(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double19994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Double19995;
		public Double(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._Double19995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Double.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Double"));
			global::java.lang.Double._equals19970 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Double._toString19971 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
			global::java.lang.Double._toString19972 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Double._hashCode19973 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "hashCode", "()I");
			global::java.lang.Double._doubleToRawLongBits19974 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
			global::java.lang.Double._doubleToLongBits19975 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
			global::java.lang.Double._longBitsToDouble19976 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
			global::java.lang.Double._compareTo19977 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Double._compareTo19978 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I");
			global::java.lang.Double._toHexString19979 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
			global::java.lang.Double._valueOf19980 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
			global::java.lang.Double._valueOf19981 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
			global::java.lang.Double._compare19982 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "compare", "(DD)I");
			global::java.lang.Double._isNaN19983 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "()Z");
			global::java.lang.Double._isNaN19984 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
			global::java.lang.Double._isInfinite19985 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
			global::java.lang.Double._isInfinite19986 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "()Z");
			global::java.lang.Double._byteValue19987 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "byteValue", "()B");
			global::java.lang.Double._shortValue19988 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "shortValue", "()S");
			global::java.lang.Double._intValue19989 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "intValue", "()I");
			global::java.lang.Double._longValue19990 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "longValue", "()J");
			global::java.lang.Double._floatValue19991 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "floatValue", "()F");
			global::java.lang.Double._doubleValue19992 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleValue", "()D");
			global::java.lang.Double._parseDouble19993 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
			global::java.lang.Double._Double19994 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(D)V");
			global::java.lang.Double._Double19995 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
