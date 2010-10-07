namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewAnimator : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static ViewAnimator()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ViewAnimator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ViewAnimator(@__env);
			}
		}
		protected ViewAnimator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView12008;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._addView12008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._addView12008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeView12009;
		public override void removeView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeView12009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeView12009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline12010;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ViewAnimator._getBaseline12010);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getBaseline12010);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout12011;
		public override void removeViewInLayout(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeViewInLayout12011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewInLayout12011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout12012;
		public override void removeViewsInLayout(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeViewsInLayout12012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewsInLayout12012, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt12013;
		public override void removeViewAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeViewAt12013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViewAt12013, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViews12014;
		public override void removeViews(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeViews12014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeViews12014, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews12015;
		public override void removeAllViews() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._removeAllViews12015);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._removeAllViews12015);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentView12016;
		public virtual global::android.view.View getCurrentView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ViewAnimator._getCurrentView12016));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getCurrentView12016));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDisplayedChild12017;
		public virtual void setDisplayedChild(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setDisplayedChild12017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setDisplayedChild12017, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayedChild12018;
		public virtual int getDisplayedChild() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ViewAnimator._getDisplayedChild12018);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getDisplayedChild12018);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showNext12019;
		public virtual void showNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._showNext12019);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showNext12019);
		}
		internal static global::net.sf.jni4net.jni.MethodId _showPrevious12020;
		public virtual void showPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._showPrevious12020);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._showPrevious12020);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInAnimation12021;
		public virtual global::android.view.animation.Animation getInAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ViewAnimator._getInAnimation12021));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getInAnimation12021));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation12022;
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setInAnimation12022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation12023;
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setInAnimation12023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setInAnimation12023, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOutAnimation12024;
		public virtual global::android.view.animation.Animation getOutAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ViewAnimator._getOutAnimation12024));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._getOutAnimation12024));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation12025;
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setOutAnimation12025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation12026;
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setOutAnimation12026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setOutAnimation12026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimateFirstView12027;
		public virtual void setAnimateFirstView(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewAnimator._setAnimateFirstView12027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._setAnimateFirstView12027, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator12028;
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12028, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator12029;
		public ViewAnimator(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewAnimator.staticClass, global::android.widget.ViewAnimator._ViewAnimator12029, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ViewAnimator.staticClass = @__class;
			global::android.widget.ViewAnimator._addView12008 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewAnimator._removeView12009 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._getBaseline12010 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I");
			global::android.widget.ViewAnimator._removeViewInLayout12011 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.widget.ViewAnimator._removeViewsInLayout12012 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V");
			global::android.widget.ViewAnimator._removeViewAt12013 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V");
			global::android.widget.ViewAnimator._removeViews12014 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V");
			global::android.widget.ViewAnimator._removeAllViews12015 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V");
			global::android.widget.ViewAnimator._getCurrentView12016 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;");
			global::android.widget.ViewAnimator._setDisplayedChild12017 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V");
			global::android.widget.ViewAnimator._getDisplayedChild12018 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I");
			global::android.widget.ViewAnimator._showNext12019 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showNext", "()V");
			global::android.widget.ViewAnimator._showPrevious12020 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V");
			global::android.widget.ViewAnimator._getInAnimation12021 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setInAnimation12022 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setInAnimation12023 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._getOutAnimation12024 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;");
			global::android.widget.ViewAnimator._setOutAnimation12025 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V");
			global::android.widget.ViewAnimator._setOutAnimation12026 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V");
			global::android.widget.ViewAnimator._setAnimateFirstView12027 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V");
			global::android.widget.ViewAnimator._ViewAnimator12028 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ViewAnimator._ViewAnimator12029 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
