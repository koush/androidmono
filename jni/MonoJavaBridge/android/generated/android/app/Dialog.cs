namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Dialog : java.lang.Object, android.content.DialogInterface, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Dialog()
		{
			InitJNI();
		}
		protected Dialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContext460;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getContext460)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getContext460)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _cancel461;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._cancel461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._cancel461);
		}
		internal static global::MonoJavaBridge.MethodId _onCreate462;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onCreate462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreate462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart463;
		protected virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onStart463);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStart463);
		}
		internal static global::MonoJavaBridge.MethodId _getWindow464;
		public virtual global::android.view.Window getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getWindow464)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getWindow464)) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus465;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getCurrentFocus465)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getCurrentFocus465)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState466;
		public virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onRestoreInstanceState466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onRestoreInstanceState466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState467;
		public virtual global::android.os.Bundle onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._onSaveInstanceState467)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSaveInstanceState467)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onStop468;
		protected virtual void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onStop468);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStop468);
		}
		internal static global::MonoJavaBridge.MethodId _findViewById469;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._findViewById469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._findViewById469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView470;
		public virtual void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView471;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView472;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView473;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._addContentView473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._addContentView473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown474;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyDown474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyDown474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress475;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyLongPress475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyLongPress475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp476;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyUp476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyUp476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple477;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyMultiple477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyMultiple477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed478;
		public virtual void onBackPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onBackPressed478);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onBackPressed478);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent479;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onTouchEvent479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTouchEvent479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent480;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onTrackballEvent480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTrackballEvent480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged481;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onWindowAttributesChanged481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowAttributesChanged481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged482;
		public virtual void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onContentChanged482);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContentChanged482);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged483;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onWindowFocusChanged483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowFocusChanged483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow484;
		public virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onAttachedToWindow484);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onAttachedToWindow484);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow485;
		public virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onDetachedFromWindow485);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onDetachedFromWindow485);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent486;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchKeyEvent486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchKeyEvent486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent487;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchTouchEvent487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTouchEvent487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent488;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchTrackballEvent488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTrackballEvent488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent489;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchPopulateAccessibilityEvent489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchPopulateAccessibilityEvent489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView490;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._onCreatePanelView490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelView490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu491;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onCreatePanelMenu491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelMenu491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel492;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onPreparePanel492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPreparePanel492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened493;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onMenuOpened493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuOpened493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected494;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onMenuItemSelected494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuItemSelected494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed495;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onPanelClosed495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPanelClosed495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu496;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onCreateOptionsMenu496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateOptionsMenu496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu497;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onPrepareOptionsMenu497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPrepareOptionsMenu497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected498;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onOptionsItemSelected498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsItemSelected498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed499;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onOptionsMenuClosed499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsMenuClosed499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu500;
		public virtual void openOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._openOptionsMenu500);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._openOptionsMenu500);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu501;
		public virtual void closeOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._closeOptionsMenu501);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._closeOptionsMenu501);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu502;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onCreateContextMenu502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateContextMenu502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu503;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._registerForContextMenu503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._registerForContextMenu503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu504;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._unregisterForContextMenu504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._unregisterForContextMenu504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu505;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._openContextMenu505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._openContextMenu505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected506;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onContextItemSelected506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextItemSelected506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed507;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onContextMenuClosed507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextMenuClosed507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested508;
		public virtual bool onSearchRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onSearchRequested508);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSearchRequested508);
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents509;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._takeKeyEvents509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._takeKeyEvents509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature510;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._requestWindowFeature510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._requestWindowFeature510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource511;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableResource511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableResource511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri512;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableUri512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableUri512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable513;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawable513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawable513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha514;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableAlpha514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableAlpha514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater515;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getLayoutInflater515)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getLayoutInflater515)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle516;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setTitle516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle517;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setTitle517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream518;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setVolumeControlStream518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setVolumeControlStream518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream519;
		public virtual int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Dialog._getVolumeControlStream519);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getVolumeControlStream519);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener520;
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnKeyListener520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnKeyListener520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOwnerActivity521;
		public virtual void setOwnerActivity(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOwnerActivity521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOwnerActivity521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerActivity522;
		public virtual global::android.app.Activity getOwnerActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getOwnerActivity522)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getOwnerActivity522)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing523;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._isShowing523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._isShowing523);
		}
		internal static global::MonoJavaBridge.MethodId _show524;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._show524);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._show524);
		}
		internal static global::MonoJavaBridge.MethodId _hide525;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._hide525);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._hide525);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss526;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._dismiss526);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dismiss526);
		}
		internal static global::MonoJavaBridge.MethodId _setCancelable527;
		public virtual void setCancelable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCancelable527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelable527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCanceledOnTouchOutside528;
		public virtual void setCanceledOnTouchOutside(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCanceledOnTouchOutside528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCanceledOnTouchOutside528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCancelListener529;
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnCancelListener529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnCancelListener529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCancelMessage530;
		public virtual void setCancelMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCancelMessage530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelMessage530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener531;
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnDismissListener531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnDismissListener531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnShowListener532;
		public virtual void setOnShowListener(android.content.DialogInterface_OnShowListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnShowListener532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnShowListener532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDismissMessage533;
		public virtual void setDismissMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setDismissMessage533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setDismissMessage533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Dialog534;
		public Dialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog535;
		public Dialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog536;
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Dialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Dialog"));
			global::android.app.Dialog._getContext460 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Dialog._cancel461 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "cancel", "()V");
			global::android.app.Dialog._onCreate462 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onStart463 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onStart", "()V");
			global::android.app.Dialog._getWindow464 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Dialog._getCurrentFocus465 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Dialog._onRestoreInstanceState466 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onSaveInstanceState467 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.Dialog._onStop468 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onStop", "()V");
			global::android.app.Dialog._findViewById469 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Dialog._setContentView470 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(I)V");
			global::android.app.Dialog._setContentView471 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Dialog._setContentView472 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._addContentView473 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._onKeyDown474 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyLongPress475 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyUp476 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyMultiple477 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onBackPressed478 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onBackPressed", "()V");
			global::android.app.Dialog._onTouchEvent479 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onTrackballEvent480 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onWindowAttributesChanged481 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Dialog._onContentChanged482 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContentChanged", "()V");
			global::android.app.Dialog._onWindowFocusChanged483 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Dialog._onAttachedToWindow484 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Dialog._onDetachedFromWindow485 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Dialog._dispatchKeyEvent486 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Dialog._dispatchTouchEvent487 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchTrackballEvent488 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchPopulateAccessibilityEvent489 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Dialog._onCreatePanelView490 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Dialog._onCreatePanelMenu491 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onPreparePanel492 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuOpened493 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuItemSelected494 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Dialog._onPanelClosed495 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Dialog._onCreateOptionsMenu496 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onPrepareOptionsMenu497 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onOptionsItemSelected498 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onOptionsMenuClosed499 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._openOptionsMenu500 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "openOptionsMenu", "()V");
			global::android.app.Dialog._closeOptionsMenu501 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Dialog._onCreateContextMenu502 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Dialog._registerForContextMenu503 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._unregisterForContextMenu504 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._openContextMenu505 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._onContextItemSelected506 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onContextMenuClosed507 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._onSearchRequested508 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onSearchRequested", "()Z");
			global::android.app.Dialog._takeKeyEvents509 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Dialog._requestWindowFeature510 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Dialog._setFeatureDrawableResource511 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Dialog._setFeatureDrawableUri512 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Dialog._setFeatureDrawable513 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Dialog._setFeatureDrawableAlpha514 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Dialog._getLayoutInflater515 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Dialog._setTitle516 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setTitle", "(I)V");
			global::android.app.Dialog._setTitle517 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Dialog._setVolumeControlStream518 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Dialog._getVolumeControlStream519 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Dialog._setOnKeyListener520 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V");
			global::android.app.Dialog._setOwnerActivity521 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V");
			global::android.app.Dialog._getOwnerActivity522 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;");
			global::android.app.Dialog._isShowing523 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "isShowing", "()Z");
			global::android.app.Dialog._show524 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "show", "()V");
			global::android.app.Dialog._hide525 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "hide", "()V");
			global::android.app.Dialog._dismiss526 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dismiss", "()V");
			global::android.app.Dialog._setCancelable527 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCancelable", "(Z)V");
			global::android.app.Dialog._setCanceledOnTouchOutside528 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V");
			global::android.app.Dialog._setOnCancelListener529 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.Dialog._setCancelMessage530 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._setOnDismissListener531 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V");
			global::android.app.Dialog._setOnShowListener532 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V");
			global::android.app.Dialog._setDismissMessage533 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._Dialog534 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.Dialog._Dialog535 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.Dialog._Dialog536 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
		}
	}
}
