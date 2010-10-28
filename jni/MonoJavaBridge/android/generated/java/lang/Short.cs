namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Short : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Short()
		{
			InitJNI();
		}
		internal Short(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20506;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Short._equals20506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._equals20506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20507;
		public static global::java.lang.String toString(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._toString20507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20508;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Short._toString20508)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._toString20508)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20509;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._hashCode20509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._hashCode20509);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20510;
		public static short reverseBytes(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._reverseBytes20510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20511;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo20511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo20511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20512;
		public int compareTo(java.lang.Short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo20512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo20512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20513;
		public static global::java.lang.Short valueOf(short arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20514;
		public static global::java.lang.Short valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20515;
		public static global::java.lang.Short valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf20515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _decode20516;
		public static global::java.lang.Short decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Short>(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._decode20516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20517;
		public sealed override byte byteValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Short._byteValue20517);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._byteValue20517);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20518;
		public sealed override short shortValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Short._shortValue20518);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._shortValue20518);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20519;
		public sealed override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._intValue20519);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._intValue20519);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20520;
		public sealed override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Short._longValue20520);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._longValue20520);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20521;
		public sealed override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Short._floatValue20521);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._floatValue20521);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20522;
		public sealed override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Short._doubleValue20522);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._doubleValue20522);
		}
		internal static global::MonoJavaBridge.MethodId _parseShort20523;
		public static short parseShort(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort20523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseShort20524;
		public static short parseShort(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort20524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Short20525;
		public Short(short arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short20525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Short20526;
		public Short(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Short.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Short"));
			global::java.lang.Short._equals20506 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Short._toString20507 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
			global::java.lang.Short._toString20508 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Short._hashCode20509 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "hashCode", "()I");
			global::java.lang.Short._reverseBytes20510 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
			global::java.lang.Short._compareTo20511 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Short._compareTo20512 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I");
			global::java.lang.Short._valueOf20513 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
			global::java.lang.Short._valueOf20514 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._valueOf20515 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
			global::java.lang.Short._decode20516 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._byteValue20517 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "byteValue", "()B");
			global::java.lang.Short._shortValue20518 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "shortValue", "()S");
			global::java.lang.Short._intValue20519 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "intValue", "()I");
			global::java.lang.Short._longValue20520 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "longValue", "()J");
			global::java.lang.Short._floatValue20521 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "floatValue", "()F");
			global::java.lang.Short._doubleValue20522 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "doubleValue", "()D");
			global::java.lang.Short._parseShort20523 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
			global::java.lang.Short._parseShort20524 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
			global::java.lang.Short._Short20525 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(S)V");
			global::java.lang.Short._Short20526 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Short._TYPE20529 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Short.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
