namespace java.math 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class RoundingMode : java.lang.Enum
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RoundingMode() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.math.RoundingMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _valueOf11647; 
		public static java.math.RoundingMode valueOf(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, _valueOf11647, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf11648; 
		public static java.math.RoundingMode valueOf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.math.RoundingMode>(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, _valueOf11648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _values11649; 
		public static java.math.RoundingMode[] values() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.math.RoundingMode.staticClass, _values11649)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UP11650; 
		public static java.math.RoundingMode UP
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DOWN11651; 
		public static java.math.RoundingMode DOWN
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CEILING11652; 
		public static java.math.RoundingMode CEILING
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FLOOR11653; 
		public static java.math.RoundingMode FLOOR
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HALF_UP11654; 
		public static java.math.RoundingMode HALF_UP
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HALF_DOWN11655; 
		public static java.math.RoundingMode HALF_DOWN
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _HALF_EVEN11656; 
		public static java.math.RoundingMode HALF_EVEN
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UNNECESSARY11657; 
		public static java.math.RoundingMode UNNECESSARY
		{ 
			get 
			{ 
				return default(java.math.RoundingMode); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.math.RoundingMode.staticClass = @__class; 
			global::java.math.RoundingMode._valueOf11647 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/math/RoundingMode;"); 
			global::java.math.RoundingMode._valueOf11648 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "valueOf", "(I)Ljava/math/RoundingMode;"); 
			global::java.math.RoundingMode._values11649 = @__env.GetStaticMethodID(global::java.math.RoundingMode.staticClass, "values", "()[Ljava/math/RoundingMode;"); 
		} 
	} 
} 
