namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressBar : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProgressBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.widget.ProgressBar._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.widget.ProgressBar.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.widget.ProgressBar._m1) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setProgress", "(I)V", ref global::android.widget.ProgressBar._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setSecondaryProgress", "(I)V", ref global::android.widget.ProgressBar._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setVisibility", "(I)V", ref global::android.widget.ProgressBar._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.widget.ProgressBar._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.ProgressBar._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void postInvalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "postInvalidate", "()V", ref global::android.widget.ProgressBar._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.ProgressBar._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ProgressBar._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ProgressBar.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.ProgressBar._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "drawableStateChanged", "()V", ref global::android.widget.ProgressBar._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "onMeasure", "(II)V", ref global::android.widget.ProgressBar._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, "getProgress", "()I", ref global::android.widget.ProgressBar._m13);
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
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getSecondaryProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, "getSecondaryProgress", "()I", ref global::android.widget.ProgressBar._m14);
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
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int getMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ProgressBar.staticClass, "getMax", "()I", ref global::android.widget.ProgressBar._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setMax", "(I)V", ref global::android.widget.ProgressBar._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void incrementProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "incrementProgressBy", "(I)V", ref global::android.widget.ProgressBar._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void incrementSecondaryProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "incrementSecondaryProgressBy", "(I)V", ref global::android.widget.ProgressBar._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ProgressBar._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.ProgressBar._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Indeterminate
		{
			set
			{
				setIndeterminate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setIndeterminate", "(Z)V", ref global::android.widget.ProgressBar._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool isIndeterminate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.ProgressBar.staticClass, "isIndeterminate", "()Z", ref global::android.widget.ProgressBar._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setInterpolator(android.view.animation.Interpolator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V", ref global::android.widget.ProgressBar._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setInterpolator(global::android.view.animation.InterpolatorDelegate arg0)
		{
			setInterpolator((global::android.view.animation.InterpolatorDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setInterpolator(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ProgressBar.staticClass, "setInterpolator", "(Landroid/content/Context;I)V", ref global::android.widget.ProgressBar._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::android.view.animation.Interpolator getInterpolator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.animation.Interpolator>(this, global::android.widget.ProgressBar.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;", ref global::android.widget.ProgressBar._m25) as android.view.animation.Interpolator;
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
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.graphics.drawable.Drawable getIndeterminateDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, "getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.ProgressBar._m26) as android.graphics.drawable.Drawable;
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
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.graphics.drawable.Drawable getProgressDrawable()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ProgressBar.staticClass, "getProgressDrawable", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.ProgressBar._m27) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public ProgressBar(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ProgressBar._m28.native == global::System.IntPtr.Zero)
				global::android.widget.ProgressBar._m28 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ProgressBar._m29.native == global::System.IntPtr.Zero)
				global::android.widget.ProgressBar._m29 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public ProgressBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ProgressBar._m30.native == global::System.IntPtr.Zero)
				global::android.widget.ProgressBar._m30 = @__env.GetMethodIDNoThrow(global::android.widget.ProgressBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ProgressBar.staticClass, global::android.widget.ProgressBar._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ProgressBar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ProgressBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ProgressBar"));
		}
		internal static void InitJNI()
		{
		}
	}
}
