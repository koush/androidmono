namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Double : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Double(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Double._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String toString(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toString", "(D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Double.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Double._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "hashCode", "()I", ref global::java.lang.Double._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static long doubleToRawLongBits(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToRawLongBits", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static long doubleToLongBits(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m5.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "doubleToLongBits", "(D)J");
			return @__env.CallStaticLongMethod(java.lang.Double.staticClass, global::java.lang.Double._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static double longBitsToDouble(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "longBitsToDouble", "(J)D");
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Double._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public int compareTo(java.lang.Double arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "compareTo", "(Ljava/lang/Double;)I", ref global::java.lang.Double._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String toHexString(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m9.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "toHexString", "(D)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.Double valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m10.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Double;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.Double valueOf(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "valueOf", "(D)Ljava/lang/Double;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Double>(@__env.CallStaticObjectMethod(java.lang.Double.staticClass, global::java.lang.Double._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Double;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int compare(double arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "compare", "(DD)I");
			return @__env.CallStaticIntMethod(java.lang.Double.staticClass, global::java.lang.Double._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public bool isNaN()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "isNaN", "()Z", ref global::java.lang.Double._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static bool isNaN(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isNaN", "(D)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static bool isInfinite(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "isInfinite", "(D)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Double.staticClass, global::java.lang.Double._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public bool isInfinite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Double.staticClass, "isInfinite", "()Z", ref global::java.lang.Double._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Double.staticClass, "byteValue", "()B", ref global::java.lang.Double._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Double.staticClass, "shortValue", "()S", ref global::java.lang.Double._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Double.staticClass, "intValue", "()I", ref global::java.lang.Double._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Double.staticClass, "longValue", "()J", ref global::java.lang.Double._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Double.staticClass, "floatValue", "()F", ref global::java.lang.Double._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Double.staticClass, "doubleValue", "()D", ref global::java.lang.Double._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static double parseDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m23.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m23 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Double.staticClass, "parseDouble", "(Ljava/lang/String;)D");
			return @__env.CallStaticDoubleMethod(java.lang.Double.staticClass, global::java.lang.Double._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public Double(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m24 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public Double(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Double._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Double._m25 = @__env.GetMethodIDNoThrow(global::java.lang.Double.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Double.staticClass, global::java.lang.Double._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Double()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Double.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Double"));
		}
	}
}
