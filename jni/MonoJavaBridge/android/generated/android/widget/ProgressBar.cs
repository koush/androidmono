namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressBar : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProgressBar()
		{
			InitJNI();
		}
		protected ProgressBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17387;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onRestoreInstanceState17387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onRestoreInstanceState17387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17388;
		public virtual global::android.os.Parcelable onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._onSaveInstanceState17388)) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSaveInstanceState17388)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setProgress17389;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setProgress17389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgress17389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress17390;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setSecondaryProgress17390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setSecondaryProgress17390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility17391;
		public override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setVisibility17391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setVisibility17391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged17392;
		protected override void onVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onVisibilityChanged17392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onVisibilityChanged17392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17393;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onSizeChanged17393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSizeChanged17393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate17394;
		public override void postInvalidate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._postInvalidate17394);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._postInvalidate17394);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17395;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onDraw17395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onDraw17395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17396;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._invalidateDrawable17396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._invalidateDrawable17396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17397;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar._verifyDrawable17397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._verifyDrawable17397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17398;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._drawableStateChanged17398);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._drawableStateChanged17398);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17399;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._onMeasure17399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onMeasure17399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
			set
			{
				setProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress17400;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getProgress17400);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgress17400);
		}
		public new int SecondaryProgress
		{
			get
			{
				return getSecondaryProgress();
			}
			set
			{
				setSecondaryProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress17401;
		public virtual int getSecondaryProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getSecondaryProgress17401);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getSecondaryProgress17401);
		}
		public new int Max
		{
			get
			{
				return getMax();
			}
			set
			{
				setMax(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMax17402;
		public virtual int getMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ProgressBar._getMax17402);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getMax17402);
		}
		internal static global::MonoJavaBridge.MethodId _setMax17403;
		public virtual void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setMax17403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setMax17403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy17404;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._incrementProgressBy17404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementProgressBy17404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy17405;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._incrementSecondaryProgressBy17405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementSecondaryProgressBy17405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable17406;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setProgressDrawable17406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgressDrawable17406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable17407;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setIndeterminateDrawable17407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminateDrawable17407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate17408;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setIndeterminate17408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminate17408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate17409;
		public virtual bool isIndeterminate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar._isIndeterminate17409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._isIndeterminate17409);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator17410;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setInterpolator17410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator17410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator17411;
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ProgressBar._setInterpolator17411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator17411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.animation.Interpolator Interpolator
		{
			get
			{
				return getInterpolator();
			}
			set
			{
				setInterpolator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator17412;
		public virtual global::android.view.animation.Interpolator getInterpolator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getInterpolator17412)) as android.view.animation.Interpolator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getInterpolator17412)) as android.view.animation.Interpolator;
		}
		public new global::android.graphics.drawable.Drawable IndeterminateDrawable
		{
			get
			{
				return getIndeterminateDrawable();
			}
			set
			{
				setIndeterminateDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndeterminateDrawable17413;
		public virtual global::android.graphics.drawable.Drawable getIndeterminateDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getIndeterminateDrawable17413)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getIndeterminateDrawable17413)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable ProgressDrawable
		{
			get
			{
				return getProgressDrawable();
			}
			set
			{
				setProgressDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgressDrawable17414;
		public virtual global::android.graphics.drawable.Drawable getProgressDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ProgressBar._getProgressDrawable17414)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgressDrawable17414)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17415;
		public ProgressBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17416;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17417;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ProgressBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ProgressBar"));
			global::android.widget.ProgressBar._onRestoreInstanceState17387 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ProgressBar._onSaveInstanceState17388 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ProgressBar._setProgress17389 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V");
			global::android.widget.ProgressBar._setSecondaryProgress17390 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V");
			global::android.widget.ProgressBar._setVisibility17391 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V");
			global::android.widget.ProgressBar._onVisibilityChanged17392 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.widget.ProgressBar._onSizeChanged17393 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ProgressBar._postInvalidate17394 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V");
			global::android.widget.ProgressBar._onDraw17395 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ProgressBar._invalidateDrawable17396 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._verifyDrawable17397 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ProgressBar._drawableStateChanged17398 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ProgressBar._onMeasure17399 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.ProgressBar._getProgress17400 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgress", "()I");
			global::android.widget.ProgressBar._getSecondaryProgress17401 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I");
			global::android.widget.ProgressBar._getMax17402 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getMax", "()I");
			global::android.widget.ProgressBar._setMax17403 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V");
			global::android.widget.ProgressBar._incrementProgressBy17404 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V");
			global::android.widget.ProgressBar._incrementSecondaryProgressBy17405 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.widget.ProgressBar._setProgressDrawable17406 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminateDrawable17407 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminate17408 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V");
			global::android.widget.ProgressBar._isIndeterminate17409 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z");
			global::android.widget.ProgressBar._setInterpolator17410 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.widget.ProgressBar._setInterpolator17411 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.widget.ProgressBar._getInterpolator17412 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.widget.ProgressBar._getIndeterminateDrawable17413 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._getProgressDrawable17414 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._ProgressBar17415 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ProgressBar._ProgressBar17416 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ProgressBar._ProgressBar17417 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
