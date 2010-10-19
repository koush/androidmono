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
		internal static global::MonoJavaBridge.MethodId _inflate4143;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._inflate4143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._inflate4143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable4144;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getDrawable4144)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getDrawable4144)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _draw4145;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._draw4145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._draw4145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations4146;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations4146);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations4146);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha4147;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setAlpha4147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setAlpha4147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter4148;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setColorFilter4148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setColorFilter4148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful4149;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._isStateful4149);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._isStateful4149);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible4150;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._setVisible4150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setVisible4150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity4151;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getOpacity4151);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getOpacity4151);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange4152;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onStateChange4152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onStateChange4152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange4153;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onLevelChange4153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onLevelChange4153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange4154;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._onBoundsChange4154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onBoundsChange4154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4155;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth4155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth4155);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4156;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight4156);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight4156);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4157;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getPadding4157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getPadding4157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4158;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._mutate4158)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._mutate4158)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4159;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._getConstantState4159)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getConstantState4159)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable4160;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._invalidateDrawable4160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._invalidateDrawable4160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable4161;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._scheduleDrawable4161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._scheduleDrawable4161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable4162;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable4162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable4162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RotateDrawable4163;
		public RotateDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._RotateDrawable4163);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.RotateDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/RotateDrawable"));
			global::android.graphics.drawable.RotateDrawable._inflate4143 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.RotateDrawable._getDrawable4144 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._draw4145 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.RotateDrawable._getChangingConfigurations4146 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.RotateDrawable._setAlpha4147 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.RotateDrawable._setColorFilter4148 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.RotateDrawable._isStateful4149 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.RotateDrawable._setVisible4150 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.RotateDrawable._getOpacity4151 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.RotateDrawable._onStateChange4152 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.RotateDrawable._onLevelChange4153 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.RotateDrawable._onBoundsChange4154 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth4155 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight4156 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.RotateDrawable._getPadding4157 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.RotateDrawable._mutate4158 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._getConstantState4159 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.RotateDrawable._invalidateDrawable4160 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.RotateDrawable._scheduleDrawable4161 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.RotateDrawable._unscheduleDrawable4162 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.RotateDrawable._RotateDrawable4163 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.RotateDrawable.staticClass, "<init>", "()V");
		}
	}
}
