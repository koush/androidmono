namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PictureDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PictureDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.PictureDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.PictureDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.drawable.PictureDrawable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.PictureDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.PictureDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.PictureDrawable._m5);
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.PictureDrawable._m6);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.PictureDrawable._m7);
		}
		public new global::android.graphics.Picture Picture
		{
			get
			{
				return getPicture();
			}
			set
			{
				setPicture(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.graphics.Picture getPicture()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "getPicture", "()Landroid/graphics/Picture;", ref global::android.graphics.drawable.PictureDrawable._m8) as android.graphics.Picture;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setPicture(android.graphics.Picture arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, "setPicture", "(Landroid/graphics/Picture;)V", ref global::android.graphics.drawable.PictureDrawable._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public PictureDrawable(android.graphics.Picture arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._m10 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PictureDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PictureDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PictureDrawable"));
		}
	}
}
