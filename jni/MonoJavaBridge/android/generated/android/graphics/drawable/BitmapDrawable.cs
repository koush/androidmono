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
		internal static global::MonoJavaBridge.MethodId _inflate5833;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._inflate5833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._inflate5833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5834;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._draw5834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._draw5834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5835;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5835);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5835);
		}
		internal static global::MonoJavaBridge.MethodId _setDither5836;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setDither5836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setDither5836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap5837;
		public override void setFilterBitmap(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5838;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAlpha5838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAlpha5838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5839;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setColorFilter5839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setColorFilter5839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5840;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getOpacity5840);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getOpacity5840);
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5841;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._onBoundsChange5841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._onBoundsChange5841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5842;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5842);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5842);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5843;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5843);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5843);
		}
		internal static global::MonoJavaBridge.MethodId _mutate5844;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._mutate5844)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._mutate5844)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5845;
		public sealed override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getConstantState5845)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getConstantState5845)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _setGravity5846;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setGravity5846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setGravity5846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint5847;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getPaint5847)) as android.graphics.Paint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getPaint5847)) as android.graphics.Paint;
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
		internal static global::MonoJavaBridge.MethodId _getGravity5848;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getGravity5848);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getGravity5848);
		}
		internal static global::MonoJavaBridge.MethodId _setAntiAlias5849;
		public virtual void setAntiAlias(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setAntiAlias5849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAntiAlias5849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap Bitmap
		{
			get
			{
				return getBitmap();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBitmap5850;
		public virtual global::android.graphics.Bitmap getBitmap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getBitmap5850)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getBitmap5850)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5851;
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5852;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTargetDensity5853;
		public virtual void setTargetDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity5853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getTileModeX5854;
		public virtual global::android.graphics.Shader.TileMode getTileModeX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeX5854)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeX5854)) as android.graphics.Shader.TileMode;
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
		internal static global::MonoJavaBridge.MethodId _getTileModeY5855;
		public virtual global::android.graphics.Shader.TileMode getTileModeY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._getTileModeY5855)) as android.graphics.Shader.TileMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Shader.TileMode>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeY5855)) as android.graphics.Shader.TileMode;
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeX5856;
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeX5856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeX5856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeY5857;
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeY5857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeY5857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTileModeXY5858;
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable._setTileModeXY5858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeXY5858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5859;
		public BitmapDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5859);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5860;
		public BitmapDrawable(android.content.res.Resources arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5861;
		public BitmapDrawable(android.graphics.Bitmap arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5862;
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5863;
		public BitmapDrawable(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5864;
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5865;
		public BitmapDrawable(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BitmapDrawable5866;
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/BitmapDrawable"));
			global::android.graphics.drawable.BitmapDrawable._inflate5833 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.BitmapDrawable._draw5834 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations5835 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.BitmapDrawable._setDither5836 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setFilterBitmap5837 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setAlpha5838 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._setColorFilter5839 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.BitmapDrawable._getOpacity5840 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.BitmapDrawable._onBoundsChange5841 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth5842 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight5843 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.BitmapDrawable._mutate5844 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.BitmapDrawable._getConstantState5845 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.BitmapDrawable._setGravity5846 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getPaint5847 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.BitmapDrawable._getGravity5848 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I");
			global::android.graphics.drawable.BitmapDrawable._setAntiAlias5849 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._getBitmap5850 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5851 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5852 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity5853 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getTileModeX5854 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._getTileModeY5855 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._setTileModeX5856 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeY5857 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeXY5858 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5859 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5860 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5861 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5862 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5863 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5864 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5865 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable5866 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V");
		}
	}
}
