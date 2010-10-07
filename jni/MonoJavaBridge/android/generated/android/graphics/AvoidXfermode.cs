namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AvoidXfermode : android.graphics.Xfermode
	{
		internal new static global::java.lang.Class staticClass;
		static AvoidXfermode()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.AvoidXfermode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.AvoidXfermode(@__env);
			}
		}
		protected AvoidXfermode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Mode : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Mode()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.AvoidXfermode.Mode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.AvoidXfermode.Mode(@__env);
				}
			}
			internal Mode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2898;
			public static global::android.graphics.AvoidXfermode.Mode[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._values2898));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2899;
			public static global::android.graphics.AvoidXfermode.Mode valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.AvoidXfermode.Mode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._valueOf2899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _AVOID2900;
			public static global::android.graphics.AvoidXfermode.Mode AVOID
			{
				get
				{
					return default(global::android.graphics.AvoidXfermode.Mode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TARGET2901;
			public static global::android.graphics.AvoidXfermode.Mode TARGET
			{
				get
				{
					return default(global::android.graphics.AvoidXfermode.Mode);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.AvoidXfermode.Mode.staticClass = @__class;
				global::android.graphics.AvoidXfermode.Mode._values2898 = @__env.GetStaticMethodID(global::android.graphics.AvoidXfermode.Mode.staticClass, "values", "()[Landroid/graphics/AvoidXfermode/Mode;");
				global::android.graphics.AvoidXfermode.Mode._valueOf2899 = @__env.GetStaticMethodID(global::android.graphics.AvoidXfermode.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/AvoidXfermode$Mode;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _AvoidXfermode2902;
		public AvoidXfermode(int arg0, int arg1, android.graphics.AvoidXfermode.Mode arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.AvoidXfermode.staticClass, global::android.graphics.AvoidXfermode._AvoidXfermode2902, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.AvoidXfermode.staticClass = @__class;
			global::android.graphics.AvoidXfermode._AvoidXfermode2902 = @__env.GetMethodID(global::android.graphics.AvoidXfermode.staticClass, "<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V");
		}
	}
}
