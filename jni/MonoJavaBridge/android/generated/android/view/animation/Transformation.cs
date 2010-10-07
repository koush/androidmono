namespace android.view.animation
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Transformation : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Transformation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.animation.Transformation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.animation.Transformation(@__env);
			}
		}
		protected Transformation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9711;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._toString9711));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toString9711));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear9712;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._clear9712);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._clear9712);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set9713;
		public virtual void set(android.view.animation.Transformation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._set9713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._set9713, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compose9714;
		public virtual void compose(android.view.animation.Transformation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._compose9714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._compose9714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha9715;
		public virtual void setAlpha(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._setAlpha9715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setAlpha9715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toShortString9716;
		public virtual global::java.lang.String toShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._toShortString9716));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toShortString9716));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix9717;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._getMatrix9717));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getMatrix9717));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationType9718;
		public virtual int getTransformationType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.Transformation._getTransformationType9718);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getTransformationType9718);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationType9719;
		public virtual void setTransformationType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._setTransformationType9719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setTransformationType9719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha9720;
		public virtual float getAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.Transformation._getAlpha9720);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getAlpha9720);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Transformation9721;
		public Transformation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._Transformation9721, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_IDENTITY9722;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_ALPHA9723;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_MATRIX9724;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_BOTH9725;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.animation.Transformation.staticClass = @__class;
			global::android.view.animation.Transformation._toString9711 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._clear9712 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "clear", "()V");
			global::android.view.animation.Transformation._set9713 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._compose9714 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._setAlpha9715 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V");
			global::android.view.animation.Transformation._toShortString9716 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._getMatrix9717 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.view.animation.Transformation._getTransformationType9718 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I");
			global::android.view.animation.Transformation._setTransformationType9719 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V");
			global::android.view.animation.Transformation._getAlpha9720 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F");
			global::android.view.animation.Transformation._Transformation9721 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
		}
	}
}
