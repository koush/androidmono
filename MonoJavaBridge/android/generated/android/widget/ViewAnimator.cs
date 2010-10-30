namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewAnimator : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewAnimator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addView18247;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._addView18247.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._addView18247 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._addView18247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeView18248;
		public override void removeView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeView18248.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeView18248 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeView18248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18249;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._getBaseline18249.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._getBaseline18249 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getBaseline18249);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout18250;
		public override void removeViewInLayout(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeViewInLayout18250.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeViewInLayout18250 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewInLayout18250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout18251;
		public override void removeViewsInLayout(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeViewsInLayout18251.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeViewsInLayout18251 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewsInLayout18251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt18252;
		public override void removeViewAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeViewAt18252.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeViewAt18252 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewAt18252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews18253;
		public override void removeViews(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeViews18253.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeViews18253 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViews18253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews18254;
		public override void removeAllViews()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._removeAllViews18254.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._removeAllViews18254 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeAllViews18254);
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView18255;
		public virtual global::android.view.View getCurrentView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._getCurrentView18255.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._getCurrentView18255 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getCurrentView18255) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayedChild18256;
		public virtual void setDisplayedChild(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setDisplayedChild18256.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setDisplayedChild18256 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setDisplayedChild18256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDisplayedChild18257;
		public virtual int getDisplayedChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._getDisplayedChild18257.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._getDisplayedChild18257 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getDisplayedChild18257);
		}
		internal static global::MonoJavaBridge.MethodId _showNext18258;
		public virtual void showNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._showNext18258.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._showNext18258 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showNext", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showNext18258);
		}
		internal static global::MonoJavaBridge.MethodId _showPrevious18259;
		public virtual void showPrevious()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._showPrevious18259.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._showPrevious18259 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showPrevious18259);
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
		internal static global::MonoJavaBridge.MethodId _getInAnimation18260;
		public virtual global::android.view.animation.Animation getInAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._getInAnimation18260.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._getInAnimation18260 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getInAnimation18260) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation18261;
		public virtual void setInAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setInAnimation18261.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setInAnimation18261 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation18261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation18262;
		public virtual void setInAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setInAnimation18262.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setInAnimation18262 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation18262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOutAnimation18263;
		public virtual global::android.view.animation.Animation getOutAnimation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._getOutAnimation18263.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._getOutAnimation18263 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getOutAnimation18263) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation18264;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setOutAnimation18264.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setOutAnimation18264 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation18264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation18265;
		public virtual void setOutAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setOutAnimation18265.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setOutAnimation18265 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation18265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool AnimateFirstView
		{
			set
			{
				setAnimateFirstView(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAnimateFirstView18266;
		public virtual void setAnimateFirstView(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._setAnimateFirstView18266.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._setAnimateFirstView18266 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setAnimateFirstView18266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator18267;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._ViewAnimator18267.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._ViewAnimator18267 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator18267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator18268;
		public ViewAnimator(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewAnimator._ViewAnimator18268.native == global::System.IntPtr.Zero)
				global::android.widget.ViewAnimator._ViewAnimator18268 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator18268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ViewAnimator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewAnimator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewAnimator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
