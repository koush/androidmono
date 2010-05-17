namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebView : android.widget.AbsoluteLayout, android.view.ViewTreeObserver.OnGlobalFocusChangeListener, android.view.ViewGroup.OnHierarchyChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static WebView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebView(@__env); 
			} 
		} 
		protected WebView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class HitTestResult : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static HitTestResult() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebView.HitTestResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.webkit.WebView.HitTestResult(@__env); 
				} 
			} 
			protected HitTestResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getType8833; 
			public virtual int getType() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.HitTestResult)) 
					return @__env.CallIntMethod(this, _getType8833); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.HitTestResult.staticClass, _getType8833); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getExtra8834; 
			public virtual java.lang.String getExtra() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.HitTestResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getExtra8834)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.HitTestResult.staticClass, _getExtra8834)); 
			} 
			public static int UNKNOWN_TYPE
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int ANCHOR_TYPE
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int PHONE_TYPE
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int GEO_TYPE
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			public static int EMAIL_TYPE
			{ 
				get 
				{ 
					return 4; 
				} 
			} 
			public static int IMAGE_TYPE
			{ 
				get 
				{ 
					return 5; 
				} 
			} 
			public static int IMAGE_ANCHOR_TYPE
			{ 
				get 
				{ 
					return 6; 
				} 
			} 
			public static int SRC_ANCHOR_TYPE
			{ 
				get 
				{ 
					return 7; 
				} 
			} 
			public static int SRC_IMAGE_ANCHOR_TYPE
			{ 
				get 
				{ 
					return 8; 
				} 
			} 
			public static int EDIT_TEXT_TYPE
			{ 
				get 
				{ 
					return 9; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebView.HitTestResult.staticClass = @__class; 
				global::android.webkit.WebView.HitTestResult._getType8833 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I"); 
				global::android.webkit.WebView.HitTestResult._getExtra8834 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PictureListener 
		{ 
			void onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class WebViewTransport : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static WebViewTransport() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebView.WebViewTransport), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.webkit.WebView.WebViewTransport(@__env); 
				} 
			} 
			protected WebViewTransport(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setWebView8835; 
			public virtual void setWebView(android.webkit.WebView arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.WebViewTransport)) 
					@__env.CallVoidMethod(this, _setWebView8835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.WebViewTransport.staticClass, _setWebView8835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getWebView8836; 
			public virtual android.webkit.WebView getWebView() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.WebViewTransport)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallObjectMethodPtr(this, _getWebView8836)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.WebViewTransport.staticClass, _getWebView8836)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _WebViewTransport8837; 
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, _WebViewTransport8837, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebView.WebViewTransport.staticClass = @__class; 
				global::android.webkit.WebView.WebViewTransport._setWebView8835 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V"); 
				global::android.webkit.WebView.WebViewTransport._getWebView8836 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;"); 
				global::android.webkit.WebView.WebViewTransport._WebViewTransport8837 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroy8838; 
		public virtual void destroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _destroy8838); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _destroy8838); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeMemory8839; 
		public virtual void freeMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _freeMemory8839); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _freeMemory8839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCertificate8840; 
		public virtual android.net.http.SslCertificate getCertificate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallObjectMethodPtr(this, _getCertificate8840)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getCertificate8840)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearCache8841; 
		public virtual void clearCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearCache8841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearCache8841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown8842; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _onKeyDown8842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _onKeyDown8842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp8843; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _onKeyUp8843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _onKeyUp8843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8844; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent8844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _onTouchEvent8844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent8845; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _onTrackballEvent8845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _onTrackballEvent8845, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged8846; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onWindowFocusChanged8846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onWindowFocusChanged8846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow8847; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onAttachedToWindow8847); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onAttachedToWindow8847); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow8848; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow8848); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onDetachedFromWindow8848); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent8849; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent8849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _dispatchKeyEvent8849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle8850; 
		public virtual java.lang.String getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTitle8850)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getTitle8850)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick8851; 
		public override bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _performLongClick8851); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _performLongClick8851); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged8852; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onFocusChanged8852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onFocusChanged8852, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8853; 
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _requestFocus8853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _requestFocus8853, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged8854; 
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onScrollChanged8854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onScrollChanged8854, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged8855; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onSizeChanged8855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onSizeChanged8855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams8856; 
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setLayoutParams8856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setLayoutParams8856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll8857; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _computeScroll8857); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _computeScroll8857); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle8858; 
		public override void setScrollBarStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setScrollBarStyle8858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setScrollBarStyle8858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange8859; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _computeHorizontalScrollRange8859); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _computeHorizontalScrollRange8859); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange8860; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollRange8860); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _computeVerticalScrollRange8860); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset8861; 
		protected override int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollOffset8861); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _computeVerticalScrollOffset8861); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent8862; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _computeVerticalScrollExtent8862); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _computeVerticalScrollExtent8862); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw8863; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onDraw8863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onDraw8863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor8864; 
		public override void setBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setBackgroundColor8864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setBackgroundColor8864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure8865; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onMeasure8865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onMeasure8865, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen8866; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _requestChildRectangleOnScreen8866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _requestChildRectangleOnScreen8866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild8867; 
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _drawChild8867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _drawChild8867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress8868; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _getProgress8868); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _getProgress8868); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewAdded8869; 
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onChildViewAdded8869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onChildViewAdded8869, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewRemoved8870; 
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onChildViewRemoved8870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onChildViewRemoved8870, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl8871; 
		public virtual java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUrl8871)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getUrl8871)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveState8872; 
		public virtual android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, _saveState8872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _saveState8872, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreState8873; 
		public virtual android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, _restoreState8873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _restoreState8873, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearHistory8874; 
		public virtual void clearHistory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearHistory8874); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearHistory8874); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reload8875; 
		public virtual void reload() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _reload8875); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _reload8875); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalFocusChanged8876; 
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _onGlobalFocusChanged8876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _onGlobalFocusChanged8876, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebViewClient8877; 
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setWebViewClient8877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setWebViewClient8877, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebChromeClient8878; 
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setWebChromeClient8878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setWebChromeClient8878, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDownloadListener8879; 
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setDownloadListener8879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setDownloadListener8879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollbarOverlay8880; 
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setHorizontalScrollbarOverlay8880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setHorizontalScrollbarOverlay8880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollbarOverlay8881; 
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setVerticalScrollbarOverlay8881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setVerticalScrollbarOverlay8881, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _overlayHorizontalScrollbar8882; 
		public virtual bool overlayHorizontalScrollbar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _overlayHorizontalScrollbar8882); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _overlayHorizontalScrollbar8882); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _overlayVerticalScrollbar8883; 
		public virtual bool overlayVerticalScrollbar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _overlayVerticalScrollbar8883); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _overlayVerticalScrollbar8883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCertificate8884; 
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setCertificate8884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setCertificate8884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _savePassword8885; 
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _savePassword8885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _savePassword8885, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHttpAuthUsernamePassword8886; 
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setHttpAuthUsernamePassword8886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setHttpAuthUsernamePassword8886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHttpAuthUsernamePassword8887; 
		public virtual java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{ 
			if (GetType() == typeof(android.webkit.WebView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getHttpAuthUsernamePassword8887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getHttpAuthUsernamePassword8887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enablePlatformNotifications8888; 
		public static void enablePlatformNotifications() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, _enablePlatformNotifications8888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disablePlatformNotifications8889; 
		public static void disablePlatformNotifications() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, _disablePlatformNotifications8889); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNetworkAvailable8890; 
		public virtual void setNetworkAvailable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setNetworkAvailable8890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setNetworkAvailable8890, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _savePicture8891; 
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _savePicture8891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _savePicture8891, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restorePicture8892; 
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _restorePicture8892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _restorePicture8892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadUrl8893; 
		public virtual void loadUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _loadUrl8893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _loadUrl8893, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postUrl8894; 
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _postUrl8894, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _postUrl8894, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadData8895; 
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _loadData8895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _loadData8895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDataWithBaseURL8896; 
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _loadDataWithBaseURL8896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _loadDataWithBaseURL8896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopLoading8897; 
		public virtual void stopLoading() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _stopLoading8897); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _stopLoading8897); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoBack8898; 
		public virtual bool canGoBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _canGoBack8898); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _canGoBack8898); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goBack8899; 
		public virtual void goBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _goBack8899); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _goBack8899); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoForward8900; 
		public virtual bool canGoForward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _canGoForward8900); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _canGoForward8900); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goForward8901; 
		public virtual void goForward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _goForward8901); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _goForward8901); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoBackOrForward8902; 
		public virtual bool canGoBackOrForward(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _canGoBackOrForward8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _canGoBackOrForward8902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goBackOrForward8903; 
		public virtual void goBackOrForward(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _goBackOrForward8903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _goBackOrForward8903, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageUp8904; 
		public virtual bool pageUp(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _pageUp8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _pageUp8904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageDown8905; 
		public virtual bool pageDown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _pageDown8905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _pageDown8905, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearView8906; 
		public virtual void clearView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearView8906); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearView8906); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _capturePicture8907; 
		public virtual android.graphics.Picture capturePicture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallObjectMethodPtr(this, _capturePicture8907)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _capturePicture8907)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScale8908; 
		public virtual float getScale() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallFloatMethod(this, _getScale8908); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.webkit.WebView.staticClass, _getScale8908); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInitialScale8909; 
		public virtual void setInitialScale(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setInitialScale8909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setInitialScale8909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeZoomPicker8910; 
		public virtual void invokeZoomPicker() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _invokeZoomPicker8910); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _invokeZoomPicker8910); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHitTestResult8911; 
		public virtual android.webkit.WebView.HitTestResult getHitTestResult() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallObjectMethodPtr(this, _getHitTestResult8911)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getHitTestResult8911)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusNodeHref8912; 
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _requestFocusNodeHref8912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _requestFocusNodeHref8912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestImageRef8913; 
		public virtual void requestImageRef(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _requestImageRef8913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _requestImageRef8913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl8914; 
		public virtual java.lang.String getOriginalUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getOriginalUrl8914)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getOriginalUrl8914)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon8915; 
		public virtual android.graphics.Bitmap getFavicon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _getFavicon8915)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getFavicon8915)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentHeight8916; 
		public virtual int getContentHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _getContentHeight8916); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _getContentHeight8916); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pauseTimers8917; 
		public virtual void pauseTimers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _pauseTimers8917); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _pauseTimers8917); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resumeTimers8918; 
		public virtual void resumeTimers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _resumeTimers8918); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _resumeTimers8918); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData8919; 
		public virtual void clearFormData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearFormData8919); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearFormData8919); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearSslPreferences8920; 
		public virtual void clearSslPreferences() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearSslPreferences8920); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearSslPreferences8920); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBackForwardList8921; 
		public virtual android.webkit.WebBackForwardList copyBackForwardList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, _copyBackForwardList8921)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _copyBackForwardList8921)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findNext8922; 
		public virtual void findNext(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _findNext8922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _findNext8922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findAll8923; 
		public virtual int findAll(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, _findAll8923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.WebView.staticClass, _findAll8923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findAddress8924; 
		public static java.lang.String findAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, _findAddress8924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMatches8925; 
		public virtual void clearMatches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _clearMatches8925); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _clearMatches8925); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _documentHasImages8926; 
		public virtual void documentHasImages(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _documentHasImages8926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _documentHasImages8926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPictureListener8927; 
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setPictureListener8927, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setPictureListener8927, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addJavascriptInterface8928; 
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _addJavascriptInterface8928, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _addJavascriptInterface8928, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSettings8929; 
		public virtual android.webkit.WebSettings getSettings() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallObjectMethodPtr(this, _getSettings8929)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getSettings8929)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginList8930; 
		public static android.webkit.PluginList getPluginList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginList>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, _getPluginList8930)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _refreshPlugins8931; 
		public virtual void refreshPlugins(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _refreshPlugins8931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _refreshPlugins8931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMapTrackballToArrowKeys8932; 
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _setMapTrackballToArrowKeys8932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _setMapTrackballToArrowKeys8932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flingScroll8933; 
		public virtual void flingScroll(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _flingScroll8933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _flingScroll8933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls8934; 
		public virtual android.view.View getZoomControls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getZoomControls8934)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.WebView.staticClass, _getZoomControls8934)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _zoomIn8935; 
		public virtual bool zoomIn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _zoomIn8935); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _zoomIn8935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _zoomOut8936; 
		public virtual bool zoomOut() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, _zoomOut8936); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebView.staticClass, _zoomOut8936); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debugDump8937; 
		public virtual void debugDump() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, _debugDump8937); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebView.staticClass, _debugDump8937); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView8938; 
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, _WebView8938, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView8939; 
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, _WebView8939, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView8940; 
		public WebView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, _WebView8940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static java.lang.String SCHEME_TEL
		{ 
			get 
			{ 
				return "tel:"; 
			} 
		} 
		public static java.lang.String SCHEME_MAILTO
		{ 
			get 
			{ 
				return "mailto:"; 
			} 
		} 
		public static java.lang.String SCHEME_GEO
		{ 
			get 
			{ 
				return "geo:0,0?q="; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebView.staticClass = @__class; 
			global::android.webkit.WebView._destroy8838 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "destroy", "()V"); 
			global::android.webkit.WebView._freeMemory8839 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "freeMemory", "()V"); 
			global::android.webkit.WebView._getCertificate8840 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;"); 
			global::android.webkit.WebView._clearCache8841 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V"); 
			global::android.webkit.WebView._onKeyDown8842 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._onKeyUp8843 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._onTouchEvent8844 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.webkit.WebView._onTrackballEvent8845 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.webkit.WebView._onWindowFocusChanged8846 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.webkit.WebView._onAttachedToWindow8847 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.webkit.WebView._onDetachedFromWindow8848 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.webkit.WebView._dispatchKeyEvent8849 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._getTitle8850 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._performLongClick8851 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "performLongClick", "()Z"); 
			global::android.webkit.WebView._onFocusChanged8852 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.webkit.WebView._requestFocus8853 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.webkit.WebView._onScrollChanged8854 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.webkit.WebView._onSizeChanged8855 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.webkit.WebView._setLayoutParams8856 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.webkit.WebView._computeScroll8857 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeScroll", "()V"); 
			global::android.webkit.WebView._setScrollBarStyle8858 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V"); 
			global::android.webkit.WebView._computeHorizontalScrollRange8859 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollRange8860 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollOffset8861 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollExtent8862 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.webkit.WebView._onDraw8863 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.webkit.WebView._setBackgroundColor8864 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V"); 
			global::android.webkit.WebView._onMeasure8865 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V"); 
			global::android.webkit.WebView._requestChildRectangleOnScreen8866 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.webkit.WebView._drawChild8867 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.webkit.WebView._getProgress8868 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getProgress", "()I"); 
			global::android.webkit.WebView._onChildViewAdded8869 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._onChildViewRemoved8870 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._getUrl8871 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._saveState8872 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._restoreState8873 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._clearHistory8874 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearHistory", "()V"); 
			global::android.webkit.WebView._reload8875 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "reload", "()V"); 
			global::android.webkit.WebView._onGlobalFocusChanged8876 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._setWebViewClient8877 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V"); 
			global::android.webkit.WebView._setWebChromeClient8878 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V"); 
			global::android.webkit.WebView._setDownloadListener8879 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V"); 
			global::android.webkit.WebView._setHorizontalScrollbarOverlay8880 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V"); 
			global::android.webkit.WebView._setVerticalScrollbarOverlay8881 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V"); 
			global::android.webkit.WebView._overlayHorizontalScrollbar8882 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z"); 
			global::android.webkit.WebView._overlayVerticalScrollbar8883 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z"); 
			global::android.webkit.WebView._setCertificate8884 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V"); 
			global::android.webkit.WebView._savePassword8885 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._setHttpAuthUsernamePassword8886 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._getHttpAuthUsernamePassword8887 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.webkit.WebView._enablePlatformNotifications8888 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V"); 
			global::android.webkit.WebView._disablePlatformNotifications8889 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V"); 
			global::android.webkit.WebView._setNetworkAvailable8890 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V"); 
			global::android.webkit.WebView._savePicture8891 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z"); 
			global::android.webkit.WebView._restorePicture8892 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z"); 
			global::android.webkit.WebView._loadUrl8893 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebView._postUrl8894 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V"); 
			global::android.webkit.WebView._loadData8895 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._loadDataWithBaseURL8896 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._stopLoading8897 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "stopLoading", "()V"); 
			global::android.webkit.WebView._canGoBack8898 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBack", "()Z"); 
			global::android.webkit.WebView._goBack8899 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBack", "()V"); 
			global::android.webkit.WebView._canGoForward8900 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoForward", "()Z"); 
			global::android.webkit.WebView._goForward8901 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goForward", "()V"); 
			global::android.webkit.WebView._canGoBackOrForward8902 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z"); 
			global::android.webkit.WebView._goBackOrForward8903 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V"); 
			global::android.webkit.WebView._pageUp8904 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z"); 
			global::android.webkit.WebView._pageDown8905 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z"); 
			global::android.webkit.WebView._clearView8906 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearView", "()V"); 
			global::android.webkit.WebView._capturePicture8907 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;"); 
			global::android.webkit.WebView._getScale8908 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getScale", "()F"); 
			global::android.webkit.WebView._setInitialScale8909 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V"); 
			global::android.webkit.WebView._invokeZoomPicker8910 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V"); 
			global::android.webkit.WebView._getHitTestResult8911 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;"); 
			global::android.webkit.WebView._requestFocusNodeHref8912 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._requestImageRef8913 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._getOriginalUrl8914 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._getFavicon8915 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;"); 
			global::android.webkit.WebView._getContentHeight8916 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getContentHeight", "()I"); 
			global::android.webkit.WebView._pauseTimers8917 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pauseTimers", "()V"); 
			global::android.webkit.WebView._resumeTimers8918 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "resumeTimers", "()V"); 
			global::android.webkit.WebView._clearFormData8919 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearFormData", "()V"); 
			global::android.webkit.WebView._clearSslPreferences8920 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V"); 
			global::android.webkit.WebView._copyBackForwardList8921 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._findNext8922 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findNext", "(Z)V"); 
			global::android.webkit.WebView._findAll8923 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I"); 
			global::android.webkit.WebView._findAddress8924 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.WebView._clearMatches8925 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearMatches", "()V"); 
			global::android.webkit.WebView._documentHasImages8926 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._setPictureListener8927 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V"); 
			global::android.webkit.WebView._addJavascriptInterface8928 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._getSettings8929 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;"); 
			global::android.webkit.WebView._getPluginList8930 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;"); 
			global::android.webkit.WebView._refreshPlugins8931 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V"); 
			global::android.webkit.WebView._setMapTrackballToArrowKeys8932 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V"); 
			global::android.webkit.WebView._flingScroll8933 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V"); 
			global::android.webkit.WebView._getZoomControls8934 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;"); 
			global::android.webkit.WebView._zoomIn8935 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomIn", "()Z"); 
			global::android.webkit.WebView._zoomOut8936 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomOut", "()Z"); 
			global::android.webkit.WebView._debugDump8937 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "debugDump", "()V"); 
			global::android.webkit.WebView._WebView8938 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.webkit.WebView._WebView8939 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.webkit.WebView._WebView8940 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
