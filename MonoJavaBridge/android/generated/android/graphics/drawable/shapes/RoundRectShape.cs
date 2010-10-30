namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RoundRectShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RoundRectShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.drawable.shapes.RoundRectShape clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;", ref global::android.graphics.drawable.shapes.RoundRectShape._m0) as android.graphics.drawable.shapes.RoundRectShape;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.RoundRectShape._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onResize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "onResize", "(FF)V", ref global::android.graphics.drawable.shapes.RoundRectShape._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RoundRectShape(float[] arg0, android.graphics.RectF arg1, float[] arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.RoundRectShape._m3.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.RoundRectShape._m3 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "<init>", "([FLandroid/graphics/RectF;[F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static RoundRectShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.RoundRectShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/RoundRectShape"));
		}
		internal static void InitJNI()
		{
		}
	}
}
