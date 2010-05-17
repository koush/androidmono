namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Shape : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Shape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.shapes.Shape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Shape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone3632; 
		public virtual android.graphics.drawable.shapes.Shape clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallObjectMethodPtr(this, _clone3632)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.shapes.Shape.staticClass, _clone3632)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resize3633; 
		public virtual void resize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				@__env.CallVoidMethod(this, _resize3633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.Shape.staticClass, _resize3633, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3634; 
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3635; 
		public virtual float getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallFloatMethod(this, _getWidth3635); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.drawable.shapes.Shape.staticClass, _getWidth3635); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3636; 
		public virtual float getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallFloatMethod(this, _getHeight3636); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.graphics.drawable.shapes.Shape.staticClass, _getHeight3636); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha3637; 
		public virtual bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallBooleanMethod(this, _hasAlpha3637); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.shapes.Shape.staticClass, _hasAlpha3637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResize3638; 
		protected virtual void onResize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				@__env.CallVoidMethod(this, _onResize3638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.shapes.Shape.staticClass, _onResize3638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Shape3639; 
		public Shape()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, _Shape3639, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.Shape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.Shape._clone3632 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;"); 
			global::android.graphics.drawable.shapes.Shape._resize3633 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V"); 
			global::android.graphics.drawable.shapes.Shape._draw3634 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.Shape._getWidth3635 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F"); 
			global::android.graphics.drawable.shapes.Shape._getHeight3636 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F"); 
			global::android.graphics.drawable.shapes.Shape._hasAlpha3637 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.drawable.shapes.Shape._onResize3638 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V"); 
			global::android.graphics.drawable.shapes.Shape._Shape3639 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V"); 
		} 
	} 
} 
