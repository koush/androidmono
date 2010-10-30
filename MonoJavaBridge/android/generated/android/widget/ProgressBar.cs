namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressBar : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProgressBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState17492;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onRestoreInstanceState17492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState17493;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSaveInstanceState17493)) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _setProgress17494;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgress17494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress17495;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setSecondaryProgress17495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility17496;
		public override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setVisibility17496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onVisibilityChanged17497;
		protected override void onVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onVisibilityChanged17497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged17498;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onSizeChanged17498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _postInvalidate17499;
		public override void postInvalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._postInvalidate17499);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw17500;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onDraw17500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable17501;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._invalidateDrawable17501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable17502;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._verifyDrawable17502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged17503;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._drawableStateChanged17503);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17504;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._onMeasure17504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getProgress17505;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgress17505);
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
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress17506;
		public virtual int getSecondaryProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getSecondaryProgress17506);
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
		internal static global::MonoJavaBridge.MethodId _getMax17507;
		public virtual int getMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getMax17507);
		}
		internal static global::MonoJavaBridge.MethodId _setMax17508;
		public virtual void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setMax17508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy17509;
		public virtual void incrementProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementProgressBy17509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy17510;
		public virtual void incrementSecondaryProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._incrementSecondaryProgressBy17510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable17511;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setProgressDrawable17511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable17512;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminateDrawable17512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Indeterminate
		{
			set
			{
				setIndeterminate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate17513;
		public virtual void setIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setIndeterminate17513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate17514;
		public virtual bool isIndeterminate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._isIndeterminate17514);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator17515;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator17515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setInterpolator17516;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._setInterpolator17516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.animation.InterpolatorDelegate Interpolator
		{
			get
			{
				return new global::android.view.animation.InterpolatorDelegate(getInterpolator().getInterpolation);
			}
			set
			{
				setInterpolator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolator17517;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.animation.Interpolator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getInterpolator17517)) as android.view.animation.Interpolator;
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
		internal static global::MonoJavaBridge.MethodId _getIndeterminateDrawable17518;
		public virtual global::android.graphics.drawable.Drawable getIndeterminateDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getIndeterminateDrawable17518)) as android.graphics.drawable.Drawable;
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
		internal static global::MonoJavaBridge.MethodId _getProgressDrawable17519;
		public virtual global::android.graphics.drawable.Drawable getProgressDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._getProgressDrawable17519)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17520;
		public ProgressBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17521;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressBar17522;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._ProgressBar17522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ProgressBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ProgressBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ProgressBar"));
			global::android.widget.ProgressBar._onRestoreInstanceState17492 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			global::android.widget.ProgressBar._onSaveInstanceState17493 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			global::android.widget.ProgressBar._setProgress17494 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V");
			global::android.widget.ProgressBar._setSecondaryProgress17495 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V");
			global::android.widget.ProgressBar._setVisibility17496 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V");
			global::android.widget.ProgressBar._onVisibilityChanged17497 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.widget.ProgressBar._onSizeChanged17498 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V");
			global::android.widget.ProgressBar._postInvalidate17499 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V");
			global::android.widget.ProgressBar._onDraw17500 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ProgressBar._invalidateDrawable17501 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._verifyDrawable17502 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ProgressBar._drawableStateChanged17503 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ProgressBar._onMeasure17504 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.ProgressBar._getProgress17505 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgress", "()I");
			global::android.widget.ProgressBar._getSecondaryProgress17506 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I");
			global::android.widget.ProgressBar._getMax17507 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getMax", "()I");
			global::android.widget.ProgressBar._setMax17508 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setMax", "(I)V");
			global::android.widget.ProgressBar._incrementProgressBy17509 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V");
			global::android.widget.ProgressBar._incrementSecondaryProgressBy17510 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.widget.ProgressBar._setProgressDrawable17511 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminateDrawable17512 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ProgressBar._setIndeterminate17513 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V");
			global::android.widget.ProgressBar._isIndeterminate17514 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z");
			global::android.widget.ProgressBar._setInterpolator17515 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			global::android.widget.ProgressBar._setInterpolator17516 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V");
			global::android.widget.ProgressBar._getInterpolator17517 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;");
			global::android.widget.ProgressBar._getIndeterminateDrawable17518 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._getProgressDrawable17519 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ProgressBar._ProgressBar17520 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ProgressBar._ProgressBar17521 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ProgressBar._ProgressBar17522 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
