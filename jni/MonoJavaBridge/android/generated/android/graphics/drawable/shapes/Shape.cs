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
		internal static global::net.sf.jni4net.jni.MethodId _clone4044;
		public virtual global::android.graphics.drawable.shapes.Shape clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.shapes.Shape._clone4044));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._clone4044));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resize4045;
		public virtual void resize(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape._resize4045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._resize4045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw4046;
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getWidth4047;
		public virtual float getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape._getWidth4047);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getWidth4047);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight4048;
		public virtual float getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape._getHeight4048);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getHeight4048);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha4049;
		public virtual bool hasAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.shapes.Shape._hasAlpha4049);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._hasAlpha4049);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResize4050;
		protected virtual void onResize(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape._onResize4050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._onResize4050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Shape4051;
		public Shape()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._Shape4051, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.shapes.Shape.staticClass = @__class;
			global::android.graphics.drawable.shapes.Shape._clone4044 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;");
			global::android.graphics.drawable.shapes.Shape._resize4045 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._draw4046 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.Shape._getWidth4047 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F");
			global::android.graphics.drawable.shapes.Shape._getHeight4048 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F");
			global::android.graphics.drawable.shapes.Shape._hasAlpha4049 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z");
			global::android.graphics.drawable.shapes.Shape._onResize4050 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._Shape4051 = @__env.GetMethodID(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V");
		}
	}
}
