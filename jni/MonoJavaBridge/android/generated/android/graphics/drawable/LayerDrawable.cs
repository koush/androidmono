namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayerDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayerDrawable()
		{
			InitJNI();
		}
		protected LayerDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getId4070;
		public virtual int getId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getId4070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getId4070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate4071;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._inflate4071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._inflate4071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable4072;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getDrawable4072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getDrawable4072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _draw4073;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._draw4073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._draw4073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations4074;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations4074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations4074);
		}
		internal static global::MonoJavaBridge.MethodId _setDither4075;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setDither4075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDither4075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha4076;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setAlpha4076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setAlpha4076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter4077;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setColorFilter4077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setColorFilter4077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful4078;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._isStateful4078);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._isStateful4078);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible4079;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setVisible4079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setVisible4079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity4080;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getOpacity4080);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getOpacity4080);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange4081;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onStateChange4081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onStateChange4081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange4082;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onLevelChange4082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onLevelChange4082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange4083;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onBoundsChange4083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onBoundsChange4083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4084;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth4084);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth4084);
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4085;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight4085);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight4085);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4086;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getPadding4086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getPadding4086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4087;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._mutate4087)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._mutate4087)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4088;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getConstantState4088)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getConstantState4088)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable4089;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._invalidateDrawable4089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._invalidateDrawable4089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable4090;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._scheduleDrawable4090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._scheduleDrawable4090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable4091;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable4091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable4091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setId4092;
		public virtual void setId(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setId4092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setId4092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _findDrawableByLayerId4093;
		public virtual global::android.graphics.drawable.Drawable findDrawableByLayerId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId4093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId4093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfLayers4094;
		public virtual int getNumberOfLayers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers4094);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers4094);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawableByLayerId4095;
		public virtual bool setDrawableByLayerId(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId4095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId4095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLayerInset4096;
		public virtual void setLayerInset(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setLayerInset4096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setLayerInset4096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _LayerDrawable4097;
		public LayerDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._LayerDrawable4097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.LayerDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/LayerDrawable"));
			global::android.graphics.drawable.LayerDrawable._getId4070 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getId", "(I)I");
			global::android.graphics.drawable.LayerDrawable._inflate4071 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.LayerDrawable._getDrawable4072 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._draw4073 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.LayerDrawable._getChangingConfigurations4074 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.LayerDrawable._setDither4075 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.LayerDrawable._setAlpha4076 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.LayerDrawable._setColorFilter4077 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.LayerDrawable._isStateful4078 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.LayerDrawable._setVisible4079 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.LayerDrawable._getOpacity4080 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.LayerDrawable._onStateChange4081 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.LayerDrawable._onLevelChange4082 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.LayerDrawable._onBoundsChange4083 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth4084 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight4085 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.LayerDrawable._getPadding4086 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.LayerDrawable._mutate4087 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getConstantState4088 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.LayerDrawable._invalidateDrawable4089 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.LayerDrawable._scheduleDrawable4090 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.LayerDrawable._unscheduleDrawable4091 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.LayerDrawable._setId4092 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setId", "(II)V");
			global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId4093 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getNumberOfLayers4094 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getNumberOfLayers", "()I");
			global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId4095 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z");
			global::android.graphics.drawable.LayerDrawable._setLayerInset4096 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setLayerInset", "(IIIII)V");
			global::android.graphics.drawable.LayerDrawable._LayerDrawable4097 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
