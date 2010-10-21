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
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext1744;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getContext1744)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getContext1744)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _cancel1745;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._cancel1745);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._cancel1745);
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1746;
		protected virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onCreate1746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreate1746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1747;
		protected virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onStart1747);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStart1747);
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindow1748;
		public virtual global::android.view.Window getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getWindow1748)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getWindow1748)) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus1749;
		public virtual global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getCurrentFocus1749)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getCurrentFocus1749)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1750;
		public virtual void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onRestoreInstanceState1750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onRestoreInstanceState1750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1751;
		public virtual global::android.os.Bundle onSaveInstanceState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._onSaveInstanceState1751)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSaveInstanceState1751)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onStop1752;
		protected virtual void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onStop1752);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onStop1752);
		}
		internal static global::MonoJavaBridge.MethodId _findViewById1753;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._findViewById1753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._findViewById1753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1754;
		public virtual void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView1754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView1754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1755;
		public virtual void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView1755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView1755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1756;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setContentView1756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setContentView1756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView1757;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._addContentView1757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._addContentView1757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1758;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyDown1758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyDown1758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress1759;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyLongPress1759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyLongPress1759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1760;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyUp1760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyUp1760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple1761;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onKeyMultiple1761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onKeyMultiple1761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed1762;
		public virtual void onBackPressed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onBackPressed1762);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onBackPressed1762);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent1763;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onTouchEvent1763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTouchEvent1763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent1764;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onTrackballEvent1764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onTrackballEvent1764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged1765;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onWindowAttributesChanged1765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowAttributesChanged1765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1766;
		public virtual void onContentChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onContentChanged1766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContentChanged1766);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged1767;
		public virtual void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onWindowFocusChanged1767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onWindowFocusChanged1767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow1768;
		public virtual void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onAttachedToWindow1768);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onAttachedToWindow1768);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow1769;
		public virtual void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onDetachedFromWindow1769);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onDetachedFromWindow1769);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent1770;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchKeyEvent1770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchKeyEvent1770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent1771;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchTouchEvent1771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTouchEvent1771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent1772;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchTrackballEvent1772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchTrackballEvent1772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent1773;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._dispatchPopulateAccessibilityEvent1773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dispatchPopulateAccessibilityEvent1773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView1774;
		public virtual global::android.view.View onCreatePanelView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._onCreatePanelView1774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelView1774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu1775;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onCreatePanelMenu1775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreatePanelMenu1775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel1776;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onPreparePanel1776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPreparePanel1776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened1777;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onMenuOpened1777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuOpened1777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected1778;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onMenuItemSelected1778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onMenuItemSelected1778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed1779;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onPanelClosed1779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPanelClosed1779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu1780;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onCreateOptionsMenu1780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateOptionsMenu1780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu1781;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onPrepareOptionsMenu1781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onPrepareOptionsMenu1781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected1782;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onOptionsItemSelected1782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsItemSelected1782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed1783;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onOptionsMenuClosed1783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onOptionsMenuClosed1783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu1784;
		public virtual void openOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._openOptionsMenu1784);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._openOptionsMenu1784);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu1785;
		public virtual void closeOptionsMenu() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._closeOptionsMenu1785);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._closeOptionsMenu1785);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu1786;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onCreateContextMenu1786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onCreateContextMenu1786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu1787;
		public virtual void registerForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._registerForContextMenu1787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._registerForContextMenu1787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu1788;
		public virtual void unregisterForContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._unregisterForContextMenu1788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._unregisterForContextMenu1788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu1789;
		public virtual void openContextMenu(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._openContextMenu1789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._openContextMenu1789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected1790;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onContextItemSelected1790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextItemSelected1790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed1791;
		public virtual void onContextMenuClosed(android.view.Menu arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._onContextMenuClosed1791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onContextMenuClosed1791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested1792;
		public virtual bool onSearchRequested() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._onSearchRequested1792);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._onSearchRequested1792);
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents1793;
		public virtual void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._takeKeyEvents1793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._takeKeyEvents1793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature1794;
		public virtual bool requestWindowFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._requestWindowFeature1794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._requestWindowFeature1794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource1795;
		public virtual void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableResource1795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableResource1795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri1796;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableUri1796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableUri1796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable1797;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawable1797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawable1797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha1798;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setFeatureDrawableAlpha1798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setFeatureDrawableAlpha1798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater1799;
		public virtual global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getLayoutInflater1799)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getLayoutInflater1799)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1800;
		public virtual void setTitle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setTitle1800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle1800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1801;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setTitle1801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setTitle1801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream1802;
		public virtual void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setVolumeControlStream1802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setVolumeControlStream1802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VolumeControlStream
		{
			get
			{
				return getVolumeControlStream();
			}
			set
			{
				setVolumeControlStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream1803;
		public virtual int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Dialog._getVolumeControlStream1803);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getVolumeControlStream1803);
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener1804;
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnKeyListener1804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnKeyListener1804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOwnerActivity1805;
		public virtual void setOwnerActivity(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOwnerActivity1805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOwnerActivity1805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Activity OwnerActivity
		{
			get
			{
				return getOwnerActivity();
			}
			set
			{
				setOwnerActivity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOwnerActivity1806;
		public virtual global::android.app.Activity getOwnerActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Dialog._getOwnerActivity1806)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._getOwnerActivity1806)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing1807;
		public virtual bool isShowing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Dialog._isShowing1807);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._isShowing1807);
		}
		internal static global::MonoJavaBridge.MethodId _show1808;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._show1808);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._show1808);
		}
		internal static global::MonoJavaBridge.MethodId _hide1809;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._hide1809);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._hide1809);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss1810;
		public virtual void dismiss() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._dismiss1810);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._dismiss1810);
		}
		internal static global::MonoJavaBridge.MethodId _setCancelable1811;
		public virtual void setCancelable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCancelable1811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelable1811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCanceledOnTouchOutside1812;
		public virtual void setCanceledOnTouchOutside(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCanceledOnTouchOutside1812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCanceledOnTouchOutside1812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnCancelListener1813;
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnCancelListener1813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnCancelListener1813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCancelMessage1814;
		public virtual void setCancelMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setCancelMessage1814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setCancelMessage1814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener1815;
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnDismissListener1815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnDismissListener1815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnShowListener1816;
		public virtual void setOnShowListener(android.content.DialogInterface_OnShowListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setOnShowListener1816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setOnShowListener1816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDismissMessage1817;
		public virtual void setDismissMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Dialog._setDismissMessage1817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Dialog.staticClass, global::android.app.Dialog._setDismissMessage1817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1818;
		public Dialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1819;
		public Dialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1820;
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Dialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Dialog"));
			global::android.app.Dialog._getContext1744 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Dialog._cancel1745 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "cancel", "()V");
			global::android.app.Dialog._onCreate1746 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onStart1747 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onStart", "()V");
			global::android.app.Dialog._getWindow1748 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;");
			global::android.app.Dialog._getCurrentFocus1749 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.app.Dialog._onRestoreInstanceState1750 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.Dialog._onSaveInstanceState1751 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;");
			global::android.app.Dialog._onStop1752 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onStop", "()V");
			global::android.app.Dialog._findViewById1753 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.app.Dialog._setContentView1754 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(I)V");
			global::android.app.Dialog._setContentView1755 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.app.Dialog._setContentView1756 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._addContentView1757 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.app.Dialog._onKeyDown1758 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyLongPress1759 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyUp1760 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onKeyMultiple1761 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.app.Dialog._onBackPressed1762 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onBackPressed", "()V");
			global::android.app.Dialog._onTouchEvent1763 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onTrackballEvent1764 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._onWindowAttributesChanged1765 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.app.Dialog._onContentChanged1766 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContentChanged", "()V");
			global::android.app.Dialog._onWindowFocusChanged1767 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.app.Dialog._onAttachedToWindow1768 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V");
			global::android.app.Dialog._onDetachedFromWindow1769 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V");
			global::android.app.Dialog._dispatchKeyEvent1770 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.app.Dialog._dispatchTouchEvent1771 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchTrackballEvent1772 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.app.Dialog._dispatchPopulateAccessibilityEvent1773 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.app.Dialog._onCreatePanelView1774 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
			global::android.app.Dialog._onCreatePanelMenu1775 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onPreparePanel1776 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuOpened1777 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			global::android.app.Dialog._onMenuItemSelected1778 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			global::android.app.Dialog._onPanelClosed1779 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
			global::android.app.Dialog._onCreateOptionsMenu1780 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onPrepareOptionsMenu1781 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z");
			global::android.app.Dialog._onOptionsItemSelected1782 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onOptionsMenuClosed1783 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._openOptionsMenu1784 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "openOptionsMenu", "()V");
			global::android.app.Dialog._closeOptionsMenu1785 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V");
			global::android.app.Dialog._onCreateContextMenu1786 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.Dialog._registerForContextMenu1787 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._unregisterForContextMenu1788 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._openContextMenu1789 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V");
			global::android.app.Dialog._onContextItemSelected1790 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z");
			global::android.app.Dialog._onContextMenuClosed1791 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V");
			global::android.app.Dialog._onSearchRequested1792 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "onSearchRequested", "()Z");
			global::android.app.Dialog._takeKeyEvents1793 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V");
			global::android.app.Dialog._requestWindowFeature1794 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z");
			global::android.app.Dialog._setFeatureDrawableResource1795 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.app.Dialog._setFeatureDrawableUri1796 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.app.Dialog._setFeatureDrawable1797 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.app.Dialog._setFeatureDrawableAlpha1798 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.app.Dialog._getLayoutInflater1799 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.app.Dialog._setTitle1800 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setTitle", "(I)V");
			global::android.app.Dialog._setTitle1801 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.Dialog._setVolumeControlStream1802 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V");
			global::android.app.Dialog._getVolumeControlStream1803 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I");
			global::android.app.Dialog._setOnKeyListener1804 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V");
			global::android.app.Dialog._setOwnerActivity1805 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V");
			global::android.app.Dialog._getOwnerActivity1806 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;");
			global::android.app.Dialog._isShowing1807 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "isShowing", "()Z");
			global::android.app.Dialog._show1808 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "show", "()V");
			global::android.app.Dialog._hide1809 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "hide", "()V");
			global::android.app.Dialog._dismiss1810 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "dismiss", "()V");
			global::android.app.Dialog._setCancelable1811 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCancelable", "(Z)V");
			global::android.app.Dialog._setCanceledOnTouchOutside1812 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V");
			global::android.app.Dialog._setOnCancelListener1813 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.Dialog._setCancelMessage1814 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._setOnDismissListener1815 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V");
			global::android.app.Dialog._setOnShowListener1816 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V");
			global::android.app.Dialog._setDismissMessage1817 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V");
			global::android.app.Dialog._Dialog1818 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.Dialog._Dialog1819 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.Dialog._Dialog1820 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
		}
	}
}
