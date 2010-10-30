namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebViewClient : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebViewClient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool shouldOverrideUrlLoading(android.webkit.WebView arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewClient.staticClass, "shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z", ref global::android.webkit.WebViewClient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onPageStarted(android.webkit.WebView arg0, java.lang.String arg1, android.graphics.Bitmap arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V", ref global::android.webkit.WebViewClient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onPageFinished(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V", ref global::android.webkit.WebViewClient._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onLoadResource(android.webkit.WebView arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V", ref global::android.webkit.WebViewClient._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onTooManyRedirects(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", ref global::android.webkit.WebViewClient._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onReceivedError(android.webkit.WebView arg0, int arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebViewClient._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onFormResubmission(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V", ref global::android.webkit.WebViewClient._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void doUpdateVisitedHistory(android.webkit.WebView arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V", ref global::android.webkit.WebViewClient._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onReceivedSslError(android.webkit.WebView arg0, android.webkit.SslErrorHandler arg1, android.net.http.SslError arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslError;)V", ref global::android.webkit.WebViewClient._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void onReceivedHttpAuthRequest(android.webkit.WebView arg0, android.webkit.HttpAuthHandler arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebViewClient._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool shouldOverrideKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewClient.staticClass, "shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z", ref global::android.webkit.WebViewClient._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void onUnhandledKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V", ref global::android.webkit.WebViewClient._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void onScaleChanged(android.webkit.WebView arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewClient.staticClass, "onScaleChanged", "(Landroid/webkit/WebView;FF)V", ref global::android.webkit.WebViewClient._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public WebViewClient() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewClient._m13.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewClient._m13 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._m13);
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
		static WebViewClient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewClient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewClient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
