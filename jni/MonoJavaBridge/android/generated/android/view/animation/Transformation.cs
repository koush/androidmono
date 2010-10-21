namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Transformation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Transformation()
		{
			InitJNI();
		}
		protected Transformation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString15675;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._toString15675)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toString15675)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear15676;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._clear15676);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._clear15676);
		}
		internal static global::MonoJavaBridge.MethodId _set15677;
		public virtual void set(android.view.animation.Transformation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._set15677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._set15677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compose15678;
		public virtual void compose(android.view.animation.Transformation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._compose15678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._compose15678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha15679;
		public virtual void setAlpha(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._setAlpha15679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setAlpha15679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toShortString15680;
		public virtual global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._toShortString15680)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toShortString15680)) as java.lang.String;
		}
		public new global::android.graphics.Matrix Matrix
		{
			get
			{
				return getMatrix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix15681;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._getMatrix15681)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getMatrix15681)) as android.graphics.Matrix;
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
		internal static global::MonoJavaBridge.MethodId _getTransformationType15682;
		public virtual int getTransformationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Transformation._getTransformationType15682);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getTransformationType15682);
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationType15683;
		public virtual void setTransformationType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._setTransformationType15683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setTransformationType15683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAlpha15684;
		public virtual float getAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Transformation._getAlpha15684);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getAlpha15684);
		}
		internal static global::MonoJavaBridge.MethodId _Transformation15685;
		public Transformation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._Transformation15685);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_IDENTITY15686;
		public static int TYPE_IDENTITY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_IDENTITY15686);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_ALPHA15687;
		public static int TYPE_ALPHA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_ALPHA15687);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_MATRIX15688;
		public static int TYPE_MATRIX
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_MATRIX15688);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_BOTH15689;
		public static int TYPE_BOTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetStaticIntField(global::android.view.animation.Transformation.staticClass, _TYPE_BOTH15689);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Transformation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Transformation"));
			global::android.view.animation.Transformation._toString15675 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._clear15676 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "clear", "()V");
			global::android.view.animation.Transformation._set15677 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._compose15678 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._setAlpha15679 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V");
			global::android.view.animation.Transformation._toShortString15680 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._getMatrix15681 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.view.animation.Transformation._getTransformationType15682 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I");
			global::android.view.animation.Transformation._setTransformationType15683 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V");
			global::android.view.animation.Transformation._getAlpha15684 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F");
			global::android.view.animation.Transformation._Transformation15685 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
			global::android.view.animation.Transformation._TYPE_IDENTITY15686 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_IDENTITY", "I");
			global::android.view.animation.Transformation._TYPE_ALPHA15687 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_ALPHA", "I");
			global::android.view.animation.Transformation._TYPE_MATRIX15688 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_MATRIX", "I");
			global::android.view.animation.Transformation._TYPE_BOTH15689 = @__env.GetStaticFieldIDNoThrow(global::android.view.animation.Transformation.staticClass, "TYPE_BOTH", "I");
		}
	}
}
