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
			public new int Type
			{
				get
				{
					return getType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getType11109;
			public virtual int getType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getType11109);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType11109);
			}
			public new global::java.lang.String Extra
			{
				get
				{
					return getExtra();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExtra11110;
			public virtual global::java.lang.String getExtra() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getExtra11110)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra11110)) as java.lang.String;
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
				global::android.webkit.WebView.HitTestResult._getType11109 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I");
				global::android.webkit.WebView.HitTestResult._getExtra11110 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;");
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
			internal static global::MonoJavaBridge.MethodId _onNewPicture11111;
			 void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_._onNewPicture11111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_.staticClass, global::android.webkit.WebView.PictureListener_._onNewPicture11111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$PictureListener"));
				global::android.webkit.WebView.PictureListener_._onNewPicture11111 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListener_.staticClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
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
			internal static global::MonoJavaBridge.MethodId _setWebView11112;
			public virtual void setWebView(android.webkit.WebView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._setWebView11112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView11112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::android.webkit.WebView WebView
			{
				get
				{
					return getWebView();
				}
				set
				{
					setWebView(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _getWebView11113;
			public virtual global::android.webkit.WebView getWebView() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._getWebView11113)) as android.webkit.WebView;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView11113)) as android.webkit.WebView;
			}
			internal static global::MonoJavaBridge.MethodId _WebViewTransport11114;
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport11114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.WebViewTransport.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$WebViewTransport"));
				global::android.webkit.WebView.WebViewTransport._setWebView11112 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V");
				global::android.webkit.WebView.WebViewTransport._getWebView11113 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;");
				global::android.webkit.WebView.WebViewTransport._WebViewTransport11114 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize11115;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._finalize11115);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._finalize11115);
		}
		internal static global::MonoJavaBridge.MethodId _destroy11116;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._destroy11116);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy11116);
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory11117;
		public virtual void freeMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._freeMemory11117);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory11117);
		}
		public new global::android.net.http.SslCertificate Certificate
		{
			get
			{
				return getCertificate();
			}
			set
			{
				setCertificate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertificate11118;
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getCertificate11118)) as android.net.http.SslCertificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate11118)) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache11119;
		public virtual void clearCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearCache11119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache11119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown11120;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyDown11120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown11120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11121;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyUp11121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp11121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent11122;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTouchEvent11122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent11122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent11123;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTrackballEvent11123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent11123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged11124;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onWindowFocusChanged11124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged11124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow11125;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onAttachedToWindow11125);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow11125);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow11126;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDetachedFromWindow11126);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow11126);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent11127;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._dispatchKeyEvent11127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent11127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle11128;
		public virtual global::java.lang.String getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getTitle11128)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle11128)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick11129;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._performLongClick11129);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick11129);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11130;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onFocusChanged11130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged11130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus11131;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestFocus11131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus11131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection11132;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._onCreateInputConnection11132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onCreateInputConnection11132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged11133;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onScrollChanged11133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged11133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged11134;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onSizeChanged11134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged11134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams11135;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setLayoutParams11135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams11135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll11136;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._computeScroll11136);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll11136);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle11137;
		public override void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setScrollBarStyle11137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle11137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange11138;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeHorizontalScrollRange11138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange11138);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange11139;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollRange11139);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange11139);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset11140;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollOffset11140);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset11140);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent11141;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollExtent11141);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent11141);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw11142;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDraw11142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw11142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor11143;
		public override void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setBackgroundColor11143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor11143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11144;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onMeasure11144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure11144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen11145;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestChildRectangleOnScreen11145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen11145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild11146;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._drawChild11146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild11146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress11147;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getProgress11147);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress11147);
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewAdded11148;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewAdded11148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded11148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewRemoved11149;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewRemoved11149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved11149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl11150;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getUrl11150)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl11150)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState11151;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._saveState11151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState11151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState11152;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._restoreState11152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState11152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory11153;
		public virtual void clearHistory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearHistory11153);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory11153);
		}
		internal static global::MonoJavaBridge.MethodId _reload11154;
		public virtual void reload() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._reload11154);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload11154);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged11155;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onGlobalFocusChanged11155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged11155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl11156;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getOriginalUrl11156)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl11156)) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon11157;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getFavicon11157)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon11157)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollbarOverlay11158;
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHorizontalScrollbarOverlay11158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay11158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollbarOverlay11159;
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setVerticalScrollbarOverlay11159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay11159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _overlayHorizontalScrollbar11160;
		public virtual bool overlayHorizontalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayHorizontalScrollbar11160);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar11160);
		}
		internal static global::MonoJavaBridge.MethodId _overlayVerticalScrollbar11161;
		public virtual bool overlayVerticalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayVerticalScrollbar11161);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar11161);
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate11162;
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setCertificate11162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate11162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePassword11163;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._savePassword11163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword11163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpAuthUsernamePassword11164;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHttpAuthUsernamePassword11164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword11164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpAuthUsernamePassword11165;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHttpAuthUsernamePassword11165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword11165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _enablePlatformNotifications11166;
		public static void enablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications11166);
		}
		internal static global::MonoJavaBridge.MethodId _disablePlatformNotifications11167;
		public static void disablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications11167);
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkAvailable11168;
		public virtual void setNetworkAvailable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setNetworkAvailable11168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable11168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePicture11169;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._savePicture11169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture11169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restorePicture11170;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._restorePicture11170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture11170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl11171;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl11171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl11171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl11172;
		public virtual void loadUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl11172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl11172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postUrl11173;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._postUrl11173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl11173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadData11174;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadData11174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData11174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _loadDataWithBaseURL11175;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadDataWithBaseURL11175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL11175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _stopLoading11176;
		public virtual void stopLoading() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._stopLoading11176);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading11176);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBack11177;
		public virtual bool canGoBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBack11177);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack11177);
		}
		internal static global::MonoJavaBridge.MethodId _goBack11178;
		public virtual void goBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBack11178);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack11178);
		}
		internal static global::MonoJavaBridge.MethodId _canGoForward11179;
		public virtual bool canGoForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoForward11179);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward11179);
		}
		internal static global::MonoJavaBridge.MethodId _goForward11180;
		public virtual void goForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goForward11180);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward11180);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBackOrForward11181;
		public virtual bool canGoBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBackOrForward11181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward11181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _goBackOrForward11182;
		public virtual void goBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBackOrForward11182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward11182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageUp11183;
		public virtual bool pageUp(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageUp11183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp11183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageDown11184;
		public virtual bool pageDown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageDown11184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown11184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearView11185;
		public virtual void clearView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearView11185);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView11185);
		}
		internal static global::MonoJavaBridge.MethodId _capturePicture11186;
		public virtual global::android.graphics.Picture capturePicture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._capturePicture11186)) as android.graphics.Picture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture11186)) as android.graphics.Picture;
		}
		public new float Scale
		{
			get
			{
				return getScale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScale11187;
		public virtual float getScale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.webkit.WebView._getScale11187);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale11187);
		}
		internal static global::MonoJavaBridge.MethodId _setInitialScale11188;
		public virtual void setInitialScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setInitialScale11188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale11188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeZoomPicker11189;
		public virtual void invokeZoomPicker() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._invokeZoomPicker11189);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker11189);
		}
		internal static global::MonoJavaBridge.MethodId _getHitTestResult11190;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHitTestResult11190)) as android.webkit.WebView.HitTestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult11190)) as android.webkit.WebView.HitTestResult;
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusNodeHref11191;
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestFocusNodeHref11191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref11191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestImageRef11192;
		public virtual void requestImageRef(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestImageRef11192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef11192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ContentHeight
		{
			get
			{
				return getContentHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentHeight11193;
		public virtual int getContentHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getContentHeight11193);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight11193);
		}
		internal static global::MonoJavaBridge.MethodId _pauseTimers11194;
		public virtual void pauseTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._pauseTimers11194);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers11194);
		}
		internal static global::MonoJavaBridge.MethodId _resumeTimers11195;
		public virtual void resumeTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._resumeTimers11195);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers11195);
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData11196;
		public virtual void clearFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearFormData11196);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData11196);
		}
		internal static global::MonoJavaBridge.MethodId _clearSslPreferences11197;
		public virtual void clearSslPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearSslPreferences11197);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences11197);
		}
		internal static global::MonoJavaBridge.MethodId _copyBackForwardList11198;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._copyBackForwardList11198)) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList11198)) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _findNext11199;
		public virtual void findNext(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._findNext11199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext11199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAll11200;
		public virtual int findAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._findAll11200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll11200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAddress11201;
		public static global::java.lang.String findAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress11201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearMatches11202;
		public virtual void clearMatches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearMatches11202);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches11202);
		}
		internal static global::MonoJavaBridge.MethodId _documentHasImages11203;
		public virtual void documentHasImages(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._documentHasImages11203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages11203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebViewClient11204;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebViewClient11204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient11204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDownloadListener11205;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setDownloadListener11205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener11205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebChromeClient11206;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebChromeClient11206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient11206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPictureListener11207;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setPictureListener11207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener11207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addJavascriptInterface11208;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._addJavascriptInterface11208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface11208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.webkit.WebSettings Settings
		{
			get
			{
				return getSettings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettings11209;
		public virtual global::android.webkit.WebSettings getSettings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getSettings11209)) as android.webkit.WebSettings;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings11209)) as android.webkit.WebSettings;
		}
		public static global::android.webkit.PluginList PluginList
		{
			get
			{
				return getPluginList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPluginList11210;
		public static global::android.webkit.PluginList getPluginList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList11210)) as android.webkit.PluginList;
		}
		internal static global::MonoJavaBridge.MethodId _refreshPlugins11211;
		public virtual void refreshPlugins(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._refreshPlugins11211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins11211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _emulateShiftHeld11212;
		public virtual void emulateShiftHeld() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._emulateShiftHeld11212);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._emulateShiftHeld11212);
		}
		internal static global::MonoJavaBridge.MethodId _setMapTrackballToArrowKeys11213;
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setMapTrackballToArrowKeys11213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys11213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flingScroll11214;
		public virtual void flingScroll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._flingScroll11214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll11214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls11215;
		public virtual global::android.view.View getZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getZoomControls11215)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls11215)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _zoomIn11216;
		public virtual bool zoomIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomIn11216);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn11216);
		}
		internal static global::MonoJavaBridge.MethodId _zoomOut11217;
		public virtual bool zoomOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomOut11217);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut11217);
		}
		internal static global::MonoJavaBridge.MethodId _debugDump11218;
		public virtual void debugDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._debugDump11218);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump11218);
		}
		internal static global::MonoJavaBridge.MethodId _WebView11219;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView11219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView11220;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView11220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView11221;
		public WebView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView11221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.webkit.WebView._finalize11115 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "finalize", "()V");
			global::android.webkit.WebView._destroy11116 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "destroy", "()V");
			global::android.webkit.WebView._freeMemory11117 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "freeMemory", "()V");
			global::android.webkit.WebView._getCertificate11118 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.webkit.WebView._clearCache11119 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V");
			global::android.webkit.WebView._onKeyDown11120 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onKeyUp11121 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onTouchEvent11122 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onTrackballEvent11123 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onWindowFocusChanged11124 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.webkit.WebView._onAttachedToWindow11125 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V");
			global::android.webkit.WebView._onDetachedFromWindow11126 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V");
			global::android.webkit.WebView._dispatchKeyEvent11127 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._getTitle11128 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebView._performLongClick11129 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "performLongClick", "()Z");
			global::android.webkit.WebView._onFocusChanged11130 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.webkit.WebView._requestFocus11131 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.webkit.WebView._onCreateInputConnection11132 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.webkit.WebView._onScrollChanged11133 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V");
			global::android.webkit.WebView._onSizeChanged11134 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.webkit.WebView._setLayoutParams11135 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.webkit.WebView._computeScroll11136 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeScroll", "()V");
			global::android.webkit.WebView._setScrollBarStyle11137 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V");
			global::android.webkit.WebView._computeHorizontalScrollRange11138 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollRange11139 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollOffset11140 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.webkit.WebView._computeVerticalScrollExtent11141 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.webkit.WebView._onDraw11142 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.webkit.WebView._setBackgroundColor11143 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V");
			global::android.webkit.WebView._onMeasure11144 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V");
			global::android.webkit.WebView._requestChildRectangleOnScreen11145 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.webkit.WebView._drawChild11146 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.webkit.WebView._getProgress11147 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getProgress", "()I");
			global::android.webkit.WebView._onChildViewAdded11148 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._onChildViewRemoved11149 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getUrl11150 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._saveState11151 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._restoreState11152 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._clearHistory11153 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearHistory", "()V");
			global::android.webkit.WebView._reload11154 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "reload", "()V");
			global::android.webkit.WebView._onGlobalFocusChanged11155 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getOriginalUrl11156 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._getFavicon11157 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebView._setHorizontalScrollbarOverlay11158 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._setVerticalScrollbarOverlay11159 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._overlayHorizontalScrollbar11160 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z");
			global::android.webkit.WebView._overlayVerticalScrollbar11161 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z");
			global::android.webkit.WebView._setCertificate11162 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V");
			global::android.webkit.WebView._savePassword11163 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._setHttpAuthUsernamePassword11164 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._getHttpAuthUsernamePassword11165 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.webkit.WebView._enablePlatformNotifications11166 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			global::android.webkit.WebView._disablePlatformNotifications11167 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			global::android.webkit.WebView._setNetworkAvailable11168 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V");
			global::android.webkit.WebView._savePicture11169 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._restorePicture11170 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._loadUrl11171 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.webkit.WebView._loadUrl11172 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebView._postUrl11173 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V");
			global::android.webkit.WebView._loadData11174 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._loadDataWithBaseURL11175 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._stopLoading11176 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "stopLoading", "()V");
			global::android.webkit.WebView._canGoBack11177 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBack", "()Z");
			global::android.webkit.WebView._goBack11178 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBack", "()V");
			global::android.webkit.WebView._canGoForward11179 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoForward", "()Z");
			global::android.webkit.WebView._goForward11180 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goForward", "()V");
			global::android.webkit.WebView._canGoBackOrForward11181 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z");
			global::android.webkit.WebView._goBackOrForward11182 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V");
			global::android.webkit.WebView._pageUp11183 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z");
			global::android.webkit.WebView._pageDown11184 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z");
			global::android.webkit.WebView._clearView11185 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearView", "()V");
			global::android.webkit.WebView._capturePicture11186 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;");
			global::android.webkit.WebView._getScale11187 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getScale", "()F");
			global::android.webkit.WebView._setInitialScale11188 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V");
			global::android.webkit.WebView._invokeZoomPicker11189 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V");
			global::android.webkit.WebView._getHitTestResult11190 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;");
			global::android.webkit.WebView._requestFocusNodeHref11191 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._requestImageRef11192 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._getContentHeight11193 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getContentHeight", "()I");
			global::android.webkit.WebView._pauseTimers11194 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pauseTimers", "()V");
			global::android.webkit.WebView._resumeTimers11195 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "resumeTimers", "()V");
			global::android.webkit.WebView._clearFormData11196 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearFormData", "()V");
			global::android.webkit.WebView._clearSslPreferences11197 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V");
			global::android.webkit.WebView._copyBackForwardList11198 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._findNext11199 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findNext", "(Z)V");
			global::android.webkit.WebView._findAll11200 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I");
			global::android.webkit.WebView._findAddress11201 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.WebView._clearMatches11202 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearMatches", "()V");
			global::android.webkit.WebView._documentHasImages11203 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._setWebViewClient11204 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V");
			global::android.webkit.WebView._setDownloadListener11205 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V");
			global::android.webkit.WebView._setWebChromeClient11206 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V");
			global::android.webkit.WebView._setPictureListener11207 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V");
			global::android.webkit.WebView._addJavascriptInterface11208 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V");
			global::android.webkit.WebView._getSettings11209 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;");
			global::android.webkit.WebView._getPluginList11210 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			global::android.webkit.WebView._refreshPlugins11211 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V");
			global::android.webkit.WebView._emulateShiftHeld11212 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V");
			global::android.webkit.WebView._setMapTrackballToArrowKeys11213 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V");
			global::android.webkit.WebView._flingScroll11214 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V");
			global::android.webkit.WebView._getZoomControls11215 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.webkit.WebView._zoomIn11216 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomIn", "()Z");
			global::android.webkit.WebView._zoomOut11217 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomOut", "()Z");
			global::android.webkit.WebView._debugDump11218 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "debugDump", "()V");
			global::android.webkit.WebView._WebView11219 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.webkit.WebView._WebView11220 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.webkit.WebView._WebView11221 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
