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
			internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged9677;
			 void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowAttributesChanged9677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowAttributesChanged9677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onContentChanged9678;
			 void android.view.Window.Callback.onContentChanged() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onContentChanged9678);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onContentChanged9678);
			}
			internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged9679;
			 void android.view.Window.Callback.onWindowFocusChanged(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowFocusChanged9679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onWindowFocusChanged9679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAttachedToWindow9680;
			 void android.view.Window.Callback.onAttachedToWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onAttachedToWindow9680);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onAttachedToWindow9680);
			}
			internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow9681;
			 void android.view.Window.Callback.onDetachedFromWindow() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onDetachedFromWindow9681);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onDetachedFromWindow9681);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent9682;
			 bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchKeyEvent9682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchKeyEvent9682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent9683;
			 bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTouchEvent9683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTouchEvent9683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent9684;
			 bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTrackballEvent9684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchTrackballEvent9684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent9685;
			 bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent9685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelView9686;
			 global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelView9686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelView9686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu9687;
			 bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelMenu9687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onCreatePanelMenu9687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPreparePanel9688;
			 bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onPreparePanel9688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPreparePanel9688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuOpened9689;
			 bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuOpened9689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuOpened9689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuItemSelected9690;
			 bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuItemSelected9690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onMenuItemSelected9690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPanelClosed9691;
			 void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onPanelClosed9691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onPanelClosed9691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSearchRequested9692;
			 bool android.view.Window.Callback.onSearchRequested() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onSearchRequested9692);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_.staticClass, global::android.view.Window.Callback_._onSearchRequested9692);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Window.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window$Callback"));
				global::android.view.Window.Callback_._onWindowAttributesChanged9677 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				global::android.view.Window.Callback_._onContentChanged9678 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onContentChanged", "()V");
				global::android.view.Window.Callback_._onWindowFocusChanged9679 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowFocusChanged", "(Z)V");
				global::android.view.Window.Callback_._onAttachedToWindow9680 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onAttachedToWindow", "()V");
				global::android.view.Window.Callback_._onDetachedFromWindow9681 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onDetachedFromWindow", "()V");
				global::android.view.Window.Callback_._dispatchKeyEvent9682 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				global::android.view.Window.Callback_._dispatchTouchEvent9683 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchTrackballEvent9684 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent9685 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				global::android.view.Window.Callback_._onCreatePanelView9686 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
				global::android.view.Window.Callback_._onCreatePanelMenu9687 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onPreparePanel9688 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuOpened9689 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.Callback_._onMenuItemSelected9690 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				global::android.view.Window.Callback_._onPanelClosed9691 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
				global::android.view.Window.Callback_._onSearchRequested9692 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onSearchRequested", "()Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext9693;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContext9693)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContext9693)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes9694;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getAttributes9694)) as android.view.WindowManager_LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getAttributes9694)) as android.view.WindowManager_LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged9695;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		internal static global::MonoJavaBridge.MethodId _setType9696;
		public virtual void setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setType9696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setType9696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags9697;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFlags9697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFlags9697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFlags9698;
		public virtual void addFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._addFlags9698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._addFlags9698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback9699;
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setCallback9699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setCallback9699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager9700;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowManager9700)) as android.view.WindowManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.WindowManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager9700)) as android.view.WindowManager;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus9701;
		public abstract global::android.view.View getCurrentFocus();
		internal static global::MonoJavaBridge.MethodId _findViewById9702;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._findViewById9702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._findViewById9702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView9703;
		public abstract void setContentView(int arg0);
		internal static global::MonoJavaBridge.MethodId _setContentView9704;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _setContentView9705;
		public abstract void setContentView(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _addContentView9706;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents9707;
		public abstract void takeKeyEvents(bool arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource9708;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri9709;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable9710;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha9711;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater9712;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		internal static global::MonoJavaBridge.MethodId _setTitle9713;
		public abstract void setTitle(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _setTitleColor9714;
		public abstract void setTitleColor(int arg0);
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream9715;
		public abstract void setVolumeControlStream(int arg0);
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream9716;
		public abstract int getVolumeControlStream();
		internal static global::MonoJavaBridge.MethodId _getWindowStyle9717;
		public virtual global::android.content.res.TypedArray getWindowStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getWindowStyle9717)) as android.content.res.TypedArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle9717)) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _setContainer9718;
		public virtual void setContainer(android.view.Window arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setContainer9718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setContainer9718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContainer9719;
		public virtual global::android.view.Window getContainer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getContainer9719)) as android.view.Window;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getContainer9719)) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildren9720;
		public virtual bool hasChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasChildren9720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasChildren9720);
		}
		internal static global::MonoJavaBridge.MethodId _setWindowManager9721;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowManager9721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager9721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCallback9722;
		public virtual global::android.view.Window.Callback getCallback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window._getCallback9722)) as android.view.Window.Callback;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.Window.Callback>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getCallback9722)) as android.view.Window.Callback;
		}
		internal static global::MonoJavaBridge.MethodId _isFloating9723;
		public abstract bool isFloating();
		internal static global::MonoJavaBridge.MethodId _setLayout9724;
		public virtual void setLayout(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setLayout9724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setLayout9724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity9725;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setGravity9725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setGravity9725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat9726;
		public virtual void setFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setFormat9726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setFormat9726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowAnimations9727;
		public virtual void setWindowAnimations(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setWindowAnimations9727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations9727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode9728;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setSoftInputMode9728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode9728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFlags9729;
		public virtual void clearFlags(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._clearFlags9729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._clearFlags9729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes9730;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setAttributes9730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setAttributes9730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getForcedWindowFlags9731;
		protected virtual int getForcedWindowFlags() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getForcedWindowFlags9731);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags9731);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftInputMode9732;
		protected virtual bool hasSoftInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._hasSoftInputMode9732);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode9732);
		}
		internal static global::MonoJavaBridge.MethodId _requestFeature9733;
		public virtual bool requestFeature(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._requestFeature9733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._requestFeature9733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _makeActive9734;
		public virtual void makeActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._makeActive9734);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._makeActive9734);
		}
		internal static global::MonoJavaBridge.MethodId _isActive9735;
		public virtual bool isActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window._isActive9735);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._isActive9735);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel9736;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _closePanel9737;
		public abstract void closePanel(int arg0);
		internal static global::MonoJavaBridge.MethodId _togglePanel9738;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut9739;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction9740;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _closeAllPanels9741;
		public abstract void closeAllPanels();
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction9742;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawableResource9743;
		public virtual void setBackgroundDrawableResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setBackgroundDrawableResource9743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource9743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable9744;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureInt9745;
		public abstract void setFeatureInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent9746;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent9747;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent9748;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _getDecorView9749;
		public abstract global::android.view.View getDecorView();
		internal static global::MonoJavaBridge.MethodId _peekDecorView9750;
		public abstract global::android.view.View peekDecorView();
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState9751;
		public abstract global::android.os.Bundle saveHierarchyState();
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState9752;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		internal static global::MonoJavaBridge.MethodId _onActive9753;
		protected abstract void onActive();
		internal static global::MonoJavaBridge.MethodId _getFeatures9754;
		protected virtual int getFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getFeatures9754);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getFeatures9754);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalFeatures9755;
		protected virtual int getLocalFeatures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window._getLocalFeatures9755);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures9755);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultWindowFormat9756;
		protected virtual void setDefaultWindowFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window._setDefaultWindowFormat9756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat9756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable9757;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setChildInt9758;
		public abstract void setChildInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isShortcutKey9759;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _Window9760;
		public Window(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window9760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.view.Window._getContext9693 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.Window._getAttributes9694 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;");
			global::android.view.Window._onConfigurationChanged9695 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window._setType9696 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setType", "(I)V");
			global::android.view.Window._setFlags9697 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFlags", "(II)V");
			global::android.view.Window._addFlags9698 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addFlags", "(I)V");
			global::android.view.Window._setCallback9699 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V");
			global::android.view.Window._getWindowManager9700 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.view.Window._getCurrentFocus9701 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window._findViewById9702 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.Window._setContentView9703 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(I)V");
			global::android.view.Window._setContentView9704 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._setContentView9705 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window._addContentView9706 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._takeKeyEvents9707 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window._setFeatureDrawableResource9708 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window._setFeatureDrawableUri9709 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window._setFeatureDrawable9710 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureDrawableAlpha9711 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window._getLayoutInflater9712 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window._setTitle9713 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window._setTitleColor9714 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window._setVolumeControlStream9715 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window._getVolumeControlStream9716 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window._getWindowStyle9717 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;");
			global::android.view.Window._setContainer9718 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V");
			global::android.view.Window._getContainer9719 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;");
			global::android.view.Window._hasChildren9720 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasChildren", "()Z");
			global::android.view.Window._setWindowManager9721 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.Window._getCallback9722 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;");
			global::android.view.Window._isFloating9723 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isFloating", "()Z");
			global::android.view.Window._setLayout9724 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setLayout", "(II)V");
			global::android.view.Window._setGravity9725 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setGravity", "(I)V");
			global::android.view.Window._setFormat9726 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFormat", "(I)V");
			global::android.view.Window._setWindowAnimations9727 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V");
			global::android.view.Window._setSoftInputMode9728 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V");
			global::android.view.Window._clearFlags9729 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "clearFlags", "(I)V");
			global::android.view.Window._setAttributes9730 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.view.Window._getForcedWindowFlags9731 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I");
			global::android.view.Window._hasSoftInputMode9732 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z");
			global::android.view.Window._requestFeature9733 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "requestFeature", "(I)Z");
			global::android.view.Window._makeActive9734 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "makeActive", "()V");
			global::android.view.Window._isActive9735 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isActive", "()Z");
			global::android.view.Window._openPanel9736 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._closePanel9737 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closePanel", "(I)V");
			global::android.view.Window._togglePanel9738 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._performPanelShortcut9739 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window._performPanelIdentifierAction9740 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window._closeAllPanels9741 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "closeAllPanels", "()V");
			global::android.view.Window._performContextMenuIdentifierAction9742 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window._setBackgroundDrawableResource9743 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V");
			global::android.view.Window._setBackgroundDrawable9744 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureInt9745 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window._superDispatchKeyEvent9746 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window._superDispatchTouchEvent9747 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._superDispatchTrackballEvent9748 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._getDecorView9749 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window._peekDecorView9750 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window._saveHierarchyState9751 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window._restoreHierarchyState9752 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window._onActive9753 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "onActive", "()V");
			global::android.view.Window._getFeatures9754 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getFeatures", "()I");
			global::android.view.Window._getLocalFeatures9755 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLocalFeatures", "()I");
			global::android.view.Window._setDefaultWindowFormat9756 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V");
			global::android.view.Window._setChildDrawable9757 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setChildInt9758 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setChildInt", "(II)V");
			global::android.view.Window._isShortcutKey9759 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Window._Window9760 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
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
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged9761;
		public override void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onConfigurationChanged9761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onConfigurationChanged9761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus9762;
		public override global::android.view.View getCurrentFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getCurrentFocus9762)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getCurrentFocus9762)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView9763;
		public override void setContentView(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView9763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView9763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView9764;
		public override void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView9764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView9764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView9765;
		public override void setContentView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView9765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setContentView9765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView9766;
		public override void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._addContentView9766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._addContentView9766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents9767;
		public override void takeKeyEvents(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._takeKeyEvents9767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._takeKeyEvents9767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource9768;
		public override void setFeatureDrawableResource(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableResource9768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableResource9768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri9769;
		public override void setFeatureDrawableUri(int arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableUri9769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableUri9769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable9770;
		public override void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawable9770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawable9770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha9771;
		public override void setFeatureDrawableAlpha(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableAlpha9771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureDrawableAlpha9771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater9772;
		public override global::android.view.LayoutInflater getLayoutInflater() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getLayoutInflater9772)) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getLayoutInflater9772)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle9773;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitle9773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitle9773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor9774;
		public override void setTitleColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitleColor9774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setTitleColor9774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream9775;
		public override void setVolumeControlStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setVolumeControlStream9775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setVolumeControlStream9775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream9776;
		public override int getVolumeControlStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window_._getVolumeControlStream9776);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getVolumeControlStream9776);
		}
		internal static global::MonoJavaBridge.MethodId _isFloating9777;
		public override bool isFloating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isFloating9777);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isFloating9777);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel9778;
		public override void openPanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._openPanel9778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._openPanel9778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closePanel9779;
		public override void closePanel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closePanel9779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closePanel9779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _togglePanel9780;
		public override void togglePanel(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._togglePanel9780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._togglePanel9780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut9781;
		public override bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelShortcut9781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelShortcut9781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction9782;
		public override bool performPanelIdentifierAction(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelIdentifierAction9782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performPanelIdentifierAction9782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeAllPanels9783;
		public override void closeAllPanels() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closeAllPanels9783);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._closeAllPanels9783);
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction9784;
		public override bool performContextMenuIdentifierAction(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performContextMenuIdentifierAction9784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._performContextMenuIdentifierAction9784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable9785;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setBackgroundDrawable9785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setBackgroundDrawable9785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureInt9786;
		public override void setFeatureInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureInt9786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setFeatureInt9786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent9787;
		public override bool superDispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchKeyEvent9787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchKeyEvent9787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent9788;
		public override bool superDispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTouchEvent9788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTouchEvent9788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent9789;
		public override bool superDispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTrackballEvent9789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._superDispatchTrackballEvent9789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDecorView9790;
		public override global::android.view.View getDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getDecorView9790)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._getDecorView9790)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _peekDecorView9791;
		public override global::android.view.View peekDecorView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._peekDecorView9791)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._peekDecorView9791)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState9792;
		public override global::android.os.Bundle saveHierarchyState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._saveHierarchyState9792)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._saveHierarchyState9792)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState9793;
		public override void restoreHierarchyState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._restoreHierarchyState9793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._restoreHierarchyState9793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onActive9794;
		protected override void onActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onActive9794);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._onActive9794);
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable9795;
		public override void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildDrawable9795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildDrawable9795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChildInt9796;
		public override void setChildInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildInt9796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._setChildInt9796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey9797;
		public override bool isShortcutKey(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isShortcutKey9797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Window_.staticClass, global::android.view.Window_._isShortcutKey9797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
			global::android.view.Window_._onConfigurationChanged9761 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window_._getCurrentFocus9762 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window_._setContentView9763 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(I)V");
			global::android.view.Window_._setContentView9764 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._setContentView9765 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window_._addContentView9766 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window_._takeKeyEvents9767 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window_._setFeatureDrawableResource9768 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window_._setFeatureDrawableUri9769 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window_._setFeatureDrawable9770 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureDrawableAlpha9771 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window_._getLayoutInflater9772 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window_._setTitle9773 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window_._setTitleColor9774 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window_._setVolumeControlStream9775 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window_._getVolumeControlStream9776 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window_._isFloating9777 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isFloating", "()Z");
			global::android.view.Window_._openPanel9778 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._closePanel9779 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closePanel", "(I)V");
			global::android.view.Window_._togglePanel9780 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window_._performPanelShortcut9781 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window_._performPanelIdentifierAction9782 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window_._closeAllPanels9783 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closeAllPanels", "()V");
			global::android.view.Window_._performContextMenuIdentifierAction9784 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window_._setBackgroundDrawable9785 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setFeatureInt9786 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window_._superDispatchKeyEvent9787 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window_._superDispatchTouchEvent9788 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._superDispatchTrackballEvent9789 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window_._getDecorView9790 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window_._peekDecorView9791 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window_._saveHierarchyState9792 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window_._restoreHierarchyState9793 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window_._onActive9794 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onActive", "()V");
			global::android.view.Window_._setChildDrawable9795 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window_._setChildInt9796 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildInt", "(II)V");
			global::android.view.Window_._isShortcutKey9797 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
		}
	}
}
