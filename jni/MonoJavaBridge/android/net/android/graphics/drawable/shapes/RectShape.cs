namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RectShape : android.graphics.drawable.shapes.Shape
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RectShape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.shapes.RectShape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _clone3623; 
		public virtual new android.graphics.drawable.shapes.RectShape clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RectShape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RectShape>(@__env, @__env.CallObjectMethodPtr(this, _clone3623)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.RectShape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.shapes.RectShape.staticClass, _clone3623)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3624; 
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RectShape)) 
				@__env.CallVoidMethod(this, _draw3624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.RectShape.staticClass, _draw3624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _rect3625; 
		protected virtual android.graphics.RectF rect() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RectShape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallObjectMethodPtr(this, _rect3625)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.RectF>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.shapes.RectShape.staticClass, _rect3625)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResize3626; 
		protected override void onResize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.RectShape)) 
				@__env.CallVoidMethod(this, _onResize3626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.RectShape.staticClass, _onResize3626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RectShape3627; 
		public RectShape()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.RectShape.staticClass, _RectShape3627, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.RectShape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.RectShape._clone3623 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RectShape;"); 
			global::android.graphics.drawable.shapes.RectShape._draw3624 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.RectShape._rect3625 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "rect", "()Landroid/graphics/RectF;"); 
			global::android.graphics.drawable.shapes.RectShape._onResize3626 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "onResize", "(FF)V"); 
			global::android.graphics.drawable.shapes.RectShape._RectShape3627 = @__env.GetMethodID(global::android.graphics.drawable.shapes.RectShape.staticClass, "<init>", "()V"); 
		} 
	} 
} 
