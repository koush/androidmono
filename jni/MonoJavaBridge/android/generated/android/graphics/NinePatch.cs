namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NinePatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NinePatch()
		{
			InitJNI();
		}
		protected NinePatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw5356;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw5356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw5357;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw5357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw5358;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw5358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw5358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion5359;
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.NinePatch._getTransparentRegion5359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getTransparentRegion5359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region;
		}
		public new int Density
		{
			get
			{
				return getDensity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDensity5360;
		public virtual int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getDensity5360);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getDensity5360);
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5361;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getWidth5361);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getWidth5361);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5362;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getHeight5362);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getHeight5362);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha5363;
		public virtual bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.NinePatch._hasAlpha5363);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._hasAlpha5363);
		}
		internal static global::MonoJavaBridge.MethodId _setPaint5364;
		public virtual void setPaint(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._setPaint5364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._setPaint5364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNinePatchChunk5365;
		public static bool isNinePatchChunk(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._isNinePatchChunk5365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NinePatch5366;
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._NinePatch5366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.NinePatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/NinePatch"));
			global::android.graphics.NinePatch._draw5356 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V");
			global::android.graphics.NinePatch._draw5357 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V");
			global::android.graphics.NinePatch._draw5358 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._getTransparentRegion5359 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;");
			global::android.graphics.NinePatch._getDensity5360 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getDensity", "()I");
			global::android.graphics.NinePatch._getWidth5361 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getWidth", "()I");
			global::android.graphics.NinePatch._getHeight5362 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getHeight", "()I");
			global::android.graphics.NinePatch._hasAlpha5363 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z");
			global::android.graphics.NinePatch._setPaint5364 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._isNinePatchChunk5365 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z");
			global::android.graphics.NinePatch._NinePatch5366 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V");
		}
	}
}
