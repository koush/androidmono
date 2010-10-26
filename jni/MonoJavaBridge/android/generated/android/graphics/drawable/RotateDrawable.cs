namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RotateDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RotateDrawable()
		{
			InitJNI();
		}
		protected RotateDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6156;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._inflate6156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._inflate6156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable6157;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getDrawable6157)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getDrawable6157)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _draw6158;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._draw6158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._draw6158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6159;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations6159);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations6159);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6160;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setAlpha6160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setAlpha6160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6161;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setColorFilter6161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setColorFilter6161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6162;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._isStateful6162);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._isStateful6162);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6163;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setVisible6163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setVisible6163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6164;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getOpacity6164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getOpacity6164);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6165;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onStateChange6165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onStateChange6165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6166;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onLevelChange6166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onLevelChange6166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6167;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onBoundsChange6167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onBoundsChange6167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6168;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth6168);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth6168);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6169;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight6169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight6169);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6170;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getPadding6170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getPadding6170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6171;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._mutate6171)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._mutate6171)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6172;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getConstantState6172)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getConstantState6172)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6173;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._invalidateDrawable6173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._invalidateDrawable6173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6174;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._scheduleDrawable6174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._scheduleDrawable6174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6175;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable6175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable6175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RotateDrawable6176;
		public RotateDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._RotateDrawable6176);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.RotateDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/RotateDrawable"));
			global::android.graphics.drawable.RotateDrawable._inflate6156 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.RotateDrawable._getDrawable6157 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._draw6158 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.RotateDrawable._getChangingConfigurations6159 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.RotateDrawable._setAlpha6160 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.RotateDrawable._setColorFilter6161 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.RotateDrawable._isStateful6162 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.RotateDrawable._setVisible6163 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.RotateDrawable._getOpacity6164 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.RotateDrawable._onStateChange6165 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.RotateDrawable._onLevelChange6166 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.RotateDrawable._onBoundsChange6167 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth6168 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight6169 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.RotateDrawable._getPadding6170 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.RotateDrawable._mutate6171 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._getConstantState6172 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.RotateDrawable._invalidateDrawable6173 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.RotateDrawable._scheduleDrawable6174 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.RotateDrawable._unscheduleDrawable6175 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.RotateDrawable._RotateDrawable6176 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "<init>", "()V");
		}
	}
}
