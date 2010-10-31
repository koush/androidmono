namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Shader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Shader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TileMode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal TileMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Shader.TileMode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Shader.TileMode._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Shader.TileMode._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "values", "()[Landroid/graphics/Shader/TileMode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Shader.TileMode>(@__env.CallStaticObjectMethod(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._m0)) as android.graphics.Shader.TileMode[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Shader.TileMode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Shader.TileMode._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Shader.TileMode._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallStaticObjectMethod(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader.TileMode;
			}
			internal static global::MonoJavaBridge.FieldId _CLAMP2408;
			public static global::android.graphics.Shader.TileMode CLAMP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.GetStaticObjectField(global::android.graphics.Shader.TileMode.staticClass, _CLAMP2408)) as android.graphics.Shader.TileMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIRROR2409;
			public static global::android.graphics.Shader.TileMode MIRROR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.GetStaticObjectField(global::android.graphics.Shader.TileMode.staticClass, _MIRROR2409)) as android.graphics.Shader.TileMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPEAT2410;
			public static global::android.graphics.Shader.TileMode REPEAT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.GetStaticObjectField(global::android.graphics.Shader.TileMode.staticClass, _REPEAT2410)) as android.graphics.Shader.TileMode;
				}
			}
			static TileMode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Shader.TileMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Shader$TileMode"));
				global::android.graphics.Shader.TileMode._CLAMP2408 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "CLAMP", "Landroid/graphics/Shader$TileMode;");
				global::android.graphics.Shader.TileMode._MIRROR2409 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "MIRROR", "Landroid/graphics/Shader$TileMode;");
				global::android.graphics.Shader.TileMode._REPEAT2410 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "REPEAT", "Landroid/graphics/Shader$TileMode;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Shader.staticClass, "finalize", "()V", ref global::android.graphics.Shader._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool getLocalMatrix(android.graphics.Matrix arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Shader.staticClass, "getLocalMatrix", "(Landroid/graphics/Matrix;)Z", ref global::android.graphics.Shader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Matrix LocalMatrix
		{
			set
			{
				setLocalMatrix(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setLocalMatrix(android.graphics.Matrix arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Shader.staticClass, "setLocalMatrix", "(Landroid/graphics/Matrix;)V", ref global::android.graphics.Shader._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Shader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Shader._m3.native == global::System.IntPtr.Zero)
				global::android.graphics.Shader._m3 = @__env.GetMethodIDNoThrow(global::android.graphics.Shader.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Shader.staticClass, global::android.graphics.Shader._m3);
			Init(@__env, handle);
		}
		static Shader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Shader.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Shader"));
		}
	}
}
