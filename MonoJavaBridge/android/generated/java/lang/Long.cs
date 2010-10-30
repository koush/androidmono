namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Long : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Long(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int numberOfLeadingZeros(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int numberOfTrailingZeros(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int bitCount(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "bitCount", "(J)I");
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Long.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Long._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Long.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Long._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String toString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m5.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String toString(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Long.staticClass, "hashCode", "()I", ref global::java.lang.Long._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static long reverseBytes(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int compareTo(java.lang.Long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I", ref global::java.lang.Long._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Long._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.Long getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.lang.Long getLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.Long getLong(java.lang.String arg0, java.lang.Long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.String toHexString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.Long valueOf(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.Long valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.lang.Long valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.lang.Long decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m18.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Long>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Long;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static long reverse(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m19.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m19 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "reverse", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Long.staticClass, "byteValue", "()B", ref global::java.lang.Long._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Long.staticClass, "shortValue", "()S", ref global::java.lang.Long._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Long.staticClass, "intValue", "()I", ref global::java.lang.Long._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Long.staticClass, "longValue", "()J", ref global::java.lang.Long._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Long.staticClass, "floatValue", "()F", ref global::java.lang.Long._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Long.staticClass, "doubleValue", "()D", ref global::java.lang.Long._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static global::java.lang.String toOctalString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m26.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m26 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static global::java.lang.String toBinaryString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m27.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m27 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Long.staticClass, global::java.lang.Long._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static long highestOneBit(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m28.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m28 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static long lowestOneBit(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m29.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m29 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static long rotateLeft(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m30.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m30 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static long rotateRight(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m31.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m31 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static int signum(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m32.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m32 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "signum", "(J)I");
			return @__env.CallStaticIntMethod(java.lang.Long.staticClass, global::java.lang.Long._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static long parseLong(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m33.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m33 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static long parseLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m34.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m34 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
			return @__env.CallStaticLongMethod(java.lang.Long.staticClass, global::java.lang.Long._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public Long(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m35.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m35 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(J)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public Long(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Long._m36.native == global::System.IntPtr.Zero)
				global::java.lang.Long._m36 = @__env.GetMethodIDNoThrow(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Long.staticClass, global::java.lang.Long._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static long MIN_VALUE
		{
			get
			{
				return -9223372036854775808L;
			}
		}
		public static long MAX_VALUE
		{
			get
			{
				return 9223372036854775807L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE6392;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Long.staticClass, _TYPE6392)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 64;
			}
		}
		static Long()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Long.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Long"));
			global::java.lang.Long._TYPE6392 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Long.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
