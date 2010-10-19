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
		internal static global::MonoJavaBridge.MethodId _shouldOverrideUrlLoading11222;
		public virtual bool shouldOverrideUrlLoading(android.webkit.WebView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient._shouldOverrideUrlLoading11222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._shouldOverrideUrlLoading11222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onPageStarted11223;
		public virtual void onPageStarted(android.webkit.WebView arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onPageStarted11223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onPageStarted11223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onPageFinished11224;
		public virtual void onPageFinished(android.webkit.WebView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onPageFinished11224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onPageFinished11224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onLoadResource11225;
		public virtual void onLoadResource(android.webkit.WebView arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onLoadResource11225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onLoadResource11225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTooManyRedirects11226;
		public virtual void onTooManyRedirects(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onTooManyRedirects11226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onTooManyRedirects11226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedError11227;
		public virtual void onReceivedError(android.webkit.WebView arg0, int arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedError11227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedError11227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onFormResubmission11228;
		public virtual void onFormResubmission(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onFormResubmission11228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onFormResubmission11228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _doUpdateVisitedHistory11229;
		public virtual void doUpdateVisitedHistory(android.webkit.WebView arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._doUpdateVisitedHistory11229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._doUpdateVisitedHistory11229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedSslError11230;
		public virtual void onReceivedSslError(android.webkit.WebView arg0, android.webkit.SslErrorHandler arg1, android.net.http.SslError arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedSslError11230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedSslError11230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onReceivedHttpAuthRequest11231;
		public virtual void onReceivedHttpAuthRequest(android.webkit.WebView arg0, android.webkit.HttpAuthHandler arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onReceivedHttpAuthRequest11231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onReceivedHttpAuthRequest11231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _shouldOverrideKeyEvent11232;
		public virtual bool shouldOverrideKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient._shouldOverrideKeyEvent11232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._shouldOverrideKeyEvent11232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onUnhandledKeyEvent11233;
		public virtual void onUnhandledKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onUnhandledKeyEvent11233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onUnhandledKeyEvent11233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onScaleChanged11234;
		public virtual void onScaleChanged(android.webkit.WebView arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient._onScaleChanged11234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._onScaleChanged11234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _WebViewClient11235;
		public WebViewClient()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebViewClient.staticClass, global::android.webkit.WebViewClient._WebViewClient11235);
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
			global::android.webkit.WebViewClient._shouldOverrideUrlLoading11222 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z");
			global::android.webkit.WebViewClient._onPageStarted11223 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			global::android.webkit.WebViewClient._onPageFinished11224 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onLoadResource11225 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onTooManyRedirects11226 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V");
			global::android.webkit.WebViewClient._onReceivedError11227 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._onFormResubmission11228 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V");
			global::android.webkit.WebViewClient._doUpdateVisitedHistory11229 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V");
			global::android.webkit.WebViewClient._onReceivedSslError11230 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedSslError", "(Landroid/webkit/WebView;Landroid/webkit/SslErrorHandler;Landroid/net/http/SslError;)V");
			global::android.webkit.WebViewClient._onReceivedHttpAuthRequest11231 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebViewClient._shouldOverrideKeyEvent11232 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebViewClient._onUnhandledKeyEvent11233 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V");
			global::android.webkit.WebViewClient._onScaleChanged11234 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "onScaleChanged", "(Landroid/webkit/WebView;FF)V");
			global::android.webkit.WebViewClient._WebViewClient11235 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewClient.staticClass, "<init>", "()V");
		}
	}
}
