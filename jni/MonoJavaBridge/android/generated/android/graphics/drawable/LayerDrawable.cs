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
		internal static global::MonoJavaBridge.MethodId _getId6083;
		public virtual int getId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getId6083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getId6083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate6084;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._inflate6084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._inflate6084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable6085;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getDrawable6085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getDrawable6085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _draw6086;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._draw6086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._draw6086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6087;
		public override int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations6087);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getChangingConfigurations6087);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither6088;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setDither6088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDither6088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6089;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setAlpha6089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setAlpha6089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6090;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setColorFilter6090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setColorFilter6090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6091;
		public override bool isStateful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._isStateful6091);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._isStateful6091);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6092;
		public override bool setVisible(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setVisible6092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setVisible6092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6093;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getOpacity6093);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getOpacity6093);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6094;
		protected override bool onStateChange(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onStateChange6094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onStateChange6094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6095;
		protected override bool onLevelChange(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onLevelChange6095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onLevelChange6095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6096;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._onBoundsChange6096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._onBoundsChange6096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6097;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth6097);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth6097);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6098;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight6098);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight6098);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6099;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getPadding6099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getPadding6099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6100;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._mutate6100)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._mutate6100)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6101;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getConstantState6101)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getConstantState6101)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6102;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._invalidateDrawable6102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._invalidateDrawable6102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6103;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._scheduleDrawable6103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._scheduleDrawable6103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6104;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable6104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._unscheduleDrawable6104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setId6105;
		public virtual void setId(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setId6105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setId6105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _findDrawableByLayerId6106;
		public virtual global::android.graphics.drawable.Drawable findDrawableByLayerId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId6106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId6106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new int NumberOfLayers
		{
			get
			{
				return getNumberOfLayers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfLayers6107;
		public virtual int getNumberOfLayers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers6107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._getNumberOfLayers6107);
		}
		internal static global::MonoJavaBridge.MethodId _setDrawableByLayerId6108;
		public virtual bool setDrawableByLayerId(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId6108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId6108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLayerInset6109;
		public virtual void setLayerInset(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable._setLayerInset6109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._setLayerInset6109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _LayerDrawable6110;
		public LayerDrawable(android.graphics.drawable.Drawable[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.LayerDrawable.staticClass, global::android.graphics.drawable.LayerDrawable._LayerDrawable6110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.LayerDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/LayerDrawable"));
			global::android.graphics.drawable.LayerDrawable._getId6083 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getId", "(I)I");
			global::android.graphics.drawable.LayerDrawable._inflate6084 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.LayerDrawable._getDrawable6085 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._draw6086 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.LayerDrawable._getChangingConfigurations6087 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.LayerDrawable._setDither6088 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.LayerDrawable._setAlpha6089 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.LayerDrawable._setColorFilter6090 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.LayerDrawable._isStateful6091 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.LayerDrawable._setVisible6092 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.LayerDrawable._getOpacity6093 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.LayerDrawable._onStateChange6094 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.LayerDrawable._onLevelChange6095 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.LayerDrawable._onBoundsChange6096 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth6097 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight6098 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.LayerDrawable._getPadding6099 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.LayerDrawable._mutate6100 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getConstantState6101 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.LayerDrawable._invalidateDrawable6102 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.LayerDrawable._scheduleDrawable6103 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.LayerDrawable._unscheduleDrawable6104 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.LayerDrawable._setId6105 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setId", "(II)V");
			global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId6106 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LayerDrawable._getNumberOfLayers6107 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "getNumberOfLayers", "()I");
			global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId6108 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z");
			global::android.graphics.drawable.LayerDrawable._setLayerInset6109 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "setLayerInset", "(IIIII)V");
			global::android.graphics.drawable.LayerDrawable._LayerDrawable6110 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LayerDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
