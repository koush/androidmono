namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Transformation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Transformation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15756;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toString15756)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear15757;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._clear15757);
		}
		internal static global::MonoJavaBridge.MethodId _set15758;
		public virtual void set(android.view.animation.Transformation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._set15758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compose15759;
		public virtual void compose(android.view.animation.Transformation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._compose15759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha15760;
		public virtual void setAlpha(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setAlpha15760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toShortString15761;
		public virtual global::java.lang.String toShortString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toShortString15761)) as java.lang.String;
		}
		public new global::android.graphics.Matrix Matrix
		{
			get
			{
				return getMatrix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix15762;
		public virtual global::android.graphics.Matrix getMatrix()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getMatrix15762)) as android.graphics.Matrix;
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
		internal static global::MonoJavaBridge.MethodId _getTransformationType15763;
		public virtual int getTransformationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getTransformationType15763);
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationType15764;
		public virtual void setTransformationType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setTransformationType15764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAlpha15765;
		public virtual float getAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getAlpha15765);
		}
		internal static global::MonoJavaBridge.MethodId _Transformation15766;
		public Transformation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._Transformation15766);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_IDENTITY15767;
		public static int TYPE_IDENTITY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_IDENTITY15767);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_ALPHA15768;
		public static int TYPE_ALPHA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_ALPHA15768);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_MATRIX15769;
		public static int TYPE_MATRIX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_MATRIX15769);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_BOTH15770;
		public static int TYPE_BOTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_BOTH15770);
			}
			set
			{
			}
		}
		static Transformation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Transformation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Transformation"));
			global::android.view.animation.Transformation._toString15756 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._clear15757 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "clear", "()V");
			global::android.view.animation.Transformation._set15758 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._compose15759 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._setAlpha15760 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V");
			global::android.view.animation.Transformation._toShortString15761 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._getMatrix15762 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.view.animation.Transformation._getTransformationType15763 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I");
			global::android.view.animation.Transformation._setTransformationType15764 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V");
			global::android.view.animation.Transformation._getAlpha15765 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F");
			global::android.view.animation.Transformation._Transformation15766 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
			global::android.view.animation.Transformation._TYPE_IDENTITY15767 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_IDENTITY", "I");
			global::android.view.animation.Transformation._TYPE_ALPHA15768 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_ALPHA", "I");
			global::android.view.animation.Transformation._TYPE_MATRIX15769 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_MATRIX", "I");
			global::android.view.animation.Transformation._TYPE_BOTH15770 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_BOTH", "I");
		}
		internal static void InitJNI()
		{
		}
	}
}
