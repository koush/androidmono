namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.shapes.Shape_))]
	public abstract partial class Shape : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Shape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.drawable.shapes.Shape clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;", ref global::android.graphics.drawable.shapes.Shape._m0) as android.graphics.drawable.shapes.Shape;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void resize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V", ref global::android.graphics.drawable.shapes.Shape._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F", ref global::android.graphics.drawable.shapes.Shape._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F", ref global::android.graphics.drawable.shapes.Shape._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool hasAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z", ref global::android.graphics.drawable.shapes.Shape._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void onResize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V", ref global::android.graphics.drawable.shapes.Shape._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public Shape() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.Shape._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.Shape._m7 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._m7);
			Init(@__env, handle);
		}
		static Shape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.shapes.Shape))]
	internal sealed partial class Shape_ : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Shape_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.Shape_.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.Shape_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Shape_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
		}
		internal static void InitJNI()
		{
		}
	}
}
