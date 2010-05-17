namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RoundRectShape : android.graphics.drawable.shapes.RectShape
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RoundRectShape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.shapes.RoundRectShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.shapes.RoundRectShape(@__env); 
			} 
		} 
		protected RoundRectShape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone3628; 
		public virtual new android.graphics.drawable.shapes.RoundRectShape clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RoundRectShape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RoundRectShape>(@__env, @__env.CallObjectMethodPtr(this, _clone3628)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RoundRectShape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.shapes.RoundRectShape.staticClass, _clone3628)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3629; 
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RoundRectShape)) 
				@__env.CallVoidMethod(this, _draw3629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.RoundRectShape.staticClass, _draw3629, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResize3630; 
		protected override void onResize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RoundRectShape)) 
				@__env.CallVoidMethod(this, _onResize3630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.RoundRectShape.staticClass, _onResize3630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RoundRectShape3631; 
		public RoundRectShape(float[] arg0, android.graphics.RectF arg1, float[] arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.RoundRectShape.staticClass, _RoundRectShape3631, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.RoundRectShape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.RoundRectShape._clone3628 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;"); 
			global::android.graphics.drawable.shapes.RoundRectShape._draw3629 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.RoundRectShape._onResize3630 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "onResize", "(FF)V"); 
			global::android.graphics.drawable.shapes.RoundRectShape._RoundRectShape3631 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "<init>", "([FLandroid/graphics/RectF;[F)V"); 
		} 
	} 
} 
