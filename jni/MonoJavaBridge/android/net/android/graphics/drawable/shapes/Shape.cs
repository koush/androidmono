namespace android.graphics.drawable.shapes 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Shape : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Shape() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.shapes.Shape), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Shape(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone3838; 
		public virtual global::android.graphics.drawable.shapes.Shape clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.shapes.Shape._clone3838)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._clone3838)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resize3839; 
		public virtual void resize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape._resize3839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._resize3839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3840; 
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3841; 
		public virtual float getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape._getWidth3841); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getWidth3841); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3842; 
		public virtual float getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape._getHeight3842); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getHeight3842); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha3843; 
		public virtual bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.shapes.Shape._hasAlpha3843); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._hasAlpha3843); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onResize3844; 
		protected virtual void onResize(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.shapes.Shape)) 
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape._onResize3844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._onResize3844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Shape3845; 
		public Shape()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._Shape3845, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.shapes.Shape.staticClass = @__class; 
			global::android.graphics.drawable.shapes.Shape._clone3838 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;"); 
			global::android.graphics.drawable.shapes.Shape._resize3839 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V"); 
			global::android.graphics.drawable.shapes.Shape._draw3840 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"); 
			global::android.graphics.drawable.shapes.Shape._getWidth3841 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F"); 
			global::android.graphics.drawable.shapes.Shape._getHeight3842 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F"); 
			global::android.graphics.drawable.shapes.Shape._hasAlpha3843 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.drawable.shapes.Shape._onResize3844 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V"); 
			global::android.graphics.drawable.shapes.Shape._Shape3845 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V"); 
		} 
	} 
} 
