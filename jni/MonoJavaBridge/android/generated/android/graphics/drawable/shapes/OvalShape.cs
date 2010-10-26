namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OvalShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OvalShape()
		{
			InitJNI();
		}
		protected OvalShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6242;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.OvalShape._draw6242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.OvalShape.staticClass, global::android.graphics.drawable.shapes.OvalShape._draw6242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _OvalShape6243;
		public OvalShape()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.OvalShape.staticClass, global::android.graphics.drawable.shapes.OvalShape._OvalShape6243);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.OvalShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/OvalShape"));
			global::android.graphics.drawable.shapes.OvalShape._draw6242 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.OvalShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.OvalShape._OvalShape6243 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.OvalShape.staticClass, "<init>", "()V");
		}
	}
}
