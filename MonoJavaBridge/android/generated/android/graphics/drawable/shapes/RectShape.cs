namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RectShape : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RectShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.drawable.shapes.RectShape clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RectShape;", ref global::android.graphics.drawable.shapes.RectShape._m0) as android.graphics.drawable.shapes.RectShape;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.RectShape._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual global::android.graphics.RectF rect()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, "rect", "()Landroid/graphics/RectF;", ref global::android.graphics.drawable.shapes.RectShape._m2) as android.graphics.RectF;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onResize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.RectShape.staticClass, "onResize", "(FF)V", ref global::android.graphics.drawable.shapes.RectShape._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public RectShape() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.RectShape._m4.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.RectShape._m4 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._m4);
			Init(@__env, handle);
		}
		static RectShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.RectShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/RectShape"));
		}
	}
}
