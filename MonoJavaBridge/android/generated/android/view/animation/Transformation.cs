namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Transformation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Transformation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.animation.Transformation._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, "clear", "()V", ref global::android.view.animation.Transformation._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void set(android.view.animation.Transformation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V", ref global::android.view.animation.Transformation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void compose(android.view.animation.Transformation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V", ref global::android.view.animation.Transformation._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setAlpha(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V", ref global::android.view.animation.Transformation._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;", ref global::android.view.animation.Transformation._m5) as java.lang.String;
		}
		public new global::android.graphics.Matrix Matrix
		{
			get
			{
				return getMatrix();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.graphics.Matrix getMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;", ref global::android.view.animation.Transformation._m6) as android.graphics.Matrix;
		}
		public new int TransformationType
		{
			get
			{
				return getTransformationType();
			}
			set
			{
				setTransformationType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getTransformationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I", ref global::android.view.animation.Transformation._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setTransformationType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V", ref global::android.view.animation.Transformation._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Alpha
		{
			get
			{
				return getAlpha();
			}
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual float getAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.Transformation.staticClass, "getAlpha", "()F", ref global::android.view.animation.Transformation._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Transformation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.Transformation._m10.native == global::System.IntPtr.Zero)
				global::android.view.animation.Transformation._m10 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._m10);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_IDENTITY5906;
		public static int TYPE_IDENTITY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_IDENTITY5906);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_ALPHA5907;
		public static int TYPE_ALPHA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_ALPHA5907);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_MATRIX5908;
		public static int TYPE_MATRIX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_MATRIX5908);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_BOTH5909;
		public static int TYPE_BOTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_BOTH5909);
			}
			set
			{
			}
		}
		static Transformation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Transformation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Transformation"));
			global::android.view.animation.Transformation._TYPE_IDENTITY5906 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_IDENTITY", "I");
			global::android.view.animation.Transformation._TYPE_ALPHA5907 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_ALPHA", "I");
			global::android.view.animation.Transformation._TYPE_MATRIX5908 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_MATRIX", "I");
			global::android.view.animation.Transformation._TYPE_BOTH5909 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_BOTH", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
