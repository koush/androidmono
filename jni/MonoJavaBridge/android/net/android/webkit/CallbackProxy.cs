namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CallbackProxy : android.os.Handler
	{ 
		internal new static global::java.lang.Class staticClass; 
		static CallbackProxy() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.CallbackProxy), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage9230; 
		public override void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._handleMessage9230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._handleMessage9230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress9231; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallIntMethod(this, global::android.webkit.CallbackProxy._getProgress9231); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._getProgress9231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedIcon9232; 
		public virtual void onReceivedIcon(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onReceivedIcon9232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onReceivedIcon9232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebViewClient9233; 
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._setWebViewClient9233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._setWebViewClient9233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebChromeClient9234; 
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._setWebChromeClient9234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._setWebChromeClient9234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWebChromeClient9235; 
		public virtual global::android.webkit.WebChromeClient getWebChromeClient() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebChromeClient>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CallbackProxy._getWebChromeClient9235)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebChromeClient>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._getWebChromeClient9235)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDownloadListener9236; 
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._setDownloadListener9236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._setDownloadListener9236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackForwardList9237; 
		public virtual global::android.webkit.WebBackForwardList getBackForwardList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CallbackProxy._getBackForwardList9237)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._getBackForwardList9237)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uiOverrideUrlLoading9238; 
		public virtual bool uiOverrideUrlLoading(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._uiOverrideUrlLoading9238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._uiOverrideUrlLoading9238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _uiOverrideKeyEvent9239; 
		public virtual bool uiOverrideKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._uiOverrideKeyEvent9239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._uiOverrideKeyEvent9239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageStarted9240; 
		public virtual void onPageStarted(java.lang.String arg0, android.graphics.Bitmap arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onPageStarted9240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onPageStarted9240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageFinished9241; 
		public virtual void onPageFinished(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onPageFinished9241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onPageFinished9241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTooManyRedirects9242; 
		public virtual void onTooManyRedirects(android.os.Message arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onTooManyRedirects9242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onTooManyRedirects9242, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedError9243; 
		public virtual void onReceivedError(int arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onReceivedError9243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onReceivedError9243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFormResubmission9244; 
		public virtual void onFormResubmission(android.os.Message arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onFormResubmission9244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onFormResubmission9244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldOverrideUrlLoading9245; 
		public virtual bool shouldOverrideUrlLoading(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._shouldOverrideUrlLoading9245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._shouldOverrideUrlLoading9245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedHttpAuthRequest9246; 
		public virtual void onReceivedHttpAuthRequest(android.webkit.HttpAuthHandler arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onReceivedHttpAuthRequest9246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onReceivedHttpAuthRequest9246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doUpdateVisitedHistory9247; 
		public virtual void doUpdateVisitedHistory(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._doUpdateVisitedHistory9247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._doUpdateVisitedHistory9247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLoadResource9248; 
		public virtual void onLoadResource(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onLoadResource9248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onLoadResource9248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnhandledKeyEvent9249; 
		public virtual void onUnhandledKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onUnhandledKeyEvent9249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onUnhandledKeyEvent9249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScaleChanged9250; 
		public virtual void onScaleChanged(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onScaleChanged9250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onScaleChanged9250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDownloadStart9251; 
		public virtual bool onDownloadStart(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, long arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._onDownloadStart9251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onDownloadStart9251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSavePassword9252; 
		public virtual bool onSavePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.os.Message arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._onSavePassword9252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onSavePassword9252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressChanged9253; 
		public virtual void onProgressChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onProgressChanged9253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onProgressChanged9253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createWindow9254; 
		public virtual global::android.webkit.WebView createWindow(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CallbackProxy._createWindow9254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._createWindow9254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocus9255; 
		public virtual void onRequestFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onRequestFocus9255); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onRequestFocus9255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCloseWindow9256; 
		public virtual void onCloseWindow(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onCloseWindow9256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onCloseWindow9256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTitle9257; 
		public virtual void onReceivedTitle(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onReceivedTitle9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onReceivedTitle9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsAlert9258; 
		public virtual void onJsAlert(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onJsAlert9258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onJsAlert9258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsConfirm9259; 
		public virtual bool onJsConfirm(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._onJsConfirm9259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onJsConfirm9259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsPrompt9260; 
		public virtual global::java.lang.String onJsPrompt(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CallbackProxy._onJsPrompt9260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onJsPrompt9260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsBeforeUnload9261; 
		public virtual bool onJsBeforeUnload(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._onJsBeforeUnload9261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onJsBeforeUnload9261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExceededDatabaseQuota9262; 
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onExceededDatabaseQuota9262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onExceededDatabaseQuota9262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReachedMaxAppCacheSize9263; 
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onReachedMaxAppCacheSize9263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onReachedMaxAppCacheSize9263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsShowPrompt9264; 
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onGeolocationPermissionsShowPrompt9264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onGeolocationPermissionsShowPrompt9264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsHidePrompt9265; 
		public virtual void onGeolocationPermissionsHidePrompt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._onGeolocationPermissionsHidePrompt9265); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onGeolocationPermissionsHidePrompt9265); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMessageToConsole9266; 
		public virtual void addMessageToConsole(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._addMessageToConsole9266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._addMessageToConsole9266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsTimeout9267; 
		public virtual bool onJsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.CallbackProxy._onJsTimeout9267); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._onJsTimeout9267); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisitedHistory9268; 
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CallbackProxy)) 
				@__env.CallVoidMethod(this, global::android.webkit.CallbackProxy._getVisitedHistory9268, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._getVisitedHistory9268, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CallbackProxy9269; 
		public CallbackProxy(android.content.Context arg0, android.webkit.WebView arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.CallbackProxy.staticClass, global::android.webkit.CallbackProxy._CallbackProxy9269, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.CallbackProxy.staticClass = @__class; 
			global::android.webkit.CallbackProxy._handleMessage9230 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._getProgress9231 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getProgress", "()I"); 
			global::android.webkit.CallbackProxy._onReceivedIcon9232 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedIcon", "(Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.CallbackProxy._setWebViewClient9233 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V"); 
			global::android.webkit.CallbackProxy._setWebChromeClient9234 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V"); 
			global::android.webkit.CallbackProxy._getWebChromeClient9235 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getWebChromeClient", "()Landroid/webkit/WebChromeClient;"); 
			global::android.webkit.CallbackProxy._setDownloadListener9236 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V"); 
			global::android.webkit.CallbackProxy._getBackForwardList9237 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getBackForwardList", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.CallbackProxy._uiOverrideUrlLoading9238 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "uiOverrideUrlLoading", "(Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._uiOverrideKeyEvent9239 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "uiOverrideKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.webkit.CallbackProxy._onPageStarted9240 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onPageStarted", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.CallbackProxy._onPageFinished9241 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onPageFinished", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onTooManyRedirects9242 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onTooManyRedirects", "(Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._onReceivedError9243 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedError", "(ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onFormResubmission9244 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onFormResubmission", "(Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.CallbackProxy._shouldOverrideUrlLoading9245 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "shouldOverrideUrlLoading", "(Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onReceivedHttpAuthRequest9246 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._doUpdateVisitedHistory9247 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "doUpdateVisitedHistory", "(Ljava/lang/String;Z)V"); 
			global::android.webkit.CallbackProxy._onLoadResource9248 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onLoadResource", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onUnhandledKeyEvent9249 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onUnhandledKeyEvent", "(Landroid/view/KeyEvent;)V"); 
			global::android.webkit.CallbackProxy._onScaleChanged9250 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onScaleChanged", "(FF)V"); 
			global::android.webkit.CallbackProxy._onDownloadStart9251 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)Z"); 
			global::android.webkit.CallbackProxy._onSavePassword9252 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onSavePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Message;)Z"); 
			global::android.webkit.CallbackProxy._onProgressChanged9253 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onProgressChanged", "(I)V"); 
			global::android.webkit.CallbackProxy._createWindow9254 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "createWindow", "(ZZ)Landroid/webkit/WebView;"); 
			global::android.webkit.CallbackProxy._onRequestFocus9255 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onRequestFocus", "()V"); 
			global::android.webkit.CallbackProxy._onCloseWindow9256 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.CallbackProxy._onReceivedTitle9257 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReceivedTitle", "(Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsAlert9258 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsAlert", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsConfirm9259 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsConfirm", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onJsPrompt9260 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsPrompt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.CallbackProxy._onJsBeforeUnload9261 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsBeforeUnload", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.webkit.CallbackProxy._onExceededDatabaseQuota9262 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.CallbackProxy._onReachedMaxAppCacheSize9263 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.CallbackProxy._onGeolocationPermissionsShowPrompt9264 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V"); 
			global::android.webkit.CallbackProxy._onGeolocationPermissionsHidePrompt9265 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onGeolocationPermissionsHidePrompt", "()V"); 
			global::android.webkit.CallbackProxy._addMessageToConsole9266 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "addMessageToConsole", "(Ljava/lang/String;ILjava/lang/String;)V"); 
			global::android.webkit.CallbackProxy._onJsTimeout9267 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "onJsTimeout", "()Z"); 
			global::android.webkit.CallbackProxy._getVisitedHistory9268 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.CallbackProxy._CallbackProxy9269 = @__env.GetMethodID(global::android.webkit.CallbackProxy.staticClass, "<init>", "(Landroid/content/Context;Landroid/webkit/WebView;)V"); 
		} 
	} 
} 
