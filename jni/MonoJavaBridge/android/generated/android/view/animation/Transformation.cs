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
		internal static global::MonoJavaBridge.MethodId _toString10604;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._toString10604)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toString10604)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear10605;
		public virtual void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._clear10605);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._clear10605);
		}
		internal static global::MonoJavaBridge.MethodId _set10606;
		public virtual void set(android.view.animation.Transformation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._set10606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._set10606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compose10607;
		public virtual void compose(android.view.animation.Transformation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._compose10607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._compose10607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha10608;
		public virtual void setAlpha(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._setAlpha10608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setAlpha10608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toShortString10609;
		public virtual global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._toShortString10609)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toShortString10609)) as java.lang.String;
		}
		public new global::android.graphics.Matrix Matrix
		{
			get
			{
				return getMatrix();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMatrix10610;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.animation.Transformation._getMatrix10610)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getMatrix10610)) as android.graphics.Matrix;
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
		internal static global::MonoJavaBridge.MethodId _getTransformationType10611;
		public virtual int getTransformationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.animation.Transformation._getTransformationType10611);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getTransformationType10611);
		}
		internal static global::MonoJavaBridge.MethodId _setTransformationType10612;
		public virtual void setTransformationType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.animation.Transformation._setTransformationType10612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setTransformationType10612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAlpha10613;
		public virtual float getAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.Transformation._getAlpha10613);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getAlpha10613);
		}
		internal static global::MonoJavaBridge.MethodId _Transformation10614;
		public Transformation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._Transformation10614);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_IDENTITY10615;
		public static int TYPE_IDENTITY
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_ALPHA10616;
		public static int TYPE_ALPHA
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_MATRIX10617;
		public static int TYPE_MATRIX
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE_BOTH10618;
		public static int TYPE_BOTH
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.Transformation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/Transformation"));
			global::android.view.animation.Transformation._toString10604 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._clear10605 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "clear", "()V");
			global::android.view.animation.Transformation._set10606 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._compose10607 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._setAlpha10608 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V");
			global::android.view.animation.Transformation._toShortString10609 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._getMatrix10610 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.view.animation.Transformation._getTransformationType10611 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I");
			global::android.view.animation.Transformation._setTransformationType10612 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V");
			global::android.view.animation.Transformation._getAlpha10613 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F");
			global::android.view.animation.Transformation._Transformation10614 = @__env.GetMethodIDNoThrow(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
		}
	}
}
