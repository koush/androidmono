namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Dialog : java.lang.Object, android.content.DialogInterface, android.view.Window.Callback, android.view.KeyEvent.Callback, android.view.View.OnCreateContextMenuListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getContext1747;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.app.Dialog._getContext1747) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _cancel1748;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "cancel", "()V", ref global::android.app.Dialog._cancel1748);
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1749;
		protected virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Dialog._onCreate1749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1750;
		protected virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onStart", "()V", ref global::android.app.Dialog._onStart1750);
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWindow1751;
		public virtual global::android.view.Window getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;", ref global::android.app.Dialog._getWindow1751) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus1752;
		public virtual global::android.view.View getCurrentFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;", ref global::android.app.Dialog._getCurrentFocus1752) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onRestoreInstanceState1753;
		public virtual void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.Dialog._onRestoreInstanceState1753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSaveInstanceState1754;
		public virtual global::android.os.Bundle onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;", ref global::android.app.Dialog._onSaveInstanceState1754) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _onStop1755;
		protected virtual void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onStop", "()V", ref global::android.app.Dialog._onStop1755);
		}
		internal static global::MonoJavaBridge.MethodId _findViewById1756;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.app.Dialog._findViewById1756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1757;
		public virtual void setContentView(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(I)V", ref global::android.app.Dialog._setContentView1757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1758;
		public virtual void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V", ref global::android.app.Dialog._setContentView1758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView1759;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Dialog._setContentView1759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView1760;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Dialog._addContentView1760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1761;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._onKeyDown1761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyLongPress1762;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._onKeyLongPress1762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1763;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._onKeyUp1763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple1764;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._onKeyMultiple1764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onBackPressed1765;
		public virtual void onBackPressed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onBackPressed", "()V", ref global::android.app.Dialog._onBackPressed1765);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent1766;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._onTouchEvent1766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent1767;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._onTrackballEvent1767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged1768;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", ref global::android.app.Dialog._onWindowAttributesChanged1768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContentChanged1769;
		public virtual void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onContentChanged", "()V", ref global::android.app.Dialog._onContentChanged1769);
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged1770;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.app.Dialog._onWindowFocusChanged1770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow1771;
		public virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V", ref global::android.app.Dialog._onAttachedToWindow1771);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow1772;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V", ref global::android.app.Dialog._onDetachedFromWindow1772);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent1773;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.app.Dialog._dispatchKeyEvent1773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent1774;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._dispatchTouchEvent1774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent1775;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._dispatchTrackballEvent1775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent1776;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.app.Dialog._dispatchPopulateAccessibilityEvent1776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelView1777;
		public virtual global::android.view.View onCreatePanelView(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;", ref global::android.app.Dialog._onCreatePanelView1777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu1778;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z", ref global::android.app.Dialog._onCreatePanelMenu1778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPreparePanel1779;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", ref global::android.app.Dialog._onPreparePanel1779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuOpened1780;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z", ref global::android.app.Dialog._onMenuOpened1780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onMenuItemSelected1781;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", ref global::android.app.Dialog._onMenuItemSelected1781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPanelClosed1782;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V", ref global::android.app.Dialog._onPanelClosed1782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateOptionsMenu1783;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Dialog._onCreateOptionsMenu1783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPrepareOptionsMenu1784;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Dialog._onPrepareOptionsMenu1784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsItemSelected1785;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Dialog._onOptionsItemSelected1785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onOptionsMenuClosed1786;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Dialog._onOptionsMenuClosed1786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOptionsMenu1787;
		public virtual void openOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "openOptionsMenu", "()V", ref global::android.app.Dialog._openOptionsMenu1787);
		}
		internal static global::MonoJavaBridge.MethodId _closeOptionsMenu1788;
		public virtual void closeOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V", ref global::android.app.Dialog._closeOptionsMenu1788);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateContextMenu1789;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.app.Dialog._onCreateContextMenu1789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerForContextMenu1790;
		public virtual void registerForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._registerForContextMenu1790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterForContextMenu1791;
		public virtual void unregisterForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._unregisterForContextMenu1791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openContextMenu1792;
		public virtual void openContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._openContextMenu1792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextItemSelected1793;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Dialog._onContextItemSelected1793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onContextMenuClosed1794;
		public virtual void onContextMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Dialog._onContextMenuClosed1794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSearchRequested1795;
		public virtual bool onSearchRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onSearchRequested", "()Z", ref global::android.app.Dialog._onSearchRequested1795);
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents1796;
		public virtual void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V", ref global::android.app.Dialog._takeKeyEvents1796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestWindowFeature1797;
		public virtual bool requestWindowFeature(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z", ref global::android.app.Dialog._requestWindowFeature1797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource1798;
		public virtual void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V", ref global::android.app.Dialog._setFeatureDrawableResource1798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri1799;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V", ref global::android.app.Dialog._setFeatureDrawableUri1799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable1800;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", ref global::android.app.Dialog._setFeatureDrawable1800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha1801;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V", ref global::android.app.Dialog._setFeatureDrawableAlpha1801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater1802;
		public virtual global::android.view.LayoutInflater getLayoutInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;", ref global::android.app.Dialog._getLayoutInflater1802) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1803;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setTitle", "(I)V", ref global::android.app.Dialog._setTitle1803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1804;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.app.Dialog._setTitle1804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream1805;
		public virtual void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V", ref global::android.app.Dialog._setVolumeControlStream1805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream1806;
		public virtual int getVolumeControlStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I", ref global::android.app.Dialog._getVolumeControlStream1806);
		}
		public new global::android.content.DialogInterface_OnKeyListener OnKeyListener
		{
			set
			{
				setOnKeyListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnKeyListener1807;
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V", ref global::android.app.Dialog._setOnKeyListener1807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnKeyListener(global::android.content.DialogInterface_OnKeyListenerDelegate arg0)
		{
			setOnKeyListener((global::android.content.DialogInterface_OnKeyListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOwnerActivity1808;
		public virtual void setOwnerActivity(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V", ref global::android.app.Dialog._setOwnerActivity1808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOwnerActivity1809;
		public virtual global::android.app.Activity getOwnerActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;", ref global::android.app.Dialog._getOwnerActivity1809) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _isShowing1810;
		public virtual bool isShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "isShowing", "()Z", ref global::android.app.Dialog._isShowing1810);
		}
		internal static global::MonoJavaBridge.MethodId _show1811;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "show", "()V", ref global::android.app.Dialog._show1811);
		}
		internal static global::MonoJavaBridge.MethodId _hide1812;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "hide", "()V", ref global::android.app.Dialog._hide1812);
		}
		internal static global::MonoJavaBridge.MethodId _dismiss1813;
		public virtual void dismiss()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "dismiss", "()V", ref global::android.app.Dialog._dismiss1813);
		}
		public new bool Cancelable
		{
			set
			{
				setCancelable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCancelable1814;
		public virtual void setCancelable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCancelable", "(Z)V", ref global::android.app.Dialog._setCancelable1814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CanceledOnTouchOutside
		{
			set
			{
				setCanceledOnTouchOutside(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCanceledOnTouchOutside1815;
		public virtual void setCanceledOnTouchOutside(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V", ref global::android.app.Dialog._setCanceledOnTouchOutside1815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.DialogInterface_OnCancelListener OnCancelListener
		{
			set
			{
				setOnCancelListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnCancelListener1816;
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V", ref global::android.app.Dialog._setOnCancelListener1816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCancelListener(global::android.content.DialogInterface_OnCancelListenerDelegate arg0)
		{
			setOnCancelListener((global::android.content.DialogInterface_OnCancelListenerDelegateWrapper)arg0);
		}
		public new global::android.os.Message CancelMessage
		{
			set
			{
				setCancelMessage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCancelMessage1817;
		public virtual void setCancelMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V", ref global::android.app.Dialog._setCancelMessage1817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.DialogInterface_OnDismissListener OnDismissListener
		{
			set
			{
				setOnDismissListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnDismissListener1818;
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V", ref global::android.app.Dialog._setOnDismissListener1818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDismissListener(global::android.content.DialogInterface_OnDismissListenerDelegate arg0)
		{
			setOnDismissListener((global::android.content.DialogInterface_OnDismissListenerDelegateWrapper)arg0);
		}
		public new global::android.content.DialogInterface_OnShowListener OnShowListener
		{
			set
			{
				setOnShowListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnShowListener1819;
		public virtual void setOnShowListener(android.content.DialogInterface_OnShowListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V", ref global::android.app.Dialog._setOnShowListener1819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnShowListener(global::android.content.DialogInterface_OnShowListenerDelegate arg0)
		{
			setOnShowListener((global::android.content.DialogInterface_OnShowListenerDelegateWrapper)arg0);
		}
		public new global::android.os.Message DismissMessage
		{
			set
			{
				setDismissMessage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDismissMessage1820;
		public virtual void setDismissMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V", ref global::android.app.Dialog._setDismissMessage1820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1821;
		public Dialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._Dialog1821.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._Dialog1821 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1822;
		public Dialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._Dialog1822.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._Dialog1822 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Dialog1823;
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._Dialog1823.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._Dialog1823 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._Dialog1823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Dialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Dialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Dialog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
