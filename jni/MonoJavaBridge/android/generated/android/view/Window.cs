namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Window : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Window()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Window), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Window(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface Callback 
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

		public partial class Callback_
		{
			public static global::java.lang.Class _class
			{
				get { return __Callback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __Callback : java.lang.Object, Callback
		{
			internal static global::java.lang.Class staticClass;
			static __Callback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Window.__Callback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.Window.__Callback(@__env);
				}
			}
			internal __Callback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged9367;
			 void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onWindowAttributesChanged9367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onWindowAttributesChanged9367, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onContentChanged9368;
			 void android.view.Window.Callback.onContentChanged() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onContentChanged9368);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onContentChanged9368);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged9369;
			 void android.view.Window.Callback.onWindowFocusChanged(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onWindowFocusChanged9369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onWindowFocusChanged9369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9370;
			 void android.view.Window.Callback.onAttachedToWindow() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onAttachedToWindow9370);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onAttachedToWindow9370);
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9371;
			 void android.view.Window.Callback.onDetachedFromWindow() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onDetachedFromWindow9371);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onDetachedFromWindow9371);
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9372;
			 bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchKeyEvent9372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchKeyEvent9372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent9373;
			 bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchTouchEvent9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchTouchEvent9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent9374;
			 bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchTrackballEvent9374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchTrackballEvent9374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9375;
			 bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent9375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent9375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView9376;
			 global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window.__Callback._onCreatePanelView9376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onCreatePanelView9376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu9377;
			 bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onCreatePanelMenu9377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onCreatePanelMenu9377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel9378;
			 bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onPreparePanel9378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onPreparePanel9378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened9379;
			 bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onMenuOpened9379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onMenuOpened9379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected9380;
			 bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onMenuItemSelected9380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onMenuItemSelected9380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed9381;
			 void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onPanelClosed9381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onPanelClosed9381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested9382;
			 bool android.view.Window.Callback.onSearchRequested() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onSearchRequested9382);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onSearchRequested9382);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.Window.__Callback.staticClass = @__class;
				global::android.view.Window.__Callback._onWindowAttributesChanged9367 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				global::android.view.Window.__Callback._onContentChanged9368 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onContentChanged", "()V");
				global::android.view.Window.__Callback._onWindowFocusChanged9369 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onWindowFocusChanged", "(Z)V");
				global::android.view.Window.__Callback._onAttachedToWindow9370 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onAttachedToWindow", "()V");
				global::android.view.Window.__Callback._onDetachedFromWindow9371 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onDetachedFromWindow", "()V");
				global::android.view.Window.__Callback._dispatchKeyEvent9372 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				global::android.view.Window.__Callback._dispatchTouchEvent9373 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.__Callback._dispatchTrackballEvent9374 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent9375 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				global::android.view.Window.__Callback._onCreatePanelView9376 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onCreatePanelView", "(I)Landroid/view/View;");
				global::android.view.Window.__Callback._onCreatePanelMenu9377 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.__Callback._onPreparePanel9378 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				global::android.view.Window.__Callback._onMenuOpened9379 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onMenuOpened", "(ILandroid/view/Menu;)Z");
				global::android.view.Window.__Callback._onMenuItemSelected9380 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				global::android.view.Window.__Callback._onPanelClosed9381 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onPanelClosed", "(ILandroid/view/Menu;)V");
				global::android.view.Window.__Callback._onSearchRequested9382 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onSearchRequested", "()Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext9383;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getContext9383));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getContext9383));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAttributes9384;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getAttributes9384));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getAttributes9384));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged9385;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setType9386;
		public virtual void setType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setType9386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setType9386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFlags9387;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setFlags9387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFlags9387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFlags9388;
		public virtual void addFlags(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._addFlags9388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._addFlags9388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCallback9389;
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setCallback9389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setCallback9389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager9390;
		public virtual global::android.view.WindowManager getWindowManager() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getWindowManager9390));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager9390));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus9391;
		public abstract global::android.view.View getCurrentFocus();
		internal static global::net.sf.jni4net.jni.MethodId _findViewById9392;
		public virtual global::android.view.View findViewById(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._findViewById9392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._findViewById9392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContentView9393;
		public abstract void setContentView(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setContentView9394;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setContentView9395;
		public abstract void setContentView(android.view.View arg0);
		internal static global::net.sf.jni4net.jni.MethodId _addContentView9396;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents9397;
		public abstract void takeKeyEvents(bool arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource9398;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri9399;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable9400;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha9401;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater9402;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		internal static global::net.sf.jni4net.jni.MethodId _setTitle9403;
		public abstract void setTitle(java.lang.CharSequence arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor9404;
		public abstract void setTitleColor(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream9405;
		public abstract void setVolumeControlStream(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream9406;
		public abstract int getVolumeControlStream();
		internal static global::net.sf.jni4net.jni.MethodId _getWindowStyle9407;
		public virtual global::android.content.res.TypedArray getWindowStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getWindowStyle9407));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle9407));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setContainer9408;
		public virtual void setContainer(android.view.Window arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setContainer9408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setContainer9408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContainer9409;
		public virtual global::android.view.Window getContainer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getContainer9409));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getContainer9409));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasChildren9410;
		public virtual bool hasChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.Window._hasChildren9410);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasChildren9410);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWindowManager9411;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setWindowManager9411, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager9411, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallback9412;
		public virtual global::android.view.Window.Callback getCallback() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getCallback9412));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getCallback9412));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFloating9413;
		public abstract bool isFloating();
		internal static global::net.sf.jni4net.jni.MethodId _setLayout9414;
		public virtual void setLayout(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setLayout9414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setLayout9414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity9415;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setGravity9415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setGravity9415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFormat9416;
		public virtual void setFormat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setFormat9416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFormat9416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWindowAnimations9417;
		public virtual void setWindowAnimations(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setWindowAnimations9417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations9417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode9418;
		public virtual void setSoftInputMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setSoftInputMode9418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode9418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFlags9419;
		public virtual void clearFlags(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._clearFlags9419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._clearFlags9419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAttributes9420;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setAttributes9420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setAttributes9420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getForcedWindowFlags9421;
		protected virtual int getForcedWindowFlags() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Window._getForcedWindowFlags9421);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags9421);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftInputMode9422;
		protected virtual bool hasSoftInputMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.Window._hasSoftInputMode9422);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode9422);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFeature9423;
		public virtual bool requestFeature(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.Window._requestFeature9423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._requestFeature9423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _makeActive9424;
		public virtual void makeActive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._makeActive9424);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._makeActive9424);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isActive9425;
		public virtual bool isActive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.Window._isActive9425);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._isActive9425);
		}
		internal static global::net.sf.jni4net.jni.MethodId _openPanel9426;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _closePanel9427;
		public abstract void closePanel(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _togglePanel9428;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _performPanelShortcut9429;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		internal static global::net.sf.jni4net.jni.MethodId _performPanelIdentifierAction9430;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _closeAllPanels9431;
		public abstract void closeAllPanels();
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuIdentifierAction9432;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawableResource9433;
		public virtual void setBackgroundDrawableResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setBackgroundDrawableResource9433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource9433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable9434;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureInt9435;
		public abstract void setFeatureInt(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchKeyEvent9436;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTouchEvent9437;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTrackballEvent9438;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getDecorView9439;
		public abstract global::android.view.View getDecorView();
		internal static global::net.sf.jni4net.jni.MethodId _peekDecorView9440;
		public abstract global::android.view.View peekDecorView();
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState9441;
		public abstract global::android.os.Bundle saveHierarchyState();
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState9442;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		internal static global::net.sf.jni4net.jni.MethodId _onActive9443;
		protected abstract void onActive();
		internal static global::net.sf.jni4net.jni.MethodId _getFeatures9444;
		protected virtual int getFeatures() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Window._getFeatures9444);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getFeatures9444);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalFeatures9445;
		protected virtual int getLocalFeatures() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Window._getLocalFeatures9445);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures9445);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultWindowFormat9446;
		protected virtual void setDefaultWindowFormat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Window._setDefaultWindowFormat9446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat9446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildDrawable9447;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::net.sf.jni4net.jni.MethodId _setChildInt9448;
		public abstract void setChildInt(int arg0, int arg1);
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey9449;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		internal static global::net.sf.jni4net.jni.MethodId _Window9450;
		public Window(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window9450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.Window.staticClass = @__class;
			global::android.view.Window._getContext9383 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.Window._getAttributes9384 = @__env.GetMethodID(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;");
			global::android.view.Window._onConfigurationChanged9385 = @__env.GetMethodID(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.Window._setType9386 = @__env.GetMethodID(global::android.view.Window.staticClass, "setType", "(I)V");
			global::android.view.Window._setFlags9387 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFlags", "(II)V");
			global::android.view.Window._addFlags9388 = @__env.GetMethodID(global::android.view.Window.staticClass, "addFlags", "(I)V");
			global::android.view.Window._setCallback9389 = @__env.GetMethodID(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V");
			global::android.view.Window._getWindowManager9390 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			global::android.view.Window._getCurrentFocus9391 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			global::android.view.Window._findViewById9392 = @__env.GetMethodID(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;");
			global::android.view.Window._setContentView9393 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(I)V");
			global::android.view.Window._setContentView9394 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._setContentView9395 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V");
			global::android.view.Window._addContentView9396 = @__env.GetMethodID(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.Window._takeKeyEvents9397 = @__env.GetMethodID(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V");
			global::android.view.Window._setFeatureDrawableResource9398 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V");
			global::android.view.Window._setFeatureDrawableUri9399 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			global::android.view.Window._setFeatureDrawable9400 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureDrawableAlpha9401 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V");
			global::android.view.Window._getLayoutInflater9402 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			global::android.view.Window._setTitle9403 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.Window._setTitleColor9404 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitleColor", "(I)V");
			global::android.view.Window._setVolumeControlStream9405 = @__env.GetMethodID(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V");
			global::android.view.Window._getVolumeControlStream9406 = @__env.GetMethodID(global::android.view.Window.staticClass, "getVolumeControlStream", "()I");
			global::android.view.Window._getWindowStyle9407 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;");
			global::android.view.Window._setContainer9408 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V");
			global::android.view.Window._getContainer9409 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;");
			global::android.view.Window._hasChildren9410 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasChildren", "()Z");
			global::android.view.Window._setWindowManager9411 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V");
			global::android.view.Window._getCallback9412 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;");
			global::android.view.Window._isFloating9413 = @__env.GetMethodID(global::android.view.Window.staticClass, "isFloating", "()Z");
			global::android.view.Window._setLayout9414 = @__env.GetMethodID(global::android.view.Window.staticClass, "setLayout", "(II)V");
			global::android.view.Window._setGravity9415 = @__env.GetMethodID(global::android.view.Window.staticClass, "setGravity", "(I)V");
			global::android.view.Window._setFormat9416 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFormat", "(I)V");
			global::android.view.Window._setWindowAnimations9417 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V");
			global::android.view.Window._setSoftInputMode9418 = @__env.GetMethodID(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V");
			global::android.view.Window._clearFlags9419 = @__env.GetMethodID(global::android.view.Window.staticClass, "clearFlags", "(I)V");
			global::android.view.Window._setAttributes9420 = @__env.GetMethodID(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::android.view.Window._getForcedWindowFlags9421 = @__env.GetMethodID(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I");
			global::android.view.Window._hasSoftInputMode9422 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z");
			global::android.view.Window._requestFeature9423 = @__env.GetMethodID(global::android.view.Window.staticClass, "requestFeature", "(I)Z");
			global::android.view.Window._makeActive9424 = @__env.GetMethodID(global::android.view.Window.staticClass, "makeActive", "()V");
			global::android.view.Window._isActive9425 = @__env.GetMethodID(global::android.view.Window.staticClass, "isActive", "()Z");
			global::android.view.Window._openPanel9426 = @__env.GetMethodID(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._closePanel9427 = @__env.GetMethodID(global::android.view.Window.staticClass, "closePanel", "(I)V");
			global::android.view.Window._togglePanel9428 = @__env.GetMethodID(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			global::android.view.Window._performPanelShortcut9429 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			global::android.view.Window._performPanelIdentifierAction9430 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z");
			global::android.view.Window._closeAllPanels9431 = @__env.GetMethodID(global::android.view.Window.staticClass, "closeAllPanels", "()V");
			global::android.view.Window._performContextMenuIdentifierAction9432 = @__env.GetMethodID(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			global::android.view.Window._setBackgroundDrawableResource9433 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V");
			global::android.view.Window._setBackgroundDrawable9434 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setFeatureInt9435 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureInt", "(II)V");
			global::android.view.Window._superDispatchKeyEvent9436 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.Window._superDispatchTouchEvent9437 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._superDispatchTrackballEvent9438 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.Window._getDecorView9439 = @__env.GetMethodID(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;");
			global::android.view.Window._peekDecorView9440 = @__env.GetMethodID(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;");
			global::android.view.Window._saveHierarchyState9441 = @__env.GetMethodID(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			global::android.view.Window._restoreHierarchyState9442 = @__env.GetMethodID(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			global::android.view.Window._onActive9443 = @__env.GetMethodID(global::android.view.Window.staticClass, "onActive", "()V");
			global::android.view.Window._getFeatures9444 = @__env.GetMethodID(global::android.view.Window.staticClass, "getFeatures", "()I");
			global::android.view.Window._getLocalFeatures9445 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLocalFeatures", "()I");
			global::android.view.Window._setDefaultWindowFormat9446 = @__env.GetMethodID(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V");
			global::android.view.Window._setChildDrawable9447 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			global::android.view.Window._setChildInt9448 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildInt", "(II)V");
			global::android.view.Window._isShortcutKey9449 = @__env.GetMethodID(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			global::android.view.Window._Window9450 = @__env.GetMethodID(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
