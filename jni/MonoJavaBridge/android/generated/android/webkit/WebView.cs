namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebView : android.widget.AbsoluteLayout, android.view.ViewTreeObserver.OnGlobalFocusChangeListener, android.view.ViewGroup.OnHierarchyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebView()
		{
			InitJNI();
		}
		protected WebView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class HitTestResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static HitTestResult()
			{
				InitJNI();
			}
			protected HitTestResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getType10563;
			public virtual int getType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getType10563);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType10563);
			}
			internal static global::MonoJavaBridge.MethodId _getExtra10564;
			public virtual global::java.lang.String getExtra() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getExtra10564)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra10564)) as java.lang.String;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.HitTestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$HitTestResult"));
				global::android.webkit.WebView.HitTestResult._getType10563 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I");
				global::android.webkit.WebView.HitTestResult._getExtra10564 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebView.PictureListener_))]
		public interface PictureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebView.PictureListener))]
		public sealed partial class PictureListener_ : java.lang.Object, PictureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PictureListener_()
			{
				InitJNI();
			}
			internal PictureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onNewPicture10565;
			 void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_._onNewPicture10565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_.staticClass, global::android.webkit.WebView.PictureListener_._onNewPicture10565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$PictureListener"));
				global::android.webkit.WebView.PictureListener_._onNewPicture10565 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListener_.staticClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WebViewTransport : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static WebViewTransport()
			{
				InitJNI();
			}
			protected WebViewTransport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setWebView10566;
			public virtual void setWebView(android.webkit.WebView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._setWebView10566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView10566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getWebView10567;
			public virtual global::android.webkit.WebView getWebView() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._getWebView10567)) as android.webkit.WebView;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView10567)) as android.webkit.WebView;
			}
			internal static global::MonoJavaBridge.MethodId _WebViewTransport10568;
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport10568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.WebViewTransport.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$WebViewTransport"));
				global::android.webkit.WebView.WebViewTransport._setWebView10566 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V");
				global::android.webkit.WebView.WebViewTransport._getWebView10567 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;");
				global::android.webkit.WebView.WebViewTransport._WebViewTransport10568 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize10569;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._finalize10569);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._finalize10569);
		}
		internal static global::MonoJavaBridge.MethodId _destroy10570;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._destroy10570);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy10570);
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory10571;
		public virtual void freeMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._freeMemory10571);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory10571);
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate10572;
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getCertificate10572)) as android.net.http.SslCertificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate10572)) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache10573;
		public virtual void clearCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearCache10573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache10573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown10574;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyDown10574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown10574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp10575;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyUp10575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp10575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent10576;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTouchEvent10576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent10576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent10577;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTrackballEvent10577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent10577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged10578;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onWindowFocusChanged10578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged10578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow10579;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onAttachedToWindow10579);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow10579);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow10580;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDetachedFromWindow10580);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow10580);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent10581;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._dispatchKeyEvent10581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent10581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTitle10582;
		public virtual global::java.lang.String getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getTitle10582)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle10582)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick10583;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._performLongClick10583);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick10583);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged10584;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onFocusChanged10584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged10584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus10585;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestFocus10585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus10585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection10586;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._onCreateInputConnection10586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onCreateInputConnection10586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged10587;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onScrollChanged10587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged10587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged10588;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onSizeChanged10588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged10588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams10589;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setLayoutParams10589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams10589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll10590;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._computeScroll10590);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll10590);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle10591;
		public override void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setScrollBarStyle10591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle10591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange10592;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeHorizontalScrollRange10592);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange10592);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange10593;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollRange10593);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange10593);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset10594;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollOffset10594);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset10594);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent10595;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollExtent10595);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent10595);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw10596;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDraw10596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw10596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor10597;
		public override void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setBackgroundColor10597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor10597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure10598;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onMeasure10598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure10598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen10599;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestChildRectangleOnScreen10599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen10599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild10600;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._drawChild10600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild10600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getProgress10601;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getProgress10601);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress10601);
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewAdded10602;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewAdded10602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded10602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewRemoved10603;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewRemoved10603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved10603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUrl10604;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getUrl10604)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl10604)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState10605;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._saveState10605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState10605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState10606;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._restoreState10606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState10606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory10607;
		public virtual void clearHistory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearHistory10607);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory10607);
		}
		internal static global::MonoJavaBridge.MethodId _reload10608;
		public virtual void reload() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._reload10608);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload10608);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged10609;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onGlobalFocusChanged10609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged10609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl10610;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getOriginalUrl10610)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl10610)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon10611;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getFavicon10611)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon10611)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollbarOverlay10612;
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHorizontalScrollbarOverlay10612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay10612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollbarOverlay10613;
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setVerticalScrollbarOverlay10613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay10613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _overlayHorizontalScrollbar10614;
		public virtual bool overlayHorizontalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayHorizontalScrollbar10614);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar10614);
		}
		internal static global::MonoJavaBridge.MethodId _overlayVerticalScrollbar10615;
		public virtual bool overlayVerticalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayVerticalScrollbar10615);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar10615);
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate10616;
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setCertificate10616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate10616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePassword10617;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._savePassword10617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword10617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpAuthUsernamePassword10618;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHttpAuthUsernamePassword10618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword10618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpAuthUsernamePassword10619;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHttpAuthUsernamePassword10619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword10619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _enablePlatformNotifications10620;
		public static void enablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications10620);
		}
		internal static global::MonoJavaBridge.MethodId _disablePlatformNotifications10621;
		public static void disablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications10621);
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkAvailable10622;
		public virtual void setNetworkAvailable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setNetworkAvailable10622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable10622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePicture10623;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._savePicture10623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture10623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restorePicture10624;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._restorePicture10624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture10624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl10625;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl10625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl10625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl10626;
		public virtual void loadUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl10626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl10626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postUrl10627;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._postUrl10627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl10627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadData10628;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadData10628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData10628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _loadDataWithBaseURL10629;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadDataWithBaseURL10629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL10629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _stopLoading10630;
		public virtual void stopLoading() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._stopLoading10630);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading10630);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBack10631;
		public virtual bool canGoBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBack10631);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack10631);
		}
		internal static global::MonoJavaBridge.MethodId _goBack10632;
		public virtual void goBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBack10632);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack10632);
		}
		internal static global::MonoJavaBridge.MethodId _canGoForward10633;
		public virtual bool canGoForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoForward10633);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward10633);
		}
		internal static global::MonoJavaBridge.MethodId _goForward10634;
		public virtual void goForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goForward10634);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward10634);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBackOrForward10635;
		public virtual bool canGoBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBackOrForward10635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward10635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _goBackOrForward10636;
		public virtual void goBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBackOrForward10636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward10636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageUp10637;
		public virtual bool pageUp(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageUp10637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp10637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageDown10638;
		public virtual bool pageDown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageDown10638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown10638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearView10639;
		public virtual void clearView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearView10639);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView10639);
		}
		internal static global::MonoJavaBridge.MethodId _capturePicture10640;
		public virtual global::android.graphics.Picture capturePicture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._capturePicture10640)) as android.graphics.Picture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture10640)) as android.graphics.Picture;
		}
		internal static global::MonoJavaBridge.MethodId _getScale10641;
		public virtual float getScale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.webkit.WebView._getScale10641);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale10641);
		}
		internal static global::MonoJavaBridge.MethodId _setInitialScale10642;
		public virtual void setInitialScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setInitialScale10642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale10642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeZoomPicker10643;
		public virtual void invokeZoomPicker() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._invokeZoomPicker10643);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker10643);
		}
		internal static global::MonoJavaBridge.MethodId _getHitTestResult10644;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHitTestResult10644)) as android.webkit.WebView.HitTestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult10644)) as android.webkit.WebView.HitTestResult;
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusNodeHref10645;
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestFocusNodeHref10645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref10645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestImageRef10646;
		public virtual void requestImageRef(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestImageRef10646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef10646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentHeight10647;
		public virtual int getContentHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getContentHeight10647);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight10647);
		}
		internal static global::MonoJavaBridge.MethodId _pauseTimers10648;
		public virtual void pauseTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._pauseTimers10648);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers10648);
		}
		internal static global::MonoJavaBridge.MethodId _resumeTimers10649;
		public virtual void resumeTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._resumeTimers10649);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers10649);
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData10650;
		public virtual void clearFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearFormData10650);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData10650);
		}
		internal static global::MonoJavaBridge.MethodId _clearSslPreferences10651;
		public virtual void clearSslPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearSslPreferences10651);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences10651);
		}
		internal static global::MonoJavaBridge.MethodId _copyBackForwardList10652;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._copyBackForwardList10652)) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList10652)) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _findNext10653;
		public virtual void findNext(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._findNext10653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext10653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAll10654;
		public virtual int findAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._findAll10654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll10654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAddress10655;
		public static global::java.lang.String findAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress10655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearMatches10656;
		public virtual void clearMatches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearMatches10656);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches10656);
		}
		internal static global::MonoJavaBridge.MethodId _documentHasImages10657;
		public virtual void documentHasImages(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._documentHasImages10657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages10657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebViewClient10658;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebViewClient10658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient10658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDownloadListener10659;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setDownloadListener10659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener10659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebChromeClient10660;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebChromeClient10660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient10660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPictureListener10661;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setPictureListener10661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener10661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addJavascriptInterface10662;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._addJavascriptInterface10662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface10662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSettings10663;
		public virtual global::android.webkit.WebSettings getSettings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getSettings10663)) as android.webkit.WebSettings;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings10663)) as android.webkit.WebSettings;
		}
		internal static global::MonoJavaBridge.MethodId _getPluginList10664;
		public static global::android.webkit.PluginList getPluginList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList10664)) as android.webkit.PluginList;
		}
		internal static global::MonoJavaBridge.MethodId _refreshPlugins10665;
		public virtual void refreshPlugins(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._refreshPlugins10665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins10665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _emulateShiftHeld10666;
		public virtual void emulateShiftHeld() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._emulateShiftHeld10666);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._emulateShiftHeld10666);
		}
		internal static global::MonoJavaBridge.MethodId _setMapTrackballToArrowKeys10667;
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setMapTrackballToArrowKeys10667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys10667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flingScroll10668;
		public virtual void flingScroll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._flingScroll10668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll10668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls10669;
		public virtual global::android.view.View getZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getZoomControls10669)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls10669)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _zoomIn10670;
		public virtual bool zoomIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomIn10670);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn10670);
		}
		internal static global::MonoJavaBridge.MethodId _zoomOut10671;
		public virtual bool zoomOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomOut10671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut10671);
		}
		internal static global::MonoJavaBridge.MethodId _debugDump10672;
		public virtual void debugDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._debugDump10672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump10672);
		}
		internal static global::MonoJavaBridge.MethodId _WebView10673;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView10674;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView10675;
		public WebView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView"));
			global::android.webkit.WebView._finalize10569 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "finalize", "()V");
			global::android.webkit.WebView._destroy10570 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "destroy", "()V");
			global::android.webkit.WebView._freeMemory10571 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "freeMemory", "()V");
			global::android.webkit.WebView._getCertificate10572 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.webkit.WebView._clearCache10573 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V");
			global::android.webkit.WebView._onKeyDown10574 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onKeyUp10575 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onTouchEvent10576 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onTrackballEvent10577 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onWindowFocusChanged10578 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.webkit.WebView._onAttachedToWindow10579 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V");
			global::android.webkit.WebView._onDetachedFromWindow10580 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V");
			global::android.webkit.WebView._dispatchKeyEvent10581 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._getTitle10582 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebView._performLongClick10583 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "performLongClick", "()Z");
			global::android.webkit.WebView._onFocusChanged10584 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.webkit.WebView._requestFocus10585 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.webkit.WebView._onCreateInputConnection10586 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.webkit.WebView._onScrollChanged10587 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V");
			global::android.webkit.WebView._onSizeChanged10588 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.webkit.WebView._setLayoutParams10589 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.webkit.WebView._computeScroll10590 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeScroll", "()V");
			global::android.webkit.WebView._setScrollBarStyle10591 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V");
			global::android.webkit.WebView._computeHorizontalScrollRange10592 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollRange10593 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollOffset10594 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.webkit.WebView._computeVerticalScrollExtent10595 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.webkit.WebView._onDraw10596 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.webkit.WebView._setBackgroundColor10597 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V");
			global::android.webkit.WebView._onMeasure10598 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V");
			global::android.webkit.WebView._requestChildRectangleOnScreen10599 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.webkit.WebView._drawChild10600 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.webkit.WebView._getProgress10601 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getProgress", "()I");
			global::android.webkit.WebView._onChildViewAdded10602 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._onChildViewRemoved10603 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getUrl10604 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._saveState10605 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._restoreState10606 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._clearHistory10607 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearHistory", "()V");
			global::android.webkit.WebView._reload10608 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "reload", "()V");
			global::android.webkit.WebView._onGlobalFocusChanged10609 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getOriginalUrl10610 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._getFavicon10611 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebView._setHorizontalScrollbarOverlay10612 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._setVerticalScrollbarOverlay10613 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._overlayHorizontalScrollbar10614 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z");
			global::android.webkit.WebView._overlayVerticalScrollbar10615 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z");
			global::android.webkit.WebView._setCertificate10616 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V");
			global::android.webkit.WebView._savePassword10617 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._setHttpAuthUsernamePassword10618 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._getHttpAuthUsernamePassword10619 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.webkit.WebView._enablePlatformNotifications10620 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			global::android.webkit.WebView._disablePlatformNotifications10621 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			global::android.webkit.WebView._setNetworkAvailable10622 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V");
			global::android.webkit.WebView._savePicture10623 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._restorePicture10624 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._loadUrl10625 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.webkit.WebView._loadUrl10626 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebView._postUrl10627 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V");
			global::android.webkit.WebView._loadData10628 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._loadDataWithBaseURL10629 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._stopLoading10630 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "stopLoading", "()V");
			global::android.webkit.WebView._canGoBack10631 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBack", "()Z");
			global::android.webkit.WebView._goBack10632 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBack", "()V");
			global::android.webkit.WebView._canGoForward10633 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoForward", "()Z");
			global::android.webkit.WebView._goForward10634 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goForward", "()V");
			global::android.webkit.WebView._canGoBackOrForward10635 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z");
			global::android.webkit.WebView._goBackOrForward10636 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V");
			global::android.webkit.WebView._pageUp10637 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z");
			global::android.webkit.WebView._pageDown10638 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z");
			global::android.webkit.WebView._clearView10639 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearView", "()V");
			global::android.webkit.WebView._capturePicture10640 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;");
			global::android.webkit.WebView._getScale10641 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getScale", "()F");
			global::android.webkit.WebView._setInitialScale10642 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V");
			global::android.webkit.WebView._invokeZoomPicker10643 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V");
			global::android.webkit.WebView._getHitTestResult10644 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;");
			global::android.webkit.WebView._requestFocusNodeHref10645 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._requestImageRef10646 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._getContentHeight10647 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getContentHeight", "()I");
			global::android.webkit.WebView._pauseTimers10648 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pauseTimers", "()V");
			global::android.webkit.WebView._resumeTimers10649 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "resumeTimers", "()V");
			global::android.webkit.WebView._clearFormData10650 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearFormData", "()V");
			global::android.webkit.WebView._clearSslPreferences10651 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V");
			global::android.webkit.WebView._copyBackForwardList10652 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._findNext10653 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findNext", "(Z)V");
			global::android.webkit.WebView._findAll10654 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I");
			global::android.webkit.WebView._findAddress10655 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.WebView._clearMatches10656 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearMatches", "()V");
			global::android.webkit.WebView._documentHasImages10657 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._setWebViewClient10658 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V");
			global::android.webkit.WebView._setDownloadListener10659 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V");
			global::android.webkit.WebView._setWebChromeClient10660 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V");
			global::android.webkit.WebView._setPictureListener10661 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V");
			global::android.webkit.WebView._addJavascriptInterface10662 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V");
			global::android.webkit.WebView._getSettings10663 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;");
			global::android.webkit.WebView._getPluginList10664 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			global::android.webkit.WebView._refreshPlugins10665 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V");
			global::android.webkit.WebView._emulateShiftHeld10666 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V");
			global::android.webkit.WebView._setMapTrackballToArrowKeys10667 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V");
			global::android.webkit.WebView._flingScroll10668 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V");
			global::android.webkit.WebView._getZoomControls10669 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.webkit.WebView._zoomIn10670 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomIn", "()Z");
			global::android.webkit.WebView._zoomOut10671 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomOut", "()Z");
			global::android.webkit.WebView._debugDump10672 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "debugDump", "()V");
			global::android.webkit.WebView._WebView10673 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.webkit.WebView._WebView10674 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.webkit.WebView._WebView10675 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
