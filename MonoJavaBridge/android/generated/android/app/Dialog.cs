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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.app.Dialog._m0) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "cancel", "()V", ref global::android.app.Dialog._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Dialog._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onStart", "()V", ref global::android.app.Dialog._m3);
		}
		public new global::android.view.Window Window
		{
			get
			{
				return getWindow();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.view.Window getWindow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getWindow", "()Landroid/view/Window;", ref global::android.app.Dialog._m4) as android.view.Window;
		}
		public new global::android.view.View CurrentFocus
		{
			get
			{
				return getCurrentFocus();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.view.View getCurrentFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getCurrentFocus", "()Landroid/view/View;", ref global::android.app.Dialog._m5) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onRestoreInstanceState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V", ref global::android.app.Dialog._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.os.Bundle onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Dialog.staticClass, "onSaveInstanceState", "()Landroid/os/Bundle;", ref global::android.app.Dialog._m7) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onStop", "()V", ref global::android.app.Dialog._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.app.Dialog._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setContentView(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(I)V", ref global::android.app.Dialog._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;)V", ref global::android.app.Dialog._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Dialog._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.app.Dialog._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.app.Dialog._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void onBackPressed()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onBackPressed", "()V", ref global::android.app.Dialog._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", ref global::android.app.Dialog._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void onContentChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onContentChanged", "()V", ref global::android.app.Dialog._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.app.Dialog._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onAttachedToWindow", "()V", ref global::android.app.Dialog._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onDetachedFromWindow", "()V", ref global::android.app.Dialog._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.app.Dialog._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.app.Dialog._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.app.Dialog._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::android.view.View onCreatePanelView(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "onCreatePanelView", "(I)Landroid/view/View;", ref global::android.app.Dialog._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool onCreatePanelMenu(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z", ref global::android.app.Dialog._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", ref global::android.app.Dialog._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool onMenuOpened(int arg0, android.view.Menu arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z", ref global::android.app.Dialog._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool onMenuItemSelected(int arg0, android.view.MenuItem arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", ref global::android.app.Dialog._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void onPanelClosed(int arg0, android.view.Menu arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V", ref global::android.app.Dialog._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual bool onCreateOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onCreateOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Dialog._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool onPrepareOptionsMenu(android.view.Menu arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;)Z", ref global::android.app.Dialog._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool onOptionsItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Dialog._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void onOptionsMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onOptionsMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Dialog._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void openOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "openOptionsMenu", "()V", ref global::android.app.Dialog._m40);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void closeOptionsMenu()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "closeOptionsMenu", "()V", ref global::android.app.Dialog._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.app.Dialog._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void registerForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "registerForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void unregisterForContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "unregisterForContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void openContextMenu(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "openContextMenu", "(Landroid/view/View;)V", ref global::android.app.Dialog._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool onContextItemSelected(android.view.MenuItem arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onContextItemSelected", "(Landroid/view/MenuItem;)Z", ref global::android.app.Dialog._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void onContextMenuClosed(android.view.Menu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "onContextMenuClosed", "(Landroid/view/Menu;)V", ref global::android.app.Dialog._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual bool onSearchRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "onSearchRequested", "()Z", ref global::android.app.Dialog._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "takeKeyEvents", "(Z)V", ref global::android.app.Dialog._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual bool requestWindowFeature(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "requestWindowFeature", "(I)Z", ref global::android.app.Dialog._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableResource", "(II)V", ref global::android.app.Dialog._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V", ref global::android.app.Dialog._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", ref global::android.app.Dialog._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setFeatureDrawableAlpha", "(II)V", ref global::android.app.Dialog._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.LayoutInflater LayoutInflater
		{
			get
			{
				return getLayoutInflater();
			}
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::android.view.LayoutInflater getLayoutInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;", ref global::android.app.Dialog._m55) as android.view.LayoutInflater;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void setTitle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setTitle", "(I)V", ref global::android.app.Dialog._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.app.Dialog._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setVolumeControlStream", "(I)V", ref global::android.app.Dialog._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual int getVolumeControlStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Dialog.staticClass, "getVolumeControlStream", "()I", ref global::android.app.Dialog._m59);
		}
		public new global::android.content.DialogInterface_OnKeyListener OnKeyListener
		{
			set
			{
				setOnKeyListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)V", ref global::android.app.Dialog._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnKeyListener(global::android.content.DialogInterface_OnKeyListenerDelegate arg0)
		{
			setOnKeyListener((global::android.content.DialogInterface_OnKeyListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void setOwnerActivity(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOwnerActivity", "(Landroid/app/Activity;)V", ref global::android.app.Dialog._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual global::android.app.Activity getOwnerActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Dialog.staticClass, "getOwnerActivity", "()Landroid/app/Activity;", ref global::android.app.Dialog._m62) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual bool isShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Dialog.staticClass, "isShowing", "()Z", ref global::android.app.Dialog._m63);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "show", "()V", ref global::android.app.Dialog._m64);
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "hide", "()V", ref global::android.app.Dialog._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void dismiss()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "dismiss", "()V", ref global::android.app.Dialog._m66);
		}
		public new bool Cancelable
		{
			set
			{
				setCancelable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual void setCancelable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCancelable", "(Z)V", ref global::android.app.Dialog._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool CanceledOnTouchOutside
		{
			set
			{
				setCanceledOnTouchOutside(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual void setCanceledOnTouchOutside(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCanceledOnTouchOutside", "(Z)V", ref global::android.app.Dialog._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.DialogInterface_OnCancelListener OnCancelListener
		{
			set
			{
				setOnCancelListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual void setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)V", ref global::android.app.Dialog._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void setCancelMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setCancelMessage", "(Landroid/os/Message;)V", ref global::android.app.Dialog._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.content.DialogInterface_OnDismissListener OnDismissListener
		{
			set
			{
				setOnDismissListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual void setOnDismissListener(android.content.DialogInterface_OnDismissListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)V", ref global::android.app.Dialog._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual void setOnShowListener(android.content.DialogInterface_OnShowListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setOnShowListener", "(Landroid/content/DialogInterface$OnShowListener;)V", ref global::android.app.Dialog._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void setDismissMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Dialog.staticClass, "setDismissMessage", "(Landroid/os/Message;)V", ref global::android.app.Dialog._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public Dialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._m74.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._m74 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public Dialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._m75.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._m75 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		protected Dialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Dialog._m76.native == global::System.IntPtr.Zero)
				global::android.app.Dialog._m76 = @__env.GetMethodIDNoThrow(global::android.app.Dialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Dialog.staticClass, global::android.app.Dialog._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Dialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Dialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Dialog"));
		}
	}
}
