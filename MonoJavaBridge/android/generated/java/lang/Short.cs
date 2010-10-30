namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Short : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Short(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20506;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Short.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Short._equals20506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20507;
		public static global::java.lang.String toString(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._toString20507.native == global::System.IntPtr.Zero)
				global::java.lang.Short._toString20507 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._toString20507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20508;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Short.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Short._toString20508) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20509;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "hashCode", "()I", ref global::java.lang.Short._hashCode20509);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20510;
		public static short reverseBytes(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._reverseBytes20510.native == global::System.IntPtr.Zero)
				global::java.lang.Short._reverseBytes20510 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._reverseBytes20510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20511;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Short._compareTo20511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20512;
		public int compareTo(java.lang.Short arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I", ref global::java.lang.Short._compareTo20512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20513;
		public static global::java.lang.Short valueOf(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._valueOf20513.native == global::System.IntPtr.Zero)
				global::java.lang.Short._valueOf20513 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20514;
		public static global::java.lang.Short valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._valueOf20514.native == global::System.IntPtr.Zero)
				global::java.lang.Short._valueOf20514 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20515;
		public static global::java.lang.Short valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._valueOf20515.native == global::System.IntPtr.Zero)
				global::java.lang.Short._valueOf20515 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _decode20516;
		public static global::java.lang.Short decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._decode20516.native == global::System.IntPtr.Zero)
				global::java.lang.Short._decode20516 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._decode20516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20517;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Short.staticClass, "byteValue", "()B", ref global::java.lang.Short._byteValue20517);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20518;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Short.staticClass, "shortValue", "()S", ref global::java.lang.Short._shortValue20518);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20519;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Short.staticClass, "intValue", "()I", ref global::java.lang.Short._intValue20519);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20520;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Short.staticClass, "longValue", "()J", ref global::java.lang.Short._longValue20520);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20521;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Short.staticClass, "floatValue", "()F", ref global::java.lang.Short._floatValue20521);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20522;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Short.staticClass, "doubleValue", "()D", ref global::java.lang.Short._doubleValue20522);
		}
		internal static global::MonoJavaBridge.MethodId _parseShort20523;
		public static short parseShort(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._parseShort20523.native == global::System.IntPtr.Zero)
				global::java.lang.Short._parseShort20523 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort20523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseShort20524;
		public static short parseShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._parseShort20524.native == global::System.IntPtr.Zero)
				global::java.lang.Short._parseShort20524 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort20524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Short20525;
		public Short(short arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._Short20525.native == global::System.IntPtr.Zero)
				global::java.lang.Short._Short20525 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(S)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short20525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Short20526;
		public Short(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Short._Short20526.native == global::System.IntPtr.Zero)
				global::java.lang.Short._Short20526 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short20526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE20529;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Short.staticClass, _TYPE20529)) as java.lang.Class;
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
			global::java.lang.Short._TYPE20529 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Short.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
