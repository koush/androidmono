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
		internal static global::MonoJavaBridge.MethodId _equals12803;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Byte._equals12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._equals12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12804;
		public static global::java.lang.String toString(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._toString12804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString12805;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Byte._toString12805)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._toString12805)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12806;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._hashCode12806);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._hashCode12806);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12807;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo12808;
		public int compareTo(java.lang.Byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo12808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo12808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12809;
		public static global::java.lang.Byte valueOf(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf12809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12810;
		public static global::java.lang.Byte valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf12810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf12811;
		public static global::java.lang.Byte valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf12811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _decode12812;
		public static global::java.lang.Byte decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._decode12812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue12813;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Byte._byteValue12813);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._byteValue12813);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue12814;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Byte._shortValue12814);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._shortValue12814);
		}
		internal static global::MonoJavaBridge.MethodId _intValue12815;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._intValue12815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._intValue12815);
		}
		internal static global::MonoJavaBridge.MethodId _longValue12816;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Byte._longValue12816);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._longValue12816);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue12817;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Byte._floatValue12817);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._floatValue12817);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue12818;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Byte._doubleValue12818);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._doubleValue12818);
		}
		internal static global::MonoJavaBridge.MethodId _parseByte12819;
		public static byte parseByte(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte12819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseByte12820;
		public static byte parseByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte12820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Byte12821;
		public Byte(byte arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte12821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Byte12822;
		public Byte(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte12822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Byte.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Byte"));
			global::java.lang.Byte._equals12803 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Byte._toString12804 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
			global::java.lang.Byte._toString12805 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Byte._hashCode12806 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "hashCode", "()I");
			global::java.lang.Byte._compareTo12807 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Byte._compareTo12808 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I");
			global::java.lang.Byte._valueOf12809 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf12810 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf12811 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._decode12812 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._byteValue12813 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "byteValue", "()B");
			global::java.lang.Byte._shortValue12814 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "shortValue", "()S");
			global::java.lang.Byte._intValue12815 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "intValue", "()I");
			global::java.lang.Byte._longValue12816 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "longValue", "()J");
			global::java.lang.Byte._floatValue12817 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "floatValue", "()F");
			global::java.lang.Byte._doubleValue12818 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "doubleValue", "()D");
			global::java.lang.Byte._parseByte12819 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
			global::java.lang.Byte._parseByte12820 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
			global::java.lang.Byte._Byte12821 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(B)V");
			global::java.lang.Byte._Byte12822 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
