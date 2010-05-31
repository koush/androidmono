namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Dialog : java.lang.Object, android.content.DialogInterface, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static Dialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Dialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.Dialog(@__env); 
			} 
		} 
		protected Dialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext443; 
		public virtual global::android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getContext443)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getContext443)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel444; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._cancel444); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._cancel444); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate445; 
		protected virtual void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onCreate445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreate445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart446; 
		protected virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onStart446); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStart446); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow447; 
		public virtual global::android.view.Window getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getWindow447)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getWindow447)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus448; 
		public virtual global::android.view.View getCurrentFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getCurrentFocus448)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getCurrentFocus448)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState449; 
		public virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onRestoreInstanceState449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onRestoreInstanceState449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState450; 
		public virtual global::android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._onSaveInstanceState450)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSaveInstanceState450)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop451; 
		protected virtual void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onStop451); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStop451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById452; 
		public virtual global::android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._findViewById452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._findViewById452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView453; 
		public virtual void setContentView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView454; 
		public virtual void setContentView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView455; 
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addContentView456; 
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._addContentView456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._addContentView456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown457; 
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyDown457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyDown457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress458; 
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyLongPress458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyLongPress458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp459; 
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyUp459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyUp459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple460; 
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyMultiple460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyMultiple460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed461; 
		public virtual void onBackPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onBackPressed461); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onBackPressed461); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent462; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onTouchEvent462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTouchEvent462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent463; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onTrackballEvent463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTrackballEvent463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged464; 
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onWindowAttributesChanged464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowAttributesChanged464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged465; 
		public virtual void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onContentChanged465); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContentChanged465); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged466; 
		public virtual void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onWindowFocusChanged466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowFocusChanged466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow467; 
		public virtual void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onAttachedToWindow467); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onAttachedToWindow467); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow468; 
		public virtual void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onDetachedFromWindow468); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onDetachedFromWindow468); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent469; 
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchKeyEvent469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchKeyEvent469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent470; 
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchTouchEvent470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTouchEvent470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent471; 
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchTrackballEvent471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTrackballEvent471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent472; 
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchPopulateAccessibilityEvent472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchPopulateAccessibilityEvent472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView473; 
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._onCreatePanelView473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelView473, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu474; 
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onCreatePanelMenu474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelMenu474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel475; 
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onPreparePanel475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPreparePanel475, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened476; 
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onMenuOpened476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuOpened476, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected477; 
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onMenuItemSelected477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuItemSelected477, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed478; 
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onPanelClosed478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPanelClosed478, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu479; 
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onCreateOptionsMenu479, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateOptionsMenu479, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu480; 
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onPrepareOptionsMenu480, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPrepareOptionsMenu480, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected481; 
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onOptionsItemSelected481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsItemSelected481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed482; 
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onOptionsMenuClosed482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsMenuClosed482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu483; 
		public virtual void openOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._openOptionsMenu483); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._openOptionsMenu483); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu484; 
		public virtual void closeOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._closeOptionsMenu484); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._closeOptionsMenu484); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu485; 
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onCreateContextMenu485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateContextMenu485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu486; 
		public virtual void registerForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._registerForContextMenu486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._registerForContextMenu486, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu487; 
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._unregisterForContextMenu487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._unregisterForContextMenu487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu488; 
		public virtual void openContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._openContextMenu488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._openContextMenu488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected489; 
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onContextItemSelected489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextItemSelected489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed490; 
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._onContextMenuClosed490, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextMenuClosed490, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested491; 
		public virtual bool onSearchRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onSearchRequested491); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSearchRequested491); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents492; 
		public virtual void takeKeyEvents(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._takeKeyEvents492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._takeKeyEvents492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature493; 
		public virtual bool requestWindowFeature(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._requestWindowFeature493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._requestWindowFeature493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource494; 
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableResource494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableResource494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri495; 
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableUri495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableUri495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable496; 
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawable496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawable496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha497; 
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableAlpha497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableAlpha497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater498; 
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getLayoutInflater498)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getLayoutInflater498)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle499; 
		public virtual void setTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setTitle499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle499, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle500; 
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setTitle500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle500, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream501; 
		public virtual void setVolumeControlStream(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setVolumeControlStream501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setVolumeControlStream501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream502; 
		public virtual int getVolumeControlStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.app.Dialog._getVolumeControlStream502); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getVolumeControlStream502); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener503; 
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnKeyListener503, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnKeyListener503, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOwnerActivity504; 
		public virtual void setOwnerActivity(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOwnerActivity504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOwnerActivity504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOwnerActivity505; 
		public virtual global::android.app.Activity getOwnerActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getOwnerActivity505)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getOwnerActivity505)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing506; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._isShowing506); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._isShowing506); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show507; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._show507); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._show507); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide508; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._hide508); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._hide508); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismiss509; 
		public virtual void dismiss() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._dismiss509); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dismiss509); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCancelable510; 
		public virtual void setCancelable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCancelable510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelable510, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCanceledOnTouchOutside511; 
		public virtual void setCanceledOnTouchOutside(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCanceledOnTouchOutside511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCanceledOnTouchOutside511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener512; 
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnCancelListener512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnCancelListener512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCancelMessage513; 
		public virtual void setCancelMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCancelMessage513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelMessage513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener514; 
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnDismissListener514, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnDismissListener514, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDismissMessage515; 
		public virtual void setDismissMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Dialog._setDismissMessage515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setDismissMessage515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog516; 
		public Dialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog516, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog517; 
		public Dialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog517, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog518; 
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog518, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Dialog.staticClass = @__class; 
			global::android.app.Dialog._getContext443 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.app.Dialog._cancel444 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "cancel", "()V"); 
			global::android.app.Dialog._onCreate445 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Dialog._onStart446 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStart", "()V"); 
			global::android.app.Dialog._getWindow447 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;"); 
			global::android.app.Dialog._getCurrentFocus448 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;"); 
			global::android.app.Dialog._onRestoreInstanceState449 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.Dialog._onSaveInstanceState450 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.Dialog._onStop451 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStop", "()V"); 
			global::android.app.Dialog._findViewById452 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.app.Dialog._setContentView453 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(I)V"); 
			global::android.app.Dialog._setContentView454 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._setContentView455 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Dialog._addContentView456 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Dialog._onKeyDown457 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyLongPress458 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyUp459 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyMultiple460 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onBackPressed461 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onBackPressed", "()V"); 
			global::android.app.Dialog._onTouchEvent462 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._onTrackballEvent463 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._onWindowAttributesChanged464 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V"); 
			global::android.app.Dialog._onContentChanged465 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContentChanged", "()V"); 
			global::android.app.Dialog._onWindowFocusChanged466 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.app.Dialog._onAttachedToWindow467 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V"); 
			global::android.app.Dialog._onDetachedFromWindow468 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.app.Dialog._dispatchKeyEvent469 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._dispatchTouchEvent470 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._dispatchTrackballEvent471 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._dispatchPopulateAccessibilityEvent472 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.app.Dialog._onCreatePanelView473 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;"); 
			global::android.app.Dialog._onCreatePanelMenu474 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Dialog._onPreparePanel475 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onMenuOpened476 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Dialog._onMenuItemSelected477 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onPanelClosed478 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V"); 
			global::android.app.Dialog._onCreateOptionsMenu479 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onPrepareOptionsMenu480 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onOptionsItemSelected481 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onOptionsMenuClosed482 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Dialog._openOptionsMenu483 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openOptionsMenu", "()V"); 
			global::android.app.Dialog._closeOptionsMenu484 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V"); 
			global::android.app.Dialog._onCreateContextMenu485 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			global::android.app.Dialog._registerForContextMenu486 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._unregisterForContextMenu487 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._openContextMenu488 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._onContextItemSelected489 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onContextMenuClosed490 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Dialog._onSearchRequested491 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSearchRequested", "()Z"); 
			global::android.app.Dialog._takeKeyEvents492 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V"); 
			global::android.app.Dialog._requestWindowFeature493 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z"); 
			global::android.app.Dialog._setFeatureDrawableResource494 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V"); 
			global::android.app.Dialog._setFeatureDrawableUri495 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V"); 
			global::android.app.Dialog._setFeatureDrawable496 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.app.Dialog._setFeatureDrawableAlpha497 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V"); 
			global::android.app.Dialog._getLayoutInflater498 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.app.Dialog._setTitle499 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(I)V"); 
			global::android.app.Dialog._setTitle500 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.Dialog._setVolumeControlStream501 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V"); 
			global::android.app.Dialog._getVolumeControlStream502 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I"); 
			global::android.app.Dialog._setOnKeyListener503 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V"); 
			global::android.app.Dialog._setOwnerActivity504 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V"); 
			global::android.app.Dialog._getOwnerActivity505 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;"); 
			global::android.app.Dialog._isShowing506 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "isShowing", "()Z"); 
			global::android.app.Dialog._show507 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "show", "()V"); 
			global::android.app.Dialog._hide508 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "hide", "()V"); 
			global::android.app.Dialog._dismiss509 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dismiss", "()V"); 
			global::android.app.Dialog._setCancelable510 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelable", "(Z)V"); 
			global::android.app.Dialog._setCanceledOnTouchOutside511 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V"); 
			global::android.app.Dialog._setOnCancelListener512 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V"); 
			global::android.app.Dialog._setCancelMessage513 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V"); 
			global::android.app.Dialog._setOnDismissListener514 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V"); 
			global::android.app.Dialog._setDismissMessage515 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V"); 
			global::android.app.Dialog._Dialog516 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.app.Dialog._Dialog517 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.app.Dialog._Dialog518 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V"); 
		} 
	} 
} 
