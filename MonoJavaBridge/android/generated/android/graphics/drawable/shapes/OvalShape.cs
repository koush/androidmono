namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OvalShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OvalShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.shapes.OvalShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.shapes.OvalShape._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public OvalShape() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.shapes.OvalShape._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.shapes.OvalShape._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.OvalShape.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.OvalShape.staticClass, global::android.graphics.drawable.shapes.OvalShape._m1);
			Init(@__env, handle);
		}
		static OvalShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.OvalShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/OvalShape"));
		}
	}
}
