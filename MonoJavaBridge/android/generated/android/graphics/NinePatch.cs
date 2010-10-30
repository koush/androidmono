namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NinePatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NinePatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw5375;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw5376;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw5377;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion5378;
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getTransparentRegion5378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region;
		}
		public new int Density
		{
			get
			{
				return getDensity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDensity5379;
		public virtual int getDensity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getDensity5379);
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5380;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getWidth5380);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5381;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getHeight5381);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha5382;
		public virtual bool hasAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._hasAlpha5382);
		}
		public new global::android.graphics.Paint Paint
		{
			set
			{
				setPaint(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPaint5383;
		public virtual void setPaint(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._setPaint5383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNinePatchChunk5384;
		public static bool isNinePatchChunk(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._isNinePatchChunk5384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NinePatch5385;
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._NinePatch5385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static NinePatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.NinePatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/NinePatch"));
			global::android.graphics.NinePatch._draw5375 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V");
			global::android.graphics.NinePatch._draw5376 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V");
			global::android.graphics.NinePatch._draw5377 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._getTransparentRegion5378 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;");
			global::android.graphics.NinePatch._getDensity5379 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getDensity", "()I");
			global::android.graphics.NinePatch._getWidth5380 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getWidth", "()I");
			global::android.graphics.NinePatch._getHeight5381 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getHeight", "()I");
			global::android.graphics.NinePatch._hasAlpha5382 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z");
			global::android.graphics.NinePatch._setPaint5383 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._isNinePatchChunk5384 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z");
			global::android.graphics.NinePatch._NinePatch5385 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
