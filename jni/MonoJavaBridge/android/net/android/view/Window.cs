namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Window : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Window() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.Window), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			android.view.View onCreatePanelView(int arg0); 
			bool onCreatePanelMenu(int arg0, android.view.Menu arg1); 
			bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2); 
			bool onMenuOpened(int arg0, android.view.Menu arg1); 
			bool onMenuItemSelected(int arg0, android.view.MenuItem arg1); 
			void onPanelClosed(int arg0, android.view.Menu arg1); 
			bool onSearchRequested(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext8046; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext8046)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getContext8046)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributes8047; 
		public virtual android.view.WindowManager_LayoutParams getAttributes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _getAttributes8047)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.WindowManager_LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getAttributes8047)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged8048; 
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setType8049; 
		public virtual void setType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setType8049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setType8049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags8050; 
		public virtual void setFlags(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setFlags8050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setFlags8050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFlags8051; 
		public virtual void addFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _addFlags8051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _addFlags8051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCallback8052; 
		public virtual void setCallback(android.view.Window.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setCallback8052, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setCallback8052, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowManager8053; 
		public virtual android.view.WindowManager getWindowManager() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallObjectMethodPtr(this, _getWindowManager8053)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.WindowManager>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getWindowManager8053)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentFocus8054; 
		public abstract android.view.View getCurrentFocus(); 
		internal static global::net.sf.jni4net.jni.MethodId _findViewById8055; 
		public virtual android.view.View findViewById(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findViewById8055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _findViewById8055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8056; 
		public abstract void setContentView(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8057; 
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setContentView8058; 
		public abstract void setContentView(android.view.View arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _addContentView8059; 
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _takeKeyEvents8060; 
		public abstract void takeKeyEvents(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableResource8061; 
		public abstract void setFeatureDrawableResource(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableUri8062; 
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawable8063; 
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureDrawableAlpha8064; 
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutInflater8065; 
		public abstract android.view.LayoutInflater getLayoutInflater(); 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle8066; 
		public abstract void setTitle(java.lang.CharSequence arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setTitleColor8067; 
		public abstract void setTitleColor(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setVolumeControlStream8068; 
		public abstract void setVolumeControlStream(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getVolumeControlStream8069; 
		public abstract int getVolumeControlStream(); 
		internal static global::net.sf.jni4net.jni.MethodId _getWindowStyle8070; 
		public virtual android.content.res.TypedArray getWindowStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallObjectMethodPtr(this, _getWindowStyle8070)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.TypedArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getWindowStyle8070)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContainer8071; 
		public virtual void setContainer(android.view.Window arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setContainer8071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setContainer8071, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContainer8072; 
		public virtual android.view.Window getContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallObjectMethodPtr(this, _getContainer8072)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.Window>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getContainer8072)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasChildren8073; 
		public virtual bool hasChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallBooleanMethod(this, _hasChildren8073); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.Window.staticClass, _hasChildren8073); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowManager8074; 
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setWindowManager8074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setWindowManager8074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallback8075; 
		public virtual android.view.Window.Callback getCallback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallObjectMethodPtr(this, _getCallback8075)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.Window.Callback>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Window.staticClass, _getCallback8075)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFloating8076; 
		public abstract bool isFloating(); 
		internal static global::net.sf.jni4net.jni.MethodId _setLayout8077; 
		public virtual void setLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setLayout8077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setLayout8077, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity8078; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setGravity8078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setGravity8078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFormat8079; 
		public virtual void setFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setFormat8079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setFormat8079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWindowAnimations8080; 
		public virtual void setWindowAnimations(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setWindowAnimations8080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setWindowAnimations8080, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSoftInputMode8081; 
		public virtual void setSoftInputMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setSoftInputMode8081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setSoftInputMode8081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFlags8082; 
		public virtual void clearFlags(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _clearFlags8082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _clearFlags8082, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAttributes8083; 
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setAttributes8083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setAttributes8083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getForcedWindowFlags8084; 
		protected virtual int getForcedWindowFlags() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallIntMethod(this, _getForcedWindowFlags8084); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Window.staticClass, _getForcedWindowFlags8084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasSoftInputMode8085; 
		protected virtual bool hasSoftInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallBooleanMethod(this, _hasSoftInputMode8085); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.Window.staticClass, _hasSoftInputMode8085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFeature8086; 
		public virtual bool requestFeature(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallBooleanMethod(this, _requestFeature8086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.Window.staticClass, _requestFeature8086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _makeActive8087; 
		public virtual void makeActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _makeActive8087); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _makeActive8087); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isActive8088; 
		public virtual bool isActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallBooleanMethod(this, _isActive8088); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.Window.staticClass, _isActive8088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openPanel8089; 
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _closePanel8090; 
		public abstract void closePanel(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _togglePanel8091; 
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _performPanelShortcut8092; 
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3); 
		internal static global::net.sf.jni4net.jni.MethodId _performPanelIdentifierAction8093; 
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _closeAllPanels8094; 
		public abstract void closeAllPanels(); 
		internal static global::net.sf.jni4net.jni.MethodId _performContextMenuIdentifierAction8095; 
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawableResource8096; 
		public virtual void setBackgroundDrawableResource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setBackgroundDrawableResource8096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setBackgroundDrawableResource8096, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundDrawable8097; 
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureInt8098; 
		public abstract void setFeatureInt(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchKeyEvent8099; 
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTouchEvent8100; 
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _superDispatchTrackballEvent8101; 
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDecorView8102; 
		public abstract android.view.View getDecorView(); 
		internal static global::net.sf.jni4net.jni.MethodId _peekDecorView8103; 
		public abstract android.view.View peekDecorView(); 
		internal static global::net.sf.jni4net.jni.MethodId _saveHierarchyState8104; 
		public abstract android.os.Bundle saveHierarchyState(); 
		internal static global::net.sf.jni4net.jni.MethodId _restoreHierarchyState8105; 
		public abstract void restoreHierarchyState(android.os.Bundle arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onActive8106; 
		protected abstract void onActive(); 
		internal static global::net.sf.jni4net.jni.MethodId _getFeatures8107; 
		protected virtual int getFeatures() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallIntMethod(this, _getFeatures8107); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Window.staticClass, _getFeatures8107); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalFeatures8108; 
		protected virtual int getLocalFeatures() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				return @__env.CallIntMethod(this, _getLocalFeatures8108); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Window.staticClass, _getLocalFeatures8108); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultWindowFormat8109; 
		protected virtual void setDefaultWindowFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Window)) 
				@__env.CallVoidMethod(this, _setDefaultWindowFormat8109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Window.staticClass, _setDefaultWindowFormat8109, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildDrawable8110; 
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _setChildInt8111; 
		public abstract void setChildInt(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _isShortcutKey8112; 
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _Window8113; 
		public Window(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.Window.staticClass, _Window8113, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.view.Window._getContext8046 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.view.Window._getAttributes8047 = @__env.GetMethodID(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;"); 
			global::android.view.Window._onConfigurationChanged8048 = @__env.GetMethodID(global::android.view.Window.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.view.Window._setType8049 = @__env.GetMethodID(global::android.view.Window.staticClass, "setType", "(I)V"); 
			global::android.view.Window._setFlags8050 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFlags", "(II)V"); 
			global::android.view.Window._addFlags8051 = @__env.GetMethodID(global::android.view.Window.staticClass, "addFlags", "(I)V"); 
			global::android.view.Window._setCallback8052 = @__env.GetMethodID(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V"); 
			global::android.view.Window._getWindowManager8053 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;"); 
			global::android.view.Window._getCurrentFocus8054 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCurrentFocus", "()Landroid/view/View;"); 
			global::android.view.Window._findViewById8055 = @__env.GetMethodID(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;"); 
			global::android.view.Window._setContentView8056 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(I)V"); 
			global::android.view.Window._setContentView8057 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.Window._setContentView8058 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContentView", "(Landroid/view/View;)V"); 
			global::android.view.Window._addContentView8059 = @__env.GetMethodID(global::android.view.Window.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.Window._takeKeyEvents8060 = @__env.GetMethodID(global::android.view.Window.staticClass, "takeKeyEvents", "(Z)V"); 
			global::android.view.Window._setFeatureDrawableResource8061 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableResource", "(II)V"); 
			global::android.view.Window._setFeatureDrawableUri8062 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V"); 
			global::android.view.Window._setFeatureDrawable8063 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setFeatureDrawableAlpha8064 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureDrawableAlpha", "(II)V"); 
			global::android.view.Window._getLayoutInflater8065 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;"); 
			global::android.view.Window._setTitle8066 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.view.Window._setTitleColor8067 = @__env.GetMethodID(global::android.view.Window.staticClass, "setTitleColor", "(I)V"); 
			global::android.view.Window._setVolumeControlStream8068 = @__env.GetMethodID(global::android.view.Window.staticClass, "setVolumeControlStream", "(I)V"); 
			global::android.view.Window._getVolumeControlStream8069 = @__env.GetMethodID(global::android.view.Window.staticClass, "getVolumeControlStream", "()I"); 
			global::android.view.Window._getWindowStyle8070 = @__env.GetMethodID(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;"); 
			global::android.view.Window._setContainer8071 = @__env.GetMethodID(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V"); 
			global::android.view.Window._getContainer8072 = @__env.GetMethodID(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;"); 
			global::android.view.Window._hasChildren8073 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasChildren", "()Z"); 
			global::android.view.Window._setWindowManager8074 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V"); 
			global::android.view.Window._getCallback8075 = @__env.GetMethodID(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;"); 
			global::android.view.Window._isFloating8076 = @__env.GetMethodID(global::android.view.Window.staticClass, "isFloating", "()Z"); 
			global::android.view.Window._setLayout8077 = @__env.GetMethodID(global::android.view.Window.staticClass, "setLayout", "(II)V"); 
			global::android.view.Window._setGravity8078 = @__env.GetMethodID(global::android.view.Window.staticClass, "setGravity", "(I)V"); 
			global::android.view.Window._setFormat8079 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFormat", "(I)V"); 
			global::android.view.Window._setWindowAnimations8080 = @__env.GetMethodID(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V"); 
			global::android.view.Window._setSoftInputMode8081 = @__env.GetMethodID(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V"); 
			global::android.view.Window._clearFlags8082 = @__env.GetMethodID(global::android.view.Window.staticClass, "clearFlags", "(I)V"); 
			global::android.view.Window._setAttributes8083 = @__env.GetMethodID(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V"); 
			global::android.view.Window._getForcedWindowFlags8084 = @__env.GetMethodID(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I"); 
			global::android.view.Window._hasSoftInputMode8085 = @__env.GetMethodID(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z"); 
			global::android.view.Window._requestFeature8086 = @__env.GetMethodID(global::android.view.Window.staticClass, "requestFeature", "(I)Z"); 
			global::android.view.Window._makeActive8087 = @__env.GetMethodID(global::android.view.Window.staticClass, "makeActive", "()V"); 
			global::android.view.Window._isActive8088 = @__env.GetMethodID(global::android.view.Window.staticClass, "isActive", "()Z"); 
			global::android.view.Window._openPanel8089 = @__env.GetMethodID(global::android.view.Window.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V"); 
			global::android.view.Window._closePanel8090 = @__env.GetMethodID(global::android.view.Window.staticClass, "closePanel", "(I)V"); 
			global::android.view.Window._togglePanel8091 = @__env.GetMethodID(global::android.view.Window.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V"); 
			global::android.view.Window._performPanelShortcut8092 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z"); 
			global::android.view.Window._performPanelIdentifierAction8093 = @__env.GetMethodID(global::android.view.Window.staticClass, "performPanelIdentifierAction", "(III)Z"); 
			global::android.view.Window._closeAllPanels8094 = @__env.GetMethodID(global::android.view.Window.staticClass, "closeAllPanels", "()V"); 
			global::android.view.Window._performContextMenuIdentifierAction8095 = @__env.GetMethodID(global::android.view.Window.staticClass, "performContextMenuIdentifierAction", "(II)Z"); 
			global::android.view.Window._setBackgroundDrawableResource8096 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V"); 
			global::android.view.Window._setBackgroundDrawable8097 = @__env.GetMethodID(global::android.view.Window.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setFeatureInt8098 = @__env.GetMethodID(global::android.view.Window.staticClass, "setFeatureInt", "(II)V"); 
			global::android.view.Window._superDispatchKeyEvent8099 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.Window._superDispatchTouchEvent8100 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.Window._superDispatchTrackballEvent8101 = @__env.GetMethodID(global::android.view.Window.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.Window._getDecorView8102 = @__env.GetMethodID(global::android.view.Window.staticClass, "getDecorView", "()Landroid/view/View;"); 
			global::android.view.Window._peekDecorView8103 = @__env.GetMethodID(global::android.view.Window.staticClass, "peekDecorView", "()Landroid/view/View;"); 
			global::android.view.Window._saveHierarchyState8104 = @__env.GetMethodID(global::android.view.Window.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;"); 
			global::android.view.Window._restoreHierarchyState8105 = @__env.GetMethodID(global::android.view.Window.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V"); 
			global::android.view.Window._onActive8106 = @__env.GetMethodID(global::android.view.Window.staticClass, "onActive", "()V"); 
			global::android.view.Window._getFeatures8107 = @__env.GetMethodID(global::android.view.Window.staticClass, "getFeatures", "()I"); 
			global::android.view.Window._getLocalFeatures8108 = @__env.GetMethodID(global::android.view.Window.staticClass, "getLocalFeatures", "()I"); 
			global::android.view.Window._setDefaultWindowFormat8109 = @__env.GetMethodID(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V"); 
			global::android.view.Window._setChildDrawable8110 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V"); 
			global::android.view.Window._setChildInt8111 = @__env.GetMethodID(global::android.view.Window.staticClass, "setChildInt", "(II)V"); 
			global::android.view.Window._isShortcutKey8112 = @__env.GetMethodID(global::android.view.Window.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.view.Window._Window8113 = @__env.GetMethodID(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
