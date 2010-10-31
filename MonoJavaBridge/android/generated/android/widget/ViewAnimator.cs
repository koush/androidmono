namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewAnimator : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewAnimator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.ViewAnimator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V", ref global::android.widget.ViewAnimator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I", ref global::android.widget.ViewAnimator._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void removeViewInLayout(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V", ref global::android.widget.ViewAnimator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void removeViewsInLayout(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V", ref global::android.widget.ViewAnimator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void removeViewAt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V", ref global::android.widget.ViewAnimator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void removeViews(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V", ref global::android.widget.ViewAnimator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void removeAllViews()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V", ref global::android.widget.ViewAnimator._m7);
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.view.View getCurrentView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;", ref global::android.widget.ViewAnimator._m8) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setDisplayedChild(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V", ref global::android.widget.ViewAnimator._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DisplayedChild
		{
			get
			{
				return getDisplayedChild();
			}
			set
			{
				setDisplayedChild(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getDisplayedChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I", ref global::android.widget.ViewAnimator._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void showNext()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "showNext", "()V", ref global::android.widget.ViewAnimator._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void showPrevious()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V", ref global::android.widget.ViewAnimator._m12);
		}
		public new global::android.view.animation.Animation InAnimation
		{
			get
			{
				return getInAnimation();
			}
			set
			{
				setInAnimation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.view.animation.Animation getInAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;", ref global::android.widget.ViewAnimator._m13) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setInAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V", ref global::android.widget.ViewAnimator._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setInAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.widget.ViewAnimator._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.animation.Animation OutAnimation
		{
			get
			{
				return getOutAnimation();
			}
			set
			{
				setOutAnimation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.view.animation.Animation getOutAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;", ref global::android.widget.ViewAnimator._m16) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V", ref global::android.widget.ViewAnimator._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setOutAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.widget.ViewAnimator._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AnimateFirstView
		{
			set
			{
				setAnimateFirstView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setAnimateFirstView(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V", ref global::android.widget.ViewAnimator._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._m20.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._m20 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ViewAnimator(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._m21.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._m21 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ViewAnimator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewAnimator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewAnimator"));
		}
	}
}
