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
			internal static global::net.sf.jni4net.jni.MethodId _onWindowAttributesChanged8662; 
			 void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onWindowAttributesChanged8662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onWindowAttributesChanged8662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onContentChanged8663; 
			 void android.view.Window.Callback.onContentChanged() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onContentChanged8663); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onContentChanged8663); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged8664; 
			 void android.view.Window.Callback.onWindowFocusChanged(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onWindowFocusChanged8664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onWindowFocusChanged8664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8665; 
			 void android.view.Window.Callback.onAttachedToWindow() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onAttachedToWindow8665); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onAttachedToWindow8665); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8666; 
			 void android.view.Window.Callback.onDetachedFromWindow() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onDetachedFromWindow8666); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onDetachedFromWindow8666); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent8667; 
			 bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchKeyEvent8667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchKeyEvent8667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent8668; 
			 bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchTouchEvent8668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchTouchEvent8668, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent8669; 
			 bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchTrackballEvent8669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchTrackballEvent8669, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent8670; 
			 bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent8670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent8670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelView8671; 
			 global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window.__Callback._onCreatePanelView8671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onCreatePanelView8671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCreatePanelMenu8672; 
			 bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onCreatePanelMenu8672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onCreatePanelMenu8672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPreparePanel8673; 
			 bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onPreparePanel8673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onPreparePanel8673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onMenuOpened8674; 
			 bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onMenuOpened8674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onMenuOpened8674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onMenuItemSelected8675; 
			 bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onMenuItemSelected8675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onMenuItemSelected8675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPanelClosed8676; 
			 void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.view.Window.__Callback._onPanelClosed8676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onPanelClosed8676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSearchRequested8677; 
			 bool android.view.Window.Callback.onSearchRequested() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.view.Window.__Callback._onSearchRequested8677); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.__Callback.staticClass, global::android.view.Window.__Callback._onSearchRequested8677); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.Window.__Callback.staticClass = @__class; 
				global::android.view.Window.__Callback._onWindowAttributesChanged8662 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V"); 
				global::android.view.Window.__Callback._onContentChanged8663 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onContentChanged", "()V"); 
				global::android.view.Window.__Callback._onWindowFocusChanged8664 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onWindowFocusChanged", "(Z)V"); 
				global::android.view.Window.__Callback._onAttachedToWindow8665 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onAttachedToWindow", "()V"); 
				global::android.view.Window.__Callback._onDetachedFromWindow8666 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onDetachedFromWindow", "()V"); 
				global::android.view.Window.__Callback._dispatchKeyEvent8667 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
				global::android.view.Window.__Callback._dispatchTouchEvent8668 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.Window.__Callback._dispatchTrackballEvent8669 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.Window.__Callback._dispatchPopulateAccessibilityEvent8670 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
				global::android.view.Window.__Callback._onCreatePanelView8671 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onCreatePanelView", "(I)Landroid/view/View;"); 
				global::android.view.Window.__Callback._onCreatePanelMenu8672 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onCreatePanelMenu", "(ILandroid/view/Menu;)Z"); 
				global::android.view.Window.__Callback._onPreparePanel8673 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z"); 
				global::android.view.Window.__Callback._onMenuOpened8674 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onMenuOpened", "(ILandroid/view/Menu;)Z"); 
				global::android.view.Window.__Callback._onMenuItemSelected8675 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onMenuItemSelected", "(ILandroid/view/MenuItem;)Z"); 
				global::android.view.Window.__Callback._onPanelClosed8676 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onPanelClosed", "(ILandroid/view/Menu;)V"); 
				global::android.view.Window.__Callback._onSearchRequested8677 = @__env.GetMethodID(global::android.view.Window.__Callback.staticClass, "android.view.Window.Callback.onSearchRequested", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext8678; 
		public virtual global::android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getContext8678)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getContext8678)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributes8679; 
		public virtual global::android.view.WindowManager_LayoutParams getAttributes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getAttributes8679)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getAttributes8679)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged8680; 
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setType8681; 
		public virtual void setType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setType8681, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setType8681, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags8682; 
		public virtual void setFlags(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setFlags8682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFlags8682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFlags8683; 
		public virtual void addFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._addFlags8683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._addFlags8683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCallback8684; 
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setCallback8684, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setCallback8684, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager8685; 
		public virtual global::android.view.WindowManager getWindowManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getWindowManager8685)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager8685)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus8686; 
		public abstract global::android.view.View getCurrentFocus(); 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById8687; 
		public virtual global::android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._findViewById8687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._findViewById8687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8688; 
		public abstract void setContentView(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8689; 
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8690; 
		public abstract void setContentView(android.view.View arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _addContentView8691; 
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents8692; 
		public abstract void takeKeyEvents(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource8693; 
		public abstract void setFeatureDrawableResource(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri8694; 
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable8695; 
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha8696; 
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater8697; 
		public abstract global::android.view.LayoutInflater getLayoutInflater(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle8698; 
		public abstract void setTitle(java.lang.CharSequence arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor8699; 
		public abstract void setTitleColor(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream8700; 
		public abstract void setVolumeControlStream(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream8701; 
		public abstract int getVolumeControlStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowStyle8702; 
		public virtual global::android.content.res.TypedArray getWindowStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getWindowStyle8702)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle8702)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContainer8703; 
		public virtual void setContainer(android.view.Window arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setContainer8703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setContainer8703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContainer8704; 
		public virtual global::android.view.Window getContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getContainer8704)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getContainer8704)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasChildren8705; 
		public virtual bool hasChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.Window._hasChildren8705); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasChildren8705); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowManager8706; 
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setWindowManager8706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager8706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallback8707; 
		public virtual global::android.view.Window.Callback getCallback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Window._getCallback8707)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Window.staticClass, global::android.view.Window._getCallback8707)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloating8708; 
		public abstract bool isFloating(); 
		internal static global::net.sf.jni4net.jni.MethodId _setLayout8709; 
		public virtual void setLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setLayout8709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setLayout8709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity8710; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setGravity8710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setGravity8710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFormat8711; 
		public virtual void setFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setFormat8711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFormat8711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowAnimations8712; 
		public virtual void setWindowAnimations(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setWindowAnimations8712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations8712, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode8713; 
		public virtual void setSoftInputMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setSoftInputMode8713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode8713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFlags8714; 
		public virtual void clearFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._clearFlags8714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._clearFlags8714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAttributes8715; 
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setAttributes8715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setAttributes8715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getForcedWindowFlags8716; 
		protected virtual int getForcedWindowFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.Window._getForcedWindowFlags8716); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags8716); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftInputMode8717; 
		protected virtual bool hasSoftInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.Window._hasSoftInputMode8717); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode8717); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFeature8718; 
		public virtual bool requestFeature(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.Window._requestFeature8718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._requestFeature8718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeActive8719; 
		public virtual void makeActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._makeActive8719); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._makeActive8719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isActive8720; 
		public virtual bool isActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.view.Window._isActive8720); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._isActive8720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openPanel8721; 
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _closePanel8722; 
		public abstract void closePanel(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _togglePanel8723; 
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _performPanelShortcut8724; 
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _performPanelIdentifierAction8725; 
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _closeAllPanels8726; 
		public abstract void closeAllPanels(); 
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuIdentifierAction8727; 
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawableResource8728; 
		public virtual void setBackgroundDrawableResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setBackgroundDrawableResource8728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource8728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable8729; 
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureInt8730; 
		public abstract void setFeatureInt(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchKeyEvent8731; 
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTouchEvent8732; 
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTrackballEvent8733; 
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDecorView8734; 
		public abstract global::android.view.View getDecorView(); 
		internal static global::net.sf.jni4net.jni.MethodId _peekDecorView8735; 
		public abstract global::android.view.View peekDecorView(); 
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState8736; 
		public abstract global::android.os.Bundle saveHierarchyState(); 
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState8737; 
		public abstract void restoreHierarchyState(android.os.Bundle arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onActive8738; 
		protected abstract void onActive(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFeatures8739; 
		protected virtual int getFeatures() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.Window._getFeatures8739); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getFeatures8739); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalFeatures8740; 
		protected virtual int getLocalFeatures() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.view.Window._getLocalFeatures8740); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures8740); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultWindowFormat8741; 
		protected virtual void setDefaultWindowFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.view.Window._setDefaultWindowFormat8741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat8741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildDrawable8742; 
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setChildInt8743; 
		public abstract void setChildInt(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey8744; 
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _Window8745; 
		public Window(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window8745, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.view.Window._getContext8678 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.Window._getAttributes8679 = @__env.GetMethodID(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;"); 
			global::android.view.Window._onConfigurationChanged8680 = @__env.GetMethodID(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.view.Window._setType8681 = @__env.GetMethodID(global::android.view.Window.staticClass, "setType", "(I)V"); 
			global::android.view.Window._setFlags8682 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFlags", "(II)V"); 
			global::android.view.Window._addFlags8683 = @__env.GetMethodID(global::android.view.Window.staticClass, "addFlags", "(I)V"); 
			global::android.view.Window._setCallback8684 = @__env.GetMethodID(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V"); 
			global::android.view.Window._getWindowManager8685 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;"); 
			global::android.view.Window._getCurrentFocus8686 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;"); 
			global::android.view.Window._findViewById8687 = @__env.GetMethodID(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.view.Window._setContentView8688 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(I)V"); 
			global::android.view.Window._setContentView8689 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.Window._setContentView8690 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.view.Window._addContentView8691 = @__env.GetMethodID(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.Window._takeKeyEvents8692 = @__env.GetMethodID(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V"); 
			global::android.view.Window._setFeatureDrawableResource8693 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V"); 
			global::android.view.Window._setFeatureDrawableUri8694 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V"); 
			global::android.view.Window._setFeatureDrawable8695 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setFeatureDrawableAlpha8696 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V"); 
			global::android.view.Window._getLayoutInflater8697 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.view.Window._setTitle8698 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.Window._setTitleColor8699 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitleColor", "(I)V"); 
			global::android.view.Window._setVolumeControlStream8700 = @__env.GetMethodID(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V"); 
			global::android.view.Window._getVolumeControlStream8701 = @__env.GetMethodID(global::android.view.Window.staticClass, "getVolumeControlStream", "()I"); 
			global::android.view.Window._getWindowStyle8702 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;"); 
			global::android.view.Window._setContainer8703 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V"); 
			global::android.view.Window._getContainer8704 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;"); 
			global::android.view.Window._hasChildren8705 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasChildren", "()Z"); 
			global::android.view.Window._setWindowManager8706 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V"); 
			global::android.view.Window._getCallback8707 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;"); 
			global::android.view.Window._isFloating8708 = @__env.GetMethodID(global::android.view.Window.staticClass, "isFloating", "()Z"); 
			global::android.view.Window._setLayout8709 = @__env.GetMethodID(global::android.view.Window.staticClass, "setLayout", "(II)V"); 
			global::android.view.Window._setGravity8710 = @__env.GetMethodID(global::android.view.Window.staticClass, "setGravity", "(I)V"); 
			global::android.view.Window._setFormat8711 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFormat", "(I)V"); 
			global::android.view.Window._setWindowAnimations8712 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V"); 
			global::android.view.Window._setSoftInputMode8713 = @__env.GetMethodID(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V"); 
			global::android.view.Window._clearFlags8714 = @__env.GetMethodID(global::android.view.Window.staticClass, "clearFlags", "(I)V"); 
			global::android.view.Window._setAttributes8715 = @__env.GetMethodID(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V"); 
			global::android.view.Window._getForcedWindowFlags8716 = @__env.GetMethodID(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I"); 
			global::android.view.Window._hasSoftInputMode8717 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z"); 
			global::android.view.Window._requestFeature8718 = @__env.GetMethodID(global::android.view.Window.staticClass, "requestFeature", "(I)Z"); 
			global::android.view.Window._makeActive8719 = @__env.GetMethodID(global::android.view.Window.staticClass, "makeActive", "()V"); 
			global::android.view.Window._isActive8720 = @__env.GetMethodID(global::android.view.Window.staticClass, "isActive", "()Z"); 
			global::android.view.Window._openPanel8721 = @__env.GetMethodID(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V"); 
			global::android.view.Window._closePanel8722 = @__env.GetMethodID(global::android.view.Window.staticClass, "closePanel", "(I)V"); 
			global::android.view.Window._togglePanel8723 = @__env.GetMethodID(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V"); 
			global::android.view.Window._performPanelShortcut8724 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z"); 
			global::android.view.Window._performPanelIdentifierAction8725 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z"); 
			global::android.view.Window._closeAllPanels8726 = @__env.GetMethodID(global::android.view.Window.staticClass, "closeAllPanels", "()V"); 
			global::android.view.Window._performContextMenuIdentifierAction8727 = @__env.GetMethodID(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z"); 
			global::android.view.Window._setBackgroundDrawableResource8728 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V"); 
			global::android.view.Window._setBackgroundDrawable8729 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setFeatureInt8730 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureInt", "(II)V"); 
			global::android.view.Window._superDispatchKeyEvent8731 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.Window._superDispatchTouchEvent8732 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.Window._superDispatchTrackballEvent8733 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.Window._getDecorView8734 = @__env.GetMethodID(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;"); 
			global::android.view.Window._peekDecorView8735 = @__env.GetMethodID(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;"); 
			global::android.view.Window._saveHierarchyState8736 = @__env.GetMethodID(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;"); 
			global::android.view.Window._restoreHierarchyState8737 = @__env.GetMethodID(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V"); 
			global::android.view.Window._onActive8738 = @__env.GetMethodID(global::android.view.Window.staticClass, "onActive", "()V"); 
			global::android.view.Window._getFeatures8739 = @__env.GetMethodID(global::android.view.Window.staticClass, "getFeatures", "()I"); 
			global::android.view.Window._getLocalFeatures8740 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLocalFeatures", "()I"); 
			global::android.view.Window._setDefaultWindowFormat8741 = @__env.GetMethodID(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V"); 
			global::android.view.Window._setChildDrawable8742 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setChildInt8743 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildInt", "(II)V"); 
			global::android.view.Window._isShortcutKey8744 = @__env.GetMethodID(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.Window._Window8745 = @__env.GetMethodID(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
