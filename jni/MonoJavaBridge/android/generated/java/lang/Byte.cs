namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Byte : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Byte()
		{
			InitJNI();
		}
		internal Byte(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals14117;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Byte._equals14117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._equals14117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14118;
		public static global::java.lang.String toString(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._toString14118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString14119;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Byte._toString14119)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._toString14119)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14120;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._hashCode14120);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._hashCode14120);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14121;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo14121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo14121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo14122;
		public int compareTo(java.lang.Byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo14122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo14122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14123;
		public static global::java.lang.Byte valueOf(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf14123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14124;
		public static global::java.lang.Byte valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf14124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf14125;
		public static global::java.lang.Byte valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf14125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _decode14126;
		public static global::java.lang.Byte decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._decode14126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue14127;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Byte._byteValue14127);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._byteValue14127);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue14128;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Byte._shortValue14128);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._shortValue14128);
		}
		internal static global::MonoJavaBridge.MethodId _intValue14129;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._intValue14129);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._intValue14129);
		}
		internal static global::MonoJavaBridge.MethodId _longValue14130;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Byte._longValue14130);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._longValue14130);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue14131;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Byte._floatValue14131);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._floatValue14131);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue14132;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Byte._doubleValue14132);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._doubleValue14132);
		}
		internal static global::MonoJavaBridge.MethodId _parseByte14133;
		public static byte parseByte(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte14133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseByte14134;
		public static byte parseByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte14134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Byte14135;
		public Byte(byte arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte14135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Byte14136;
		public Byte(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte14136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Byte.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Byte"));
			global::java.lang.Byte._equals14117 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Byte._toString14118 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
			global::java.lang.Byte._toString14119 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Byte._hashCode14120 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "hashCode", "()I");
			global::java.lang.Byte._compareTo14121 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Byte._compareTo14122 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I");
			global::java.lang.Byte._valueOf14123 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf14124 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf14125 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._decode14126 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._byteValue14127 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "byteValue", "()B");
			global::java.lang.Byte._shortValue14128 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "shortValue", "()S");
			global::java.lang.Byte._intValue14129 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "intValue", "()I");
			global::java.lang.Byte._longValue14130 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "longValue", "()J");
			global::java.lang.Byte._floatValue14131 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "floatValue", "()F");
			global::java.lang.Byte._doubleValue14132 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "doubleValue", "()D");
			global::java.lang.Byte._parseByte14133 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
			global::java.lang.Byte._parseByte14134 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
			global::java.lang.Byte._Byte14135 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(B)V");
			global::java.lang.Byte._Byte14136 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
