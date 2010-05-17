namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CallbackProxy : android.os.Handler
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CallbackProxy() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.CallbackProxy), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.CallbackProxy(@__env); 
			} 
		} 
		protected CallbackProxy(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage8548; 
		public override void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _handleMessage8548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _handleMessage8548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress8549; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallIntMethod(this, _getProgress8549); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.CallbackProxy.staticClass, _getProgress8549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedIcon8550; 
		public virtual void onReceivedIcon(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onReceivedIcon8550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onReceivedIcon8550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebViewClient8551; 
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _setWebViewClient8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _setWebViewClient8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebChromeClient8552; 
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _setWebChromeClient8552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _setWebChromeClient8552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWebChromeClient8553; 
		public virtual android.webkit.WebChromeClient getWebChromeClient() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebChromeClient>(@__env, @__env.CallObjectMethodPtr(this, _getWebChromeClient8553)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebChromeClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CallbackProxy.staticClass, _getWebChromeClient8553)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDownloadListener8554; 
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _setDownloadListener8554, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _setDownloadListener8554, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackForwardList8555; 
		public virtual android.webkit.WebBackForwardList getBackForwardList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, _getBackForwardList8555)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CallbackProxy.staticClass, _getBackForwardList8555)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uiOverrideUrlLoading8556; 
		public virtual bool uiOverrideUrlLoading(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _uiOverrideUrlLoading8556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _uiOverrideUrlLoading8556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uiOverrideKeyEvent8557; 
		public virtual bool uiOverrideKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _uiOverrideKeyEvent8557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _uiOverrideKeyEvent8557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageStarted8558; 
		public virtual void onPageStarted(java.lang.String arg0, android.graphics.Bitmap arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onPageStarted8558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onPageStarted8558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageFinished8559; 
		public virtual void onPageFinished(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onPageFinished8559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onPageFinished8559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTooManyRedirects8560; 
		public virtual void onTooManyRedirects(android.os.Message arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onTooManyRedirects8560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onTooManyRedirects8560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedError8561; 
		public virtual void onReceivedError(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onReceivedError8561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onReceivedError8561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFormResubmission8562; 
		public virtual void onFormResubmission(android.os.Message arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onFormResubmission8562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onFormResubmission8562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldOverrideUrlLoading8563; 
		public virtual bool shouldOverrideUrlLoading(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _shouldOverrideUrlLoading8563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _shouldOverrideUrlLoading8563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedHttpAuthRequest8564; 
		public virtual void onReceivedHttpAuthRequest(android.webkit.HttpAuthHandler arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onReceivedHttpAuthRequest8564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onReceivedHttpAuthRequest8564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doUpdateVisitedHistory8565; 
		public virtual void doUpdateVisitedHistory(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _doUpdateVisitedHistory8565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _doUpdateVisitedHistory8565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLoadResource8566; 
		public virtual void onLoadResource(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onLoadResource8566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onLoadResource8566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnhandledKeyEvent8567; 
		public virtual void onUnhandledKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onUnhandledKeyEvent8567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onUnhandledKeyEvent8567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScaleChanged8568; 
		public virtual void onScaleChanged(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onScaleChanged8568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onScaleChanged8568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDownloadStart8569; 
		public virtual bool onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _onDownloadStart8569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _onDownloadStart8569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSavePassword8570; 
		public virtual bool onSavePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.os.Message arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _onSavePassword8570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _onSavePassword8570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressChanged8571; 
		public virtual void onProgressChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onProgressChanged8571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onProgressChanged8571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createWindow8572; 
		public virtual android.webkit.WebView createWindow(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallObjectMethodPtr(this, _createWindow8572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CallbackProxy.staticClass, _createWindow8572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocus8573; 
		public virtual void onRequestFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onRequestFocus8573); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onRequestFocus8573); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCloseWindow8574; 
		public virtual void onCloseWindow(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onCloseWindow8574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onCloseWindow8574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTitle8575; 
		public virtual void onReceivedTitle(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onReceivedTitle8575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onReceivedTitle8575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsAlert8576; 
		public virtual void onJsAlert(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onJsAlert8576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onJsAlert8576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsConfirm8577; 
		public virtual bool onJsConfirm(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _onJsConfirm8577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _onJsConfirm8577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsPrompt8578; 
		public virtual java.lang.String onJsPrompt(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _onJsPrompt8578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CallbackProxy.staticClass, _onJsPrompt8578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsBeforeUnload8579; 
		public virtual bool onJsBeforeUnload(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _onJsBeforeUnload8579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _onJsBeforeUnload8579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExceededDatabaseQuota8580; 
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onExceededDatabaseQuota8580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onExceededDatabaseQuota8580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReachedMaxAppCacheSize8581; 
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onReachedMaxAppCacheSize8581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onReachedMaxAppCacheSize8581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsShowPrompt8582; 
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onGeolocationPermissionsShowPrompt8582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onGeolocationPermissionsShowPrompt8582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsHidePrompt8583; 
		public virtual void onGeolocationPermissionsHidePrompt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _onGeolocationPermissionsHidePrompt8583); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _onGeolocationPermissionsHidePrompt8583); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMessageToConsole8584; 
		public virtual void addMessageToConsole(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _addMessageToConsole8584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _addMessageToConsole8584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsTimeout8585; 
		public virtual bool onJsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, _onJsTimeout8585); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CallbackProxy.staticClass, _onJsTimeout8585); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisitedHistory8586; 
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, _getVisitedHistory8586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CallbackProxy.staticClass, _getVisitedHistory8586, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CallbackProxy8587; 
		public CallbackProxy(android.content.Context arg0, android.webkit.WebView arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.CallbackProxy.staticClass, _CallbackProxy8587, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.CallbackProxy.staticClass = @__class; 
			global::android.webkit.CallbackProxy._handleMessage8548 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._getProgress8549 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getProgress", "()I"); 
			global::android.webkit.CallbackProxy._onReceivedIcon8550 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedIcon", "(Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.CallbackProxy._setWebViewClient8551 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V"); 
			global::android.webkit.CallbackProxy._setWebChromeClient8552 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V"); 
			global::android.webkit.CallbackProxy._getWebChromeClient8553 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getWebChromeClient", "()Landroid/webkit/WebChromeClient;"); 
			global::android.webkit.CallbackProxy._setDownloadListener8554 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V"); 
			global::android.webkit.CallbackProxy._getBackForwardList8555 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getBackForwardList", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.CallbackProxy._uiOverrideUrlLoading8556 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "uiOverrideUrlLoading", "(Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._uiOverrideKeyEvent8557 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "uiOverrideKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.webkit.CallbackProxy._onPageStarted8558 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onPageStarted", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.CallbackProxy._onPageFinished8559 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onPageFinished", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onTooManyRedirects8560 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onTooManyRedirects", "(Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._onReceivedError8561 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedError", "(ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onFormResubmission8562 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onFormResubmission", "(Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._shouldOverrideUrlLoading8563 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "shouldOverrideUrlLoading", "(Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onReceivedHttpAuthRequest8564 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._doUpdateVisitedHistory8565 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "doUpdateVisitedHistory", "(Ljava/lang/String;Z)V"); 
			global::android.webkit.CallbackProxy._onLoadResource8566 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onLoadResource", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onUnhandledKeyEvent8567 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onUnhandledKeyEvent", "(Landroid/view/KeyEvent;)V"); 
			global::android.webkit.CallbackProxy._onScaleChanged8568 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onScaleChanged", "(FF)V"); 
			global::android.webkit.CallbackProxy._onDownloadStart8569 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)Z"); 
			global::android.webkit.CallbackProxy._onSavePassword8570 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onSavePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Message;)Z"); 
			global::android.webkit.CallbackProxy._onProgressChanged8571 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onProgressChanged", "(I)V"); 
			global::android.webkit.CallbackProxy._createWindow8572 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "createWindow", "(ZZ)Landroid/webkit/WebView;"); 
			global::android.webkit.CallbackProxy._onRequestFocus8573 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onRequestFocus", "()V"); 
			global::android.webkit.CallbackProxy._onCloseWindow8574 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.CallbackProxy._onReceivedTitle8575 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedTitle", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsAlert8576 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsAlert", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsConfirm8577 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsConfirm", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onJsPrompt8578 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsPrompt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.CallbackProxy._onJsBeforeUnload8579 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsBeforeUnload", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onExceededDatabaseQuota8580 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.CallbackProxy._onReachedMaxAppCacheSize8581 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.CallbackProxy._onGeolocationPermissionsShowPrompt8582 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V"); 
			global::android.webkit.CallbackProxy._onGeolocationPermissionsHidePrompt8583 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onGeolocationPermissionsHidePrompt", "()V"); 
			global::android.webkit.CallbackProxy._addMessageToConsole8584 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "addMessageToConsole", "(Ljava/lang/String;ILjava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsTimeout8585 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsTimeout", "()Z"); 
			global::android.webkit.CallbackProxy._getVisitedHistory8586 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.CallbackProxy._CallbackProxy8587 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "<init>", "(Landroid/content/Context;Landroid/webkit/WebView;)V"); 
		} 
	} 
} 
