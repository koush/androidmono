namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebViewClient : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebViewClient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebViewClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebViewClient(@__env); 
			} 
		} 
		protected WebViewClient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageStarted8941; 
		public virtual void onPageStarted(android.webkit.WebView arg0, java.lang.String arg1, android.graphics.Bitmap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onPageStarted8941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onPageStarted8941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPageFinished8942; 
		public virtual void onPageFinished(android.webkit.WebView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onPageFinished8942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onPageFinished8942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTooManyRedirects8943; 
		public virtual void onTooManyRedirects(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onTooManyRedirects8943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onTooManyRedirects8943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedError8944; 
		public virtual void onReceivedError(android.webkit.WebView arg0, int arg1, java.lang.String arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onReceivedError8944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onReceivedError8944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFormResubmission8945; 
		public virtual void onFormResubmission(android.webkit.WebView arg0, android.os.Message arg1, android.os.Message arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onFormResubmission8945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onFormResubmission8945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldOverrideUrlLoading8946; 
		public virtual bool shouldOverrideUrlLoading(android.webkit.WebView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				return @__env.CallBooleanMethod(this, _shouldOverrideUrlLoading8946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebViewClient.staticClass, _shouldOverrideUrlLoading8946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedHttpAuthRequest8947; 
		public virtual void onReceivedHttpAuthRequest(android.webkit.WebView arg0, android.webkit.HttpAuthHandler arg1, java.lang.String arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onReceivedHttpAuthRequest8947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onReceivedHttpAuthRequest8947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doUpdateVisitedHistory8948; 
		public virtual void doUpdateVisitedHistory(android.webkit.WebView arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _doUpdateVisitedHistory8948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _doUpdateVisitedHistory8948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLoadResource8949; 
		public virtual void onLoadResource(android.webkit.WebView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onLoadResource8949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onLoadResource8949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnhandledKeyEvent8950; 
		public virtual void onUnhandledKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onUnhandledKeyEvent8950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onUnhandledKeyEvent8950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScaleChanged8951; 
		public virtual void onScaleChanged(android.webkit.WebView arg0, float arg1, float arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				@__env.CallVoidMethod(this, _onScaleChanged8951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewClient.staticClass, _onScaleChanged8951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldOverrideKeyEvent8952; 
		public virtual bool shouldOverrideKeyEvent(android.webkit.WebView arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewClient)) 
				return @__env.CallBooleanMethod(this, _shouldOverrideKeyEvent8952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebViewClient.staticClass, _shouldOverrideKeyEvent8952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebViewClient8953; 
		public WebViewClient()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebViewClient.staticClass, _WebViewClient8953, this); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebViewClient.staticClass = @__class; 
			global::android.webkit.WebViewClient._onPageStarted8941 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onPageStarted", "(Landroid/webkit/WebView;Ljava/lang/String;Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.WebViewClient._onPageFinished8942 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onPageFinished", "(Landroid/webkit/WebView;Ljava/lang/String;)V"); 
			global::android.webkit.WebViewClient._onTooManyRedirects8943 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onTooManyRedirects", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.WebViewClient._onReceivedError8944 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onReceivedError", "(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebViewClient._onFormResubmission8945 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onFormResubmission", "(Landroid/webkit/WebView;Landroid/os/Message;Landroid/os/Message;)V"); 
			global::android.webkit.WebViewClient._shouldOverrideUrlLoading8946 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "shouldOverrideUrlLoading", "(Landroid/webkit/WebView;Ljava/lang/String;)Z"); 
			global::android.webkit.WebViewClient._onReceivedHttpAuthRequest8947 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onReceivedHttpAuthRequest", "(Landroid/webkit/WebView;Landroid/webkit/HttpAuthHandler;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebViewClient._doUpdateVisitedHistory8948 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "doUpdateVisitedHistory", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V"); 
			global::android.webkit.WebViewClient._onLoadResource8949 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onLoadResource", "(Landroid/webkit/WebView;Ljava/lang/String;)V"); 
			global::android.webkit.WebViewClient._onUnhandledKeyEvent8950 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onUnhandledKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)V"); 
			global::android.webkit.WebViewClient._onScaleChanged8951 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "onScaleChanged", "(Landroid/webkit/WebView;FF)V"); 
			global::android.webkit.WebViewClient._shouldOverrideKeyEvent8952 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "shouldOverrideKeyEvent", "(Landroid/webkit/WebView;Landroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebViewClient._WebViewClient8953 = @__env.GetMethodID(global::android.webkit.WebViewClient.staticClass, "<init>", "()V"); 
		} 
	} 
} 
