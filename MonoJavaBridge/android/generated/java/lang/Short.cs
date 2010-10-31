namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Short : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Short(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Short.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Short._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String toString(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Short.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Short._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "hashCode", "()I", ref global::java.lang.Short._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static short reverseBytes(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Short._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public int compareTo(java.lang.Short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I", ref global::java.lang.Short._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.Short valueOf(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m7.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Short valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.Short valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m9.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Short;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.Short decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m10.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Short.staticClass, "byteValue", "()B", ref global::java.lang.Short._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Short.staticClass, "shortValue", "()S", ref global::java.lang.Short._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "intValue", "()I", ref global::java.lang.Short._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Short.staticClass, "longValue", "()J", ref global::java.lang.Short._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Short.staticClass, "floatValue", "()F", ref global::java.lang.Short._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Short.staticClass, "doubleValue", "()D", ref global::java.lang.Short._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static short parseShort(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static short parseShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m18.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Short(short arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m19.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m19 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(S)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public Short(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._m20.native == global::System.IntPtr.Zero)
				global::java.lang.Short._m20 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static short MIN_VALUE
		{
			get
			{
				return -32768;
			}
		}
		public static short MAX_VALUE
		{
			get
			{
				return 32767;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE6396;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Short.staticClass, _TYPE6396)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 16;
			}
		}
		static Short()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Short.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Short"));
			global::java.lang.Short._TYPE6396 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Short.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
