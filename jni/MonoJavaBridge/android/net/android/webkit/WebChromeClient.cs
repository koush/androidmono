namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebChromeClient : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebChromeClient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebChromeClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebChromeClient(@__env); 
			} 
		} 
		protected WebChromeClient(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface CustomViewCallback 
		{ 
			void onCustomViewHidden(); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedIcon8679; 
		public virtual void onReceivedIcon(android.webkit.WebView arg0, android.graphics.Bitmap arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onReceivedIcon8679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onReceivedIcon8679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressChanged8680; 
		public virtual void onProgressChanged(android.webkit.WebView arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onProgressChanged8680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onProgressChanged8680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocus8681; 
		public virtual void onRequestFocus(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onRequestFocus8681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onRequestFocus8681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCloseWindow8682; 
		public virtual void onCloseWindow(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onCloseWindow8682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onCloseWindow8682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTitle8683; 
		public virtual void onReceivedTitle(android.webkit.WebView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onReceivedTitle8683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onReceivedTitle8683, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsAlert8684; 
		public virtual bool onJsAlert(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onJsAlert8684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onJsAlert8684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsConfirm8685; 
		public virtual bool onJsConfirm(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onJsConfirm8685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onJsConfirm8685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsPrompt8686; 
		public virtual bool onJsPrompt(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, android.webkit.JsPromptResult arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onJsPrompt8686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onJsPrompt8686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsBeforeUnload8687; 
		public virtual bool onJsBeforeUnload(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onJsBeforeUnload8687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onJsBeforeUnload8687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExceededDatabaseQuota8688; 
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onExceededDatabaseQuota8688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onExceededDatabaseQuota8688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReachedMaxAppCacheSize8689; 
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onReachedMaxAppCacheSize8689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onReachedMaxAppCacheSize8689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsShowPrompt8690; 
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onGeolocationPermissionsShowPrompt8690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onGeolocationPermissionsShowPrompt8690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsHidePrompt8691; 
		public virtual void onGeolocationPermissionsHidePrompt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onGeolocationPermissionsHidePrompt8691); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onGeolocationPermissionsHidePrompt8691); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsTimeout8692; 
		public virtual bool onJsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onJsTimeout8692); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onJsTimeout8692); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisitedHistory8693; 
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _getVisitedHistory8693, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _getVisitedHistory8693, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTouchIconUrl8694; 
		public virtual void onReceivedTouchIconUrl(android.webkit.WebView arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onReceivedTouchIconUrl8694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onReceivedTouchIconUrl8694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onShowCustomView8695; 
		public virtual void onShowCustomView(android.view.View arg0, android.webkit.WebChromeClient.CustomViewCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onShowCustomView8695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onShowCustomView8695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onHideCustomView8696; 
		public virtual void onHideCustomView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onHideCustomView8696); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onHideCustomView8696); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateWindow8697; 
		public virtual bool onCreateWindow(android.webkit.WebView arg0, bool arg1, bool arg2, android.os.Message arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return @__env.CallBooleanMethod(this, _onCreateWindow8697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebChromeClient.staticClass, _onCreateWindow8697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConsoleMessage8698; 
		public virtual void onConsoleMessage(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				@__env.CallVoidMethod(this, _onConsoleMessage8698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebChromeClient.staticClass, _onConsoleMessage8698, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultVideoPoster8699; 
		public virtual android.graphics.Bitmap getDefaultVideoPoster() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getDefaultVideoPoster8699)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebChromeClient.staticClass, _getDefaultVideoPoster8699)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVideoLoadingProgressView8700; 
		public virtual android.view.View getVideoLoadingProgressView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebChromeClient)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getVideoLoadingProgressView8700)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebChromeClient.staticClass, _getVideoLoadingProgressView8700)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebChromeClient8701; 
		public WebChromeClient()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebChromeClient.staticClass, _WebChromeClient8701, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebChromeClient.staticClass = @__class; 
			global::android.webkit.WebChromeClient._onReceivedIcon8679 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.WebChromeClient._onProgressChanged8680 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onProgressChanged", "(Landroid/webkit/WebView;I)V"); 
			global::android.webkit.WebChromeClient._onRequestFocus8681 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onRequestFocus", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.WebChromeClient._onCloseWindow8682 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.WebChromeClient._onReceivedTitle8683 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V"); 
			global::android.webkit.WebChromeClient._onJsAlert8684 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsConfirm8685 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsPrompt8686 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsPromptResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsBeforeUnload8687 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onExceededDatabaseQuota8688 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize8689 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt8690 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V"); 
			global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt8691 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsHidePrompt", "()V"); 
			global::android.webkit.WebChromeClient._onJsTimeout8692 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsTimeout", "()Z"); 
			global::android.webkit.WebChromeClient._getVisitedHistory8693 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.WebChromeClient._onReceivedTouchIconUrl8694 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V"); 
			global::android.webkit.WebChromeClient._onShowCustomView8695 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V"); 
			global::android.webkit.WebChromeClient._onHideCustomView8696 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onHideCustomView", "()V"); 
			global::android.webkit.WebChromeClient._onCreateWindow8697 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z"); 
			global::android.webkit.WebChromeClient._onConsoleMessage8698 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V"); 
			global::android.webkit.WebChromeClient._getDefaultVideoPoster8699 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getDefaultVideoPoster", "()Landroid/graphics/Bitmap;"); 
			global::android.webkit.WebChromeClient._getVideoLoadingProgressView8700 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getVideoLoadingProgressView", "()Landroid/view/View;"); 
			global::android.webkit.WebChromeClient._WebChromeClient8701 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "<init>", "()V"); 
		} 
	} 
} 
