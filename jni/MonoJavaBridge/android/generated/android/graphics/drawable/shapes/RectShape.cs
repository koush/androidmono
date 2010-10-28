namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RectShape : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RectShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone6248;
		public virtual global::android.graphics.drawable.shapes.RectShape clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape._clone6248)) as android.graphics.drawable.shapes.RectShape;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._clone6248)) as android.graphics.drawable.shapes.RectShape;
		}
		internal static global::MonoJavaBridge.MethodId _draw6249;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape._draw6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._draw6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rect6250;
		protected virtual global::android.graphics.RectF rect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape._rect6250)) as android.graphics.RectF;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._rect6250)) as android.graphics.RectF;
		}
		internal static global::MonoJavaBridge.MethodId _onResize6251;
		protected override void onResize(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape._onResize6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._onResize6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RectShape6252;
		public RectShape() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.RectShape.staticClass, global::android.graphics.drawable.shapes.RectShape._RectShape6252);
			Init(@__env, handle);
		}
		static RectShape()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.RectShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/RectShape"));
			global::android.graphics.drawable.shapes.RectShape._clone6248 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RectShape;");
			global::android.graphics.drawable.shapes.RectShape._draw6249 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.RectShape._rect6250 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "rect", "()Landroid/graphics/RectF;");
			global::android.graphics.drawable.shapes.RectShape._onResize6251 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.RectShape._RectShape6252 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RectShape.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
