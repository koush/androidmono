namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ViewSwitcher : android.widget.ViewAnimator
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ViewSwitcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.ViewSwitcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.ViewSwitcher(@__env); 
			} 
		} 
		protected ViewSwitcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ViewFactory 
		{ 
			android.view.View makeView(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset10517; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewSwitcher)) 
				@__env.CallVoidMethod(this, _reset10517); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewSwitcher.staticClass, _reset10517); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10518; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewSwitcher)) 
				@__env.CallVoidMethod(this, _addView10518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewSwitcher.staticClass, _addView10518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFactory10519; 
		public virtual void setFactory(android.widget.ViewSwitcher.ViewFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewSwitcher)) 
				@__env.CallVoidMethod(this, _setFactory10519, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.ViewSwitcher.staticClass, _setFactory10519, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNextView10520; 
		public virtual android.view.View getNextView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.ViewSwitcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getNextView10520)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.ViewSwitcher.staticClass, _getNextView10520)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewSwitcher10521; 
		public ViewSwitcher(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewSwitcher.staticClass, _ViewSwitcher10521, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewSwitcher10522; 
		public ViewSwitcher(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.ViewSwitcher.staticClass, _ViewSwitcher10522, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.ViewSwitcher.staticClass = @__class; 
			global::android.widget.ViewSwitcher._reset10517 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "reset", "()V"); 
			global::android.widget.ViewSwitcher._addView10518 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.ViewSwitcher._setFactory10519 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V"); 
			global::android.widget.ViewSwitcher._getNextView10520 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "getNextView", "()Landroid/view/View;"); 
			global::android.widget.ViewSwitcher._ViewSwitcher10521 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.ViewSwitcher._ViewSwitcher10522 = @__env.GetMethodID(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
