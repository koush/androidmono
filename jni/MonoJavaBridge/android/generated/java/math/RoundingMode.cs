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
		internal static global::MonoJavaBridge.MethodId _values13569;
		public static global::java.math.RoundingMode[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.math.RoundingMode>(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._values13569)) as java.math.RoundingMode[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13570;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf13570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf13571;
		public static global::java.math.RoundingMode valueOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf13571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.FieldId _UP13572;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOWN13573;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CEILING13574;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FLOOR13575;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_UP13576;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_DOWN13577;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HALF_EVEN13578;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::MonoJavaBridge.FieldId _UNNECESSARY13579;
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
			global::java.math.RoundingMode._values13569 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf13570 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf13571 = @__env.GetStaticMethodIDNoThrow(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
		}
	}
}
