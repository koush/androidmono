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
		internal static global::MonoJavaBridge.MethodId _equals13111;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Short._equals13111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._equals13111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13112;
		public static global::java.lang.String toString(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._toString13112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString13113;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Short._toString13113)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._toString13113)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13114;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._hashCode13114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._hashCode13114);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes13115;
		public static short reverseBytes(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._reverseBytes13115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13116;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo13116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo13116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo13117;
		public int compareTo(java.lang.Short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo13117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo13117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13118;
		public static global::java.lang.Short valueOf(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf13118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13119;
		public static global::java.lang.Short valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf13119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13120;
		public static global::java.lang.Short valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf13120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _decode13121;
		public static global::java.lang.Short decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._decode13121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue13122;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Short._byteValue13122);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._byteValue13122);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue13123;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Short._shortValue13123);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._shortValue13123);
		}
		internal static global::MonoJavaBridge.MethodId _intValue13124;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._intValue13124);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._intValue13124);
		}
		internal static global::MonoJavaBridge.MethodId _longValue13125;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Short._longValue13125);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._longValue13125);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue13126;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Short._floatValue13126);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._floatValue13126);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue13127;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Short._doubleValue13127);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._doubleValue13127);
		}
		internal static global::MonoJavaBridge.MethodId _parseShort13128;
		public static short parseShort(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort13128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseShort13129;
		public static short parseShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort13129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Short13130;
		public Short(short arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short13130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Short13131;
		public Short(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short13131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE13132;
		public static global::java.lang.Class TYPE
		{
			get
			{
				return default(global::java.lang.Class);
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
			global::java.lang.Short._equals13111 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Short._toString13112 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
			global::java.lang.Short._toString13113 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Short._hashCode13114 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "hashCode", "()I");
			global::java.lang.Short._reverseBytes13115 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
			global::java.lang.Short._compareTo13116 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Short._compareTo13117 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I");
			global::java.lang.Short._valueOf13118 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
			global::java.lang.Short._valueOf13119 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._valueOf13120 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
			global::java.lang.Short._decode13121 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._byteValue13122 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "byteValue", "()B");
			global::java.lang.Short._shortValue13123 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "shortValue", "()S");
			global::java.lang.Short._intValue13124 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "intValue", "()I");
			global::java.lang.Short._longValue13125 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "longValue", "()J");
			global::java.lang.Short._floatValue13126 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "floatValue", "()F");
			global::java.lang.Short._doubleValue13127 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "doubleValue", "()D");
			global::java.lang.Short._parseShort13128 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
			global::java.lang.Short._parseShort13129 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
			global::java.lang.Short._Short13130 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(S)V");
			global::java.lang.Short._Short13131 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
