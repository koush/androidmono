namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InsetDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InsetDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6063;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._inflate6063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._inflate6063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw6064;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._draw6064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._draw6064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6065;
		public override int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations6065);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations6065);
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6066;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setAlpha6066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setAlpha6066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6067;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setColorFilter6067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setColorFilter6067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6068;
		public override bool isStateful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._isStateful6068);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._isStateful6068);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6069;
		public override bool setVisible(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setVisible6069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setVisible6069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6070;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getOpacity6070);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getOpacity6070);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6071;
		protected override bool onStateChange(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._onStateChange6071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onStateChange6071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6072;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._onBoundsChange6072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onBoundsChange6072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6073;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth6073);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth6073);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6074;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight6074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight6074);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6075;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getPadding6075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getPadding6075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6076;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._mutate6076)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._mutate6076)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6077;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getConstantState6077)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getConstantState6077)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6078;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._invalidateDrawable6078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._invalidateDrawable6078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6079;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._scheduleDrawable6079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._scheduleDrawable6079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6080;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable6080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable6080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable6081;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable6081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable6082;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable6082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InsetDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.InsetDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/InsetDrawable"));
			global::android.graphics.drawable.InsetDrawable._inflate6063 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.InsetDrawable._draw6064 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.InsetDrawable._getChangingConfigurations6065 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.InsetDrawable._setAlpha6066 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.InsetDrawable._setColorFilter6067 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.InsetDrawable._isStateful6068 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.InsetDrawable._setVisible6069 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.InsetDrawable._getOpacity6070 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.InsetDrawable._onStateChange6071 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.InsetDrawable._onBoundsChange6072 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth6073 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight6074 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.InsetDrawable._getPadding6075 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.InsetDrawable._mutate6076 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.InsetDrawable._getConstantState6077 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.InsetDrawable._invalidateDrawable6078 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.InsetDrawable._scheduleDrawable6079 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.InsetDrawable._unscheduleDrawable6080 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable6081 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable6082 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
