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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.InsetDrawable._inflate6063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw6064;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.InsetDrawable._draw6064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.InsetDrawable._getChangingConfigurations6065);
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.InsetDrawable._setAlpha6066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.InsetDrawable._setColorFilter6067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6068;
		public override bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z", ref global::android.graphics.drawable.InsetDrawable._isStateful6068);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6069;
		public override bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z", ref global::android.graphics.drawable.InsetDrawable._setVisible6069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.InsetDrawable._getOpacity6070);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6071;
		protected override bool onStateChange(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z", ref global::android.graphics.drawable.InsetDrawable._onStateChange6071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6072;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.InsetDrawable._onBoundsChange6072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth6073);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight6074);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6075;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.InsetDrawable._getPadding6075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6076;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.InsetDrawable._mutate6076) as android.graphics.drawable.Drawable;
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
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.InsetDrawable._getConstantState6077) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6078;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.graphics.drawable.InsetDrawable._invalidateDrawable6078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6079;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", ref global::android.graphics.drawable.InsetDrawable._scheduleDrawable6079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6080;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", ref global::android.graphics.drawable.InsetDrawable._unscheduleDrawable6080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable6081;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.InsetDrawable._InsetDrawable6081.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.InsetDrawable._InsetDrawable6081 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable6081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable6082;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.InsetDrawable._InsetDrawable6082.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.InsetDrawable._InsetDrawable6082 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable6082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static InsetDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.InsetDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/InsetDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
