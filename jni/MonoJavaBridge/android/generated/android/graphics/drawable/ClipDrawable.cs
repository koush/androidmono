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
		internal static global::MonoJavaBridge.MethodId _inflate3882;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._inflate3882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._inflate3882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw3883;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._draw3883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._draw3883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations3884;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3884);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3884);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha3885;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setAlpha3885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setAlpha3885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter3886;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setColorFilter3886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setColorFilter3886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful3887;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._isStateful3887);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._isStateful3887);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible3888;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._setVisible3888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setVisible3888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity3889;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getOpacity3889);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getOpacity3889);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange3890;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onStateChange3890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onStateChange3890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange3891;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onLevelChange3891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onLevelChange3891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange3892;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._onBoundsChange3892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onBoundsChange3892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth3893;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3893);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3893);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight3894;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3894);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3894);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding3895;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getPadding3895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getPadding3895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState3896;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._getConstantState3896)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getConstantState3896)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable3897;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._invalidateDrawable3897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._invalidateDrawable3897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable3898;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._scheduleDrawable3898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._scheduleDrawable3898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable3899;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ClipDrawable3900;
		public ClipDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._ClipDrawable3900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
			global::android.graphics.drawable.ClipDrawable._inflate3882 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ClipDrawable._draw3883 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3884 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ClipDrawable._setAlpha3885 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ClipDrawable._setColorFilter3886 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ClipDrawable._isStateful3887 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.ClipDrawable._setVisible3888 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.ClipDrawable._getOpacity3889 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ClipDrawable._onStateChange3890 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.ClipDrawable._onLevelChange3891 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.ClipDrawable._onBoundsChange3892 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3893 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3894 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ClipDrawable._getPadding3895 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ClipDrawable._getConstantState3896 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ClipDrawable._invalidateDrawable3897 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.ClipDrawable._scheduleDrawable3898 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3899 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.ClipDrawable._ClipDrawable3900 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ClipDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;II)V");
		}
	}
}
