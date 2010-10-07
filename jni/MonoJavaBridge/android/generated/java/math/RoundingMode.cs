namespace java.math
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class RoundingMode : java.lang.Enum
	{
		internal new static global::java.lang.Class staticClass;
		static RoundingMode()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.math.RoundingMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.math.RoundingMode(@__env);
			}
		}
		internal RoundingMode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _values12376;
		public static global::java.math.RoundingMode[] values() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._values12376));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf12377;
		public static global::java.math.RoundingMode valueOf(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf12377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _valueOf12378;
		public static global::java.math.RoundingMode valueOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, global::java.math.RoundingMode._valueOf12378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _UP12379;
		public static global::java.math.RoundingMode UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DOWN12380;
		public static global::java.math.RoundingMode DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CEILING12381;
		public static global::java.math.RoundingMode CEILING
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FLOOR12382;
		public static global::java.math.RoundingMode FLOOR
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HALF_UP12383;
		public static global::java.math.RoundingMode HALF_UP
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HALF_DOWN12384;
		public static global::java.math.RoundingMode HALF_DOWN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _HALF_EVEN12385;
		public static global::java.math.RoundingMode HALF_EVEN
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _UNNECESSARY12386;
		public static global::java.math.RoundingMode UNNECESSARY
		{
			get
			{
				return default(global::java.math.RoundingMode);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.math.RoundingMode.staticClass = @__class;
			global::java.math.RoundingMode._values12376 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf12377 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;");
			global::java.math.RoundingMode._valueOf12378 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;");
		}
	}
}
