namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PorterDuff : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PorterDuff()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PorterDuff), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.PorterDuff.Mode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _values3258;
			public static global::android.graphics.PorterDuff.Mode[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._values3258));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3259;
			public static global::android.graphics.PorterDuff.Mode valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PorterDuff.Mode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PorterDuff.Mode.staticClass, global::android.graphics.PorterDuff.Mode._valueOf3259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CLEAR3260;
			public static global::android.graphics.PorterDuff.Mode CLEAR
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DARKEN3261;
			public static global::android.graphics.PorterDuff.Mode DARKEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DST3262;
			public static global::android.graphics.PorterDuff.Mode DST
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DST_ATOP3263;
			public static global::android.graphics.PorterDuff.Mode DST_ATOP
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DST_IN3264;
			public static global::android.graphics.PorterDuff.Mode DST_IN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DST_OUT3265;
			public static global::android.graphics.PorterDuff.Mode DST_OUT
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DST_OVER3266;
			public static global::android.graphics.PorterDuff.Mode DST_OVER
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LIGHTEN3267;
			public static global::android.graphics.PorterDuff.Mode LIGHTEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MULTIPLY3268;
			public static global::android.graphics.PorterDuff.Mode MULTIPLY
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SCREEN3269;
			public static global::android.graphics.PorterDuff.Mode SCREEN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SRC3270;
			public static global::android.graphics.PorterDuff.Mode SRC
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SRC_ATOP3271;
			public static global::android.graphics.PorterDuff.Mode SRC_ATOP
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SRC_IN3272;
			public static global::android.graphics.PorterDuff.Mode SRC_IN
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SRC_OUT3273;
			public static global::android.graphics.PorterDuff.Mode SRC_OUT
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SRC_OVER3274;
			public static global::android.graphics.PorterDuff.Mode SRC_OVER
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _XOR3275;
			public static global::android.graphics.PorterDuff.Mode XOR
			{
				get
				{
					return default(global::android.graphics.PorterDuff.Mode);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.PorterDuff.Mode.staticClass = @__class;
				global::android.graphics.PorterDuff.Mode._values3258 = @__env.GetStaticMethodID(global::android.graphics.PorterDuff.Mode.staticClass, "values", "()[Landroid/graphics/PorterDuff/Mode;");
				global::android.graphics.PorterDuff.Mode._valueOf3259 = @__env.GetStaticMethodID(global::android.graphics.PorterDuff.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PorterDuff$Mode;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _PorterDuff3276;
		public PorterDuff()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.PorterDuff.staticClass, global::android.graphics.PorterDuff._PorterDuff3276, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.PorterDuff.staticClass = @__class;
			global::android.graphics.PorterDuff._PorterDuff3276 = @__env.GetMethodID(global::android.graphics.PorterDuff.staticClass, "<init>", "()V");
		}
	}
}
