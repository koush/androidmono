namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PictureDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PictureDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6145;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._draw6145.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._draw6145 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._draw6145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither6146;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._setDither6146.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._setDither6146 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setDither", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setDither6146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap6147;
		public override void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._setFilterBitmap6147.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._setFilterBitmap6147 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setFilterBitmap6147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6148;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._setAlpha6148.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._setAlpha6148 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setAlpha", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setAlpha6148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6149;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._setColorFilter6149.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._setColorFilter6149 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setColorFilter6149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6150;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._getOpacity6150.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._getOpacity6150 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getOpacity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getOpacity6150);
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6151;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6151.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6151 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicWidth", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6151);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6152;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6152.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6152 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicHeight", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6152);
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
		internal static global::MonoJavaBridge.MethodId _getPicture6153;
		public virtual global::android.graphics.Picture getPicture()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._getPicture6153.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._getPicture6153 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getPicture", "()Landroid/graphics/Picture;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getPicture6153) as android.graphics.Picture;
		}
		internal static global::MonoJavaBridge.MethodId _setPicture6154;
		public virtual void setPicture(android.graphics.Picture arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._setPicture6154.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._setPicture6154 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setPicture", "(Landroid/graphics/Picture;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setPicture6154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PictureDrawable6155;
		public PictureDrawable(android.graphics.Picture arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PictureDrawable._PictureDrawable6155.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PictureDrawable._PictureDrawable6155 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._PictureDrawable6155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PictureDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PictureDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PictureDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
