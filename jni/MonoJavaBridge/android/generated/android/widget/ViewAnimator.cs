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
		internal static global::MonoJavaBridge.MethodId _addView18130;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._addView18130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._addView18130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeView18131;
		public override void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeView18131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeView18131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline18132;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getBaseline18132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getBaseline18132);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout18133;
		public override void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewInLayout18133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewInLayout18133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout18134;
		public override void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewsInLayout18134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewsInLayout18134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt18135;
		public override void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewAt18135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewAt18135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews18136;
		public override void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViews18136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViews18136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews18137;
		public override void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeAllViews18137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeAllViews18137);
		}
		public new global::android.view.View CurrentView
		{
			get
			{
				return getCurrentView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView18138;
		public virtual global::android.view.View getCurrentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getCurrentView18138)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getCurrentView18138)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayedChild18139;
		public virtual void setDisplayedChild(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setDisplayedChild18139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setDisplayedChild18139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDisplayedChild18140;
		public virtual int getDisplayedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getDisplayedChild18140);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getDisplayedChild18140);
		}
		internal static global::MonoJavaBridge.MethodId _showNext18141;
		public virtual void showNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showNext18141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showNext18141);
		}
		internal static global::MonoJavaBridge.MethodId _showPrevious18142;
		public virtual void showPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showPrevious18142);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showPrevious18142);
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
		internal static global::MonoJavaBridge.MethodId _getInAnimation18143;
		public virtual global::android.view.animation.Animation getInAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getInAnimation18143)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getInAnimation18143)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation18144;
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation18144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation18144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation18145;
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation18145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation18145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOutAnimation18146;
		public virtual global::android.view.animation.Animation getOutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getOutAnimation18146)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getOutAnimation18146)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation18147;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation18147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation18147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation18148;
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation18148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimateFirstView18149;
		public virtual void setAnimateFirstView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setAnimateFirstView18149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setAnimateFirstView18149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator18150;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator18150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator18151;
		public ViewAnimator(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator18151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewAnimator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewAnimator"));
			global::android.widget.ViewAnimator._addView18130 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewAnimator._removeView18131 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._getBaseline18132 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I");
			global::android.widget.ViewAnimator._removeViewInLayout18133 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._removeViewsInLayout18134 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V");
			global::android.widget.ViewAnimator._removeViewAt18135 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V");
			global::android.widget.ViewAnimator._removeViews18136 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V");
			global::android.widget.ViewAnimator._removeAllViews18137 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V");
			global::android.widget.ViewAnimator._getCurrentView18138 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.ViewAnimator._setDisplayedChild18139 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V");
			global::android.widget.ViewAnimator._getDisplayedChild18140 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I");
			global::android.widget.ViewAnimator._showNext18141 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showNext", "()V");
			global::android.widget.ViewAnimator._showPrevious18142 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V");
			global::android.widget.ViewAnimator._getInAnimation18143 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setInAnimation18144 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setInAnimation18145 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._getOutAnimation18146 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setOutAnimation18147 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setOutAnimation18148 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._setAnimateFirstView18149 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V");
			global::android.widget.ViewAnimator._ViewAnimator18150 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ViewAnimator._ViewAnimator18151 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
