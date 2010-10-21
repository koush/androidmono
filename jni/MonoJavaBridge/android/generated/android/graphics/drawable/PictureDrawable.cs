namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PictureDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PictureDrawable()
		{
			InitJNI();
		}
		protected PictureDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw6126;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._draw6126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._draw6126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDither6127;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._setDither6127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setDither6127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap6128;
		public override void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._setFilterBitmap6128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setFilterBitmap6128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6129;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._setAlpha6129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setAlpha6129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6130;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._setColorFilter6130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setColorFilter6130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6131;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._getOpacity6131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getOpacity6131);
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6132;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6132);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6133;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6133);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6133);
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
		internal static global::MonoJavaBridge.MethodId _getPicture6134;
		public virtual global::android.graphics.Picture getPicture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._getPicture6134)) as android.graphics.Picture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._getPicture6134)) as android.graphics.Picture;
		}
		internal static global::MonoJavaBridge.MethodId _setPicture6135;
		public virtual void setPicture(android.graphics.Picture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable._setPicture6135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._setPicture6135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PictureDrawable6136;
		public PictureDrawable(android.graphics.Picture arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PictureDrawable.staticClass, global::android.graphics.drawable.PictureDrawable._PictureDrawable6136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PictureDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PictureDrawable"));
			global::android.graphics.drawable.PictureDrawable._draw6126 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.PictureDrawable._setDither6127 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.PictureDrawable._setFilterBitmap6128 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.PictureDrawable._setAlpha6129 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.PictureDrawable._setColorFilter6130 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.PictureDrawable._getOpacity6131 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth6132 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight6133 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.PictureDrawable._getPicture6134 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "getPicture", "()Landroid/graphics/Picture;");
			global::android.graphics.drawable.PictureDrawable._setPicture6135 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "setPicture", "(Landroid/graphics/Picture;)V");
			global::android.graphics.drawable.PictureDrawable._PictureDrawable6136 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PictureDrawable.staticClass, "<init>", "(Landroid/graphics/Picture;)V");
		}
	}
}
