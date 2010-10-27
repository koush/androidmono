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
		internal static global::MonoJavaBridge.MethodId _equals19741;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Byte._equals19741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._equals19741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19742;
		public static global::java.lang.String toString(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._toString19742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19743;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Byte._toString19743)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._toString19743)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19744;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._hashCode19744);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._hashCode19744);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19745;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo19745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo19745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19746;
		public int compareTo(java.lang.Byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo19746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo19746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19747;
		public static global::java.lang.Byte valueOf(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19748;
		public static global::java.lang.Byte valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19749;
		public static global::java.lang.Byte valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _decode19750;
		public static global::java.lang.Byte decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._decode19750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue19751;
		public sealed override byte byteValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Byte._byteValue19751);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._byteValue19751);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue19752;
		public sealed override short shortValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Byte._shortValue19752);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._shortValue19752);
		}
		internal static global::MonoJavaBridge.MethodId _intValue19753;
		public sealed override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._intValue19753);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._intValue19753);
		}
		internal static global::MonoJavaBridge.MethodId _longValue19754;
		public sealed override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Byte._longValue19754);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._longValue19754);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue19755;
		public sealed override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Byte._floatValue19755);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._floatValue19755);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue19756;
		public sealed override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Byte._doubleValue19756);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._doubleValue19756);
		}
		internal static global::MonoJavaBridge.MethodId _parseByte19757;
		public static byte parseByte(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte19757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseByte19758;
		public static byte parseByte(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte19758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Byte19759;
		public Byte(byte arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte19759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Byte19760;
		public Byte(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte19760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Byte.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Byte"));
			global::java.lang.Byte._equals19741 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Byte._toString19742 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
			global::java.lang.Byte._toString19743 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Byte._hashCode19744 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "hashCode", "()I");
			global::java.lang.Byte._compareTo19745 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Byte._compareTo19746 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I");
			global::java.lang.Byte._valueOf19747 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf19748 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf19749 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._decode19750 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._byteValue19751 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "byteValue", "()B");
			global::java.lang.Byte._shortValue19752 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "shortValue", "()S");
			global::java.lang.Byte._intValue19753 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "intValue", "()I");
			global::java.lang.Byte._longValue19754 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "longValue", "()J");
			global::java.lang.Byte._floatValue19755 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "floatValue", "()F");
			global::java.lang.Byte._doubleValue19756 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "doubleValue", "()D");
			global::java.lang.Byte._parseByte19757 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
			global::java.lang.Byte._parseByte19758 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
			global::java.lang.Byte._Byte19759 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(B)V");
			global::java.lang.Byte._Byte19760 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
