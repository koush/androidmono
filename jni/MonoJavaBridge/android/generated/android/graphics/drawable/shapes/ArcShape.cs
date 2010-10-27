namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArcShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArcShape()
		{
			InitJNI();
		}
		protected ArcShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6240;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.ArcShape._draw6240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.ArcShape.staticClass, global::android.graphics.drawable.shapes.ArcShape._draw6240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ArcShape6241;
		public ArcShape(float arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.ArcShape.staticClass, global::android.graphics.drawable.shapes.ArcShape._ArcShape6241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.ArcShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/ArcShape"));
			global::android.graphics.drawable.shapes.ArcShape._draw6240 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.ArcShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.ArcShape._ArcShape6241 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.ArcShape.staticClass, "<init>", "(FF)V");
		}
	}
}
