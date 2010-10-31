namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NinePatch : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NinePatch(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V", ref global::android.graphics.NinePatch._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V", ref global::android.graphics.NinePatch._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V", ref global::android.graphics.NinePatch._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;", ref global::android.graphics.NinePatch._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Region;
		}
		public new int Density
		{
			get
			{
				return getDensity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getDensity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, "getDensity", "()I", ref global::android.graphics.NinePatch._m4);
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, "getWidth", "()I", ref global::android.graphics.NinePatch._m5);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.NinePatch.staticClass, "getHeight", "()I", ref global::android.graphics.NinePatch._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool hasAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z", ref global::android.graphics.NinePatch._m7);
		}
		public new global::android.graphics.Paint Paint
		{
			set
			{
				setPaint(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setPaint(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V", ref global::android.graphics.NinePatch._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool isNinePatchChunk(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.NinePatch._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.NinePatch._m9 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z");
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.NinePatch._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.NinePatch._m10 = @__env.GetMethodIDNoThrow(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static NinePatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.NinePatch.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/NinePatch"));
		}
	}
}
