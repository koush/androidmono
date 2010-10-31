namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NinePatchDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NinePatchDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.NinePatchDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.NinePatchDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m2);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.NinePatchDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.drawable.NinePatchDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.NinePatchDrawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.NinePatchDrawable._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m7);
		}
		public new global::android.graphics.Region TransparentRegion
		{
			get
			{
				return getTransparentRegion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::android.graphics.Region getTransparentRegion()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;", ref global::android.graphics.drawable.NinePatchDrawable._m8) as android.graphics.Region;
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m9);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m10);
		}
		public new int MinimumWidth
		{
			get
			{
				return getMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumWidth", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m11);
		}
		public new int MinimumHeight
		{
			get
			{
				return getMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumHeight", "()I", ref global::android.graphics.drawable.NinePatchDrawable._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.NinePatchDrawable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.NinePatchDrawable._m14) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.NinePatchDrawable._m15) as android.graphics.drawable.Drawable.ConstantState;
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.graphics.Paint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;", ref global::android.graphics.drawable.NinePatchDrawable._m16) as android.graphics.Paint;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setTargetDensity(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.NinePatchDrawable._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V", ref global::android.graphics.drawable.NinePatchDrawable._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setTargetDensity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(I)V", ref global::android.graphics.drawable.NinePatchDrawable._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.NinePatch arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._m20.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._m20 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1, byte[] arg2, android.graphics.Rect arg3, java.lang.String arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._m21.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._m21 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public NinePatchDrawable(android.graphics.NinePatch arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._m22.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._m22 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/NinePatch;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public NinePatchDrawable(android.graphics.Bitmap arg0, byte[] arg1, android.graphics.Rect arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.NinePatchDrawable._m23.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.NinePatchDrawable._m23 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, global::android.graphics.drawable.NinePatchDrawable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static NinePatchDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.NinePatchDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/NinePatchDrawable"));
		}
	}
}
