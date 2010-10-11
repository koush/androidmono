namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AvoidXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AvoidXfermode()
		{
			InitJNI();
		}
		protected AvoidXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Mode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Mode()
			{
				InitJNI();
			}
			internal Mode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3072;
			public static global::android.graphics.AvoidXfermode.Mode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.AvoidXfermode.Mode>(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._values3072)) as android.graphics.AvoidXfermode.Mode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3073;
			public static global::android.graphics.AvoidXfermode.Mode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._valueOf3073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.AvoidXfermode.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _AVOID3074;
			public static global::android.graphics.AvoidXfermode.Mode AVOID
			{
				get
				{
					return default(global::android.graphics.AvoidXfermode.Mode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _TARGET3075;
			public static global::android.graphics.AvoidXfermode.Mode TARGET
			{
				get
				{
					return default(global::android.graphics.AvoidXfermode.Mode);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.AvoidXfermode.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode$Mode"));
				global::android.graphics.AvoidXfermode.Mode._values3072 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "values", "()[Landroid/graphics/AvoidXfermode/Mode;");
				global::android.graphics.AvoidXfermode.Mode._valueOf3073 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/AvoidXfermode$Mode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _AvoidXfermode3076;
		public AvoidXfermode(int arg0, int arg1, android.graphics.AvoidXfermode.Mode arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.AvoidXfermode.staticClass, global::android.graphics.AvoidXfermode._AvoidXfermode3076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.AvoidXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode"));
			global::android.graphics.AvoidXfermode._AvoidXfermode3076 = @__env.GetMethodIDNoThrow(global::android.graphics.AvoidXfermode.staticClass, "<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V");
		}
	}
}
