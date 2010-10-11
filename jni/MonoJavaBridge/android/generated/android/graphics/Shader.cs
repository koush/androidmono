namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Shader : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Shader()
		{
			InitJNI();
		}
		protected Shader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class TileMode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TileMode()
			{
				InitJNI();
			}
			internal TileMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3794;
			public static global::android.graphics.Shader.TileMode[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Shader.TileMode>(@__env.CallStaticObjectMethod(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._values3794)) as android.graphics.Shader.TileMode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3795;
			public static global::android.graphics.Shader.TileMode valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._valueOf3795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Shader.TileMode;
			}
			internal static global::MonoJavaBridge.FieldId _CLAMP3796;
			public static global::android.graphics.Shader.TileMode CLAMP
			{
				get
				{
					return default(global::android.graphics.Shader.TileMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MIRROR3797;
			public static global::android.graphics.Shader.TileMode MIRROR
			{
				get
				{
					return default(global::android.graphics.Shader.TileMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPEAT3798;
			public static global::android.graphics.Shader.TileMode REPEAT
			{
				get
				{
					return default(global::android.graphics.Shader.TileMode);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Shader.TileMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Shader$TileMode"));
				global::android.graphics.Shader.TileMode._values3794 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "values", "()[Landroid/graphics/Shader/TileMode;");
				global::android.graphics.Shader.TileMode._valueOf3795 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Shader.TileMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize3799;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Shader._finalize3799);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Shader.staticClass, global::android.graphics.Shader._finalize3799);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalMatrix3800;
		public virtual bool getLocalMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Shader._getLocalMatrix3800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Shader.staticClass, global::android.graphics.Shader._getLocalMatrix3800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocalMatrix3801;
		public virtual void setLocalMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Shader._setLocalMatrix3801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Shader.staticClass, global::android.graphics.Shader._setLocalMatrix3801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Shader3802;
		public Shader()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Shader.staticClass, global::android.graphics.Shader._Shader3802);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Shader.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Shader"));
			global::android.graphics.Shader._finalize3799 = @__env.GetMethodIDNoThrow(global::android.graphics.Shader.staticClass, "finalize", "()V");
			global::android.graphics.Shader._getLocalMatrix3800 = @__env.GetMethodIDNoThrow(global::android.graphics.Shader.staticClass, "getLocalMatrix", "(Landroid/graphics/Matrix;)Z");
			global::android.graphics.Shader._setLocalMatrix3801 = @__env.GetMethodIDNoThrow(global::android.graphics.Shader.staticClass, "setLocalMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.graphics.Shader._Shader3802 = @__env.GetMethodIDNoThrow(global::android.graphics.Shader.staticClass, "<init>", "()V");
		}
	}
}
