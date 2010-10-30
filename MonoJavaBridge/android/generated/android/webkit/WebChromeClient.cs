namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebChromeClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebChromeClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebChromeClient.CustomViewCallback_))]
		public partial interface CustomViewCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onCustomViewHidden();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebChromeClient.CustomViewCallback))]
		internal sealed partial class CustomViewCallback_ : java.lang.Object, CustomViewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CustomViewCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCustomViewHidden16128;
			void android.webkit.WebChromeClient.CustomViewCallback.onCustomViewHidden()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass, "onCustomViewHidden", "()V", ref global::android.webkit.WebChromeClient.CustomViewCallback_._onCustomViewHidden16128);
			}
			static CustomViewCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient$CustomViewCallback"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void CustomViewCallbackDelegate();

		internal partial class CustomViewCallbackDelegateWrapper : java.lang.Object, CustomViewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CustomViewCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _CustomViewCallbackDelegateWrapper16129;
			public CustomViewCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._CustomViewCallbackDelegateWrapper16129.native == global::System.IntPtr.Zero)
					global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._CustomViewCallbackDelegateWrapper16129 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass, global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._CustomViewCallbackDelegateWrapper16129);
				Init(@__env, handle);
			}
			static CustomViewCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient_CustomViewCallbackDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CustomViewCallbackDelegateWrapper
		{
			private CustomViewCallbackDelegate myDelegate;
			public void onCustomViewHidden()
			{
				myDelegate();
			}
			public static implicit operator CustomViewCallbackDelegateWrapper(CustomViewCallbackDelegate d)
			{
				global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper ret = new global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedIcon16130;
		public virtual void onReceivedIcon(android.webkit.WebView arg0, android.graphics.Bitmap arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V", ref global::android.webkit.WebChromeClient._onReceivedIcon16130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onProgressChanged16131;
		public virtual void onProgressChanged(android.webkit.WebView arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onProgressChanged", "(Landroid/webkit/WebView;I)V", ref global::android.webkit.WebChromeClient._onProgressChanged16131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedTitle16132;
		public virtual void onReceivedTitle(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V", ref global::android.webkit.WebChromeClient._onReceivedTitle16132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedTouchIconUrl16133;
		public virtual void onReceivedTouchIconUrl(android.webkit.WebView arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", ref global::android.webkit.WebChromeClient._onReceivedTouchIconUrl16133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onShowCustomView16134;
		public virtual void onShowCustomView(android.view.View arg0, android.webkit.WebChromeClient.CustomViewCallback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", ref global::android.webkit.WebChromeClient._onShowCustomView16134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onShowCustomView(android.view.View arg0, global::android.webkit.WebChromeClient.CustomViewCallbackDelegate arg1)
		{
			onShowCustomView(arg0, (global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _onHideCustomView16135;
		public virtual void onHideCustomView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onHideCustomView", "()V", ref global::android.webkit.WebChromeClient._onHideCustomView16135);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateWindow16136;
		public virtual bool onCreateWindow(android.webkit.WebView arg0, bool arg1, bool arg2, android.os.Message arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z", ref global::android.webkit.WebChromeClient._onCreateWindow16136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocus16137;
		public virtual void onRequestFocus(android.webkit.WebView arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onRequestFocus", "(Landroid/webkit/WebView;)V", ref global::android.webkit.WebChromeClient._onRequestFocus16137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCloseWindow16138;
		public virtual void onCloseWindow(android.webkit.WebView arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V", ref global::android.webkit.WebChromeClient._onCloseWindow16138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onJsAlert16139;
		public virtual bool onJsAlert(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._onJsAlert16139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onJsConfirm16140;
		public virtual bool onJsConfirm(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._onJsConfirm16140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onJsPrompt16141;
		public virtual bool onJsPrompt(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, android.webkit.JsPromptResult arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsPromptResult;)Z", ref global::android.webkit.WebChromeClient._onJsPrompt16141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onJsBeforeUnload16142;
		public virtual bool onJsBeforeUnload(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._onJsBeforeUnload16142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onExceededDatabaseQuota16143;
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V", ref global::android.webkit.WebChromeClient._onExceededDatabaseQuota16143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, global::android.webkit.WebStorage.QuotaUpdaterDelegate arg5)
		{
			onExceededDatabaseQuota(arg0, arg1, arg2, arg3, arg4, (global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper)arg5);
		}
		internal static global::MonoJavaBridge.MethodId _onReachedMaxAppCacheSize16144;
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V", ref global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize16144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void onReachedMaxAppCacheSize(long arg0, long arg1, global::android.webkit.WebStorage.QuotaUpdaterDelegate arg2)
		{
			onReachedMaxAppCacheSize(arg0, arg1, (global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _onGeolocationPermissionsShowPrompt16145;
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V", ref global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt16145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onGeolocationPermissionsShowPrompt(java.lang.String arg0, global::android.webkit.GeolocationPermissions.CallbackDelegate arg1)
		{
			onGeolocationPermissionsShowPrompt(arg0, (global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _onGeolocationPermissionsHidePrompt16146;
		public virtual void onGeolocationPermissionsHidePrompt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsHidePrompt", "()V", ref global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt16146);
		}
		internal static global::MonoJavaBridge.MethodId _onJsTimeout16147;
		public virtual bool onJsTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsTimeout", "()Z", ref global::android.webkit.WebChromeClient._onJsTimeout16147);
		}
		internal static global::MonoJavaBridge.MethodId _onConsoleMessage16148;
		public virtual void onConsoleMessage(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V", ref global::android.webkit.WebChromeClient._onConsoleMessage16148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onConsoleMessage16149;
		public virtual bool onConsoleMessage(android.webkit.ConsoleMessage arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", ref global::android.webkit.WebChromeClient._onConsoleMessage16149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap DefaultVideoPoster
		{
			get
			{
				return getDefaultVideoPoster();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultVideoPoster16150;
		public virtual global::android.graphics.Bitmap getDefaultVideoPoster()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.webkit.WebChromeClient.staticClass, "getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", ref global::android.webkit.WebChromeClient._getDefaultVideoPoster16150) as android.graphics.Bitmap;
		}
		public new global::android.view.View VideoLoadingProgressView
		{
			get
			{
				return getVideoLoadingProgressView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoLoadingProgressView16151;
		public virtual global::android.view.View getVideoLoadingProgressView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebChromeClient.staticClass, "getVideoLoadingProgressView", "()Landroid/view/View;", ref global::android.webkit.WebChromeClient._getVideoLoadingProgressView16151) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getVisitedHistory16152;
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V", ref global::android.webkit.WebChromeClient._getVisitedHistory16152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getVisitedHistory(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getVisitedHistory((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _WebChromeClient16153;
		public WebChromeClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebChromeClient._WebChromeClient16153.native == global::System.IntPtr.Zero)
				global::android.webkit.WebChromeClient._WebChromeClient16153 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._WebChromeClient16153);
			Init(@__env, handle);
		}
		static WebChromeClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebChromeClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
