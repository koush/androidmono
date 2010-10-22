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
		internal static global::MonoJavaBridge.MethodId _values21199;
		public static global::java.math.RoundingMode[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._values21199)) as java.math.RoundingMode[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21200;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf21201;
		public static global::java.math.RoundingMode valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf21201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.FieldId _UP21202;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UP21202)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOWN21203;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _DOWN21203)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CEILING21204;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _CEILING21204)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FLOOR21205;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _FLOOR21205)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_UP21206;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_UP21206)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_DOWN21207;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_DOWN21207)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_EVEN21208;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _HALF_EVEN21208)) as java.math.RoundingMode;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNNECESSARY21209;
		public static global::java.math.RoundingMode UNNECESSARY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.math.RoundingMode>(@__env.GetStaticObjectField(global::java.math.RoundingMode.staticClass, _UNNECESSARY21209)) as java.math.RoundingMode;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.RoundingMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/RoundingMode"));
			global::java.math.RoundingMode._values21199 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf21200 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf21201 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._UP21202 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._DOWN21203 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._CEILING21204 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "CEILING", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._FLOOR21205 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "FLOOR", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_UP21206 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_UP", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_DOWN21207 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_DOWN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._HALF_EVEN21208 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "HALF_EVEN", "Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._UNNECESSARY21209 = @__env.GetStaticFieldIDNoThrow(global::java.math.RoundingMode.staticClass, "UNNECESSARY", "Ljava/math/RoundingMode;");
		}
	}
}
