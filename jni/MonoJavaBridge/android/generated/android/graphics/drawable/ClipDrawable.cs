namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClipDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClipDrawable()
		{
			InitJNI();
		}
		protected ClipDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate5886;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._inflate5886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._inflate5886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5887;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._draw5887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._draw5887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5888;
		public override int getChangingConfigurations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations5888);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations5888);
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5889;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setAlpha5889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setAlpha5889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5890;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setColorFilter5890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setColorFilter5890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful5891;
		public override bool isStateful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._isStateful5891);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._isStateful5891);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5892;
		public override bool setVisible(bool arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setVisible5892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setVisible5892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5893;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getOpacity5893);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getOpacity5893);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange5894;
		protected override bool onStateChange(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onStateChange5894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onStateChange5894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange5895;
		protected override bool onLevelChange(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onLevelChange5895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onLevelChange5895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5896;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onBoundsChange5896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onBoundsChange5896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5897;
		public override int getIntrinsicWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth5897);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth5897);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5898;
		public override int getIntrinsicHeight()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight5898);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight5898);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding5899;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getPadding5899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getPadding5899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5900;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getConstantState5900)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getConstantState5900)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable5901;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._invalidateDrawable5901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._invalidateDrawable5901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable5902;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._scheduleDrawable5902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._scheduleDrawable5902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable5903;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable5903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable5903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ClipDrawable5904;
		public ClipDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._ClipDrawable5904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int HORIZONTAL
		{
			get
			{
				return 1;
			}
		}
		public static int VERTICAL
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ClipDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ClipDrawable"));
			global::android.graphics.drawable.ClipDrawable._inflate5886 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ClipDrawable._draw5887 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ClipDrawable._getChangingConfigurations5888 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ClipDrawable._setAlpha5889 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ClipDrawable._setColorFilter5890 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ClipDrawable._isStateful5891 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.ClipDrawable._setVisible5892 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.ClipDrawable._getOpacity5893 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ClipDrawable._onStateChange5894 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.ClipDrawable._onLevelChange5895 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.ClipDrawable._onBoundsChange5896 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth5897 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight5898 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ClipDrawable._getPadding5899 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ClipDrawable._getConstantState5900 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ClipDrawable._invalidateDrawable5901 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.ClipDrawable._scheduleDrawable5902 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.ClipDrawable._unscheduleDrawable5903 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.ClipDrawable._ClipDrawable5904 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;II)V");
		}
	}
}
