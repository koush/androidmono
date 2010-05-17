namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ViewTreeObserver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ViewTreeObserver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewTreeObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.ViewTreeObserver(@__env); 
			} 
		} 
		internal ViewTreeObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGlobalFocusChangeListener 
		{ 
			void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGlobalLayoutListener 
		{ 
			void onGlobalLayout(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPreDrawListener 
		{ 
			bool onPreDraw(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnScrollChangedListener 
		{ 
			void onScrollChanged(); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnTouchModeChangeListener 
		{ 
			void onTouchModeChanged(bool arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAlive8033; 
		public bool isAlive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				return @__env.CallBooleanMethod(this, _isAlive8033); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewTreeObserver.staticClass, _isAlive8033); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalFocusChangeListener8034; 
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _addOnGlobalFocusChangeListener8034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _addOnGlobalFocusChangeListener8034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGlobalFocusChangeListener8035; 
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _removeOnGlobalFocusChangeListener8035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _removeOnGlobalFocusChangeListener8035, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGlobalLayoutListener8036; 
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _addOnGlobalLayoutListener8036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _addOnGlobalLayoutListener8036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeGlobalOnLayoutListener8037; 
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _removeGlobalOnLayoutListener8037, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _removeGlobalOnLayoutListener8037, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnPreDrawListener8038; 
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _addOnPreDrawListener8038, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _addOnPreDrawListener8038, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnPreDrawListener8039; 
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _removeOnPreDrawListener8039, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _removeOnPreDrawListener8039, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnScrollChangedListener8040; 
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _addOnScrollChangedListener8040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _addOnScrollChangedListener8040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnScrollChangedListener8041; 
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _removeOnScrollChangedListener8041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _removeOnScrollChangedListener8041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnTouchModeChangeListener8042; 
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _addOnTouchModeChangeListener8042, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _addOnTouchModeChangeListener8042, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnTouchModeChangeListener8043; 
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _removeOnTouchModeChangeListener8043, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _removeOnTouchModeChangeListener8043, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnGlobalLayout8044; 
		public void dispatchOnGlobalLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				@__env.CallVoidMethod(this, _dispatchOnGlobalLayout8044); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewTreeObserver.staticClass, _dispatchOnGlobalLayout8044); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchOnPreDraw8045; 
		public bool dispatchOnPreDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewTreeObserver)) 
				return @__env.CallBooleanMethod(this, _dispatchOnPreDraw8045); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewTreeObserver.staticClass, _dispatchOnPreDraw8045); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.ViewTreeObserver.staticClass = @__class; 
			global::android.view.ViewTreeObserver._isAlive8033 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z"); 
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener8034 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener8035 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V"); 
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener8036 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V"); 
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener8037 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V"); 
			global::android.view.ViewTreeObserver._addOnPreDrawListener8038 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnPreDrawListener8039 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V"); 
			global::android.view.ViewTreeObserver._addOnScrollChangedListener8040 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener8041 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V"); 
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener8042 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V"); 
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener8043 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V"); 
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout8044 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V"); 
			global::android.view.ViewTreeObserver._dispatchOnPreDraw8045 = @__env.GetMethodID(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z"); 
		} 
	} 
} 
