namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InsetDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InsetDrawable()
		{
			InitJNI();
		}
		protected InsetDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate4050;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._inflate4050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._inflate4050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw4051;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._draw4051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._draw4051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations4052;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations4052);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getChangingConfigurations4052);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha4053;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setAlpha4053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setAlpha4053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter4054;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setColorFilter4054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setColorFilter4054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful4055;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._isStateful4055);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._isStateful4055);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible4056;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._setVisible4056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._setVisible4056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity4057;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getOpacity4057);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getOpacity4057);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange4058;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._onStateChange4058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onStateChange4058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange4059;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._onBoundsChange4059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._onBoundsChange4059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4060;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth4060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth4060);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4061;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight4061);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight4061);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4062;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getPadding4062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getPadding4062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4063;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._mutate4063)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._mutate4063)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4064;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._getConstantState4064)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._getConstantState4064)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable4065;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._invalidateDrawable4065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._invalidateDrawable4065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable4066;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._scheduleDrawable4066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._scheduleDrawable4066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable4067;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable4067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._unscheduleDrawable4067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable4068;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable4068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InsetDrawable4069;
		public InsetDrawable(android.graphics.drawable.Drawable arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.InsetDrawable.staticClass, global::android.graphics.drawable.InsetDrawable._InsetDrawable4069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.InsetDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/InsetDrawable"));
			global::android.graphics.drawable.InsetDrawable._inflate4050 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.InsetDrawable._draw4051 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.InsetDrawable._getChangingConfigurations4052 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.InsetDrawable._setAlpha4053 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.InsetDrawable._setColorFilter4054 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.InsetDrawable._isStateful4055 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.InsetDrawable._setVisible4056 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.InsetDrawable._getOpacity4057 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.InsetDrawable._onStateChange4058 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.InsetDrawable._onBoundsChange4059 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicWidth4060 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.InsetDrawable._getIntrinsicHeight4061 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.InsetDrawable._getPadding4062 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.InsetDrawable._mutate4063 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.InsetDrawable._getConstantState4064 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.InsetDrawable._invalidateDrawable4065 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.InsetDrawable._scheduleDrawable4066 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.InsetDrawable._unscheduleDrawable4067 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable4068 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IIII)V");
			global::android.graphics.drawable.InsetDrawable._InsetDrawable4069 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.InsetDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
		}
	}
}
