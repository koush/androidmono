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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.WebChromeClient.CustomViewCallback.onCustomViewHidden()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass, "onCustomViewHidden", "()V", ref global::android.webkit.WebChromeClient.CustomViewCallback_._m0);
			}
			static CustomViewCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient$CustomViewCallback"));
			}
		}

		public delegate void CustomViewCallbackDelegate();

		internal partial class CustomViewCallbackDelegateWrapper : java.lang.Object, CustomViewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CustomViewCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CustomViewCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass, global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static CustomViewCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient_CustomViewCallbackDelegateWrapper"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onReceivedIcon(android.webkit.WebView arg0, android.graphics.Bitmap arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V", ref global::android.webkit.WebChromeClient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onProgressChanged(android.webkit.WebView arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onProgressChanged", "(Landroid/webkit/WebView;I)V", ref global::android.webkit.WebChromeClient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onReceivedTitle(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V", ref global::android.webkit.WebChromeClient._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onReceivedTouchIconUrl(android.webkit.WebView arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", ref global::android.webkit.WebChromeClient._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onShowCustomView(android.view.View arg0, android.webkit.WebChromeClient.CustomViewCallback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V", ref global::android.webkit.WebChromeClient._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onShowCustomView(android.view.View arg0, global::android.webkit.WebChromeClient.CustomViewCallbackDelegate arg1)
		{
			onShowCustomView(arg0, (global::android.webkit.WebChromeClient.CustomViewCallbackDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onHideCustomView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onHideCustomView", "()V", ref global::android.webkit.WebChromeClient._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool onCreateWindow(android.webkit.WebView arg0, bool arg1, bool arg2, android.os.Message arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z", ref global::android.webkit.WebChromeClient._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void onRequestFocus(android.webkit.WebView arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onRequestFocus", "(Landroid/webkit/WebView;)V", ref global::android.webkit.WebChromeClient._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onCloseWindow(android.webkit.WebView arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V", ref global::android.webkit.WebChromeClient._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool onJsAlert(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool onJsConfirm(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool onJsPrompt(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, android.webkit.JsPromptResult arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsPromptResult;)Z", ref global::android.webkit.WebChromeClient._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool onJsBeforeUnload(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z", ref global::android.webkit.WebChromeClient._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V", ref global::android.webkit.WebChromeClient._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, global::android.webkit.WebStorage.QuotaUpdaterDelegate arg5)
		{
			onExceededDatabaseQuota(arg0, arg1, arg2, arg3, arg4, (global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper)arg5);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V", ref global::android.webkit.WebChromeClient._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void onReachedMaxAppCacheSize(long arg0, long arg1, global::android.webkit.WebStorage.QuotaUpdaterDelegate arg2)
		{
			onReachedMaxAppCacheSize(arg0, arg1, (global::android.webkit.WebStorage.QuotaUpdaterDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V", ref global::android.webkit.WebChromeClient._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void onGeolocationPermissionsShowPrompt(java.lang.String arg0, global::android.webkit.GeolocationPermissions.CallbackDelegate arg1)
		{
			onGeolocationPermissionsShowPrompt(arg0, (global::android.webkit.GeolocationPermissions.CallbackDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void onGeolocationPermissionsHidePrompt()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsHidePrompt", "()V", ref global::android.webkit.WebChromeClient._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual bool onJsTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onJsTimeout", "()Z", ref global::android.webkit.WebChromeClient._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void onConsoleMessage(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V", ref global::android.webkit.WebChromeClient._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool onConsoleMessage(android.webkit.ConsoleMessage arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z", ref global::android.webkit.WebChromeClient._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap DefaultVideoPoster
		{
			get
			{
				return getDefaultVideoPoster();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::android.graphics.Bitmap getDefaultVideoPoster()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.webkit.WebChromeClient.staticClass, "getDefaultVideoPoster", "()Landroid/graphics/Bitmap;", ref global::android.webkit.WebChromeClient._m20) as android.graphics.Bitmap;
		}
		public new global::android.view.View VideoLoadingProgressView
		{
			get
			{
				return getVideoLoadingProgressView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::android.view.View getVideoLoadingProgressView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebChromeClient.staticClass, "getVideoLoadingProgressView", "()Landroid/view/View;", ref global::android.webkit.WebChromeClient._m21) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V", ref global::android.webkit.WebChromeClient._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void getVisitedHistory(global::android.webkit.ValueCallbackDelegate arg0)
		{
			getVisitedHistory((global::android.webkit.ValueCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public WebChromeClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebChromeClient._m23.native == global::System.IntPtr.Zero)
				global::android.webkit.WebChromeClient._m23 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._m23);
			Init(@__env, handle);
		}
		static WebChromeClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebChromeClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient"));
		}
	}
}
