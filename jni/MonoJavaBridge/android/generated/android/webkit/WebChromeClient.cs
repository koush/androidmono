namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebChromeClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebChromeClient()
		{
			InitJNI();
		}
		protected WebChromeClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebChromeClient.CustomViewCallback_))]
		public partial interface CustomViewCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onCustomViewHidden();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebChromeClient.CustomViewCallback))]
		public sealed partial class CustomViewCallback_ : java.lang.Object, CustomViewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CustomViewCallback_()
			{
				InitJNI();
			}
			internal CustomViewCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCustomViewHidden16041;
			 void android.webkit.WebChromeClient.CustomViewCallback.onCustomViewHidden() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.CustomViewCallback_._onCustomViewHidden16041);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass, global::android.webkit.WebChromeClient.CustomViewCallback_._onCustomViewHidden16041);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient$CustomViewCallback"));
				global::android.webkit.WebChromeClient.CustomViewCallback_._onCustomViewHidden16041 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.CustomViewCallback_.staticClass, "onCustomViewHidden", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedIcon16042;
		public virtual void onReceivedIcon(android.webkit.WebView arg0, android.graphics.Bitmap arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onReceivedIcon16042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedIcon16042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onProgressChanged16043;
		public virtual void onProgressChanged(android.webkit.WebView arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onProgressChanged16043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onProgressChanged16043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedTitle16044;
		public virtual void onReceivedTitle(android.webkit.WebView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onReceivedTitle16044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedTitle16044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedTouchIconUrl16045;
		public virtual void onReceivedTouchIconUrl(android.webkit.WebView arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onReceivedTouchIconUrl16045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedTouchIconUrl16045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onShowCustomView16046;
		public virtual void onShowCustomView(android.view.View arg0, android.webkit.WebChromeClient.CustomViewCallback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onShowCustomView16046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onShowCustomView16046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onHideCustomView16047;
		public virtual void onHideCustomView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onHideCustomView16047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onHideCustomView16047);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateWindow16048;
		public virtual bool onCreateWindow(android.webkit.WebView arg0, bool arg1, bool arg2, android.os.Message arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onCreateWindow16048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onCreateWindow16048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onRequestFocus16049;
		public virtual void onRequestFocus(android.webkit.WebView arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onRequestFocus16049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onRequestFocus16049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCloseWindow16050;
		public virtual void onCloseWindow(android.webkit.WebView arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onCloseWindow16050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onCloseWindow16050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onJsAlert16051;
		public virtual bool onJsAlert(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onJsAlert16051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsAlert16051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onJsConfirm16052;
		public virtual bool onJsConfirm(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onJsConfirm16052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsConfirm16052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onJsPrompt16053;
		public virtual bool onJsPrompt(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, android.webkit.JsPromptResult arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onJsPrompt16053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsPrompt16053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onJsBeforeUnload16054;
		public virtual bool onJsBeforeUnload(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onJsBeforeUnload16054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsBeforeUnload16054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onExceededDatabaseQuota16055;
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onExceededDatabaseQuota16055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onExceededDatabaseQuota16055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _onReachedMaxAppCacheSize16056;
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize16056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize16056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onGeolocationPermissionsShowPrompt16057;
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt16057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt16057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onGeolocationPermissionsHidePrompt16058;
		public virtual void onGeolocationPermissionsHidePrompt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt16058);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt16058);
		}
		internal static global::MonoJavaBridge.MethodId _onJsTimeout16059;
		public virtual bool onJsTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onJsTimeout16059);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsTimeout16059);
		}
		internal static global::MonoJavaBridge.MethodId _onConsoleMessage16060;
		public virtual void onConsoleMessage(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onConsoleMessage16060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onConsoleMessage16060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onConsoleMessage16061;
		public virtual bool onConsoleMessage(android.webkit.ConsoleMessage arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient._onConsoleMessage16061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onConsoleMessage16061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Bitmap DefaultVideoPoster
		{
			get
			{
				return getDefaultVideoPoster();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultVideoPoster16062;
		public virtual global::android.graphics.Bitmap getDefaultVideoPoster() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebChromeClient._getDefaultVideoPoster16062)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getDefaultVideoPoster16062)) as android.graphics.Bitmap;
		}
		public new global::android.view.View VideoLoadingProgressView
		{
			get
			{
				return getVideoLoadingProgressView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVideoLoadingProgressView16063;
		public virtual global::android.view.View getVideoLoadingProgressView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebChromeClient._getVideoLoadingProgressView16063)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getVideoLoadingProgressView16063)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getVisitedHistory16064;
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient._getVisitedHistory16064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getVisitedHistory16064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WebChromeClient16065;
		public WebChromeClient()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._WebChromeClient16065);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebChromeClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebChromeClient"));
			global::android.webkit.WebChromeClient._onReceivedIcon16042 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V");
			global::android.webkit.WebChromeClient._onProgressChanged16043 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onProgressChanged", "(Landroid/webkit/WebView;I)V");
			global::android.webkit.WebChromeClient._onReceivedTitle16044 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			global::android.webkit.WebChromeClient._onReceivedTouchIconUrl16045 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V");
			global::android.webkit.WebChromeClient._onShowCustomView16046 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V");
			global::android.webkit.WebChromeClient._onHideCustomView16047 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onHideCustomView", "()V");
			global::android.webkit.WebChromeClient._onCreateWindow16048 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z");
			global::android.webkit.WebChromeClient._onRequestFocus16049 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onRequestFocus", "(Landroid/webkit/WebView;)V");
			global::android.webkit.WebChromeClient._onCloseWindow16050 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V");
			global::android.webkit.WebChromeClient._onJsAlert16051 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z");
			global::android.webkit.WebChromeClient._onJsConfirm16052 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z");
			global::android.webkit.WebChromeClient._onJsPrompt16053 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsPromptResult;)Z");
			global::android.webkit.WebChromeClient._onJsBeforeUnload16054 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z");
			global::android.webkit.WebChromeClient._onExceededDatabaseQuota16055 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V");
			global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize16056 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V");
			global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt16057 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V");
			global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt16058 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsHidePrompt", "()V");
			global::android.webkit.WebChromeClient._onJsTimeout16059 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onJsTimeout", "()Z");
			global::android.webkit.WebChromeClient._onConsoleMessage16060 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::android.webkit.WebChromeClient._onConsoleMessage16061 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Landroid/webkit/ConsoleMessage;)Z");
			global::android.webkit.WebChromeClient._getDefaultVideoPoster16062 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "getDefaultVideoPoster", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebChromeClient._getVideoLoadingProgressView16063 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "getVideoLoadingProgressView", "()Landroid/view/View;");
			global::android.webkit.WebChromeClient._getVisitedHistory16064 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V");
			global::android.webkit.WebChromeClient._WebChromeClient16065 = @__env.GetMethodIDNoThrow(global::android.webkit.WebChromeClient.staticClass, "<init>", "()V");
		}
	}
}
