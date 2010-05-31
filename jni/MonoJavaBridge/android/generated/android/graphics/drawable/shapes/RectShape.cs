namespace android.graphics.drawable.shapes
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RectShape : android.graphics.drawable.shapes.Shape
	{
		internal new static global::java.lang.Class staticClass;
		static RectShape()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.shapes.RectShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.shapes.RectShape(@__env);
			}
		}
		protected RectShape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone3829;
		public virtual new global::android.graphics.drawable.shapes.RectShape clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RectShape>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.shapes.RectShape._clone3829));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RectShape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._clone3829));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3830;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.RectShape._draw3830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._draw3830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rect3831;
		protected virtual global::android.graphics.RectF rect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.shapes.RectShape._rect3831));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._rect3831));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResize3832;
		protected override void onResize(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.RectShape._onResize3832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._onResize3832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RectShape3833;
		public RectShape()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._RectShape3833, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.shapes.RectShape.staticClass = @__class;
			global::android.graphics.drawable.shapes.RectShape._clone3829 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RectShape;");
			global::android.graphics.drawable.shapes.RectShape._draw3830 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.RectShape._rect3831 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "rect", "()Landroid/graphics/RectF;");
			global::android.graphics.drawable.shapes.RectShape._onResize3832 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.RectShape._RectShape3833 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "<init>", "()V");
		}
	}
}
