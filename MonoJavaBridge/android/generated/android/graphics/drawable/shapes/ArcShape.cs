namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArcShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArcShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.ArcShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.ArcShape._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ArcShape(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.ArcShape._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.ArcShape._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.ArcShape.staticClass, "<init>", "(FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.ArcShape.staticClass, global::android.graphics.drawable.shapes.ArcShape._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ArcShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.ArcShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/ArcShape"));
		}
		internal static void InitJNI()
		{
		}
	}
}
