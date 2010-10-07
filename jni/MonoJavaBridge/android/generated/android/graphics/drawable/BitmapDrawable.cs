namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BitmapDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::java.lang.Class staticClass;
		static BitmapDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.BitmapDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.BitmapDrawable(@__env);
			}
		}
		protected BitmapDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3656;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._inflate3656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._inflate3656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3657;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._draw3657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._draw3657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3658;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3658);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3658);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3659;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setDither3659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setDither3659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3660;
		public override void setFilterBitmap(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3660, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3661;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setAlpha3661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAlpha3661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3662;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setColorFilter3662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setColorFilter3662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3663;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable._getOpacity3663);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getOpacity3663);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3664;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._onBoundsChange3664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._onBoundsChange3664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3665;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3665);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3665);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3666;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3666);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3666);
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3667;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._mutate3667));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._mutate3667));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3668;
		public sealed override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._getConstantState3668));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getConstantState3668));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity3669;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setGravity3669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setGravity3669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3670;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._getPaint3670));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getPaint3670));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGravity3671;
		public virtual int getGravity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.BitmapDrawable._getGravity3671);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getGravity3671);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAntiAlias3672;
		public virtual void setAntiAlias(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setAntiAlias3672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setAntiAlias3672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBitmap3673;
		public virtual global::android.graphics.Bitmap getBitmap() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._getBitmap3673));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getBitmap3673));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3674;
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3675;
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3676;
		public virtual void setTargetDensity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTargetDensity3676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTileModeX3677;
		public virtual global::android.graphics.Shader.TileMode getTileModeX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._getTileModeX3677));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeX3677));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTileModeY3678;
		public virtual global::android.graphics.Shader.TileMode getTileModeY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable._getTileModeY3678));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._getTileModeY3678));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeX3679;
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTileModeX3679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeX3679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeY3680;
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTileModeY3680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeY3680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeXY3681;
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.BitmapDrawable._setTileModeXY3681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._setTileModeXY3681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3682;
		public BitmapDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3682, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3683;
		public BitmapDrawable(android.content.res.Resources arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3683, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3684;
		public BitmapDrawable(android.graphics.Bitmap arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3684, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3685;
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3685, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3686;
		public BitmapDrawable(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3686, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3687;
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3687, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3688;
		public BitmapDrawable(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3688, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3689;
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3689, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__class;
			global::android.graphics.drawable.BitmapDrawable._inflate3656 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.BitmapDrawable._draw3657 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3658 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.BitmapDrawable._setDither3659 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3660 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._setAlpha3661 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._setColorFilter3662 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.BitmapDrawable._getOpacity3663 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.BitmapDrawable._onBoundsChange3664 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3665 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3666 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.BitmapDrawable._mutate3667 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.BitmapDrawable._getConstantState3668 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.BitmapDrawable._setGravity3669 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getPaint3670 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.BitmapDrawable._getGravity3671 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I");
			global::android.graphics.drawable.BitmapDrawable._setAntiAlias3672 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V");
			global::android.graphics.drawable.BitmapDrawable._getBitmap3673 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3674 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3675 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V");
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3676 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V");
			global::android.graphics.drawable.BitmapDrawable._getTileModeX3677 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._getTileModeY3678 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;");
			global::android.graphics.drawable.BitmapDrawable._setTileModeX3679 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeY3680 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._setTileModeXY3681 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3682 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3683 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3684 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3685 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3686 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3687 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3688 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3689 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V");
		}
	}
}
