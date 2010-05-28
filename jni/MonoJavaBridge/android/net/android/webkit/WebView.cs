namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebView : android.widget.AbsoluteLayout, android.view.ViewTreeObserver.OnGlobalFocusChangeListener, android.view.ViewGroup.OnHierarchyChangeListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static WebView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebView.HitTestResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getType9526; 
			public virtual int getType() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.HitTestResult)) 
					return @__env.CallIntMethod(this, global::android.webkit.WebView.HitTestResult._getType9526); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType9526); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getExtra9527; 
			public virtual global::java.lang.String getExtra() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.HitTestResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView.HitTestResult._getExtra9527)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra9527)); 
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
				global::android.webkit.WebView.HitTestResult._getType9526 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I"); 
				global::android.webkit.WebView.HitTestResult._getExtra9527 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PictureListener 
		{ 
			void onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1); 
		} 

		public partial class PictureListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __PictureListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __PictureListener : java.lang.Object, PictureListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __PictureListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebView.__PictureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.webkit.WebView.__PictureListener(@__env); 
				} 
			} 
			internal __PictureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onNewPicture9528; 
			 void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.__PictureListener)) 
					@__env.CallVoidMethod(this, global::android.webkit.WebView.__PictureListener._onNewPicture9528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.__PictureListener.staticClass, global::android.webkit.WebView.__PictureListener._onNewPicture9528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebView.__PictureListener.staticClass = @__class; 
				global::android.webkit.WebView.__PictureListener._onNewPicture9528 = @__env.GetMethodID(global::android.webkit.WebView.__PictureListener.staticClass, "android.webkit.WebView.PictureListener.onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class WebViewTransport : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static WebViewTransport() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.WebView.WebViewTransport), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _setWebView9529; 
			public virtual void setWebView(android.webkit.WebView arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.WebViewTransport)) 
					@__env.CallVoidMethod(this, global::android.webkit.WebView.WebViewTransport._setWebView9529, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView9529, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getWebView9530; 
			public virtual global::android.webkit.WebView getWebView() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.webkit.WebView.WebViewTransport)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView.WebViewTransport._getWebView9530)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView9530)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _WebViewTransport9531; 
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport9531, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.webkit.WebView.WebViewTransport.staticClass = @__class; 
				global::android.webkit.WebView.WebViewTransport._setWebView9529 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V"); 
				global::android.webkit.WebView.WebViewTransport._getWebView9530 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;"); 
				global::android.webkit.WebView.WebViewTransport._WebViewTransport9531 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _destroy9532; 
		public virtual void destroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._destroy9532); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy9532); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeMemory9533; 
		public virtual void freeMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._freeMemory9533); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory9533); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCertificate9534; 
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getCertificate9534)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate9534)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearCache9535; 
		public virtual void clearCache(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearCache9535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache9535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown9536; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onKeyDown9536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown9536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp9537; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onKeyUp9537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp9537, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent9538; 
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onTouchEvent9538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent9538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent9539; 
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onTrackballEvent9539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent9539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged9540; 
		public override void onWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onWindowFocusChanged9540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged9540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow9541; 
		protected override void onAttachedToWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onAttachedToWindow9541); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow9541); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow9542; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onDetachedFromWindow9542); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow9542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9543; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._dispatchKeyEvent9543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent9543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle9544; 
		public virtual global::java.lang.String getTitle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getTitle9544)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle9544)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick9545; 
		public override bool performLongClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._performLongClick9545); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick9545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged9546; 
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onFocusChanged9546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged9546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus9547; 
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._requestFocus9547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus9547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged9548; 
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onScrollChanged9548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged9548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged9549; 
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onSizeChanged9549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged9549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams9550; 
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setLayoutParams9550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams9550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll9551; 
		public override void computeScroll() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._computeScroll9551); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll9551); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle9552; 
		public override void setScrollBarStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setScrollBarStyle9552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle9552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange9553; 
		protected override int computeHorizontalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeHorizontalScrollRange9553); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange9553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange9554; 
		protected override int computeVerticalScrollRange() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollRange9554); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange9554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset9555; 
		protected override int computeVerticalScrollOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollOffset9555); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset9555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent9556; 
		protected override int computeVerticalScrollExtent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollExtent9556); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent9556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9557; 
		protected override void onDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onDraw9557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw9557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor9558; 
		public override void setBackgroundColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setBackgroundColor9558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor9558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9559; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onMeasure9559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure9559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9560; 
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._requestChildRectangleOnScreen9560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen9560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild9561; 
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._drawChild9561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild9561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress9562; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._getProgress9562); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress9562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewAdded9563; 
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onChildViewAdded9563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded9563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewRemoved9564; 
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onChildViewRemoved9564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved9564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl9565; 
		public virtual global::java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getUrl9565)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl9565)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveState9566; 
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._saveState9566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState9566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restoreState9567; 
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._restoreState9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState9567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearHistory9568; 
		public virtual void clearHistory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearHistory9568); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory9568); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reload9569; 
		public virtual void reload() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._reload9569); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload9569); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalFocusChanged9570; 
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onGlobalFocusChanged9570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged9570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebViewClient9571; 
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setWebViewClient9571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient9571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWebChromeClient9572; 
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setWebChromeClient9572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient9572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDownloadListener9573; 
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setDownloadListener9573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener9573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollbarOverlay9574; 
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setHorizontalScrollbarOverlay9574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay9574, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollbarOverlay9575; 
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setVerticalScrollbarOverlay9575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay9575, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _overlayHorizontalScrollbar9576; 
		public virtual bool overlayHorizontalScrollbar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._overlayHorizontalScrollbar9576); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar9576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _overlayVerticalScrollbar9577; 
		public virtual bool overlayVerticalScrollbar() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._overlayVerticalScrollbar9577); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar9577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCertificate9578; 
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setCertificate9578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate9578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _savePassword9579; 
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._savePassword9579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword9579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHttpAuthUsernamePassword9580; 
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setHttpAuthUsernamePassword9580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword9580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHttpAuthUsernamePassword9581; 
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{ 
			if (GetType() == typeof(android.webkit.WebView)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getHttpAuthUsernamePassword9581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword9581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enablePlatformNotifications9582; 
		public static void enablePlatformNotifications() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications9582); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _disablePlatformNotifications9583; 
		public static void disablePlatformNotifications() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications9583); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNetworkAvailable9584; 
		public virtual void setNetworkAvailable(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setNetworkAvailable9584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable9584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _savePicture9585; 
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._savePicture9585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture9585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restorePicture9586; 
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._restorePicture9586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture9586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadUrl9587; 
		public virtual void loadUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadUrl9587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl9587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postUrl9588; 
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._postUrl9588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl9588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadData9589; 
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadData9589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData9589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDataWithBaseURL9590; 
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadDataWithBaseURL9590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL9590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopLoading9591; 
		public virtual void stopLoading() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._stopLoading9591); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading9591); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoBack9592; 
		public virtual bool canGoBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoBack9592); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack9592); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goBack9593; 
		public virtual void goBack() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goBack9593); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack9593); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoForward9594; 
		public virtual bool canGoForward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoForward9594); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward9594); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goForward9595; 
		public virtual void goForward() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goForward9595); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward9595); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canGoBackOrForward9596; 
		public virtual bool canGoBackOrForward(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoBackOrForward9596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward9596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goBackOrForward9597; 
		public virtual void goBackOrForward(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goBackOrForward9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward9597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageUp9598; 
		public virtual bool pageUp(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._pageUp9598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp9598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pageDown9599; 
		public virtual bool pageDown(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._pageDown9599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown9599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearView9600; 
		public virtual void clearView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearView9600); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView9600); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _capturePicture9601; 
		public virtual global::android.graphics.Picture capturePicture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._capturePicture9601)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture9601)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScale9602; 
		public virtual float getScale() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallFloatMethod(this, global::android.webkit.WebView._getScale9602); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale9602); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInitialScale9603; 
		public virtual void setInitialScale(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setInitialScale9603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale9603, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeZoomPicker9604; 
		public virtual void invokeZoomPicker() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._invokeZoomPicker9604); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker9604); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHitTestResult9605; 
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getHitTestResult9605)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult9605)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusNodeHref9606; 
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._requestFocusNodeHref9606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref9606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestImageRef9607; 
		public virtual void requestImageRef(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._requestImageRef9607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef9607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl9608; 
		public virtual global::java.lang.String getOriginalUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getOriginalUrl9608)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl9608)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon9609; 
		public virtual global::android.graphics.Bitmap getFavicon() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getFavicon9609)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon9609)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentHeight9610; 
		public virtual int getContentHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._getContentHeight9610); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight9610); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pauseTimers9611; 
		public virtual void pauseTimers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._pauseTimers9611); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers9611); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resumeTimers9612; 
		public virtual void resumeTimers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._resumeTimers9612); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers9612); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData9613; 
		public virtual void clearFormData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearFormData9613); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData9613); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearSslPreferences9614; 
		public virtual void clearSslPreferences() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearSslPreferences9614); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences9614); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBackForwardList9615; 
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._copyBackForwardList9615)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList9615)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findNext9616; 
		public virtual void findNext(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._findNext9616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext9616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findAll9617; 
		public virtual int findAll(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallIntMethod(this, global::android.webkit.WebView._findAll9617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll9617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findAddress9618; 
		public static global::java.lang.String findAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress9618, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMatches9619; 
		public virtual void clearMatches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearMatches9619); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches9619); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _documentHasImages9620; 
		public virtual void documentHasImages(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._documentHasImages9620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages9620, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPictureListener9621; 
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setPictureListener9621, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener9621, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addJavascriptInterface9622; 
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._addJavascriptInterface9622, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface9622, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSettings9623; 
		public virtual global::android.webkit.WebSettings getSettings() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getSettings9623)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings9623)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPluginList9624; 
		public static global::android.webkit.PluginList getPluginList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginList>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList9624)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _refreshPlugins9625; 
		public virtual void refreshPlugins(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._refreshPlugins9625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins9625, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMapTrackballToArrowKeys9626; 
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setMapTrackballToArrowKeys9626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys9626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flingScroll9627; 
		public virtual void flingScroll(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._flingScroll9627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll9627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls9628; 
		public virtual global::android.view.View getZoomControls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getZoomControls9628)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls9628)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _zoomIn9629; 
		public virtual bool zoomIn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._zoomIn9629); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn9629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _zoomOut9630; 
		public virtual bool zoomOut() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._zoomOut9630); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut9630); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debugDump9631; 
		public virtual void debugDump() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebView)) 
				@__env.CallVoidMethod(this, global::android.webkit.WebView._debugDump9631); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump9631); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView9632; 
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView9632, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView9633; 
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView9633, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WebView9634; 
		public WebView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView9634, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static global::java.lang.String SCHEME_TEL
		{ 
			get 
			{ 
				return "tel:"; 
			} 
		} 
		public static global::java.lang.String SCHEME_MAILTO
		{ 
			get 
			{ 
				return "mailto:"; 
			} 
		} 
		public static global::java.lang.String SCHEME_GEO
		{ 
			get 
			{ 
				return "geo:0,0?q="; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebView.staticClass = @__class; 
			global::android.webkit.WebView._destroy9532 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "destroy", "()V"); 
			global::android.webkit.WebView._freeMemory9533 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "freeMemory", "()V"); 
			global::android.webkit.WebView._getCertificate9534 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;"); 
			global::android.webkit.WebView._clearCache9535 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V"); 
			global::android.webkit.WebView._onKeyDown9536 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._onKeyUp9537 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._onTouchEvent9538 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.webkit.WebView._onTrackballEvent9539 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.webkit.WebView._onWindowFocusChanged9540 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V"); 
			global::android.webkit.WebView._onAttachedToWindow9541 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V"); 
			global::android.webkit.WebView._onDetachedFromWindow9542 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.webkit.WebView._dispatchKeyEvent9543 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.webkit.WebView._getTitle9544 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._performLongClick9545 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "performLongClick", "()Z"); 
			global::android.webkit.WebView._onFocusChanged9546 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V"); 
			global::android.webkit.WebView._requestFocus9547 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.webkit.WebView._onScrollChanged9548 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V"); 
			global::android.webkit.WebView._onSizeChanged9549 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V"); 
			global::android.webkit.WebView._setLayoutParams9550 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.webkit.WebView._computeScroll9551 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeScroll", "()V"); 
			global::android.webkit.WebView._setScrollBarStyle9552 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V"); 
			global::android.webkit.WebView._computeHorizontalScrollRange9553 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollRange9554 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollOffset9555 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I"); 
			global::android.webkit.WebView._computeVerticalScrollExtent9556 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I"); 
			global::android.webkit.WebView._onDraw9557 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.webkit.WebView._setBackgroundColor9558 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V"); 
			global::android.webkit.WebView._onMeasure9559 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V"); 
			global::android.webkit.WebView._requestChildRectangleOnScreen9560 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.webkit.WebView._drawChild9561 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.webkit.WebView._getProgress9562 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getProgress", "()I"); 
			global::android.webkit.WebView._onChildViewAdded9563 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._onChildViewRemoved9564 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._getUrl9565 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._saveState9566 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._restoreState9567 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._clearHistory9568 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearHistory", "()V"); 
			global::android.webkit.WebView._reload9569 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "reload", "()V"); 
			global::android.webkit.WebView._onGlobalFocusChanged9570 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.webkit.WebView._setWebViewClient9571 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V"); 
			global::android.webkit.WebView._setWebChromeClient9572 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V"); 
			global::android.webkit.WebView._setDownloadListener9573 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V"); 
			global::android.webkit.WebView._setHorizontalScrollbarOverlay9574 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V"); 
			global::android.webkit.WebView._setVerticalScrollbarOverlay9575 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V"); 
			global::android.webkit.WebView._overlayHorizontalScrollbar9576 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z"); 
			global::android.webkit.WebView._overlayVerticalScrollbar9577 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z"); 
			global::android.webkit.WebView._setCertificate9578 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V"); 
			global::android.webkit.WebView._savePassword9579 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._setHttpAuthUsernamePassword9580 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._getHttpAuthUsernamePassword9581 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;"); 
			global::android.webkit.WebView._enablePlatformNotifications9582 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V"); 
			global::android.webkit.WebView._disablePlatformNotifications9583 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V"); 
			global::android.webkit.WebView._setNetworkAvailable9584 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V"); 
			global::android.webkit.WebView._savePicture9585 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z"); 
			global::android.webkit.WebView._restorePicture9586 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z"); 
			global::android.webkit.WebView._loadUrl9587 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V"); 
			global::android.webkit.WebView._postUrl9588 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V"); 
			global::android.webkit.WebView._loadData9589 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._loadDataWithBaseURL9590 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._stopLoading9591 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "stopLoading", "()V"); 
			global::android.webkit.WebView._canGoBack9592 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBack", "()Z"); 
			global::android.webkit.WebView._goBack9593 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBack", "()V"); 
			global::android.webkit.WebView._canGoForward9594 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoForward", "()Z"); 
			global::android.webkit.WebView._goForward9595 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goForward", "()V"); 
			global::android.webkit.WebView._canGoBackOrForward9596 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z"); 
			global::android.webkit.WebView._goBackOrForward9597 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V"); 
			global::android.webkit.WebView._pageUp9598 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z"); 
			global::android.webkit.WebView._pageDown9599 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z"); 
			global::android.webkit.WebView._clearView9600 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearView", "()V"); 
			global::android.webkit.WebView._capturePicture9601 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;"); 
			global::android.webkit.WebView._getScale9602 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getScale", "()F"); 
			global::android.webkit.WebView._setInitialScale9603 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V"); 
			global::android.webkit.WebView._invokeZoomPicker9604 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V"); 
			global::android.webkit.WebView._getHitTestResult9605 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;"); 
			global::android.webkit.WebView._requestFocusNodeHref9606 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._requestImageRef9607 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._getOriginalUrl9608 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;"); 
			global::android.webkit.WebView._getFavicon9609 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;"); 
			global::android.webkit.WebView._getContentHeight9610 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getContentHeight", "()I"); 
			global::android.webkit.WebView._pauseTimers9611 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pauseTimers", "()V"); 
			global::android.webkit.WebView._resumeTimers9612 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "resumeTimers", "()V"); 
			global::android.webkit.WebView._clearFormData9613 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearFormData", "()V"); 
			global::android.webkit.WebView._clearSslPreferences9614 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V"); 
			global::android.webkit.WebView._copyBackForwardList9615 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;"); 
			global::android.webkit.WebView._findNext9616 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findNext", "(Z)V"); 
			global::android.webkit.WebView._findAll9617 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I"); 
			global::android.webkit.WebView._findAddress9618 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.WebView._clearMatches9619 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearMatches", "()V"); 
			global::android.webkit.WebView._documentHasImages9620 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V"); 
			global::android.webkit.WebView._setPictureListener9621 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V"); 
			global::android.webkit.WebView._addJavascriptInterface9622 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V"); 
			global::android.webkit.WebView._getSettings9623 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;"); 
			global::android.webkit.WebView._getPluginList9624 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;"); 
			global::android.webkit.WebView._refreshPlugins9625 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V"); 
			global::android.webkit.WebView._setMapTrackballToArrowKeys9626 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V"); 
			global::android.webkit.WebView._flingScroll9627 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V"); 
			global::android.webkit.WebView._getZoomControls9628 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;"); 
			global::android.webkit.WebView._zoomIn9629 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomIn", "()Z"); 
			global::android.webkit.WebView._zoomOut9630 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomOut", "()Z"); 
			global::android.webkit.WebView._debugDump9631 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "debugDump", "()V"); 
			global::android.webkit.WebView._WebView9632 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.webkit.WebView._WebView9633 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.webkit.WebView._WebView9634 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
