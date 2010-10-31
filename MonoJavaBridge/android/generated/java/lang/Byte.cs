namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Byte : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Byte(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Byte.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Byte._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String toString(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "toString", "(B)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Byte.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Byte._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Byte.staticClass, "hashCode", "()I", ref global::java.lang.Byte._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Byte._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int compareTo(java.lang.Byte arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Byte.staticClass, "compareTo", "(Ljava/lang/Byte;)I", ref global::java.lang.Byte._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.Byte valueOf(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(B)Ljava/lang/Byte;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.Byte valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m7.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Byte valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.Byte decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m9.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Byte;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Byte>(@__env.CallStaticObjectMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Byte;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public sealed override byte byteValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.Byte.staticClass, "byteValue", "()B", ref global::java.lang.Byte._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override short shortValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.Byte.staticClass, "shortValue", "()S", ref global::java.lang.Byte._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override int intValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Byte.staticClass, "intValue", "()I", ref global::java.lang.Byte._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public sealed override long longValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.Byte.staticClass, "longValue", "()J", ref global::java.lang.Byte._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public sealed override float floatValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.Byte.staticClass, "floatValue", "()F", ref global::java.lang.Byte._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public sealed override double doubleValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.Byte.staticClass, "doubleValue", "()D", ref global::java.lang.Byte._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static byte parseByte(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;I)B");
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static byte parseByte(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Byte.staticClass, "parseByte", "(Ljava/lang/String;)B");
			return @__env.CallStaticByteMethod(java.lang.Byte.staticClass, global::java.lang.Byte._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Byte(byte arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m18.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m18 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public Byte(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Byte._m19.native == global::System.IntPtr.Zero)
				global::java.lang.Byte._m19 = @__env.GetMethodIDNoThrow(global::java.lang.Byte.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Byte.staticClass, global::java.lang.Byte._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Byte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Byte.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Byte"));
		}
	}
}
