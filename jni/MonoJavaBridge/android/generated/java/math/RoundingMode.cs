namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RoundingMode : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RoundingMode()
		{
			InitJNI();
		}
		internal RoundingMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values21317;
		public static global::java.math.RoundingMode[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._values21317)) as java.math.RoundingMode[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21318;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf21318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21319;
		public static global::java.math.RoundingMode valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf21319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.FieldId _UP21320;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UP21320)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOWN21321;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _DOWN21321)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CEILING21322;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _CEILING21322)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FLOOR21323;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _FLOOR21323)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_UP21324;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_UP21324)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_DOWN21325;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_DOWN21325)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_EVEN21326;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_EVEN21326)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNNECESSARY21327;
		public static global::java.math.RoundingMode UNNECESSARY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UNNECESSARY21327)) as java.math.RoundingMode;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.RoundingMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/RoundingMode"));
			global::java.math.RoundingMode._values21317 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf21318 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf21319 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._UP21320 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._DOWN21321 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._CEILING21322 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "CEILING", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._FLOOR21323 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "FLOOR", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_UP21324 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_DOWN21325 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_EVEN21326 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_EVEN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._UNNECESSARY21327 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UNNECESSARY", "Ljava/math/RoundingMode;");
		}
	}
}
