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
		internal static global::MonoJavaBridge.MethodId _values15655;
		public static global::java.math.RoundingMode[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._values15655)) as java.math.RoundingMode[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15656;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf15656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15657;
		public static global::java.math.RoundingMode valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf15657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.FieldId _UP15658;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOWN15659;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CEILING15660;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FLOOR15661;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_UP15662;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_DOWN15663;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_EVEN15664;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNNECESSARY15665;
		public static global::java.math.RoundingMode UNNECESSARY
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.RoundingMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/RoundingMode"));
			global::java.math.RoundingMode._values15655 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf15656 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf15657 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
		}
	}
}
