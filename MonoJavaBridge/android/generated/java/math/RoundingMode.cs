namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RoundingMode : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RoundingMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.math.RoundingMode[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.RoundingMode._m0.native == global::System.IntPtr.Zero)
				global::java.math.RoundingMode._m0 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._m0)) as java.math.RoundingMode[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.RoundingMode._m1.native == global::System.IntPtr.Zero)
				global::java.math.RoundingMode._m1 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.math.RoundingMode valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.math.RoundingMode._m2.native == global::System.IntPtr.Zero)
				global::java.math.RoundingMode._m2 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.FieldId _UP6428;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UP6428)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOWN6429;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _DOWN6429)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CEILING6430;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _CEILING6430)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FLOOR6431;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _FLOOR6431)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_UP6432;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_UP6432)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_DOWN6433;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_DOWN6433)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_EVEN6434;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_EVEN6434)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNNECESSARY6435;
		public static global::java.math.RoundingMode UNNECESSARY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UNNECESSARY6435)) as java.math.RoundingMode;
			}
		}
		static RoundingMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.RoundingMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/RoundingMode"));
			global::java.math.RoundingMode._UP6428 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._DOWN6429 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._CEILING6430 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "CEILING", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._FLOOR6431 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "FLOOR", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_UP6432 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_DOWN6433 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_EVEN6434 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_EVEN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._UNNECESSARY6435 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UNNECESSARY", "Ljava/math/RoundingMode;");
		}
		internal static void InitJNI()
		{
		}
	}
}
