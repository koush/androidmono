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
		internal static global::net.sf.jni4net.jni.MethodId _toString9004;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._toString9004));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toString9004));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear9005;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._clear9005);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._clear9005);
		}
		internal static global::net.sf.jni4net.jni.MethodId _set9006;
		public virtual void set(android.view.animation.Transformation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._set9006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._set9006, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compose9007;
		public virtual void compose(android.view.animation.Transformation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._compose9007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._compose9007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha9008;
		public virtual void setAlpha(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._setAlpha9008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setAlpha9008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toShortString9009;
		public virtual global::java.lang.String toShortString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._toShortString9009));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._toShortString9009));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMatrix9010;
		public virtual global::android.graphics.Matrix getMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.animation.Transformation._getMatrix9010));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getMatrix9010));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransformationType9011;
		public virtual int getTransformationType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.animation.Transformation._getTransformationType9011);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getTransformationType9011);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTransformationType9012;
		public virtual void setTransformationType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.animation.Transformation._setTransformationType9012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._setTransformationType9012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlpha9013;
		public virtual float getAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.animation.Transformation._getAlpha9013);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._getAlpha9013);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Transformation9014;
		public Transformation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.animation.Transformation.staticClass, global::android.view.animation.Transformation._Transformation9014, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_IDENTITY9015;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_ALPHA9016;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_MATRIX9017;
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
		internal static global::net.sf.jni4net.jni.FieldId _TYPE_BOTH9018;
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
			global::android.view.animation.Transformation._toString9004 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._clear9005 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "clear", "()V");
			global::android.view.animation.Transformation._set9006 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "set", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._compose9007 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "compose", "(Landroid/view/animation/Transformation;)V");
			global::android.view.animation.Transformation._setAlpha9008 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setAlpha", "(F)V");
			global::android.view.animation.Transformation._toShortString9009 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.view.animation.Transformation._getMatrix9010 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getMatrix", "()Landroid/graphics/Matrix;");
			global::android.view.animation.Transformation._getTransformationType9011 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getTransformationType", "()I");
			global::android.view.animation.Transformation._setTransformationType9012 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "setTransformationType", "(I)V");
			global::android.view.animation.Transformation._getAlpha9013 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "getAlpha", "()F");
			global::android.view.animation.Transformation._Transformation9014 = @__env.GetMethodID(global::android.view.animation.Transformation.staticClass, "<init>", "()V");
		}
	}
}
