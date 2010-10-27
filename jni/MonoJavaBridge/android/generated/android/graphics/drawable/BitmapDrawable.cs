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
		internal static global::MonoJavaBridge.MethodId _inflate5852;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._inflate5852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._inflate5852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5853;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._draw5853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._draw5853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5854;
		public override int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5854);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5854);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither5855;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setDither5855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setDither5855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap5856;
		public override void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5857;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAlpha5857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAlpha5857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5858;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setColorFilter5858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setColorFilter5858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5859;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getOpacity5859);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getOpacity5859);
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5860;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._onBoundsChange5860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._onBoundsChange5860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5861;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5861);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5861);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5862;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5862);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5862);
		}
		internal static global::MonoJavaBridge.MethodId _mutate5863;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._mutate5863)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._mutate5863)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5864;
		public sealed override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getConstantState5864)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getConstantState5864)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _setGravity5865;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setGravity5865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setGravity5865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint5866;
		public virtual global::android.graphics.Paint getPaint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getPaint5866)) as android.graphics.Paint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getPaint5866)) as android.graphics.Paint;
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
		internal static global::MonoJavaBridge.MethodId _getGravity5867;
		public virtual int getGravity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getGravity5867);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getGravity5867);
		}
		public new bool AntiAlias
		{
			set
			{
				setAntiAlias(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAntiAlias5868;
		public virtual void setAntiAlias(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAntiAlias5868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAntiAlias5868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			get
			{
				return getBitmap();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBitmap5869;
		public virtual global::android.graphics.Bitmap getBitmap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getBitmap5869)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getBitmap5869)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5870;
		public virtual void setTargetDensity(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5871;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5872;
		public virtual void setTargetDensity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTileModeX5873;
		public virtual global::android.graphics.Shader.TileMode getTileModeX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeX5873)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeX5873)) as android.graphics.Shader.TileMode;
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
		internal static global::MonoJavaBridge.MethodId _getTileModeY5874;
		public virtual global::android.graphics.Shader.TileMode getTileModeY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeY5874)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeY5874)) as android.graphics.Shader.TileMode;
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeX5875;
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeX5875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeX5875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeY5876;
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeY5876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeY5876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeXY5877;
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeXY5877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeXY5877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5878;
		public BitmapDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5878);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5879;
		public BitmapDrawable(android.content.res.Resources arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5880;
		public BitmapDrawable(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5881;
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5882;
		public BitmapDrawable(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5883;
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5884;
		public BitmapDrawable(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5885;
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/BitmapDrawable"));
			global::android.graphics.drawable.BitmapDrawable._inflate5852 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.BitmapDrawable._draw5853 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5854 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.BitmapDrawable._setDither5855 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5856 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setAlpha5857 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._setColorFilter5858 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.BitmapDrawable._getOpacity5859 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.BitmapDrawable._onBoundsChange5860 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5861 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5862 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.BitmapDrawable._mutate5863 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.BitmapDrawable._getConstantState5864 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.BitmapDrawable._setGravity5865 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getPaint5866 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.BitmapDrawable._getGravity5867 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I");
			global::android.graphics.drawable.BitmapDrawable._setAntiAlias5868 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._getBitmap5869 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5870 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5871 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5872 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getTileModeX5873 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._getTileModeY5874 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._setTileModeX5875 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeY5876 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeXY5877 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5878 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5879 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5880 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5881 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5882 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5883 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5884 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5885 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V");
		}
	}
}
