namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BitmapDrawable()
		{
			InitJNI();
		}
		protected BitmapDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate3848;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._inflate3848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._inflate3848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw3849;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._draw3849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._draw3849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3850;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3850);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3850);
		}
		internal static global::MonoJavaBridge.MethodId _setDither3851;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setDither3851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setDither3851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap3852;
		public override void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3853;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAlpha3853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAlpha3853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter3854;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setColorFilter3854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setColorFilter3854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity3855;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getOpacity3855);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getOpacity3855);
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange3856;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._onBoundsChange3856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._onBoundsChange3856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth3857;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3857);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3857);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight3858;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3858);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3858);
		}
		internal static global::MonoJavaBridge.MethodId _mutate3859;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._mutate3859)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._mutate3859)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState3860;
		public sealed override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getConstantState3860)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getConstantState3860)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _setGravity3861;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setGravity3861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setGravity3861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint3862;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getPaint3862)) as android.graphics.Paint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getPaint3862)) as android.graphics.Paint;
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
		internal static global::MonoJavaBridge.MethodId _getGravity3863;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getGravity3863);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getGravity3863);
		}
		internal static global::MonoJavaBridge.MethodId _setAntiAlias3864;
		public virtual void setAntiAlias(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAntiAlias3864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAntiAlias3864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			get
			{
				return getBitmap();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBitmap3865;
		public virtual global::android.graphics.Bitmap getBitmap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getBitmap3865)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getBitmap3865)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity3866;
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity3867;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity3868;
		public virtual void setTargetDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTileModeX3869;
		public virtual global::android.graphics.Shader.TileMode getTileModeX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeX3869)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeX3869)) as android.graphics.Shader.TileMode;
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
		internal static global::MonoJavaBridge.MethodId _getTileModeY3870;
		public virtual global::android.graphics.Shader.TileMode getTileModeY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeY3870)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeY3870)) as android.graphics.Shader.TileMode;
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeX3871;
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeX3871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeX3871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeY3872;
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeY3872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeY3872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeXY3873;
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeXY3873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeXY3873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3874;
		public BitmapDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3874);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3875;
		public BitmapDrawable(android.content.res.Resources arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3876;
		public BitmapDrawable(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3877;
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3878;
		public BitmapDrawable(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3879;
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3880;
		public BitmapDrawable(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable3881;
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/BitmapDrawable"));
			global::android.graphics.drawable.BitmapDrawable._inflate3848 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.BitmapDrawable._draw3849 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3850 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.BitmapDrawable._setDither3851 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3852 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setAlpha3853 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._setColorFilter3854 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.BitmapDrawable._getOpacity3855 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.BitmapDrawable._onBoundsChange3856 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3857 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3858 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.BitmapDrawable._mutate3859 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.BitmapDrawable._getConstantState3860 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.BitmapDrawable._setGravity3861 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getPaint3862 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.BitmapDrawable._getGravity3863 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I");
			global::android.graphics.drawable.BitmapDrawable._setAntiAlias3864 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._getBitmap3865 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3866 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3867 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3868 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getTileModeX3869 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._getTileModeY3870 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._setTileModeX3871 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeY3872 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeXY3873 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3874 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3875 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3876 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3877 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3878 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3879 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3880 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3881 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V");
		}
	}
}
