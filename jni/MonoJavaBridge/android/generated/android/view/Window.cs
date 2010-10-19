namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.Window_))]
	public abstract partial class Window : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Window()
		{
			InitJNI();
		}
		protected Window(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Window.Callback_))]
		public interface Callback  : global::MonoJavaBridge.IJavaObject 
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
		public sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Callback_()
			{
				InitJNI();
			}
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged10223;
			 void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowAttributesChanged10223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowAttributesChanged10223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onContentChanged10224;
			 void android.view.Window.Callback.onContentChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onContentChanged10224);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onContentChanged10224);
			}
			internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged10225;
			 void android.view.Window.Callback.onWindowFocusChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowFocusChanged10225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowFocusChanged10225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAttachedToWindow10226;
			 void android.view.Window.Callback.onAttachedToWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onAttachedToWindow10226);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onAttachedToWindow10226);
			}
			internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow10227;
			 void android.view.Window.Callback.onDetachedFromWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onDetachedFromWindow10227);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onDetachedFromWindow10227);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent10228;
			 bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchKeyEvent10228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchKeyEvent10228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent10229;
			 bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTouchEvent10229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTouchEvent10229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent10230;
			 bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTrackballEvent10230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTrackballEvent10230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent10231;
			 bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent10231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent10231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelView10232;
			 global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelView10232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelView10232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu10233;
			 bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelMenu10233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelMenu10233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPreparePanel10234;
			 bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onPreparePanel10234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPreparePanel10234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuOpened10235;
			 bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuOpened10235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuOpened10235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuItemSelected10236;
			 bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuItemSelected10236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuItemSelected10236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPanelClosed10237;
			 void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onPanelClosed10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPanelClosed10237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSearchRequested10238;
			 bool android.view.Window.Callback.onSearchRequested() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onSearchRequested10238);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onSearchRequested10238);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Window.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window$Callback"));
				global::android.view.Window.Callback_._onWindowAttributesChanged10223 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				global::android.view.Window.Callback_._onContentChanged10224 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onContentChanged", "()V");
				global::android.view.Window.Callback_._onWindowFocusChanged10225 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowFocusChanged", "(Z)V");
				global::android.view.Window.Callback_._onAttachedToWindow10226 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onAttachedToWindow", "()V");
				global::android.view.Window.Callback_._onDetachedFromWindow10227 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onDetachedFromWindow", "()V");
				global::android.view.Window.Callback_._dispatchKeyEvent10228 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				global::android.view.Window.Callback_._dispatchTouchEvent10229 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchTrackballEvent10230 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent10231 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				global::android.view.Window.Callback_._onCreatePanelView10232 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
				global::android.view.Window.Callback_._onCreatePanelMenu10233 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onPreparePanel10234 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuOpened10235 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuItemSelected10236 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				global::android.view.Window.Callback_._onPanelClosed10237 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
				global::android.view.Window.Callback_._onSearchRequested10238 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onSearchRequested", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext10239;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContext10239)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContext10239)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes10240;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getAttributes10240)) as android.view.WindowManager_LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getAttributes10240)) as android.view.WindowManager_LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged10241;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		internal static global::MonoJavaBridge.MethodId _setType10242;
		public virtual void setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setType10242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setType10242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags10243;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFlags10243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFlags10243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFlags10244;
		public virtual void addFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._addFlags10244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._addFlags10244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback10245;
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setCallback10245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setCallback10245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager10246;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowManager10246)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager10246)) as android.view.WindowManager;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus10247;
		public abstract global::android.view.View getCurrentFocus();
		internal static global::MonoJavaBridge.MethodId _findViewById10248;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._findViewById10248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._findViewById10248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView10249;
		public abstract void setContentView(int arg0);
		internal static global::MonoJavaBridge.MethodId _setContentView10250;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _setContentView10251;
		public abstract void setContentView(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _addContentView10252;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents10253;
		public abstract void takeKeyEvents(bool arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource10254;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri10255;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable10256;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha10257;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater10258;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		internal static global::MonoJavaBridge.MethodId _setTitle10259;
		public abstract void setTitle(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _setTitleColor10260;
		public abstract void setTitleColor(int arg0);
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream10261;
		public abstract void setVolumeControlStream(int arg0);
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream10262;
		public abstract int getVolumeControlStream();
		internal static global::MonoJavaBridge.MethodId _getWindowStyle10263;
		public virtual global::android.content.res.TypedArray getWindowStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowStyle10263)) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle10263)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _setContainer10264;
		public virtual void setContainer(android.view.Window arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setContainer10264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setContainer10264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContainer10265;
		public virtual global::android.view.Window getContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContainer10265)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContainer10265)) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildren10266;
		public virtual bool hasChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasChildren10266);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasChildren10266);
		}
		internal static global::MonoJavaBridge.MethodId _setWindowManager10267;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowManager10267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager10267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCallback10268;
		public virtual global::android.view.Window.Callback getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getCallback10268)) as android.view.Window.Callback;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getCallback10268)) as android.view.Window.Callback;
		}
		internal static global::MonoJavaBridge.MethodId _isFloating10269;
		public abstract bool isFloating();
		internal static global::MonoJavaBridge.MethodId _setLayout10270;
		public virtual void setLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setLayout10270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setLayout10270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity10271;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setGravity10271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setGravity10271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat10272;
		public virtual void setFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFormat10272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFormat10272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowAnimations10273;
		public virtual void setWindowAnimations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowAnimations10273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations10273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode10274;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setSoftInputMode10274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode10274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFlags10275;
		public virtual void clearFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._clearFlags10275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._clearFlags10275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes10276;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setAttributes10276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setAttributes10276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getForcedWindowFlags10277;
		protected virtual int getForcedWindowFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getForcedWindowFlags10277);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags10277);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftInputMode10278;
		protected virtual bool hasSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasSoftInputMode10278);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode10278);
		}
		internal static global::MonoJavaBridge.MethodId _requestFeature10279;
		public virtual bool requestFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._requestFeature10279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._requestFeature10279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _makeActive10280;
		public virtual void makeActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._makeActive10280);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._makeActive10280);
		}
		internal static global::MonoJavaBridge.MethodId _isActive10281;
		public virtual bool isActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._isActive10281);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._isActive10281);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel10282;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _closePanel10283;
		public abstract void closePanel(int arg0);
		internal static global::MonoJavaBridge.MethodId _togglePanel10284;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut10285;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction10286;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _closeAllPanels10287;
		public abstract void closeAllPanels();
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction10288;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawableResource10289;
		public virtual void setBackgroundDrawableResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setBackgroundDrawableResource10289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource10289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable10290;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureInt10291;
		public abstract void setFeatureInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent10292;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent10293;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent10294;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _getDecorView10295;
		public abstract global::android.view.View getDecorView();
		internal static global::MonoJavaBridge.MethodId _peekDecorView10296;
		public abstract global::android.view.View peekDecorView();
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState10297;
		public abstract global::android.os.Bundle saveHierarchyState();
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState10298;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		internal static global::MonoJavaBridge.MethodId _onActive10299;
		protected abstract void onActive();
		internal static global::MonoJavaBridge.MethodId _getFeatures10300;
		protected virtual int getFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getFeatures10300);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getFeatures10300);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalFeatures10301;
		protected virtual int getLocalFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getLocalFeatures10301);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures10301);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultWindowFormat10302;
		protected virtual void setDefaultWindowFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setDefaultWindowFormat10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat10302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable10303;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setChildInt10304;
		public abstract void setChildInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isShortcutKey10305;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _Window10306;
		public Window(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window10306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
			global::android.view.Window._getContext10239 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.Window._getAttributes10240 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;");
			global::android.view.Window._onConfigurationChanged10241 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window._setType10242 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setType", "(I)V");
			global::android.view.Window._setFlags10243 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFlags", "(II)V");
			global::android.view.Window._addFlags10244 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addFlags", "(I)V");
			global::android.view.Window._setCallback10245 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V");
			global::android.view.Window._getWindowManager10246 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.view.Window._getCurrentFocus10247 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window._findViewById10248 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.Window._setContentView10249 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(I)V");
			global::android.view.Window._setContentView10250 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._setContentView10251 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window._addContentView10252 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._takeKeyEvents10253 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window._setFeatureDrawableResource10254 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window._setFeatureDrawableUri10255 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window._setFeatureDrawable10256 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureDrawableAlpha10257 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window._getLayoutInflater10258 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window._setTitle10259 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window._setTitleColor10260 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window._setVolumeControlStream10261 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window._getVolumeControlStream10262 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window._getWindowStyle10263 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;");
			global::android.view.Window._setContainer10264 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V");
			global::android.view.Window._getContainer10265 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;");
			global::android.view.Window._hasChildren10266 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasChildren", "()Z");
			global::android.view.Window._setWindowManager10267 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.Window._getCallback10268 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;");
			global::android.view.Window._isFloating10269 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isFloating", "()Z");
			global::android.view.Window._setLayout10270 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setLayout", "(II)V");
			global::android.view.Window._setGravity10271 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setGravity", "(I)V");
			global::android.view.Window._setFormat10272 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFormat", "(I)V");
			global::android.view.Window._setWindowAnimations10273 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V");
			global::android.view.Window._setSoftInputMode10274 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V");
			global::android.view.Window._clearFlags10275 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "clearFlags", "(I)V");
			global::android.view.Window._setAttributes10276 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.view.Window._getForcedWindowFlags10277 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I");
			global::android.view.Window._hasSoftInputMode10278 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z");
			global::android.view.Window._requestFeature10279 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "requestFeature", "(I)Z");
			global::android.view.Window._makeActive10280 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "makeActive", "()V");
			global::android.view.Window._isActive10281 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isActive", "()Z");
			global::android.view.Window._openPanel10282 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._closePanel10283 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closePanel", "(I)V");
			global::android.view.Window._togglePanel10284 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._performPanelShortcut10285 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window._performPanelIdentifierAction10286 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window._closeAllPanels10287 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closeAllPanels", "()V");
			global::android.view.Window._performContextMenuIdentifierAction10288 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window._setBackgroundDrawableResource10289 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V");
			global::android.view.Window._setBackgroundDrawable10290 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureInt10291 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window._superDispatchKeyEvent10292 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window._superDispatchTouchEvent10293 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._superDispatchTrackballEvent10294 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._getDecorView10295 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window._peekDecorView10296 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window._saveHierarchyState10297 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window._restoreHierarchyState10298 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window._onActive10299 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onActive", "()V");
			global::android.view.Window._getFeatures10300 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getFeatures", "()I");
			global::android.view.Window._getLocalFeatures10301 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLocalFeatures", "()I");
			global::android.view.Window._setDefaultWindowFormat10302 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V");
			global::android.view.Window._setChildDrawable10303 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setChildInt10304 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildInt", "(II)V");
			global::android.view.Window._isShortcutKey10305 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Window._Window10306 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Window))]
	public sealed partial class Window_ : android.view.Window
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Window_()
		{
			InitJNI();
		}
		internal Window_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged10307;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onConfigurationChanged10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onConfigurationChanged10307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus10308;
		public override global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getCurrentFocus10308)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getCurrentFocus10308)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView10309;
		public override void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView10309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView10309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView10310;
		public override void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView10310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView10310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView10311;
		public override void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView10311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView10311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView10312;
		public override void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._addContentView10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._addContentView10312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents10313;
		public override void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._takeKeyEvents10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._takeKeyEvents10313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource10314;
		public override void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableResource10314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableResource10314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri10315;
		public override void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableUri10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableUri10315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable10316;
		public override void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawable10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawable10316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha10317;
		public override void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableAlpha10317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableAlpha10317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater10318;
		public override global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getLayoutInflater10318)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getLayoutInflater10318)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10319;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitle10319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitle10319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor10320;
		public override void setTitleColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitleColor10320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitleColor10320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream10321;
		public override void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setVolumeControlStream10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setVolumeControlStream10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream10322;
		public override int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window_._getVolumeControlStream10322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getVolumeControlStream10322);
		}
		internal static global::MonoJavaBridge.MethodId _isFloating10323;
		public override bool isFloating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isFloating10323);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isFloating10323);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel10324;
		public override void openPanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._openPanel10324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._openPanel10324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closePanel10325;
		public override void closePanel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closePanel10325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closePanel10325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _togglePanel10326;
		public override void togglePanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._togglePanel10326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._togglePanel10326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut10327;
		public override bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelShortcut10327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelShortcut10327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction10328;
		public override bool performPanelIdentifierAction(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelIdentifierAction10328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelIdentifierAction10328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeAllPanels10329;
		public override void closeAllPanels() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closeAllPanels10329);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closeAllPanels10329);
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction10330;
		public override bool performContextMenuIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performContextMenuIdentifierAction10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performContextMenuIdentifierAction10330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable10331;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setBackgroundDrawable10331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setBackgroundDrawable10331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureInt10332;
		public override void setFeatureInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureInt10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureInt10332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent10333;
		public override bool superDispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchKeyEvent10333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchKeyEvent10333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent10334;
		public override bool superDispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTouchEvent10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTouchEvent10334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent10335;
		public override bool superDispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTrackballEvent10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTrackballEvent10335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDecorView10336;
		public override global::android.view.View getDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getDecorView10336)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getDecorView10336)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _peekDecorView10337;
		public override global::android.view.View peekDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._peekDecorView10337)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._peekDecorView10337)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState10338;
		public override global::android.os.Bundle saveHierarchyState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._saveHierarchyState10338)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._saveHierarchyState10338)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState10339;
		public override void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._restoreHierarchyState10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._restoreHierarchyState10339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onActive10340;
		protected override void onActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onActive10340);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onActive10340);
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable10341;
		public override void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildDrawable10341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildDrawable10341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChildInt10342;
		public override void setChildInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildInt10342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildInt10342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey10343;
		public override bool isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isShortcutKey10343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isShortcutKey10343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
			global::android.view.Window_._onConfigurationChanged10307 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window_._getCurrentFocus10308 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window_._setContentView10309 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(I)V");
			global::android.view.Window_._setContentView10310 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._setContentView10311 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window_._addContentView10312 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._takeKeyEvents10313 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window_._setFeatureDrawableResource10314 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window_._setFeatureDrawableUri10315 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window_._setFeatureDrawable10316 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureDrawableAlpha10317 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window_._getLayoutInflater10318 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window_._setTitle10319 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window_._setTitleColor10320 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window_._setVolumeControlStream10321 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window_._getVolumeControlStream10322 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window_._isFloating10323 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isFloating", "()Z");
			global::android.view.Window_._openPanel10324 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._closePanel10325 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closePanel", "(I)V");
			global::android.view.Window_._togglePanel10326 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._performPanelShortcut10327 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window_._performPanelIdentifierAction10328 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window_._closeAllPanels10329 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closeAllPanels", "()V");
			global::android.view.Window_._performContextMenuIdentifierAction10330 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window_._setBackgroundDrawable10331 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureInt10332 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window_._superDispatchKeyEvent10333 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window_._superDispatchTouchEvent10334 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._superDispatchTrackballEvent10335 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._getDecorView10336 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window_._peekDecorView10337 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window_._saveHierarchyState10338 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window_._restoreHierarchyState10339 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window_._onActive10340 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onActive", "()V");
			global::android.view.Window_._setChildDrawable10341 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setChildInt10342 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildInt", "(II)V");
			global::android.view.Window_._isShortcutKey10343 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
		}
	}
}
