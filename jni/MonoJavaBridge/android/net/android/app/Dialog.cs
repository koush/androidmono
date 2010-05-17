namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Dialog : java.lang.Object, android.content.DialogInterface, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static Dialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Dialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getContext435; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext435)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _getContext435)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel436; 
		public virtual void cancel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _cancel436); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _cancel436); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate437; 
		protected virtual void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onCreate437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onCreate437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart438; 
		protected virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onStart438); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onStart438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow439; 
		public virtual android.view.Window getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, _getWindow439)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _getWindow439)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus440; 
		public virtual android.view.View getCurrentFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentFocus440)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _getCurrentFocus440)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState441; 
		public virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onRestoreInstanceState441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState442; 
		public virtual android.os.Bundle onSaveInstanceState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _onSaveInstanceState442)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _onSaveInstanceState442)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop443; 
		protected virtual void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onStop443); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onStop443); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById444; 
		public virtual android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewById444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _findViewById444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView445; 
		public virtual void setContentView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setContentView445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setContentView445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView446; 
		public virtual void setContentView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setContentView446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setContentView446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView447; 
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setContentView447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setContentView447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addContentView448; 
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _addContentView448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _addContentView448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown449; 
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onKeyDown449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onKeyDown449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress450; 
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onKeyLongPress450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onKeyLongPress450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp451; 
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onKeyUp451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onKeyUp451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple452; 
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onKeyMultiple452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onKeyMultiple452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed453; 
		public virtual void onBackPressed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onBackPressed453); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onBackPressed453); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent454; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onTouchEvent454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent455; 
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onTrackballEvent455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged456; 
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onWindowAttributesChanged456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onWindowAttributesChanged456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged457; 
		public virtual void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onContentChanged457); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onContentChanged457); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged458; 
		public virtual void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onWindowFocusChanged458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow459; 
		public virtual void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow459); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onAttachedToWindow459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow460; 
		public virtual void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow460); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onDetachedFromWindow460); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent461; 
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _dispatchKeyEvent461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent462; 
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _dispatchTouchEvent462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent463; 
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _dispatchTrackballEvent463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _dispatchTrackballEvent463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent464; 
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _dispatchPopulateAccessibilityEvent464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView465; 
		public virtual android.view.View onCreatePanelView(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _onCreatePanelView465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _onCreatePanelView465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu466; 
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onCreatePanelMenu466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onCreatePanelMenu466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel467; 
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onPreparePanel467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onPreparePanel467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened468; 
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onMenuOpened468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onMenuOpened468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected469; 
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onMenuItemSelected469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onMenuItemSelected469, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed470; 
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onPanelClosed470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onPanelClosed470, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu471; 
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onCreateOptionsMenu471, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onCreateOptionsMenu471, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu472; 
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onPrepareOptionsMenu472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onPrepareOptionsMenu472, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected473; 
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onOptionsItemSelected473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onOptionsItemSelected473, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed474; 
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onOptionsMenuClosed474, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onOptionsMenuClosed474, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu475; 
		public virtual void openOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _openOptionsMenu475); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _openOptionsMenu475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu476; 
		public virtual void closeOptionsMenu() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _closeOptionsMenu476); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _closeOptionsMenu476); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu477; 
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onCreateContextMenu477, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onCreateContextMenu477, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu478; 
		public virtual void registerForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _registerForContextMenu478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _registerForContextMenu478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu479; 
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _unregisterForContextMenu479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _unregisterForContextMenu479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu480; 
		public virtual void openContextMenu(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _openContextMenu480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _openContextMenu480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected481; 
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onContextItemSelected481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onContextItemSelected481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed482; 
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _onContextMenuClosed482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _onContextMenuClosed482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested483; 
		public virtual bool onSearchRequested() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _onSearchRequested483); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _onSearchRequested483); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents484; 
		public virtual void takeKeyEvents(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _takeKeyEvents484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _takeKeyEvents484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature485; 
		public virtual bool requestWindowFeature(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _requestWindowFeature485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _requestWindowFeature485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource486; 
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableResource486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setFeatureDrawableResource486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri487; 
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableUri487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setFeatureDrawableUri487, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable488; 
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setFeatureDrawable488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setFeatureDrawable488, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha489; 
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setFeatureDrawableAlpha489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setFeatureDrawableAlpha489, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater490; 
		public virtual android.view.LayoutInflater getLayoutInflater() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutInflater490)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _getLayoutInflater490)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle491; 
		public virtual void setTitle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setTitle491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setTitle491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle492; 
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setTitle492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setTitle492, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream493; 
		public virtual void setVolumeControlStream(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setVolumeControlStream493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setVolumeControlStream493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream494; 
		public virtual int getVolumeControlStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallIntMethod(this, _getVolumeControlStream494); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Dialog.staticClass, _getVolumeControlStream494); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener495; 
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setOnKeyListener495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setOnKeyListener495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOwnerActivity496; 
		public virtual void setOwnerActivity(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setOwnerActivity496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setOwnerActivity496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOwnerActivity497; 
		public virtual android.app.Activity getOwnerActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getOwnerActivity497)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Dialog.staticClass, _getOwnerActivity497)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShowing498; 
		public virtual bool isShowing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				return @__env.CallBooleanMethod(this, _isShowing498); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Dialog.staticClass, _isShowing498); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show499; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _show499); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _show499); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide500; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _hide500); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _hide500); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dismiss501; 
		public virtual void dismiss() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _dismiss501); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _dismiss501); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCancelable502; 
		public virtual void setCancelable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setCancelable502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setCancelable502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCanceledOnTouchOutside503; 
		public virtual void setCanceledOnTouchOutside(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setCanceledOnTouchOutside503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setCanceledOnTouchOutside503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener504; 
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setOnCancelListener504, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setOnCancelListener504, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCancelMessage505; 
		public virtual void setCancelMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setCancelMessage505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setCancelMessage505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener506; 
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setOnDismissListener506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setOnDismissListener506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDismissMessage507; 
		public virtual void setDismissMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Dialog)) 
				@__env.CallVoidMethod(this, _setDismissMessage507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Dialog.staticClass, _setDismissMessage507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog508; 
		public Dialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, _Dialog508, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog509; 
		public Dialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, _Dialog509, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Dialog510; 
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Dialog.staticClass, _Dialog510, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Dialog.staticClass = @__class; 
			global::android.app.Dialog._getContext435 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.app.Dialog._cancel436 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "cancel", "()V"); 
			global::android.app.Dialog._onCreate437 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Dialog._onStart438 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStart", "()V"); 
			global::android.app.Dialog._getWindow439 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;"); 
			global::android.app.Dialog._getCurrentFocus440 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;"); 
			global::android.app.Dialog._onRestoreInstanceState441 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.Dialog._onSaveInstanceState442 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;"); 
			global::android.app.Dialog._onStop443 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStop", "()V"); 
			global::android.app.Dialog._findViewById444 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.app.Dialog._setContentView445 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(I)V"); 
			global::android.app.Dialog._setContentView446 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._setContentView447 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Dialog._addContentView448 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.app.Dialog._onKeyDown449 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyLongPress450 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyUp451 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onKeyMultiple452 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._onBackPressed453 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onBackPressed", "()V"); 
			global::android.app.Dialog._onTouchEvent454 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._onTrackballEvent455 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._onWindowAttributesChanged456 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V"); 
			global::android.app.Dialog._onContentChanged457 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContentChanged", "()V"); 
			global::android.app.Dialog._onWindowFocusChanged458 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.app.Dialog._onAttachedToWindow459 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V"); 
			global::android.app.Dialog._onDetachedFromWindow460 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.app.Dialog._dispatchKeyEvent461 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.app.Dialog._dispatchTouchEvent462 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._dispatchTrackballEvent463 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.app.Dialog._dispatchPopulateAccessibilityEvent464 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.app.Dialog._onCreatePanelView465 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;"); 
			global::android.app.Dialog._onCreatePanelMenu466 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Dialog._onPreparePanel467 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onMenuOpened468 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z"); 
			global::android.app.Dialog._onMenuItemSelected469 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onPanelClosed470 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V"); 
			global::android.app.Dialog._onCreateOptionsMenu471 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onPrepareOptionsMenu472 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z"); 
			global::android.app.Dialog._onOptionsItemSelected473 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onOptionsMenuClosed474 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Dialog._openOptionsMenu475 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openOptionsMenu", "()V"); 
			global::android.app.Dialog._closeOptionsMenu476 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V"); 
			global::android.app.Dialog._onCreateContextMenu477 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			global::android.app.Dialog._registerForContextMenu478 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._unregisterForContextMenu479 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._openContextMenu480 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V"); 
			global::android.app.Dialog._onContextItemSelected481 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z"); 
			global::android.app.Dialog._onContextMenuClosed482 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V"); 
			global::android.app.Dialog._onSearchRequested483 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSearchRequested", "()Z"); 
			global::android.app.Dialog._takeKeyEvents484 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V"); 
			global::android.app.Dialog._requestWindowFeature485 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z"); 
			global::android.app.Dialog._setFeatureDrawableResource486 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V"); 
			global::android.app.Dialog._setFeatureDrawableUri487 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V"); 
			global::android.app.Dialog._setFeatureDrawable488 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.app.Dialog._setFeatureDrawableAlpha489 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V"); 
			global::android.app.Dialog._getLayoutInflater490 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.app.Dialog._setTitle491 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(I)V"); 
			global::android.app.Dialog._setTitle492 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.Dialog._setVolumeControlStream493 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V"); 
			global::android.app.Dialog._getVolumeControlStream494 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I"); 
			global::android.app.Dialog._setOnKeyListener495 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V"); 
			global::android.app.Dialog._setOwnerActivity496 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V"); 
			global::android.app.Dialog._getOwnerActivity497 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;"); 
			global::android.app.Dialog._isShowing498 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "isShowing", "()Z"); 
			global::android.app.Dialog._show499 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "show", "()V"); 
			global::android.app.Dialog._hide500 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "hide", "()V"); 
			global::android.app.Dialog._dismiss501 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dismiss", "()V"); 
			global::android.app.Dialog._setCancelable502 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelable", "(Z)V"); 
			global::android.app.Dialog._setCanceledOnTouchOutside503 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V"); 
			global::android.app.Dialog._setOnCancelListener504 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V"); 
			global::android.app.Dialog._setCancelMessage505 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V"); 
			global::android.app.Dialog._setOnDismissListener506 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V"); 
			global::android.app.Dialog._setDismissMessage507 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V"); 
			global::android.app.Dialog._Dialog508 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.app.Dialog._Dialog509 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.app.Dialog._Dialog510 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V"); 
		} 
	} 
} 
