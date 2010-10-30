namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Float : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Float(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Float._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String toString(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toString", "(F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Float.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Float._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "hashCode", "()I", ref global::java.lang.Float._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int floatToRawIntBits(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToRawIntBits", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int floatToIntBits(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m5.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "floatToIntBits", "(F)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static float intBitsToFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "intBitsToFloat", "(I)F");
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int compareTo(java.lang.Float arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Float;)I", ref global::java.lang.Float._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Float._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String toHexString(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m9.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "toHexString", "(F)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.Float valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m10.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Float;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.Float valueOf(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "valueOf", "(F)Ljava/lang/Float;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Float>(@__env.CallStaticObjectMethod(java.lang.Float.staticClass, global::java.lang.Float._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Float;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int compare(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "compare", "(FF)I");
			return @__env.CallStaticIntMethod(java.lang.Float.staticClass, global::java.lang.Float._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool isNaN(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isNaN", "(F)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public bool isNaN()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "isNaN", "()Z", ref global::java.lang.Float._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static float parseFloat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "parseFloat", "(Ljava/lang/String;)F");
			return @__env.CallStaticFloatMethod(java.lang.Float.staticClass, global::java.lang.Float._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static bool isInfinite(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Float.staticClass, "isInfinite", "(F)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Float.staticClass, global::java.lang.Float._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public bool isInfinite()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Float.staticClass, "isInfinite", "()Z", ref global::java.lang.Float._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Float.staticClass, "byteValue", "()B", ref global::java.lang.Float._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Float.staticClass, "shortValue", "()S", ref global::java.lang.Float._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Float.staticClass, "intValue", "()I", ref global::java.lang.Float._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Float.staticClass, "longValue", "()J", ref global::java.lang.Float._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Float.staticClass, "floatValue", "()F", ref global::java.lang.Float._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Float.staticClass, "doubleValue", "()D", ref global::java.lang.Float._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public Float(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m24 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public Float(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m25 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public Float(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Float._m26.native == global::System.IntPtr.Zero)
				global::java.lang.Float._m26 = @__env.GetMethodIDNoThrow(global::java.lang.Float.staticClass, "<init>", "(D)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Float.staticClass, global::java.lang.Float._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Float()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Float.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Float"));
		}
		internal static void InitJNI()
		{
		}
	}
}
