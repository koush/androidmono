namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RoundRectShape : android.graphics.drawable.shapes.RectShape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RoundRectShape()
		{
			InitJNI();
		}
		protected RoundRectShape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone4240;
		public virtual global::android.graphics.drawable.shapes.RoundRectShape clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape._clone4240)) as android.graphics.drawable.shapes.RoundRectShape;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._clone4240)) as android.graphics.drawable.shapes.RoundRectShape;
		}
		internal static global::MonoJavaBridge.MethodId _draw4241;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape._draw4241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._draw4241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onResize4242;
		protected override void onResize(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape._onResize4242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._onResize4242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RoundRectShape4243;
		public RoundRectShape(float[] arg0, android.graphics.RectF arg1, float[] arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.RoundRectShape.staticClass, global::android.graphics.drawable.shapes.RoundRectShape._RoundRectShape4243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.RoundRectShape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/RoundRectShape"));
			global::android.graphics.drawable.shapes.RoundRectShape._clone4240 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/RoundRectShape;");
			global::android.graphics.drawable.shapes.RoundRectShape._draw4241 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.RoundRectShape._onResize4242 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.RoundRectShape._RoundRectShape4243 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.RoundRectShape.staticClass, "<init>", "([FLandroid/graphics/RectF;[F)V");
		}
	}
}
