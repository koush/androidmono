namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ViewAnimator : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ViewAnimator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ViewAnimator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _addView10484; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _addView10484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _addView10484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView10485; 
		public override void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeView10485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeView10485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10486; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return @__env.CallIntMethod(this, _getBaseline10486); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ViewAnimator.staticClass, _getBaseline10486); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout10487; 
		public override void removeViewInLayout(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewInLayout10487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewInLayout10487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout10488; 
		public override void removeViewsInLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewsInLayout10488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewsInLayout10488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt10489; 
		public override void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewAt10489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewAt10489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViews10490; 
		public override void removeViews(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViews10490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViews10490, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews10491; 
		public override void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeAllViews10491); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeAllViews10491); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentView10492; 
		public virtual android.view.View getCurrentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentView10492)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getCurrentView10492)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDisplayedChild10493; 
		public virtual void setDisplayedChild(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setDisplayedChild10493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setDisplayedChild10493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayedChild10494; 
		public virtual int getDisplayedChild() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return @__env.CallIntMethod(this, _getDisplayedChild10494); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ViewAnimator.staticClass, _getDisplayedChild10494); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showNext10495; 
		public virtual void showNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _showNext10495); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _showNext10495); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showPrevious10496; 
		public virtual void showPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _showPrevious10496); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _showPrevious10496); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInAnimation10497; 
		public virtual android.view.animation.Animation getInAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getInAnimation10497)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getInAnimation10497)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation10498; 
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setInAnimation10498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setInAnimation10498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation10499; 
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setInAnimation10499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setInAnimation10499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutAnimation10500; 
		public virtual android.view.animation.Animation getOutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getOutAnimation10500)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getOutAnimation10500)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation10501; 
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setOutAnimation10501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setOutAnimation10501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation10502; 
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setOutAnimation10502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setOutAnimation10502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimateFirstView10503; 
		public virtual void setAnimateFirstView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setAnimateFirstView10503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setAnimateFirstView10503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator10504; 
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewAnimator.staticClass, _ViewAnimator10504, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator10505; 
		public ViewAnimator(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewAnimator.staticClass, _ViewAnimator10505, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ViewAnimator.staticClass = @__class; 
			global::android.widget.ViewAnimator._addView10484 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.ViewAnimator._removeView10485 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.widget.ViewAnimator._getBaseline10486 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I"); 
			global::android.widget.ViewAnimator._removeViewInLayout10487 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V"); 
			global::android.widget.ViewAnimator._removeViewsInLayout10488 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V"); 
			global::android.widget.ViewAnimator._removeViewAt10489 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V"); 
			global::android.widget.ViewAnimator._removeViews10490 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V"); 
			global::android.widget.ViewAnimator._removeAllViews10491 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V"); 
			global::android.widget.ViewAnimator._getCurrentView10492 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;"); 
			global::android.widget.ViewAnimator._setDisplayedChild10493 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V"); 
			global::android.widget.ViewAnimator._getDisplayedChild10494 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I"); 
			global::android.widget.ViewAnimator._showNext10495 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showNext", "()V"); 
			global::android.widget.ViewAnimator._showPrevious10496 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V"); 
			global::android.widget.ViewAnimator._getInAnimation10497 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.widget.ViewAnimator._setInAnimation10498 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V"); 
			global::android.widget.ViewAnimator._setInAnimation10499 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.widget.ViewAnimator._getOutAnimation10500 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.widget.ViewAnimator._setOutAnimation10501 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V"); 
			global::android.widget.ViewAnimator._setOutAnimation10502 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.widget.ViewAnimator._setAnimateFirstView10503 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V"); 
			global::android.widget.ViewAnimator._ViewAnimator10504 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ViewAnimator._ViewAnimator10505 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
