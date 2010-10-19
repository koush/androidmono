namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewAnimator : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewAnimator()
		{
			InitJNI();
		}
		protected ViewAnimator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addView12941;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._addView12941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._addView12941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeView12942;
		public override void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeView12942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeView12942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12943;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getBaseline12943);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getBaseline12943);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout12944;
		public override void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewInLayout12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewInLayout12944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout12945;
		public override void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewsInLayout12945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewsInLayout12945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt12946;
		public override void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewAt12946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewAt12946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews12947;
		public override void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViews12947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViews12947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews12948;
		public override void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeAllViews12948);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeAllViews12948);
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView12949;
		public virtual global::android.view.View getCurrentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getCurrentView12949)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getCurrentView12949)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayedChild12950;
		public virtual void setDisplayedChild(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setDisplayedChild12950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setDisplayedChild12950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDisplayedChild12951;
		public virtual int getDisplayedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getDisplayedChild12951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getDisplayedChild12951);
		}
		internal static global::MonoJavaBridge.MethodId _showNext12952;
		public virtual void showNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showNext12952);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showNext12952);
		}
		internal static global::MonoJavaBridge.MethodId _showPrevious12953;
		public virtual void showPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showPrevious12953);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showPrevious12953);
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
		internal static global::MonoJavaBridge.MethodId _getInAnimation12954;
		public virtual global::android.view.animation.Animation getInAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getInAnimation12954)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getInAnimation12954)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation12955;
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation12955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation12956;
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation12956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOutAnimation12957;
		public virtual global::android.view.animation.Animation getOutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getOutAnimation12957)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getOutAnimation12957)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation12958;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation12959;
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimateFirstView12960;
		public virtual void setAnimateFirstView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setAnimateFirstView12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setAnimateFirstView12960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator12961;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator12962;
		public ViewAnimator(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewAnimator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewAnimator"));
			global::android.widget.ViewAnimator._addView12941 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewAnimator._removeView12942 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._getBaseline12943 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I");
			global::android.widget.ViewAnimator._removeViewInLayout12944 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._removeViewsInLayout12945 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V");
			global::android.widget.ViewAnimator._removeViewAt12946 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V");
			global::android.widget.ViewAnimator._removeViews12947 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V");
			global::android.widget.ViewAnimator._removeAllViews12948 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V");
			global::android.widget.ViewAnimator._getCurrentView12949 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.ViewAnimator._setDisplayedChild12950 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V");
			global::android.widget.ViewAnimator._getDisplayedChild12951 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I");
			global::android.widget.ViewAnimator._showNext12952 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showNext", "()V");
			global::android.widget.ViewAnimator._showPrevious12953 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V");
			global::android.widget.ViewAnimator._getInAnimation12954 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setInAnimation12955 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setInAnimation12956 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._getOutAnimation12957 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setOutAnimation12958 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setOutAnimation12959 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._setAnimateFirstView12960 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V");
			global::android.widget.ViewAnimator._ViewAnimator12961 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ViewAnimator._ViewAnimator12962 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
