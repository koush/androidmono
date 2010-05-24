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
		internal static global::net.sf.jni4net.jni.MethodId _addView11289; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _addView11289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _addView11289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView11290; 
		public override void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeView11290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeView11290, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11291; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return @__env.CallIntMethod(this, _getBaseline11291); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ViewAnimator.staticClass, _getBaseline11291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout11292; 
		public override void removeViewInLayout(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewInLayout11292, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewInLayout11292, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout11293; 
		public override void removeViewsInLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewsInLayout11293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewsInLayout11293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt11294; 
		public override void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViewAt11294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViewAt11294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViews11295; 
		public override void removeViews(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeViews11295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeViews11295, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews11296; 
		public override void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _removeAllViews11296); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _removeAllViews11296); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentView11297; 
		public virtual android.view.View getCurrentView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentView11297)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getCurrentView11297)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDisplayedChild11298; 
		public virtual void setDisplayedChild(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setDisplayedChild11298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setDisplayedChild11298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayedChild11299; 
		public virtual int getDisplayedChild() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return @__env.CallIntMethod(this, _getDisplayedChild11299); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.ViewAnimator.staticClass, _getDisplayedChild11299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showNext11300; 
		public virtual void showNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _showNext11300); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _showNext11300); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showPrevious11301; 
		public virtual void showPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _showPrevious11301); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _showPrevious11301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInAnimation11302; 
		public virtual android.view.animation.Animation getInAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getInAnimation11302)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getInAnimation11302)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation11303; 
		public virtual void setInAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setInAnimation11303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setInAnimation11303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInAnimation11304; 
		public virtual void setInAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setInAnimation11304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setInAnimation11304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutAnimation11305; 
		public virtual android.view.animation.Animation getOutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _getOutAnimation11305)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewAnimator.staticClass, _getOutAnimation11305)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation11306; 
		public virtual void setOutAnimation(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setOutAnimation11306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setOutAnimation11306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutAnimation11307; 
		public virtual void setOutAnimation(android.view.animation.Animation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setOutAnimation11307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setOutAnimation11307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimateFirstView11308; 
		public virtual void setAnimateFirstView(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewAnimator)) 
				@__env.CallVoidMethod(this, _setAnimateFirstView11308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewAnimator.staticClass, _setAnimateFirstView11308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator11309; 
		public ViewAnimator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewAnimator.staticClass, _ViewAnimator11309, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewAnimator11310; 
		public ViewAnimator(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewAnimator.staticClass, _ViewAnimator11310, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ViewAnimator.staticClass = @__class; 
			global::android.widget.ViewAnimator._addView11289 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.ViewAnimator._removeView11290 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.widget.ViewAnimator._getBaseline11291 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getBaseline", "()I"); 
			global::android.widget.ViewAnimator._removeViewInLayout11292 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewInLayout", "(Landroid/view/View;)V"); 
			global::android.widget.ViewAnimator._removeViewsInLayout11293 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewsInLayout", "(II)V"); 
			global::android.widget.ViewAnimator._removeViewAt11294 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViewAt", "(I)V"); 
			global::android.widget.ViewAnimator._removeViews11295 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeViews", "(II)V"); 
			global::android.widget.ViewAnimator._removeAllViews11296 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "removeAllViews", "()V"); 
			global::android.widget.ViewAnimator._getCurrentView11297 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getCurrentView", "()Landroid/view/View;"); 
			global::android.widget.ViewAnimator._setDisplayedChild11298 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setDisplayedChild", "(I)V"); 
			global::android.widget.ViewAnimator._getDisplayedChild11299 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getDisplayedChild", "()I"); 
			global::android.widget.ViewAnimator._showNext11300 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showNext", "()V"); 
			global::android.widget.ViewAnimator._showPrevious11301 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "showPrevious", "()V"); 
			global::android.widget.ViewAnimator._getInAnimation11302 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getInAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.widget.ViewAnimator._setInAnimation11303 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/content/Context;I)V"); 
			global::android.widget.ViewAnimator._setInAnimation11304 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setInAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.widget.ViewAnimator._getOutAnimation11305 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "getOutAnimation", "()Landroid/view/animation/Animation;"); 
			global::android.widget.ViewAnimator._setOutAnimation11306 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/content/Context;I)V"); 
			global::android.widget.ViewAnimator._setOutAnimation11307 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setOutAnimation", "(Landroid/view/animation/Animation;)V"); 
			global::android.widget.ViewAnimator._setAnimateFirstView11308 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "setAnimateFirstView", "(Z)V"); 
			global::android.widget.ViewAnimator._ViewAnimator11309 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.ViewAnimator._ViewAnimator11310 = @__env.GetMethodID(global::android.widget.ViewAnimator.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
