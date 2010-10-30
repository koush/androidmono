namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Integer : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Integer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int numberOfLeadingZeros(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int numberOfTrailingZeros(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int bitCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Integer.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Integer._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.String toString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m5.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Integer.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Integer._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Integer.staticClass, "hashCode", "()I", ref global::java.lang.Integer._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static int reverseBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Integer._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int compareTo(java.lang.Integer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I", ref global::java.lang.Integer._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.String toHexString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.lang.Integer valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.Integer valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.Integer valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.lang.Integer decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int reverse(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverse", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Integer.staticClass, "byteValue", "()B", ref global::java.lang.Integer._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Integer.staticClass, "shortValue", "()S", ref global::java.lang.Integer._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Integer.staticClass, "intValue", "()I", ref global::java.lang.Integer._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Integer.staticClass, "longValue", "()J", ref global::java.lang.Integer._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Integer.staticClass, "floatValue", "()F", ref global::java.lang.Integer._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Integer.staticClass, "doubleValue", "()D", ref global::java.lang.Integer._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int parseInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m23.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m23 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int parseInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m24 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.lang.String toOctalString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m25 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static global::java.lang.String toBinaryString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m26.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m26 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, java.lang.Integer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m27.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m27 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static global::java.lang.Integer getInteger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m28.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m28 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m29.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m29 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static int highestOneBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m30.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m30 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static int lowestOneBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m31.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m31 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static int rotateLeft(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m32.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m32 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static int rotateRight(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m33.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m33 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static int signum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m34.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m34 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "signum", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public Integer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m35.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m35 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public Integer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Integer._m36.native == global::System.IntPtr.Zero)
				global::java.lang.Integer._m36 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE6388;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Integer.staticClass, _TYPE6388)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 32;
			}
		}
		static Integer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Integer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Integer"));
			global::java.lang.Integer._TYPE6388 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Integer.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
