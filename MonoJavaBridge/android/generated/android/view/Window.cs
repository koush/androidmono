namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.Window_))]
	public abstract partial class Window : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Window(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Window.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0);
			void onContentChanged();
			void onWindowFocusChanged(bool arg0);
			void onAttachedToWindow();
			void onDetachedFromWindow();
			bool dispatchKeyEvent(android.view.KeyEvent arg0);
			bool dispatchTouchEvent(android.view.MotionEvent arg0);
			bool dispatchTrackballEvent(android.view.MotionEvent arg0);
			bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
			global::android.view.View onCreatePanelView(int arg0);
			bool onCreatePanelMenu(int arg0, android.view.Menu arg1);
			bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2);
			bool onMenuOpened(int arg0, android.view.Menu arg1);
			bool onMenuItemSelected(int arg0, android.view.MenuItem arg1);
			void onPanelClosed(int arg0, android.view.Menu arg1);
			bool onSearchRequested();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Window.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", ref global::android.view.Window.Callback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.view.Window.Callback.onContentChanged()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onContentChanged", "()V", ref global::android.view.Window.Callback_._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.view.Window.Callback.onWindowFocusChanged(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.view.Window.Callback_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void android.view.Window.Callback.onAttachedToWindow()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onAttachedToWindow", "()V", ref global::android.view.Window.Callback_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void android.view.Window.Callback.onDetachedFromWindow()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onDetachedFromWindow", "()V", ref global::android.view.Window.Callback_._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.Window.Callback_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.Window.Callback_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.Window.Callback_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.view.Window.Callback_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.Callback_.staticClass, "onCreatePanelView", "(I)Landroid/view/View;", ref global::android.view.Window.Callback_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z", ref global::android.view.Window.Callback_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m11;
			bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", ref global::android.view.Window.Callback_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m12;
			bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z", ref global::android.view.Window.Callback_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m13;
			bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", ref global::android.view.Window.Callback_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m14;
			void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.Callback_.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V", ref global::android.view.Window.Callback_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m15;
			bool android.view.Window.Callback.onSearchRequested()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.Callback_.staticClass, "onSearchRequested", "()Z", ref global::android.view.Window.Callback_._m15);
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Window.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window$Callback"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.view.Window._m0) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;", ref global::android.view.Window._m1) as android.view.WindowManager_LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setType", "(I)V", ref global::android.view.Window._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setFlags(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setFlags", "(II)V", ref global::android.view.Window._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void addFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "addFlags", "(I)V", ref global::android.view.Window._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setCallback(android.view.Window.Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V", ref global::android.view.Window._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.view.WindowManager getWindowManager()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.WindowManager>(this, global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;", ref global::android.view.Window._m7) as android.view.WindowManager;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::android.view.View getCurrentFocus();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.view.Window._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void setContentView(int arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void setContentView(android.view.View arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract void takeKeyEvents(bool arg0);
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract void setTitle(java.lang.CharSequence arg0);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract void setTitleColor(int arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract void setVolumeControlStream(int arg0);
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract int getVolumeControlStream();
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::android.content.res.TypedArray getWindowStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;", ref global::android.view.Window._m24) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setContainer(android.view.Window arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V", ref global::android.view.Window._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.view.Window getContainer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;", ref global::android.view.Window._m26) as android.view.Window;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool hasChildren()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, "hasChildren", "()Z", ref global::android.view.Window._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V", ref global::android.view.Window._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::android.view.Window.Callback getCallback()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.Window.Callback>(this, global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;", ref global::android.view.Window._m29) as android.view.Window.Callback;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract bool isFloating();
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual void setLayout(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setLayout", "(II)V", ref global::android.view.Window._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setGravity", "(I)V", ref global::android.view.Window._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setFormat", "(I)V", ref global::android.view.Window._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setWindowAnimations(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setWindowAnimations", "(I)V", ref global::android.view.Window._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setSoftInputMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setSoftInputMode", "(I)V", ref global::android.view.Window._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void clearFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "clearFlags", "(I)V", ref global::android.view.Window._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V", ref global::android.view.Window._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		protected virtual int getForcedWindowFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, "getForcedWindowFlags", "()I", ref global::android.view.Window._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		protected virtual bool hasSoftInputMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, "hasSoftInputMode", "()Z", ref global::android.view.Window._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual bool requestFeature(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, "requestFeature", "(I)Z", ref global::android.view.Window._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void makeActive()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "makeActive", "()V", ref global::android.view.Window._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual bool isActive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, "isActive", "()Z", ref global::android.view.Window._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m44;
		public abstract void closePanel(int arg0);
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m46;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		private static global::MonoJavaBridge.MethodId _m47;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m48;
		public abstract void closeAllPanels();
		private static global::MonoJavaBridge.MethodId _m49;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void setBackgroundDrawableResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V", ref global::android.view.Window._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		private static global::MonoJavaBridge.MethodId _m52;
		public abstract void setFeatureInt(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m53;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		private static global::MonoJavaBridge.MethodId _m54;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		private static global::MonoJavaBridge.MethodId _m55;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		private static global::MonoJavaBridge.MethodId _m56;
		public abstract global::android.view.View getDecorView();
		private static global::MonoJavaBridge.MethodId _m57;
		public abstract global::android.view.View peekDecorView();
		private static global::MonoJavaBridge.MethodId _m58;
		public abstract global::android.os.Bundle saveHierarchyState();
		private static global::MonoJavaBridge.MethodId _m59;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		private static global::MonoJavaBridge.MethodId _m60;
		protected abstract void onActive();
		private static global::MonoJavaBridge.MethodId _m61;
		protected virtual int getFeatures()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, "getFeatures", "()I", ref global::android.view.Window._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		protected virtual int getLocalFeatures()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, "getLocalFeatures", "()I", ref global::android.view.Window._m62);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		protected virtual void setDefaultWindowFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V", ref global::android.view.Window._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		private static global::MonoJavaBridge.MethodId _m65;
		public abstract void setChildInt(int arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m66;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		private static global::MonoJavaBridge.MethodId _m67;
		public Window(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._m67.native == global::System.IntPtr.Zero)
				global::android.view.Window._m67 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Window.staticClass, global::android.view.Window._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int FEATURE_OPTIONS_PANEL
		{
			get
			{
				return 0;
			}
		}
		public static int FEATURE_NO_TITLE
		{
			get
			{
				return 1;
			}
		}
		public static int FEATURE_PROGRESS
		{
			get
			{
				return 2;
			}
		}
		public static int FEATURE_LEFT_ICON
		{
			get
			{
				return 3;
			}
		}
		public static int FEATURE_RIGHT_ICON
		{
			get
			{
				return 4;
			}
		}
		public static int FEATURE_INDETERMINATE_PROGRESS
		{
			get
			{
				return 5;
			}
		}
		public static int FEATURE_CONTEXT_MENU
		{
			get
			{
				return 6;
			}
		}
		public static int FEATURE_CUSTOM_TITLE
		{
			get
			{
				return 7;
			}
		}
		public static int PROGRESS_VISIBILITY_ON
		{
			get
			{
				return -1;
			}
		}
		public static int PROGRESS_VISIBILITY_OFF
		{
			get
			{
				return -2;
			}
		}
		public static int PROGRESS_INDETERMINATE_ON
		{
			get
			{
				return -3;
			}
		}
		public static int PROGRESS_INDETERMINATE_OFF
		{
			get
			{
				return -4;
			}
		}
		public static int PROGRESS_START
		{
			get
			{
				return 0;
			}
		}
		public static int PROGRESS_END
		{
			get
			{
				return 10000;
			}
		}
		public static int PROGRESS_SECONDARY_START
		{
			get
			{
				return 20000;
			}
		}
		public static int PROGRESS_SECONDARY_END
		{
			get
			{
				return 30000;
			}
		}
		public static int ID_ANDROID_CONTENT
		{
			get
			{
				return 16908290;
			}
		}
		static Window()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Window))]
	internal sealed partial class Window_ : android.view.Window
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Window_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.Window_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::android.view.View getCurrentFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window_.staticClass, "getCurrentFocus", "()Landroid/view/View;", ref global::android.view.Window_._m1) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void setContentView(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setContentView", "(I)V", ref global::android.view.Window_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.Window_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;)V", ref global::android.view.Window_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.Window_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "takeKeyEvents", "(Z)V", ref global::android.view.Window_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setFeatureDrawableResource", "(II)V", ref global::android.view.Window_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V", ref global::android.view.Window_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", ref global::android.view.Window_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setFeatureDrawableAlpha", "(II)V", ref global::android.view.Window_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.view.LayoutInflater getLayoutInflater()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window_.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;", ref global::android.view.Window_._m11) as android.view.LayoutInflater;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.view.Window_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void setTitleColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setTitleColor", "(I)V", ref global::android.view.Window_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setVolumeControlStream", "(I)V", ref global::android.view.Window_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override int getVolumeControlStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window_.staticClass, "getVolumeControlStream", "()I", ref global::android.view.Window_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool isFloating()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "isFloating", "()Z", ref global::android.view.Window_._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override void openPanel(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V", ref global::android.view.Window_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void closePanel(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "closePanel", "(I)V", ref global::android.view.Window_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void togglePanel(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V", ref global::android.view.Window_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z", ref global::android.view.Window_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override bool performPanelIdentifierAction(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "performPanelIdentifierAction", "(III)Z", ref global::android.view.Window_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override void closeAllPanels()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "closeAllPanels", "()V", ref global::android.view.Window_._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override bool performContextMenuIdentifierAction(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "performContextMenuIdentifierAction", "(II)Z", ref global::android.view.Window_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.Window_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override void setFeatureInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setFeatureInt", "(II)V", ref global::android.view.Window_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override bool superDispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.Window_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override bool superDispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.Window_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override bool superDispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.Window_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::android.view.View getDecorView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window_.staticClass, "getDecorView", "()Landroid/view/View;", ref global::android.view.Window_._m29) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::android.view.View peekDecorView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window_.staticClass, "peekDecorView", "()Landroid/view/View;", ref global::android.view.Window_._m30) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::android.os.Bundle saveHierarchyState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.view.Window_.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;", ref global::android.view.Window_._m31) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public override void restoreHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V", ref global::android.view.Window_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		protected override void onActive()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "onActive", "()V", ref global::android.view.Window_._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public override void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V", ref global::android.view.Window_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public override void setChildInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window_.staticClass, "setChildInt", "(II)V", ref global::android.view.Window_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public override bool isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.Window_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Window_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
		}
		internal static void InitJNI()
		{
		}
	}
}
