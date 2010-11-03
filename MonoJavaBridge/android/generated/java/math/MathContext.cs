namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MathContext : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MathContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.math.MathContext.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.math.MathContext._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.math.MathContext.staticClass, "toString", "()Ljava/lang/String;", ref global::java.math.MathContext._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.MathContext.staticClass, "hashCode", "()I", ref global::java.math.MathContext._m2);
		}
		public new int Precision
		{
			get
			{
				return getPrecision();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getPrecision()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.math.MathContext.staticClass, "getPrecision", "()I", ref global::java.math.MathContext._m3);
		}
		public new global::java.math.RoundingMode RoundingMode
		{
			get
			{
				return getRoundingMode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.math.RoundingMode getRoundingMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.math.RoundingMode>(this, global::java.math.MathContext.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;", ref global::java.math.MathContext._m4) as java.math.RoundingMode;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public MathContext(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.MathContext._m5.native == global::System.IntPtr.Zero)
				global::java.math.MathContext._m5 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public MathContext(int arg0, java.math.RoundingMode arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.MathContext._m6.native == global::System.IntPtr.Zero)
				global::java.math.MathContext._m6 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(ILjava/math/RoundingMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public MathContext(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.MathContext._m7.native == global::System.IntPtr.Zero)
				global::java.math.MathContext._m7 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNLIMITED6439;
		public static global::java.math.MathContext UNLIMITED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _UNLIMITED6439)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL326440;
		public static global::java.math.MathContext DECIMAL32
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL326440)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL646441;
		public static global::java.math.MathContext DECIMAL64
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL646441)) as java.math.MathContext;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL1286442;
		public static global::java.math.MathContext DECIMAL128
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.MathContext>(@__env.GetStaticObjectField(global::java.math.MathContext.staticClass, _DECIMAL1286442)) as java.math.MathContext;
			}
		}
		static MathContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.MathContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/MathContext"));
			global::java.math.MathContext._UNLIMITED6439 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "UNLIMITED", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL326440 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL32", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL646441 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL64", "Ljava/math/MathContext;");
			global::java.math.MathContext._DECIMAL1286442 = @__env.GetStaticFieldIDNoThrow(global::java.math.MathContext.staticClass, "DECIMAL128", "Ljava/math/MathContext;");
		}
	}
}
