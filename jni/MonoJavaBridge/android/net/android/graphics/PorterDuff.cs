namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PorterDuff : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PorterDuff() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PorterDuff), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PorterDuff(@__env); 
			} 
		} 
		protected PorterDuff(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Mode : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Mode() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PorterDuff.Mode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.PorterDuff.Mode(@__env); 
				} 
			} 
			internal Mode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3058; 
			public static android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PorterDuff.Mode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PorterDuff.Mode.staticClass, _valueOf3058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3059; 
			public static android.graphics.PorterDuff.Mode[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PorterDuff.Mode.staticClass, _values3059)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLEAR3060; 
			public static android.graphics.PorterDuff.Mode CLEAR
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DARKEN3061; 
			public static android.graphics.PorterDuff.Mode DARKEN
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DST3062; 
			public static android.graphics.PorterDuff.Mode DST
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DST_ATOP3063; 
			public static android.graphics.PorterDuff.Mode DST_ATOP
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DST_IN3064; 
			public static android.graphics.PorterDuff.Mode DST_IN
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DST_OUT3065; 
			public static android.graphics.PorterDuff.Mode DST_OUT
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DST_OVER3066; 
			public static android.graphics.PorterDuff.Mode DST_OVER
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LIGHTEN3067; 
			public static android.graphics.PorterDuff.Mode LIGHTEN
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MULTIPLY3068; 
			public static android.graphics.PorterDuff.Mode MULTIPLY
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SCREEN3069; 
			public static android.graphics.PorterDuff.Mode SCREEN
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SRC3070; 
			public static android.graphics.PorterDuff.Mode SRC
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SRC_ATOP3071; 
			public static android.graphics.PorterDuff.Mode SRC_ATOP
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SRC_IN3072; 
			public static android.graphics.PorterDuff.Mode SRC_IN
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SRC_OUT3073; 
			public static android.graphics.PorterDuff.Mode SRC_OUT
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SRC_OVER3074; 
			public static android.graphics.PorterDuff.Mode SRC_OVER
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _XOR3075; 
			public static android.graphics.PorterDuff.Mode XOR
			{ 
				get 
				{ 
					return default(android.graphics.PorterDuff.Mode); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.PorterDuff.Mode.staticClass = @__class; 
				global::android.graphics.PorterDuff.Mode._valueOf3058 = @__env.GetStaticMethodID(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;"); 
				global::android.graphics.PorterDuff.Mode._values3059 = @__env.GetStaticMethodID(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PorterDuff3076; 
		public PorterDuff()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PorterDuff.staticClass, _PorterDuff3076, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PorterDuff.staticClass = @__class; 
			global::android.graphics.PorterDuff._PorterDuff3076 = @__env.GetMethodID(global::android.graphics.PorterDuff.staticClass, "<init>", "()V"); 
		} 
	} 
} 
