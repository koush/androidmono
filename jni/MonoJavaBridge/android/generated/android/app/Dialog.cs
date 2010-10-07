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
		internal static global::net.sf.jni4net.jni.MethodId _getContext451;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getContext451));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getContext451));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel452;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._cancel452);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._cancel452);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate453;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onCreate453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreate453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart454;
		protected virtual void onStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onStart454);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStart454);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow455;
		public virtual global::android.view.Window getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getWindow455));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getWindow455));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus456;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getCurrentFocus456));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getCurrentFocus456));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState457;
		public virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onRestoreInstanceState457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onRestoreInstanceState457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSaveInstanceState458;
		public virtual global::android.os.Bundle onSaveInstanceState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._onSaveInstanceState458));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSaveInstanceState458));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop459;
		protected virtual void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onStop459);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStop459);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findViewById460;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._findViewById460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._findViewById460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView461;
		public virtual void setContentView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView462;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView463;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setContentView463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addContentView464;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._addContentView464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._addContentView464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown465;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyDown465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyDown465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyLongPress466;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyLongPress466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyLongPress466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp467;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyUp467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyUp467, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple468;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onKeyMultiple468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyMultiple468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBackPressed469;
		public virtual void onBackPressed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onBackPressed469);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onBackPressed469);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent470;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onTouchEvent470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTouchEvent470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent471;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onTrackballEvent471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTrackballEvent471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged472;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onWindowAttributesChanged472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowAttributesChanged472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged473;
		public virtual void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onContentChanged473);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContentChanged473);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged474;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onWindowFocusChanged474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowFocusChanged474, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow475;
		public virtual void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onAttachedToWindow475);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onAttachedToWindow475);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow476;
		public virtual void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onDetachedFromWindow476);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onDetachedFromWindow476);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent477;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchKeyEvent477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchKeyEvent477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent478;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchTouchEvent478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTouchEvent478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent479;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchTrackballEvent479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTrackballEvent479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent480;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._dispatchPopulateAccessibilityEvent480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchPopulateAccessibilityEvent480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView481;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._onCreatePanelView481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelView481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu482;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onCreatePanelMenu482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelMenu482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel483;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onPreparePanel483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPreparePanel483, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened484;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onMenuOpened484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuOpened484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected485;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onMenuItemSelected485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuItemSelected485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed486;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onPanelClosed486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPanelClosed486, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateOptionsMenu487;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onCreateOptionsMenu487, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateOptionsMenu487, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPrepareOptionsMenu488;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onPrepareOptionsMenu488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPrepareOptionsMenu488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsItemSelected489;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onOptionsItemSelected489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsItemSelected489, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onOptionsMenuClosed490;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onOptionsMenuClosed490, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsMenuClosed490, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOptionsMenu491;
		public virtual void openOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._openOptionsMenu491);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._openOptionsMenu491);
		}
		internal static global::net.sf.jni4net.jni.MethodId _closeOptionsMenu492;
		public virtual void closeOptionsMenu() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._closeOptionsMenu492);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._closeOptionsMenu492);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu493;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onCreateContextMenu493, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateContextMenu493, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerForContextMenu494;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._registerForContextMenu494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._registerForContextMenu494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterForContextMenu495;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._unregisterForContextMenu495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._unregisterForContextMenu495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openContextMenu496;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._openContextMenu496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._openContextMenu496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextItemSelected497;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onContextItemSelected497, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextItemSelected497, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContextMenuClosed498;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._onContextMenuClosed498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextMenuClosed498, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested499;
		public virtual bool onSearchRequested() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._onSearchRequested499);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSearchRequested499);
		}
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents500;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._takeKeyEvents500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._takeKeyEvents500, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestWindowFeature501;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._requestWindowFeature501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._requestWindowFeature501, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource502;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableResource502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableResource502, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri503;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableUri503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableUri503, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable504;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawable504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawable504, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha505;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setFeatureDrawableAlpha505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableAlpha505, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater506;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getLayoutInflater506));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.LayoutInflater>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getLayoutInflater506));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle507;
		public virtual void setTitle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setTitle507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle507, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle508;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setTitle508, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle508, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream509;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setVolumeControlStream509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setVolumeControlStream509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream510;
		public virtual int getVolumeControlStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Dialog._getVolumeControlStream510);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getVolumeControlStream510);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener511;
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnKeyListener511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnKeyListener511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOwnerActivity512;
		public virtual void setOwnerActivity(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOwnerActivity512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOwnerActivity512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOwnerActivity513;
		public virtual global::android.app.Activity getOwnerActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Dialog._getOwnerActivity513));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._getOwnerActivity513));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShowing514;
		public virtual bool isShowing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Dialog._isShowing514);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._isShowing514);
		}
		internal static global::net.sf.jni4net.jni.MethodId _show515;
		public virtual void show() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._show515);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._show515);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hide516;
		public virtual void hide() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._hide516);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._hide516);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dismiss517;
		public virtual void dismiss() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._dismiss517);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._dismiss517);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCancelable518;
		public virtual void setCancelable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCancelable518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelable518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCanceledOnTouchOutside519;
		public virtual void setCanceledOnTouchOutside(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCanceledOnTouchOutside519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCanceledOnTouchOutside519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener520;
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnCancelListener520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnCancelListener520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCancelMessage521;
		public virtual void setCancelMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setCancelMessage521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelMessage521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDismissListener522;
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnDismissListener522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnDismissListener522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnShowListener523;
		public virtual void setOnShowListener(android.content.DialogInterface_OnShowListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setOnShowListener523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnShowListener523, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDismissMessage524;
		public virtual void setDismissMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Dialog._setDismissMessage524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Dialog.staticClass, global::android.app.Dialog._setDismissMessage524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Dialog525;
		public Dialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog525, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Dialog526;
		public Dialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog526, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Dialog527;
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog527, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.Dialog.staticClass = @__class;
			global::android.app.Dialog._getContext451 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Dialog._cancel452 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "cancel", "()V");
			global::android.app.Dialog._onCreate453 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onStart454 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStart", "()V");
			global::android.app.Dialog._getWindow455 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Dialog._getCurrentFocus456 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Dialog._onRestoreInstanceState457 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onSaveInstanceState458 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.Dialog._onStop459 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onStop", "()V");
			global::android.app.Dialog._findViewById460 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Dialog._setContentView461 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(I)V");
			global::android.app.Dialog._setContentView462 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Dialog._setContentView463 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._addContentView464 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._onKeyDown465 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyLongPress466 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyUp467 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyMultiple468 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onBackPressed469 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onBackPressed", "()V");
			global::android.app.Dialog._onTouchEvent470 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onTrackballEvent471 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onWindowAttributesChanged472 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Dialog._onContentChanged473 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContentChanged", "()V");
			global::android.app.Dialog._onWindowFocusChanged474 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Dialog._onAttachedToWindow475 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Dialog._onDetachedFromWindow476 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Dialog._dispatchKeyEvent477 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Dialog._dispatchTouchEvent478 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchTrackballEvent479 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchPopulateAccessibilityEvent480 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Dialog._onCreatePanelView481 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Dialog._onCreatePanelMenu482 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onPreparePanel483 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuOpened484 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuItemSelected485 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Dialog._onPanelClosed486 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Dialog._onCreateOptionsMenu487 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onPrepareOptionsMenu488 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onOptionsItemSelected489 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onOptionsMenuClosed490 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._openOptionsMenu491 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openOptionsMenu", "()V");
			global::android.app.Dialog._closeOptionsMenu492 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Dialog._onCreateContextMenu493 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Dialog._registerForContextMenu494 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._unregisterForContextMenu495 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._openContextMenu496 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._onContextItemSelected497 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onContextMenuClosed498 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._onSearchRequested499 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "onSearchRequested", "()Z");
			global::android.app.Dialog._takeKeyEvents500 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Dialog._requestWindowFeature501 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Dialog._setFeatureDrawableResource502 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Dialog._setFeatureDrawableUri503 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Dialog._setFeatureDrawable504 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Dialog._setFeatureDrawableAlpha505 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Dialog._getLayoutInflater506 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Dialog._setTitle507 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(I)V");
			global::android.app.Dialog._setTitle508 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Dialog._setVolumeControlStream509 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Dialog._getVolumeControlStream510 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Dialog._setOnKeyListener511 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V");
			global::android.app.Dialog._setOwnerActivity512 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V");
			global::android.app.Dialog._getOwnerActivity513 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;");
			global::android.app.Dialog._isShowing514 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "isShowing", "()Z");
			global::android.app.Dialog._show515 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "show", "()V");
			global::android.app.Dialog._hide516 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "hide", "()V");
			global::android.app.Dialog._dismiss517 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "dismiss", "()V");
			global::android.app.Dialog._setCancelable518 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelable", "(Z)V");
			global::android.app.Dialog._setCanceledOnTouchOutside519 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V");
			global::android.app.Dialog._setOnCancelListener520 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.Dialog._setCancelMessage521 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._setOnDismissListener522 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V");
			global::android.app.Dialog._setOnShowListener523 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V");
			global::android.app.Dialog._setDismissMessage524 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._Dialog525 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.Dialog._Dialog526 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.Dialog._Dialog527 = @__env.GetMethodID(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
		}
	}
}
