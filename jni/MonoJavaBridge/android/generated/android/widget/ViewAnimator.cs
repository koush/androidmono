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
		internal static global::MonoJavaBridge.MethodId _addView12395;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._addView12395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._addView12395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _removeView12396;
		public override void removeView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeView12396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeView12396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12397;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getBaseline12397);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getBaseline12397);
		}
		internal static global::MonoJavaBridge.MethodId _removeViewInLayout12398;
		public override void removeViewInLayout(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewInLayout12398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewInLayout12398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewsInLayout12399;
		public override void removeViewsInLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewsInLayout12399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewsInLayout12399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeViewAt12400;
		public override void removeViewAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViewAt12400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewAt12400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeViews12401;
		public override void removeViews(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeViews12401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViews12401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllViews12402;
		public override void removeAllViews() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._removeAllViews12402);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeAllViews12402);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentView12403;
		public virtual global::android.view.View getCurrentView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getCurrentView12403)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getCurrentView12403)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayedChild12404;
		public virtual void setDisplayedChild(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setDisplayedChild12404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setDisplayedChild12404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayedChild12405;
		public virtual int getDisplayedChild() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ViewAnimator._getDisplayedChild12405);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getDisplayedChild12405);
		}
		internal static global::MonoJavaBridge.MethodId _showNext12406;
		public virtual void showNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showNext12406);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showNext12406);
		}
		internal static global::MonoJavaBridge.MethodId _showPrevious12407;
		public virtual void showPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._showPrevious12407);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showPrevious12407);
		}
		internal static global::MonoJavaBridge.MethodId _getInAnimation12408;
		public virtual global::android.view.animation.Animation getInAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getInAnimation12408)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getInAnimation12408)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation12409;
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation12409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInAnimation12410;
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setInAnimation12410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOutAnimation12411;
		public virtual global::android.view.animation.Animation getOutAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator._getOutAnimation12411)) as android.view.animation.Animation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getOutAnimation12411)) as android.view.animation.Animation;
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation12412;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOutAnimation12413;
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setOutAnimation12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAnimateFirstView12414;
		public virtual void setAnimateFirstView(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator._setAnimateFirstView12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setAnimateFirstView12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator12415;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewAnimator12416;
		public ViewAnimator(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewAnimator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewAnimator"));
			global::android.widget.ViewAnimator._addView12395 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewAnimator._removeView12396 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._getBaseline12397 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I");
			global::android.widget.ViewAnimator._removeViewInLayout12398 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._removeViewsInLayout12399 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V");
			global::android.widget.ViewAnimator._removeViewAt12400 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V");
			global::android.widget.ViewAnimator._removeViews12401 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V");
			global::android.widget.ViewAnimator._removeAllViews12402 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V");
			global::android.widget.ViewAnimator._getCurrentView12403 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.ViewAnimator._setDisplayedChild12404 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V");
			global::android.widget.ViewAnimator._getDisplayedChild12405 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I");
			global::android.widget.ViewAnimator._showNext12406 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showNext", "()V");
			global::android.widget.ViewAnimator._showPrevious12407 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V");
			global::android.widget.ViewAnimator._getInAnimation12408 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setInAnimation12409 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setInAnimation12410 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._getOutAnimation12411 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setOutAnimation12412 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setOutAnimation12413 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._setAnimateFirstView12414 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V");
			global::android.widget.ViewAnimator._ViewAnimator12415 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ViewAnimator._ViewAnimator12416 = @__env.GetMethodIDNoThrow(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
