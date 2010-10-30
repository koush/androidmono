namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebView : android.widget.AbsoluteLayout, android.view.ViewTreeObserver.OnGlobalFocusChangeListener, android.view.ViewGroup.OnHierarchyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class HitTestResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal static global::MonoJavaBridge.MethodId _getType16304;
			public virtual int getType()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType16304);
			}
			public new global::java.lang.String Extra
			{
				get
				{
					return getExtra();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExtra16305;
			public virtual global::java.lang.String getExtra()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra16305)) as java.lang.String;
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
			static HitTestResult()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.HitTestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$HitTestResult"));
				global::android.webkit.WebView.HitTestResult._getType16304 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I");
				global::android.webkit.WebView.HitTestResult._getExtra16305 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.webkit.WebView.PictureListener_))]
		public partial interface PictureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.webkit.WebView.PictureListener))]
		internal sealed partial class PictureListener_ : java.lang.Object, PictureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PictureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onNewPicture16316;
			void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_._onNewPicture16316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PictureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$PictureListener"));
				global::android.webkit.WebView.PictureListener_._onNewPicture16316 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListener_.staticClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void PictureListenerDelegate(android.webkit.WebView arg0, android.graphics.Picture arg1);

		internal partial class PictureListenerDelegateWrapper : java.lang.Object, PictureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PictureListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _PictureListenerDelegateWrapper16317;
			public PictureListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.PictureListenerDelegateWrapper.staticClass, global::android.webkit.WebView.PictureListenerDelegateWrapper._PictureListenerDelegateWrapper16317);
				Init(@__env, handle);
			}
			static PictureListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView_PictureListenerDelegateWrapper"));
				global::android.webkit.WebView.PictureListenerDelegateWrapper._PictureListenerDelegateWrapper16317 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class PictureListenerDelegateWrapper
		{
			private PictureListenerDelegate myDelegate;
			public void onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator PictureListenerDelegateWrapper(PictureListenerDelegate d)
			{
				global::android.webkit.WebView.PictureListenerDelegateWrapper ret = new global::android.webkit.WebView.PictureListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class WebViewTransport : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WebViewTransport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setWebView16318;
			public virtual void setWebView(android.webkit.WebView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView16318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getWebView16319;
			public virtual global::android.webkit.WebView getWebView()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView16319)) as android.webkit.WebView;
			}
			internal static global::MonoJavaBridge.MethodId _WebViewTransport16320;
			public WebViewTransport(android.webkit.WebView arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport16320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static WebViewTransport()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.WebViewTransport.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$WebViewTransport"));
				global::android.webkit.WebView.WebViewTransport._setWebView16318 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V");
				global::android.webkit.WebView.WebViewTransport._getWebView16319 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;");
				global::android.webkit.WebView.WebViewTransport._WebViewTransport16320 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize16321;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._finalize16321);
		}
		internal static global::MonoJavaBridge.MethodId _destroy16322;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy16322);
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory16323;
		public virtual void freeMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory16323);
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
		internal static global::MonoJavaBridge.MethodId _getCertificate16324;
		public virtual global::android.net.http.SslCertificate getCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate16324)) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache16325;
		public virtual void clearCache(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache16325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16326;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown16326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16327;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp16327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16328;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent16328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent16329;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent16329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16330;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged16330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16331;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow16331);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16332;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow16332);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent16333;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent16333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle16334;
		public virtual global::java.lang.String getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle16334)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick16335;
		public override bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick16335);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16336;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged16336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus16337;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus16337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection16338;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onCreateInputConnection16338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged16339;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged16339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16340;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged16340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.view.ViewGroup.LayoutParams LayoutParams
		{
			set
			{
				setLayoutParams(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams16341;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams16341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll16342;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll16342);
		}
		public new int ScrollBarStyle
		{
			set
			{
				setScrollBarStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle16343;
		public override void setScrollBarStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle16343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange16344;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange16344);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange16345;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange16345);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset16346;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset16346);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent16347;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent16347);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16348;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw16348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundColor
		{
			set
			{
				setBackgroundColor(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor16349;
		public override void setBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor16349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16350;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure16350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen16351;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen16351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild16352;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild16352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress16353;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress16353);
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewAdded16354;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded16354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewRemoved16355;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved16355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl16356;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl16356)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState16357;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState16357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState16358;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState16358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory16359;
		public virtual void clearHistory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory16359);
		}
		internal static global::MonoJavaBridge.MethodId _reload16360;
		public virtual void reload()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload16360);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged16361;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged16361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl16362;
		public virtual global::java.lang.String getOriginalUrl()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl16362)) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon16363;
		public virtual global::android.graphics.Bitmap getFavicon()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon16363)) as android.graphics.Bitmap;
		}
		public new bool HorizontalScrollbarOverlay
		{
			set
			{
				setHorizontalScrollbarOverlay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollbarOverlay16364;
		public virtual void setHorizontalScrollbarOverlay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay16364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool VerticalScrollbarOverlay
		{
			set
			{
				setVerticalScrollbarOverlay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollbarOverlay16365;
		public virtual void setVerticalScrollbarOverlay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay16365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _overlayHorizontalScrollbar16366;
		public virtual bool overlayHorizontalScrollbar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar16366);
		}
		internal static global::MonoJavaBridge.MethodId _overlayVerticalScrollbar16367;
		public virtual bool overlayVerticalScrollbar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar16367);
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate16368;
		public virtual void setCertificate(android.net.http.SslCertificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate16368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePassword16369;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword16369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpAuthUsernamePassword16370;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword16370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpAuthUsernamePassword16371;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword16371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _enablePlatformNotifications16372;
		public static void enablePlatformNotifications()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications16372);
		}
		internal static global::MonoJavaBridge.MethodId _disablePlatformNotifications16373;
		public static void disablePlatformNotifications()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications16373);
		}
		public new bool NetworkAvailable
		{
			set
			{
				setNetworkAvailable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkAvailable16374;
		public virtual void setNetworkAvailable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable16374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePicture16375;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture16375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restorePicture16376;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture16376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl16377;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl16377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl16378;
		public virtual void loadUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl16378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postUrl16379;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl16379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadData16380;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData16380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _loadDataWithBaseURL16381;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL16381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _stopLoading16382;
		public virtual void stopLoading()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading16382);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBack16383;
		public virtual bool canGoBack()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack16383);
		}
		internal static global::MonoJavaBridge.MethodId _goBack16384;
		public virtual void goBack()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack16384);
		}
		internal static global::MonoJavaBridge.MethodId _canGoForward16385;
		public virtual bool canGoForward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward16385);
		}
		internal static global::MonoJavaBridge.MethodId _goForward16386;
		public virtual void goForward()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward16386);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBackOrForward16387;
		public virtual bool canGoBackOrForward(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward16387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _goBackOrForward16388;
		public virtual void goBackOrForward(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward16388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageUp16389;
		public virtual bool pageUp(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp16389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageDown16390;
		public virtual bool pageDown(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown16390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearView16391;
		public virtual void clearView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView16391);
		}
		internal static global::MonoJavaBridge.MethodId _capturePicture16392;
		public virtual global::android.graphics.Picture capturePicture()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture16392)) as android.graphics.Picture;
		}
		public new float Scale
		{
			get
			{
				return getScale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScale16393;
		public virtual float getScale()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale16393);
		}
		public new int InitialScale
		{
			set
			{
				setInitialScale(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInitialScale16394;
		public virtual void setInitialScale(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale16394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeZoomPicker16395;
		public virtual void invokeZoomPicker()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker16395);
		}
		internal static global::MonoJavaBridge.MethodId _getHitTestResult16396;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult16396)) as android.webkit.WebView.HitTestResult;
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusNodeHref16397;
		public virtual void requestFocusNodeHref(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref16397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestImageRef16398;
		public virtual void requestImageRef(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef16398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ContentHeight
		{
			get
			{
				return getContentHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentHeight16399;
		public virtual int getContentHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight16399);
		}
		internal static global::MonoJavaBridge.MethodId _pauseTimers16400;
		public virtual void pauseTimers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers16400);
		}
		internal static global::MonoJavaBridge.MethodId _resumeTimers16401;
		public virtual void resumeTimers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers16401);
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData16402;
		public virtual void clearFormData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData16402);
		}
		internal static global::MonoJavaBridge.MethodId _clearSslPreferences16403;
		public virtual void clearSslPreferences()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences16403);
		}
		internal static global::MonoJavaBridge.MethodId _copyBackForwardList16404;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList16404)) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _findNext16405;
		public virtual void findNext(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext16405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAll16406;
		public virtual int findAll(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll16406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAddress16407;
		public static global::java.lang.String findAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress16407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearMatches16408;
		public virtual void clearMatches()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches16408);
		}
		internal static global::MonoJavaBridge.MethodId _documentHasImages16409;
		public virtual void documentHasImages(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages16409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.WebViewClient WebViewClient
		{
			set
			{
				setWebViewClient(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWebViewClient16410;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient16410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.DownloadListener DownloadListener
		{
			set
			{
				setDownloadListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDownloadListener16411;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener16411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setDownloadListener(global::android.webkit.DownloadListenerDelegate arg0)
		{
			setDownloadListener((global::android.webkit.DownloadListenerDelegateWrapper)arg0);
		}
		public new global::android.webkit.WebChromeClient WebChromeClient
		{
			set
			{
				setWebChromeClient(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWebChromeClient16412;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPictureListener16413;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener16413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPictureListener(global::android.webkit.WebView.PictureListenerDelegate arg0)
		{
			setPictureListener((global::android.webkit.WebView.PictureListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addJavascriptInterface16414;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.webkit.WebSettings Settings
		{
			get
			{
				return getSettings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettings16415;
		public virtual global::android.webkit.WebSettings getSettings()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings16415)) as android.webkit.WebSettings;
		}
		public static global::android.webkit.PluginList PluginList
		{
			get
			{
				return getPluginList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPluginList16416;
		public static global::android.webkit.PluginList getPluginList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList16416)) as android.webkit.PluginList;
		}
		internal static global::MonoJavaBridge.MethodId _refreshPlugins16417;
		public virtual void refreshPlugins(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins16417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _emulateShiftHeld16418;
		public virtual void emulateShiftHeld()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._emulateShiftHeld16418);
		}
		public new bool MapTrackballToArrowKeys
		{
			set
			{
				setMapTrackballToArrowKeys(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMapTrackballToArrowKeys16419;
		public virtual void setMapTrackballToArrowKeys(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys16419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flingScroll16420;
		public virtual void flingScroll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll16420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls16421;
		public virtual global::android.view.View getZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls16421)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _zoomIn16422;
		public virtual bool zoomIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn16422);
		}
		internal static global::MonoJavaBridge.MethodId _zoomOut16423;
		public virtual bool zoomOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut16423);
		}
		internal static global::MonoJavaBridge.MethodId _debugDump16424;
		public virtual void debugDump()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump16424);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16425;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16426;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16427;
		public WebView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		static WebView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView"));
			global::android.webkit.WebView._finalize16321 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "finalize", "()V");
			global::android.webkit.WebView._destroy16322 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "destroy", "()V");
			global::android.webkit.WebView._freeMemory16323 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "freeMemory", "()V");
			global::android.webkit.WebView._getCertificate16324 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.webkit.WebView._clearCache16325 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V");
			global::android.webkit.WebView._onKeyDown16326 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onKeyUp16327 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onTouchEvent16328 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onTrackballEvent16329 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onWindowFocusChanged16330 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.webkit.WebView._onAttachedToWindow16331 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V");
			global::android.webkit.WebView._onDetachedFromWindow16332 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V");
			global::android.webkit.WebView._dispatchKeyEvent16333 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._getTitle16334 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebView._performLongClick16335 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "performLongClick", "()Z");
			global::android.webkit.WebView._onFocusChanged16336 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.webkit.WebView._requestFocus16337 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.webkit.WebView._onCreateInputConnection16338 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.webkit.WebView._onScrollChanged16339 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V");
			global::android.webkit.WebView._onSizeChanged16340 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.webkit.WebView._setLayoutParams16341 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.webkit.WebView._computeScroll16342 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeScroll", "()V");
			global::android.webkit.WebView._setScrollBarStyle16343 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V");
			global::android.webkit.WebView._computeHorizontalScrollRange16344 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollRange16345 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollOffset16346 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.webkit.WebView._computeVerticalScrollExtent16347 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.webkit.WebView._onDraw16348 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.webkit.WebView._setBackgroundColor16349 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V");
			global::android.webkit.WebView._onMeasure16350 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V");
			global::android.webkit.WebView._requestChildRectangleOnScreen16351 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.webkit.WebView._drawChild16352 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.webkit.WebView._getProgress16353 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getProgress", "()I");
			global::android.webkit.WebView._onChildViewAdded16354 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._onChildViewRemoved16355 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getUrl16356 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._saveState16357 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._restoreState16358 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._clearHistory16359 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearHistory", "()V");
			global::android.webkit.WebView._reload16360 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "reload", "()V");
			global::android.webkit.WebView._onGlobalFocusChanged16361 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getOriginalUrl16362 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._getFavicon16363 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebView._setHorizontalScrollbarOverlay16364 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._setVerticalScrollbarOverlay16365 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._overlayHorizontalScrollbar16366 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z");
			global::android.webkit.WebView._overlayVerticalScrollbar16367 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z");
			global::android.webkit.WebView._setCertificate16368 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V");
			global::android.webkit.WebView._savePassword16369 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._setHttpAuthUsernamePassword16370 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._getHttpAuthUsernamePassword16371 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.webkit.WebView._enablePlatformNotifications16372 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			global::android.webkit.WebView._disablePlatformNotifications16373 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			global::android.webkit.WebView._setNetworkAvailable16374 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V");
			global::android.webkit.WebView._savePicture16375 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._restorePicture16376 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._loadUrl16377 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.webkit.WebView._loadUrl16378 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebView._postUrl16379 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V");
			global::android.webkit.WebView._loadData16380 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._loadDataWithBaseURL16381 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._stopLoading16382 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "stopLoading", "()V");
			global::android.webkit.WebView._canGoBack16383 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBack", "()Z");
			global::android.webkit.WebView._goBack16384 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBack", "()V");
			global::android.webkit.WebView._canGoForward16385 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoForward", "()Z");
			global::android.webkit.WebView._goForward16386 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goForward", "()V");
			global::android.webkit.WebView._canGoBackOrForward16387 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z");
			global::android.webkit.WebView._goBackOrForward16388 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V");
			global::android.webkit.WebView._pageUp16389 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z");
			global::android.webkit.WebView._pageDown16390 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z");
			global::android.webkit.WebView._clearView16391 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearView", "()V");
			global::android.webkit.WebView._capturePicture16392 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;");
			global::android.webkit.WebView._getScale16393 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getScale", "()F");
			global::android.webkit.WebView._setInitialScale16394 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V");
			global::android.webkit.WebView._invokeZoomPicker16395 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V");
			global::android.webkit.WebView._getHitTestResult16396 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;");
			global::android.webkit.WebView._requestFocusNodeHref16397 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._requestImageRef16398 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._getContentHeight16399 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getContentHeight", "()I");
			global::android.webkit.WebView._pauseTimers16400 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pauseTimers", "()V");
			global::android.webkit.WebView._resumeTimers16401 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "resumeTimers", "()V");
			global::android.webkit.WebView._clearFormData16402 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearFormData", "()V");
			global::android.webkit.WebView._clearSslPreferences16403 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V");
			global::android.webkit.WebView._copyBackForwardList16404 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._findNext16405 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findNext", "(Z)V");
			global::android.webkit.WebView._findAll16406 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I");
			global::android.webkit.WebView._findAddress16407 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.WebView._clearMatches16408 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearMatches", "()V");
			global::android.webkit.WebView._documentHasImages16409 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._setWebViewClient16410 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V");
			global::android.webkit.WebView._setDownloadListener16411 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V");
			global::android.webkit.WebView._setWebChromeClient16412 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V");
			global::android.webkit.WebView._setPictureListener16413 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V");
			global::android.webkit.WebView._addJavascriptInterface16414 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V");
			global::android.webkit.WebView._getSettings16415 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;");
			global::android.webkit.WebView._getPluginList16416 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			global::android.webkit.WebView._refreshPlugins16417 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V");
			global::android.webkit.WebView._emulateShiftHeld16418 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V");
			global::android.webkit.WebView._setMapTrackballToArrowKeys16419 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V");
			global::android.webkit.WebView._flingScroll16420 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V");
			global::android.webkit.WebView._getZoomControls16421 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.webkit.WebView._zoomIn16422 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomIn", "()Z");
			global::android.webkit.WebView._zoomOut16423 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomOut", "()Z");
			global::android.webkit.WebView._debugDump16424 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "debugDump", "()V");
			global::android.webkit.WebView._WebView16425 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.webkit.WebView._WebView16426 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.webkit.WebView._WebView16427 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
