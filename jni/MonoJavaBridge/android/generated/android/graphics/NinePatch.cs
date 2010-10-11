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
		internal static global::MonoJavaBridge.MethodId _draw3404;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw3404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw3405;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw3405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _draw3406;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._draw3406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion3407;
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.NinePatch._getTransparentRegion3407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getTransparentRegion3407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region;
		}
		internal static global::MonoJavaBridge.MethodId _getDensity3408;
		public virtual int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getDensity3408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getDensity3408);
		}
		internal static global::MonoJavaBridge.MethodId _getWidth3409;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getWidth3409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getWidth3409);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight3410;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.NinePatch._getHeight3410);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getHeight3410);
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha3411;
		public virtual bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.NinePatch._hasAlpha3411);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._hasAlpha3411);
		}
		internal static global::MonoJavaBridge.MethodId _setPaint3412;
		public virtual void setPaint(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.NinePatch._setPaint3412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._setPaint3412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNinePatchChunk3413;
		public static bool isNinePatchChunk(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._isNinePatchChunk3413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NinePatch3414;
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._NinePatch3414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.NinePatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/NinePatch"));
			global::android.graphics.NinePatch._draw3404 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V");
			global::android.graphics.NinePatch._draw3405 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V");
			global::android.graphics.NinePatch._draw3406 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._getTransparentRegion3407 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;");
			global::android.graphics.NinePatch._getDensity3408 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getDensity", "()I");
			global::android.graphics.NinePatch._getWidth3409 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getWidth", "()I");
			global::android.graphics.NinePatch._getHeight3410 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "getHeight", "()I");
			global::android.graphics.NinePatch._hasAlpha3411 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z");
			global::android.graphics.NinePatch._setPaint3412 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._isNinePatchChunk3413 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z");
			global::android.graphics.NinePatch._NinePatch3414 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V");
		}
	}
}
