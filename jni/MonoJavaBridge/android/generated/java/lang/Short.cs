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
		internal static global::MonoJavaBridge.MethodId _equals14873;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Short._equals14873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._equals14873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14874;
		public static global::java.lang.String toString(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._toString14874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14875;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Short._toString14875)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._toString14875)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14876;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._hashCode14876);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._hashCode14876);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes14877;
		public static short reverseBytes(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._reverseBytes14877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14878;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo14878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo14878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14879;
		public int compareTo(java.lang.Short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._compareTo14879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._compareTo14879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14880;
		public static global::java.lang.Short valueOf(short arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf14880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14881;
		public static global::java.lang.Short valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf14881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14882;
		public static global::java.lang.Short valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._valueOf14882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _decode14883;
		public static global::java.lang.Short decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Short.staticClass, global::java.lang.Short._decode14883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14884;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Short._byteValue14884);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._byteValue14884);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14885;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Short._shortValue14885);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._shortValue14885);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14886;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Short._intValue14886);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._intValue14886);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14887;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Short._longValue14887);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._longValue14887);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14888;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Short._floatValue14888);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._floatValue14888);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14889;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Short._doubleValue14889);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Short.staticClass, global::java.lang.Short._doubleValue14889);
		}
		internal static global::MonoJavaBridge.MethodId _parseShort14890;
		public static short parseShort(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort14890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseShort14891;
		public static short parseShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticShortMethod(java.lang.Short.staticClass, global::java.lang.Short._parseShort14891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Short14892;
		public Short(short arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short14892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Short14893;
		public Short(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Short.staticClass, global::java.lang.Short._Short14893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _TYPE14894;
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
			global::java.lang.Short._equals14873 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Short._toString14874 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "(S)Ljava/lang/String;");
			global::java.lang.Short._toString14875 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Short._hashCode14876 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "hashCode", "()I");
			global::java.lang.Short._reverseBytes14877 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "reverseBytes", "(S)S");
			global::java.lang.Short._compareTo14878 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Short._compareTo14879 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "compareTo", "(Ljava/lang/Short;)I");
			global::java.lang.Short._valueOf14880 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(S)Ljava/lang/Short;");
			global::java.lang.Short._valueOf14881 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._valueOf14882 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;");
			global::java.lang.Short._decode14883 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Short;");
			global::java.lang.Short._byteValue14884 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "byteValue", "()B");
			global::java.lang.Short._shortValue14885 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "shortValue", "()S");
			global::java.lang.Short._intValue14886 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "intValue", "()I");
			global::java.lang.Short._longValue14887 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "longValue", "()J");
			global::java.lang.Short._floatValue14888 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "floatValue", "()F");
			global::java.lang.Short._doubleValue14889 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "doubleValue", "()D");
			global::java.lang.Short._parseShort14890 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;I)S");
			global::java.lang.Short._parseShort14891 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Short.staticClass, "parseShort", "(Ljava/lang/String;)S");
			global::java.lang.Short._Short14892 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(S)V");
			global::java.lang.Short._Short14893 = @__env.GetMethodIDNoThrow(global::java.lang.Short.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
