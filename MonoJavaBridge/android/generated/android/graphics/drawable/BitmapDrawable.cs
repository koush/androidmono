namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BitmapDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.BitmapDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.BitmapDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.BitmapDrawable._m2);
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.BitmapDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.drawable.BitmapDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.BitmapDrawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.BitmapDrawable._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.BitmapDrawable._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.BitmapDrawable._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.BitmapDrawable._m9);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.BitmapDrawable._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.BitmapDrawable._m11) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public sealed override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.BitmapDrawable._m12) as android.graphics.drawable.Drawable.ConstantState;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V", ref global::android.graphics.drawable.BitmapDrawable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.graphics.Paint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;", ref global::android.graphics.drawable.BitmapDrawable._m14) as android.graphics.Paint;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
			set
			{
				setGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getGravity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I", ref global::android.graphics.drawable.BitmapDrawable._m15);
		}
		public new bool AntiAlias
		{
			set
			{
				setAntiAlias(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setAntiAlias(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V", ref global::android.graphics.drawable.BitmapDrawable._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			get
			{
				return getBitmap();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.graphics.Bitmap getBitmap()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;", ref global::android.graphics.drawable.BitmapDrawable._m17) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setTargetDensity(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.BitmapDrawable._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V", ref global::android.graphics.drawable.BitmapDrawable._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setTargetDensity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V", ref global::android.graphics.drawable.BitmapDrawable._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Shader.TileMode TileModeX
		{
			get
			{
				return getTileModeX();
			}
			set
			{
				setTileModeX(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::android.graphics.Shader.TileMode getTileModeX()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Shader.TileMode>(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;", ref global::android.graphics.drawable.BitmapDrawable._m21) as android.graphics.Shader.TileMode;
		}
		public new global::android.graphics.Shader.TileMode TileModeY
		{
			get
			{
				return getTileModeY();
			}
			set
			{
				setTileModeY(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.graphics.Shader.TileMode getTileModeY()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Shader.TileMode>(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;", ref global::android.graphics.drawable.BitmapDrawable._m22) as android.graphics.Shader.TileMode;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V", ref global::android.graphics.drawable.BitmapDrawable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V", ref global::android.graphics.drawable.BitmapDrawable._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", ref global::android.graphics.drawable.BitmapDrawable._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public BitmapDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m26.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m26 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m26);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public BitmapDrawable(android.content.res.Resources arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m27.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m27 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public BitmapDrawable(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m28.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m28 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m29.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m29 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public BitmapDrawable(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m30.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m30 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m31.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m31 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public BitmapDrawable(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m32.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m32 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.BitmapDrawable._m33.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.BitmapDrawable._m33 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BitmapDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/BitmapDrawable"));
		}
	}
}
