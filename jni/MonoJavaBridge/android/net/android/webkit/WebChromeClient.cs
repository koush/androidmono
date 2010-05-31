namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebChromeClient : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebChromeClient() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebChromeClient), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class CustomViewCallback_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __CustomViewCallback.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __CustomViewCallback : java.lang.Object, CustomViewCallback
		{ 
			internal static global::java.lang.Class staticClass; 
			static __CustomViewCallback() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebChromeClient.__CustomViewCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.webkit.WebChromeClient.__CustomViewCallback(@__env); 
				} 
			} 
			internal __CustomViewCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onCustomViewHidden9369; 
			 void android.webkit.WebChromeClient.CustomViewCallback.onCustomViewHidden() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient.__CustomViewCallback._onCustomViewHidden9369); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.__CustomViewCallback.staticClass, global::android.webkit.WebChromeClient.__CustomViewCallback._onCustomViewHidden9369); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebChromeClient.__CustomViewCallback.staticClass = @__class; 
				global::android.webkit.WebChromeClient.__CustomViewCallback._onCustomViewHidden9369 = @__env.GetMethodID(global::android.webkit.WebChromeClient.__CustomViewCallback.staticClass, "android.webkit.WebChromeClient.CustomViewCallback.onCustomViewHidden", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedIcon9370; 
		public virtual void onReceivedIcon(android.webkit.WebView arg0, android.graphics.Bitmap arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onReceivedIcon9370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedIcon9370, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressChanged9371; 
		public virtual void onProgressChanged(android.webkit.WebView arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onProgressChanged9371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onProgressChanged9371, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocus9372; 
		public virtual void onRequestFocus(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onRequestFocus9372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onRequestFocus9372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCloseWindow9373; 
		public virtual void onCloseWindow(android.webkit.WebView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onCloseWindow9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onCloseWindow9373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTitle9374; 
		public virtual void onReceivedTitle(android.webkit.WebView arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onReceivedTitle9374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedTitle9374, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsAlert9375; 
		public virtual bool onJsAlert(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onJsAlert9375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsAlert9375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsConfirm9376; 
		public virtual bool onJsConfirm(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onJsConfirm9376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsConfirm9376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsPrompt9377; 
		public virtual bool onJsPrompt(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, android.webkit.JsPromptResult arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onJsPrompt9377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsPrompt9377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsBeforeUnload9378; 
		public virtual bool onJsBeforeUnload(android.webkit.WebView arg0, java.lang.String arg1, java.lang.String arg2, android.webkit.JsResult arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onJsBeforeUnload9378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsBeforeUnload9378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onExceededDatabaseQuota9379; 
		public virtual void onExceededDatabaseQuota(java.lang.String arg0, java.lang.String arg1, long arg2, long arg3, long arg4, android.webkit.WebStorage.QuotaUpdater arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onExceededDatabaseQuota9379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onExceededDatabaseQuota9379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReachedMaxAppCacheSize9380; 
		public virtual void onReachedMaxAppCacheSize(long arg0, long arg1, android.webkit.WebStorage.QuotaUpdater arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize9380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize9380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsShowPrompt9381; 
		public virtual void onGeolocationPermissionsShowPrompt(java.lang.String arg0, android.webkit.GeolocationPermissions.Callback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt9381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt9381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGeolocationPermissionsHidePrompt9382; 
		public virtual void onGeolocationPermissionsHidePrompt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt9382); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt9382); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onJsTimeout9383; 
		public virtual bool onJsTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onJsTimeout9383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onJsTimeout9383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVisitedHistory9384; 
		public virtual void getVisitedHistory(android.webkit.ValueCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._getVisitedHistory9384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getVisitedHistory9384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onReceivedTouchIconUrl9385; 
		public virtual void onReceivedTouchIconUrl(android.webkit.WebView arg0, java.lang.String arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onReceivedTouchIconUrl9385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onReceivedTouchIconUrl9385, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onShowCustomView9386; 
		public virtual void onShowCustomView(android.view.View arg0, android.webkit.WebChromeClient.CustomViewCallback arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onShowCustomView9386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onShowCustomView9386, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onHideCustomView9387; 
		public virtual void onHideCustomView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onHideCustomView9387); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onHideCustomView9387); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateWindow9388; 
		public virtual bool onCreateWindow(android.webkit.WebView arg0, bool arg1, bool arg2, android.os.Message arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebChromeClient._onCreateWindow9388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onCreateWindow9388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConsoleMessage9389; 
		public virtual void onConsoleMessage(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.webkit.WebChromeClient._onConsoleMessage9389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._onConsoleMessage9389, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultVideoPoster9390; 
		public virtual global::android.graphics.Bitmap getDefaultVideoPoster() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebChromeClient._getDefaultVideoPoster9390)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getDefaultVideoPoster9390)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVideoLoadingProgressView9391; 
		public virtual global::android.view.View getVideoLoadingProgressView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebChromeClient._getVideoLoadingProgressView9391)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._getVideoLoadingProgressView9391)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebChromeClient9392; 
		public WebChromeClient()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebChromeClient.staticClass, global::android.webkit.WebChromeClient._WebChromeClient9392, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebChromeClient.staticClass = @__class; 
			global::android.webkit.WebChromeClient._onReceivedIcon9370 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedIcon", "(Landroid/webkit/WebView;Landroid/graphics/Bitmap;)V"); 
			global::android.webkit.WebChromeClient._onProgressChanged9371 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onProgressChanged", "(Landroid/webkit/WebView;I)V"); 
			global::android.webkit.WebChromeClient._onRequestFocus9372 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onRequestFocus", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.WebChromeClient._onCloseWindow9373 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onCloseWindow", "(Landroid/webkit/WebView;)V"); 
			global::android.webkit.WebChromeClient._onReceivedTitle9374 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedTitle", "(Landroid/webkit/WebView;Ljava/lang/String;)V"); 
			global::android.webkit.WebChromeClient._onJsAlert9375 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsAlert", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsConfirm9376 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsConfirm", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsPrompt9377 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsPrompt", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsPromptResult;)Z"); 
			global::android.webkit.WebChromeClient._onJsBeforeUnload9378 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsBeforeUnload", "(Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;Landroid/webkit/JsResult;)Z"); 
			global::android.webkit.WebChromeClient._onExceededDatabaseQuota9379 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onExceededDatabaseQuota", "(Ljava/lang/String;Ljava/lang/String;JJJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.WebChromeClient._onReachedMaxAppCacheSize9380 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReachedMaxAppCacheSize", "(JJLandroid/webkit/WebStorage$QuotaUpdater;)V"); 
			global::android.webkit.WebChromeClient._onGeolocationPermissionsShowPrompt9381 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsShowPrompt", "(Ljava/lang/String;Landroid/webkit/GeolocationPermissions$Callback;)V"); 
			global::android.webkit.WebChromeClient._onGeolocationPermissionsHidePrompt9382 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onGeolocationPermissionsHidePrompt", "()V"); 
			global::android.webkit.WebChromeClient._onJsTimeout9383 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onJsTimeout", "()Z"); 
			global::android.webkit.WebChromeClient._getVisitedHistory9384 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getVisitedHistory", "(Landroid/webkit/ValueCallback;)V"); 
			global::android.webkit.WebChromeClient._onReceivedTouchIconUrl9385 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onReceivedTouchIconUrl", "(Landroid/webkit/WebView;Ljava/lang/String;Z)V"); 
			global::android.webkit.WebChromeClient._onShowCustomView9386 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onShowCustomView", "(Landroid/view/View;Landroid/webkit/WebChromeClient$CustomViewCallback;)V"); 
			global::android.webkit.WebChromeClient._onHideCustomView9387 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onHideCustomView", "()V"); 
			global::android.webkit.WebChromeClient._onCreateWindow9388 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onCreateWindow", "(Landroid/webkit/WebView;ZZLandroid/os/Message;)Z"); 
			global::android.webkit.WebChromeClient._onConsoleMessage9389 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "onConsoleMessage", "(Ljava/lang/String;ILjava/lang/String;)V"); 
			global::android.webkit.WebChromeClient._getDefaultVideoPoster9390 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getDefaultVideoPoster", "()Landroid/graphics/Bitmap;"); 
			global::android.webkit.WebChromeClient._getVideoLoadingProgressView9391 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "getVideoLoadingProgressView", "()Landroid/view/View;"); 
			global::android.webkit.WebChromeClient._WebChromeClient9392 = @__env.GetMethodID(global::android.webkit.WebChromeClient.staticClass, "<init>", "()V"); 
		} 
	} 
} 
