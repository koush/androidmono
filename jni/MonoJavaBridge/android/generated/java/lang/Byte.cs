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
		internal static global::MonoJavaBridge.MethodId _equals19623;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Byte._equals19623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._equals19623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19624;
		public static global::java.lang.String toString(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._toString19624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19625;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Byte._toString19625)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._toString19625)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19626;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._hashCode19626);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._hashCode19626);
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19627;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo19627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo19627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19628;
		public int compareTo(java.lang.Byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._compareTo19628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._compareTo19628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19629;
		public static global::java.lang.Byte valueOf(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19630;
		public static global::java.lang.Byte valueOf(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19631;
		public static global::java.lang.Byte valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._valueOf19631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _decode19632;
		public static global::java.lang.Byte decode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._decode19632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _byteValue19633;
		public sealed override byte byteValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Byte._byteValue19633);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._byteValue19633);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue19634;
		public sealed override short shortValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Byte._shortValue19634);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._shortValue19634);
		}
		internal static global::MonoJavaBridge.MethodId _intValue19635;
		public sealed override int intValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Byte._intValue19635);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._intValue19635);
		}
		internal static global::MonoJavaBridge.MethodId _longValue19636;
		public sealed override long longValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Byte._longValue19636);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._longValue19636);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue19637;
		public sealed override float floatValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Byte._floatValue19637);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._floatValue19637);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue19638;
		public sealed override double doubleValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Byte._doubleValue19638);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Byte.staticClass, global::java.lang.Byte._doubleValue19638);
		}
		internal static global::MonoJavaBridge.MethodId _parseByte19639;
		public static byte parseByte(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte19639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseByte19640;
		public static byte parseByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._parseByte19640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Byte19641;
		public Byte(byte arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte19641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Byte19642;
		public Byte(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._Byte19642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Byte.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Byte"));
			global::java.lang.Byte._equals19623 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Byte._toString19624 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
			global::java.lang.Byte._toString19625 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Byte._hashCode19626 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "hashCode", "()I");
			global::java.lang.Byte._compareTo19627 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Byte._compareTo19628 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I");
			global::java.lang.Byte._valueOf19629 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf19630 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
			global::java.lang.Byte._valueOf19631 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._decode19632 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
			global::java.lang.Byte._byteValue19633 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "byteValue", "()B");
			global::java.lang.Byte._shortValue19634 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "shortValue", "()S");
			global::java.lang.Byte._intValue19635 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "intValue", "()I");
			global::java.lang.Byte._longValue19636 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "longValue", "()J");
			global::java.lang.Byte._floatValue19637 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "floatValue", "()F");
			global::java.lang.Byte._doubleValue19638 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "doubleValue", "()D");
			global::java.lang.Byte._parseByte19639 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
			global::java.lang.Byte._parseByte19640 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
			global::java.lang.Byte._Byte19641 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(B)V");
			global::java.lang.Byte._Byte19642 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
