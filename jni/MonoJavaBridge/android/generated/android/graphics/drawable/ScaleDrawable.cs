namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScaleDrawable()
		{
			InitJNI();
		}
		protected ScaleDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6177;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._inflate6177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._inflate6177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable6178;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getDrawable6178)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getDrawable6178)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _draw6179;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._draw6179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._draw6179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6180;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations6180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations6180);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6181;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._setAlpha6181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setAlpha6181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6182;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._setColorFilter6182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setColorFilter6182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6183;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._isStateful6183);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._isStateful6183);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6184;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._setVisible6184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._setVisible6184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6185;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getOpacity6185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getOpacity6185);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6186;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._onStateChange6186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onStateChange6186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6187;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._onLevelChange6187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onLevelChange6187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6188;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._onBoundsChange6188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._onBoundsChange6188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6189;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth6189);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth6189);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6190;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight6190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight6190);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6191;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getPadding6191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getPadding6191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6192;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._mutate6192)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._mutate6192)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6193;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._getConstantState6193)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._getConstantState6193)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6194;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._invalidateDrawable6194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._invalidateDrawable6194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6195;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._scheduleDrawable6195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._scheduleDrawable6195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6196;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable6196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable6196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ScaleDrawable6197;
		public ScaleDrawable(android.graphics.drawable.Drawable arg0, int arg1, float arg2, float arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ScaleDrawable.staticClass, global::android.graphics.drawable.ScaleDrawable._ScaleDrawable6197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ScaleDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ScaleDrawable"));
			global::android.graphics.drawable.ScaleDrawable._inflate6177 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ScaleDrawable._getDrawable6178 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ScaleDrawable._draw6179 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations6180 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ScaleDrawable._setAlpha6181 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ScaleDrawable._setColorFilter6182 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ScaleDrawable._isStateful6183 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.ScaleDrawable._setVisible6184 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.ScaleDrawable._getOpacity6185 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ScaleDrawable._onStateChange6186 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.ScaleDrawable._onLevelChange6187 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.ScaleDrawable._onBoundsChange6188 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth6189 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight6190 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ScaleDrawable._getPadding6191 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ScaleDrawable._mutate6192 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ScaleDrawable._getConstantState6193 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ScaleDrawable._invalidateDrawable6194 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.ScaleDrawable._scheduleDrawable6195 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable6196 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.ScaleDrawable._ScaleDrawable6197 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ScaleDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IFF)V");
		}
	}
}
