namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BitmapDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BitmapDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.BitmapDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3247; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _inflate3247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _inflate3247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3248; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _draw3248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _draw3248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3249; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3249); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _getChangingConfigurations3249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3250; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setDither3250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setDither3250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3251; 
		public override void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setFilterBitmap3251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setFilterBitmap3251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3252; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setAlpha3252, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3253; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setColorFilter3253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3254; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3254); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _getOpacity3254); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3255; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _onBoundsChange3255, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3256; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3256); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _getIntrinsicWidth3256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3257; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3257); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _getIntrinsicHeight3257); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3258; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3258)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _mutate3258)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3259; 
		public sealed override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3259)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _getConstantState3259)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity3260; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setGravity3260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setGravity3260, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3261; 
		public virtual android.graphics.Paint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, _getPaint3261)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _getPaint3261)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGravity3262; 
		public virtual int getGravity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return @__env.CallIntMethod(this, _getGravity3262); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _getGravity3262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAntiAlias3263; 
		public virtual void setAntiAlias(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setAntiAlias3263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setAntiAlias3263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBitmap3264; 
		public virtual android.graphics.Bitmap getBitmap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getBitmap3264)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _getBitmap3264)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3265; 
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTargetDensity3265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3266; 
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTargetDensity3266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3267; 
		public virtual void setTargetDensity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTargetDensity3267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTileModeX3268; 
		public virtual android.graphics.Shader.TileMode getTileModeX() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallObjectMethodPtr(this, _getTileModeX3268)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _getTileModeX3268)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTileModeY3269; 
		public virtual android.graphics.Shader.TileMode getTileModeY() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallObjectMethodPtr(this, _getTileModeY3269)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.BitmapDrawable.staticClass, _getTileModeY3269)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeX3270; 
		public virtual void setTileModeX(android.graphics.Shader.TileMode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTileModeX3270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTileModeX3270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeY3271; 
		public virtual void setTileModeY(android.graphics.Shader.TileMode arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTileModeY3271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTileModeY3271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTileModeXY3272; 
		public virtual void setTileModeXY(android.graphics.Shader.TileMode arg0, android.graphics.Shader.TileMode arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.BitmapDrawable)) 
				@__env.CallVoidMethod(this, _setTileModeXY3272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.BitmapDrawable.staticClass, _setTileModeXY3272, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3273; 
		public BitmapDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3273, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3274; 
		public BitmapDrawable(android.content.res.Resources arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3274, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3275; 
		public BitmapDrawable(android.graphics.Bitmap arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3275, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3276; 
		public BitmapDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3276, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3277; 
		public BitmapDrawable(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3277, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3278; 
		public BitmapDrawable(android.content.res.Resources arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3278, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3279; 
		public BitmapDrawable(java.io.InputStream arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3279, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapDrawable3280; 
		public BitmapDrawable(android.content.res.Resources arg0, java.io.InputStream arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.BitmapDrawable.staticClass, _BitmapDrawable3280, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.BitmapDrawable.staticClass = @__class; 
			global::android.graphics.drawable.BitmapDrawable._inflate3247 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.BitmapDrawable._draw3248 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.BitmapDrawable._getChangingConfigurations3249 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.BitmapDrawable._setDither3250 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.BitmapDrawable._setFilterBitmap3251 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.drawable.BitmapDrawable._setAlpha3252 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.BitmapDrawable._setColorFilter3253 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.BitmapDrawable._getOpacity3254 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.BitmapDrawable._onBoundsChange3255 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicWidth3256 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.BitmapDrawable._getIntrinsicHeight3257 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.BitmapDrawable._mutate3258 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.BitmapDrawable._getConstantState3259 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.BitmapDrawable._setGravity3260 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setGravity", "(I)V"); 
			global::android.graphics.drawable.BitmapDrawable._getPaint3261 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;"); 
			global::android.graphics.drawable.BitmapDrawable._getGravity3262 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getGravity", "()I"); 
			global::android.graphics.drawable.BitmapDrawable._setAntiAlias3263 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setAntiAlias", "(Z)V"); 
			global::android.graphics.drawable.BitmapDrawable._getBitmap3264 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getBitmap", "()Landroid/graphics/Bitmap;"); 
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3265 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3266 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V"); 
			global::android.graphics.drawable.BitmapDrawable._setTargetDensity3267 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTargetDensity", "(I)V"); 
			global::android.graphics.drawable.BitmapDrawable._getTileModeX3268 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeX", "()Landroid/graphics/Shader$TileMode;"); 
			global::android.graphics.drawable.BitmapDrawable._getTileModeY3269 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "getTileModeY", "()Landroid/graphics/Shader$TileMode;"); 
			global::android.graphics.drawable.BitmapDrawable._setTileModeX3270 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeX", "(Landroid/graphics/Shader$TileMode;)V"); 
			global::android.graphics.drawable.BitmapDrawable._setTileModeY3271 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeY", "(Landroid/graphics/Shader$TileMode;)V"); 
			global::android.graphics.drawable.BitmapDrawable._setTileModeXY3272 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3273 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "()V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3274 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3275 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3276 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3277 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3278 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3279 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Ljava/io/InputStream;)V"); 
			global::android.graphics.drawable.BitmapDrawable._BitmapDrawable3280 = @__env.GetMethodID(global::android.graphics.drawable.BitmapDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V"); 
		} 
	} 
} 
