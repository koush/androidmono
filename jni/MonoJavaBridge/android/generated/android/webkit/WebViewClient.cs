namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebViewClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebViewClient()
		{
			InitJNI();
		}
		protected WebViewClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shouldOverrideUrlLoading16431;
		public virtual bool shouldOverrideUrlLoading(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient._shouldOverrideUrlLoading16431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._shouldOverrideUrlLoading16431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPageStarted16432;
		public virtual void onPageStarted(android.webkit.WebView arg0, java.lang.String arg1, android.graphics.Bitmap arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onPageStarted16432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onPageStarted16432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onPageFinished16433;
		public virtual void onPageFinished(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onPageFinished16433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onPageFinished16433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLoadResource16434;
		public virtual void onLoadResource(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onLoadResource16434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onLoadResource16434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTooManyRedirects16435;
		public virtual void onTooManyRedirects(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onTooManyRedirects16435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onTooManyRedirects16435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedError16436;
		public virtual void onReceivedError(android.webkit.WebView arg0, int arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedError16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedError16436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onFormResubmission16437;
		public virtual void onFormResubmission(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onFormResubmission16437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onFormResubmission16437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doUpdateVisitedHistory16438;
		public virtual void doUpdateVisitedHistory(android.webkit.WebView arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._doUpdateVisitedHistory16438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._doUpdateVisitedHistory16438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedSslError16439;
		public virtual void onReceivedSslError(android.webkit.WebView arg0, android.webkit.SslErrorHandler arg1, android.net.http.SslError arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedSslError16439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedSslError16439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedHttpAuthRequest16440;
		public virtual void onReceivedHttpAuthRequest(android.webkit.WebView arg0, android.webkit.HttpAuthHandler arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedHttpAuthRequest16440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedHttpAuthRequest16440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _shouldOverrideKeyEvent16441;
		public virtual bool shouldOverrideKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient._shouldOverrideKeyEvent16441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._shouldOverrideKeyEvent16441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onUnhandledKeyEvent16442;
		public virtual void onUnhandledKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onUnhandledKeyEvent16442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onUnhandledKeyEvent16442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onScaleChanged16443;
		public virtual void onScaleChanged(android.webkit.WebView arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onScaleChanged16443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onScaleChanged16443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _WebViewClient16444;
		public WebViewClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._WebViewClient16444);
			Init(@__env, handle);
		}
		public static int ERROR_UNKNOWN
		{
			get
			{
				return -1;
			}
		}
		public static int ERROR_HOST_LOOKUP
		{
			get
			{
				return -2;
			}
		}
		public static int ERROR_UNSUPPORTED_AUTH_SCHEME
		{
			get
			{
				return -3;
			}
		}
		public static int ERROR_AUTHENTICATION
		{
			get
			{
				return -4;
			}
		}
		public static int ERROR_PROXY_AUTHENTICATION
		{
			get
			{
				return -5;
			}
		}
		public static int ERROR_CONNECT
		{
			get
			{
				return -6;
			}
		}
		public static int ERROR_IO
		{
			get
			{
				return -7;
			}
		}
		public static int ERROR_TIMEOUT
		{
			get
			{
				return -8;
			}
		}
		public static int ERROR_REDIRECT_LOOP
		{
			get
			{
				return -9;
			}
		}
		public static int ERROR_UNSUPPORTED_SCHEME
		{
			get
			{
				return -10;
			}
		}
		public static int ERROR_FAILED_SSL_HANDSHAKE
		{
			get
			{
				return -11;
			}
		}
		public static int ERROR_BAD_URL
		{
			get
			{
				return -12;
			}
		}
		public static int ERROR_FILE
		{
			get
			{
				return -13;
			}
		}
		public static int ERROR_FILE_NOT_FOUND
		{
			get
			{
				return -14;
			}
		}
		public static int ERROR_TOO_MANY_REQUESTS
		{
			get
			{
				return -15;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewClient"));
			global::android.webkit.WebViewClient._shouldOverrideUrlLoading16431 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z");
			global::android.webkit.WebViewClient._onPageStarted16432 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			global::android.webkit.WebViewClient._onPageFinished16433 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onLoadResource16434 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onTooManyRedirects16435 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V");
			global::android.webkit.WebViewClient._onReceivedError16436 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onFormResubmission16437 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V");
			global::android.webkit.WebViewClient._doUpdateVisitedHistory16438 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V");
			global::android.webkit.WebViewClient._onReceivedSslError16439 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslError;)V");
			global::android.webkit.WebViewClient._onReceivedHttpAuthRequest16440 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._shouldOverrideKeyEvent16441 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebViewClient._onUnhandledKeyEvent16442 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V");
			global::android.webkit.WebViewClient._onScaleChanged16443 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onScaleChanged", "(Landroid/webkit/WebView;FF)V");
			global::android.webkit.WebViewClient._WebViewClient16444 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "<init>", "()V");
		}
	}
}
