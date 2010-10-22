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
			internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged15163;
			 void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowAttributesChanged15163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowAttributesChanged15163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onContentChanged15164;
			 void android.view.Window.Callback.onContentChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onContentChanged15164);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onContentChanged15164);
			}
			internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged15165;
			 void android.view.Window.Callback.onWindowFocusChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowFocusChanged15165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowFocusChanged15165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAttachedToWindow15166;
			 void android.view.Window.Callback.onAttachedToWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onAttachedToWindow15166);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onAttachedToWindow15166);
			}
			internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow15167;
			 void android.view.Window.Callback.onDetachedFromWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onDetachedFromWindow15167);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onDetachedFromWindow15167);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent15168;
			 bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchKeyEvent15168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchKeyEvent15168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent15169;
			 bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTouchEvent15169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTouchEvent15169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent15170;
			 bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTrackballEvent15170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTrackballEvent15170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent15171;
			 bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelView15172;
			 global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelView15172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelView15172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu15173;
			 bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelMenu15173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelMenu15173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPreparePanel15174;
			 bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onPreparePanel15174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPreparePanel15174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuOpened15175;
			 bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuOpened15175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuOpened15175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuItemSelected15176;
			 bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuItemSelected15176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuItemSelected15176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPanelClosed15177;
			 void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onPanelClosed15177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPanelClosed15177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSearchRequested15178;
			 bool android.view.Window.Callback.onSearchRequested() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onSearchRequested15178);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onSearchRequested15178);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Window.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window$Callback"));
				global::android.view.Window.Callback_._onWindowAttributesChanged15163 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				global::android.view.Window.Callback_._onContentChanged15164 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onContentChanged", "()V");
				global::android.view.Window.Callback_._onWindowFocusChanged15165 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowFocusChanged", "(Z)V");
				global::android.view.Window.Callback_._onAttachedToWindow15166 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onAttachedToWindow", "()V");
				global::android.view.Window.Callback_._onDetachedFromWindow15167 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onDetachedFromWindow", "()V");
				global::android.view.Window.Callback_._dispatchKeyEvent15168 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				global::android.view.Window.Callback_._dispatchTouchEvent15169 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchTrackballEvent15170 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15171 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				global::android.view.Window.Callback_._onCreatePanelView15172 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
				global::android.view.Window.Callback_._onCreatePanelMenu15173 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onPreparePanel15174 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuOpened15175 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuItemSelected15176 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				global::android.view.Window.Callback_._onPanelClosed15177 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
				global::android.view.Window.Callback_._onSearchRequested15178 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onSearchRequested", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext15179;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContext15179)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContext15179)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes15180;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getAttributes15180)) as android.view.WindowManager_LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getAttributes15180)) as android.view.WindowManager_LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged15181;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		internal static global::MonoJavaBridge.MethodId _setType15182;
		public virtual void setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setType15182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setType15182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags15183;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFlags15183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFlags15183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFlags15184;
		public virtual void addFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._addFlags15184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._addFlags15184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback15185;
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setCallback15185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setCallback15185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager15186;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowManager15186)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager15186)) as android.view.WindowManager;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus15187;
		public abstract global::android.view.View getCurrentFocus();
		internal static global::MonoJavaBridge.MethodId _findViewById15188;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._findViewById15188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._findViewById15188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15189;
		public abstract void setContentView(int arg0);
		internal static global::MonoJavaBridge.MethodId _setContentView15190;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _setContentView15191;
		public abstract void setContentView(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _addContentView15192;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents15193;
		public abstract void takeKeyEvents(bool arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource15194;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri15195;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable15196;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha15197;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater15198;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		internal static global::MonoJavaBridge.MethodId _setTitle15199;
		public abstract void setTitle(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _setTitleColor15200;
		public abstract void setTitleColor(int arg0);
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream15201;
		public abstract void setVolumeControlStream(int arg0);
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream15202;
		public abstract int getVolumeControlStream();
		internal static global::MonoJavaBridge.MethodId _getWindowStyle15203;
		public virtual global::android.content.res.TypedArray getWindowStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowStyle15203)) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle15203)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _setContainer15204;
		public virtual void setContainer(android.view.Window arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setContainer15204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setContainer15204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContainer15205;
		public virtual global::android.view.Window getContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContainer15205)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContainer15205)) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildren15206;
		public virtual bool hasChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasChildren15206);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasChildren15206);
		}
		internal static global::MonoJavaBridge.MethodId _setWindowManager15207;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowManager15207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager15207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCallback15208;
		public virtual global::android.view.Window.Callback getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getCallback15208)) as android.view.Window.Callback;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getCallback15208)) as android.view.Window.Callback;
		}
		internal static global::MonoJavaBridge.MethodId _isFloating15209;
		public abstract bool isFloating();
		internal static global::MonoJavaBridge.MethodId _setLayout15210;
		public virtual void setLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setLayout15210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setLayout15210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity15211;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setGravity15211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setGravity15211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat15212;
		public virtual void setFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFormat15212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFormat15212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowAnimations15213;
		public virtual void setWindowAnimations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowAnimations15213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations15213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode15214;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setSoftInputMode15214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode15214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFlags15215;
		public virtual void clearFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._clearFlags15215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._clearFlags15215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes15216;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setAttributes15216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setAttributes15216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getForcedWindowFlags15217;
		protected virtual int getForcedWindowFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getForcedWindowFlags15217);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags15217);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftInputMode15218;
		protected virtual bool hasSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasSoftInputMode15218);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode15218);
		}
		internal static global::MonoJavaBridge.MethodId _requestFeature15219;
		public virtual bool requestFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._requestFeature15219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._requestFeature15219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _makeActive15220;
		public virtual void makeActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._makeActive15220);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._makeActive15220);
		}
		internal static global::MonoJavaBridge.MethodId _isActive15221;
		public virtual bool isActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._isActive15221);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._isActive15221);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel15222;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _closePanel15223;
		public abstract void closePanel(int arg0);
		internal static global::MonoJavaBridge.MethodId _togglePanel15224;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut15225;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction15226;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _closeAllPanels15227;
		public abstract void closeAllPanels();
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction15228;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawableResource15229;
		public virtual void setBackgroundDrawableResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setBackgroundDrawableResource15229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource15229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable15230;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureInt15231;
		public abstract void setFeatureInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent15232;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent15233;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent15234;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _getDecorView15235;
		public abstract global::android.view.View getDecorView();
		internal static global::MonoJavaBridge.MethodId _peekDecorView15236;
		public abstract global::android.view.View peekDecorView();
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState15237;
		public abstract global::android.os.Bundle saveHierarchyState();
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState15238;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		internal static global::MonoJavaBridge.MethodId _onActive15239;
		protected abstract void onActive();
		internal static global::MonoJavaBridge.MethodId _getFeatures15240;
		protected virtual int getFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getFeatures15240);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getFeatures15240);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalFeatures15241;
		protected virtual int getLocalFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getLocalFeatures15241);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures15241);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultWindowFormat15242;
		protected virtual void setDefaultWindowFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setDefaultWindowFormat15242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat15242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable15243;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setChildInt15244;
		public abstract void setChildInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isShortcutKey15245;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _Window15246;
		public Window(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window15246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.Window._getContext15179 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.Window._getAttributes15180 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;");
			global::android.view.Window._onConfigurationChanged15181 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window._setType15182 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setType", "(I)V");
			global::android.view.Window._setFlags15183 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFlags", "(II)V");
			global::android.view.Window._addFlags15184 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addFlags", "(I)V");
			global::android.view.Window._setCallback15185 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V");
			global::android.view.Window._getWindowManager15186 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.view.Window._getCurrentFocus15187 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window._findViewById15188 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.Window._setContentView15189 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(I)V");
			global::android.view.Window._setContentView15190 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._setContentView15191 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window._addContentView15192 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._takeKeyEvents15193 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window._setFeatureDrawableResource15194 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window._setFeatureDrawableUri15195 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window._setFeatureDrawable15196 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureDrawableAlpha15197 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window._getLayoutInflater15198 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window._setTitle15199 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window._setTitleColor15200 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window._setVolumeControlStream15201 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window._getVolumeControlStream15202 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window._getWindowStyle15203 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;");
			global::android.view.Window._setContainer15204 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V");
			global::android.view.Window._getContainer15205 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;");
			global::android.view.Window._hasChildren15206 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasChildren", "()Z");
			global::android.view.Window._setWindowManager15207 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.Window._getCallback15208 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;");
			global::android.view.Window._isFloating15209 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isFloating", "()Z");
			global::android.view.Window._setLayout15210 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setLayout", "(II)V");
			global::android.view.Window._setGravity15211 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setGravity", "(I)V");
			global::android.view.Window._setFormat15212 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFormat", "(I)V");
			global::android.view.Window._setWindowAnimations15213 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V");
			global::android.view.Window._setSoftInputMode15214 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V");
			global::android.view.Window._clearFlags15215 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "clearFlags", "(I)V");
			global::android.view.Window._setAttributes15216 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.view.Window._getForcedWindowFlags15217 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I");
			global::android.view.Window._hasSoftInputMode15218 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z");
			global::android.view.Window._requestFeature15219 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "requestFeature", "(I)Z");
			global::android.view.Window._makeActive15220 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "makeActive", "()V");
			global::android.view.Window._isActive15221 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isActive", "()Z");
			global::android.view.Window._openPanel15222 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._closePanel15223 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closePanel", "(I)V");
			global::android.view.Window._togglePanel15224 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._performPanelShortcut15225 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window._performPanelIdentifierAction15226 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window._closeAllPanels15227 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closeAllPanels", "()V");
			global::android.view.Window._performContextMenuIdentifierAction15228 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window._setBackgroundDrawableResource15229 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V");
			global::android.view.Window._setBackgroundDrawable15230 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureInt15231 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window._superDispatchKeyEvent15232 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window._superDispatchTouchEvent15233 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._superDispatchTrackballEvent15234 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._getDecorView15235 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window._peekDecorView15236 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window._saveHierarchyState15237 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window._restoreHierarchyState15238 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window._onActive15239 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onActive", "()V");
			global::android.view.Window._getFeatures15240 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getFeatures", "()I");
			global::android.view.Window._getLocalFeatures15241 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLocalFeatures", "()I");
			global::android.view.Window._setDefaultWindowFormat15242 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V");
			global::android.view.Window._setChildDrawable15243 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setChildInt15244 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildInt", "(II)V");
			global::android.view.Window._isShortcutKey15245 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Window._Window15246 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged15264;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onConfigurationChanged15264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onConfigurationChanged15264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus15265;
		public override global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getCurrentFocus15265)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getCurrentFocus15265)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15266;
		public override void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView15266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15267;
		public override void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15268;
		public override void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView15268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView15269;
		public override void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._addContentView15269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._addContentView15269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents15270;
		public override void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._takeKeyEvents15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._takeKeyEvents15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource15271;
		public override void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableResource15271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableResource15271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri15272;
		public override void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableUri15272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableUri15272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable15273;
		public override void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawable15273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawable15273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha15274;
		public override void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableAlpha15274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableAlpha15274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater15275;
		public override global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getLayoutInflater15275)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getLayoutInflater15275)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle15276;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitle15276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitle15276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor15277;
		public override void setTitleColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitleColor15277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitleColor15277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream15278;
		public override void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setVolumeControlStream15278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setVolumeControlStream15278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream15279;
		public override int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window_._getVolumeControlStream15279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getVolumeControlStream15279);
		}
		internal static global::MonoJavaBridge.MethodId _isFloating15280;
		public override bool isFloating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isFloating15280);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isFloating15280);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel15281;
		public override void openPanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._openPanel15281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._openPanel15281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closePanel15282;
		public override void closePanel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closePanel15282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closePanel15282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _togglePanel15283;
		public override void togglePanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._togglePanel15283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._togglePanel15283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut15284;
		public override bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelShortcut15284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelShortcut15284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction15285;
		public override bool performPanelIdentifierAction(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelIdentifierAction15285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelIdentifierAction15285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeAllPanels15286;
		public override void closeAllPanels() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closeAllPanels15286);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closeAllPanels15286);
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction15287;
		public override bool performContextMenuIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performContextMenuIdentifierAction15287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performContextMenuIdentifierAction15287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable15288;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setBackgroundDrawable15288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setBackgroundDrawable15288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureInt15289;
		public override void setFeatureInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureInt15289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureInt15289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent15290;
		public override bool superDispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchKeyEvent15290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchKeyEvent15290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent15291;
		public override bool superDispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTouchEvent15291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTouchEvent15291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent15292;
		public override bool superDispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTrackballEvent15292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTrackballEvent15292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDecorView15293;
		public override global::android.view.View getDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getDecorView15293)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getDecorView15293)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _peekDecorView15294;
		public override global::android.view.View peekDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._peekDecorView15294)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._peekDecorView15294)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState15295;
		public override global::android.os.Bundle saveHierarchyState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._saveHierarchyState15295)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._saveHierarchyState15295)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState15296;
		public override void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._restoreHierarchyState15296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._restoreHierarchyState15296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onActive15297;
		protected override void onActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onActive15297);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onActive15297);
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable15298;
		public override void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildDrawable15298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildDrawable15298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChildInt15299;
		public override void setChildInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildInt15299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildInt15299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey15300;
		public override bool isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isShortcutKey15300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isShortcutKey15300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
			global::android.view.Window_._onConfigurationChanged15264 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window_._getCurrentFocus15265 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window_._setContentView15266 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(I)V");
			global::android.view.Window_._setContentView15267 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._setContentView15268 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window_._addContentView15269 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._takeKeyEvents15270 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window_._setFeatureDrawableResource15271 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window_._setFeatureDrawableUri15272 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window_._setFeatureDrawable15273 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureDrawableAlpha15274 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window_._getLayoutInflater15275 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window_._setTitle15276 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window_._setTitleColor15277 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window_._setVolumeControlStream15278 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window_._getVolumeControlStream15279 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window_._isFloating15280 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isFloating", "()Z");
			global::android.view.Window_._openPanel15281 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._closePanel15282 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closePanel", "(I)V");
			global::android.view.Window_._togglePanel15283 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._performPanelShortcut15284 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window_._performPanelIdentifierAction15285 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window_._closeAllPanels15286 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closeAllPanels", "()V");
			global::android.view.Window_._performContextMenuIdentifierAction15287 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window_._setBackgroundDrawable15288 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureInt15289 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window_._superDispatchKeyEvent15290 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window_._superDispatchTouchEvent15291 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._superDispatchTrackballEvent15292 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._getDecorView15293 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window_._peekDecorView15294 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window_._saveHierarchyState15295 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window_._restoreHierarchyState15296 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window_._onActive15297 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onActive", "()V");
			global::android.view.Window_._setChildDrawable15298 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setChildInt15299 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildInt", "(II)V");
			global::android.view.Window_._isShortcutKey15300 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
		}
	}
}
