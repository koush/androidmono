namespace android.graphics.drawable.shapes
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.shapes.Shape_))]
	public abstract partial class Shape : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Shape()
		{
			InitJNI();
		}
		protected Shape(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone4244;
		public virtual new global::android.graphics.drawable.shapes.Shape clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._clone4244)) as android.graphics.drawable.shapes.Shape;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._clone4244)) as android.graphics.drawable.shapes.Shape;
		}
		internal static global::MonoJavaBridge.MethodId _resize4245;
		public virtual void resize(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._resize4245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._resize4245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw4246;
		public abstract void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1);
		internal static global::MonoJavaBridge.MethodId _getWidth4247;
		public virtual float getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._getWidth4247);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getWidth4247);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight4248;
		public virtual float getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._getHeight4248);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._getHeight4248);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha4249;
		public virtual bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._hasAlpha4249);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._hasAlpha4249);
		}
		internal static global::MonoJavaBridge.MethodId _onResize4250;
		protected virtual void onResize(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape._onResize4250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._onResize4250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _Shape4251;
		public Shape()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.shapes.Shape.staticClass, global::android.graphics.drawable.shapes.Shape._Shape4251);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
			global::android.graphics.drawable.shapes.Shape._clone4244 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "clone", "()Landroid/graphics/drawable/shapes/Shape;");
			global::android.graphics.drawable.shapes.Shape._resize4245 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "resize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._draw4246 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.shapes.Shape._getWidth4247 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "getWidth", "()F");
			global::android.graphics.drawable.shapes.Shape._getHeight4248 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "getHeight", "()F");
			global::android.graphics.drawable.shapes.Shape._hasAlpha4249 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "hasAlpha", "()Z");
			global::android.graphics.drawable.shapes.Shape._onResize4250 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "onResize", "(FF)V");
			global::android.graphics.drawable.shapes.Shape._Shape4251 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.shapes.Shape))]
	public sealed partial class Shape_ : android.graphics.drawable.shapes.Shape
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Shape_()
		{
			InitJNI();
		}
		internal Shape_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw4252;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Paint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape_._draw4252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.shapes.Shape_.staticClass, global::android.graphics.drawable.shapes.Shape_._draw4252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.shapes.Shape_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/shapes/Shape"));
			global::android.graphics.drawable.shapes.Shape_._draw4252 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.shapes.Shape_.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
		}
	}
}
