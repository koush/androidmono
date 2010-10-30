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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual int getType()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I", ref global::android.webkit.WebView.HitTestResult._m0);
			}
			public new global::java.lang.String Extra
			{
				get
				{
					return getExtra();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::java.lang.String getExtra()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;", ref global::android.webkit.WebView.HitTestResult._m1) as java.lang.String;
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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.PictureListener_.staticClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V", ref global::android.webkit.WebView.PictureListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PictureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$PictureListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public PictureListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebView.PictureListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.webkit.WebView.PictureListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.PictureListenerDelegateWrapper.staticClass, global::android.webkit.WebView.PictureListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static PictureListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView_PictureListenerDelegateWrapper"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void setWebView(android.webkit.WebView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V", ref global::android.webkit.WebView.WebViewTransport._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::android.webkit.WebView getWebView()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;", ref global::android.webkit.WebView.WebViewTransport._m1) as android.webkit.WebView;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public WebViewTransport(android.webkit.WebView arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.webkit.WebView.WebViewTransport._m2.native == global::System.IntPtr.Zero)
					global::android.webkit.WebView.WebViewTransport._m2 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static WebViewTransport()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.WebViewTransport.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$WebViewTransport"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "finalize", "()V", ref global::android.webkit.WebView._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "destroy", "()V", ref global::android.webkit.WebView._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void freeMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "freeMemory", "()V", ref global::android.webkit.WebView._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.net.http.SslCertificate getCertificate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;", ref global::android.webkit.WebView._m3) as android.net.http.SslCertificate;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void clearCache(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearCache", "(Z)V", ref global::android.webkit.WebView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.webkit.WebView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.webkit.WebView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.webkit.WebView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.webkit.WebView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.webkit.WebView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V", ref global::android.webkit.WebView._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V", ref global::android.webkit.WebView._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.webkit.WebView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getTitle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;", ref global::android.webkit.WebView._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "performLongClick", "()Z", ref global::android.webkit.WebView._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.webkit.WebView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z", ref global::android.webkit.WebView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.webkit.WebView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V", ref global::android.webkit.WebView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.webkit.WebView._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.view.ViewGroup.LayoutParams LayoutParams
		{
			set
			{
				setLayoutParams(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.webkit.WebView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "computeScroll", "()V", ref global::android.webkit.WebView._m21);
		}
		public new int ScrollBarStyle
		{
			set
			{
				setScrollBarStyle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override void setScrollBarStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V", ref global::android.webkit.WebView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected override int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.webkit.WebView._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.webkit.WebView._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.webkit.WebView._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.webkit.WebView._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected override void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.webkit.WebView._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundColor
		{
			set
			{
				setBackgroundColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override void setBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V", ref global::android.webkit.WebView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onMeasure", "(II)V", ref global::android.webkit.WebView._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", ref global::android.webkit.WebView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", ref global::android.webkit.WebView._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "getProgress", "()I", ref global::android.webkit.WebView._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.webkit.WebView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.webkit.WebView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;", ref global::android.webkit.WebView._m35) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", ref global::android.webkit.WebView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.webkit.WebBackForwardList;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;", ref global::android.webkit.WebView._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.webkit.WebBackForwardList;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void clearHistory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearHistory", "()V", ref global::android.webkit.WebView._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void reload()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "reload", "()V", ref global::android.webkit.WebView._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.webkit.WebView._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::java.lang.String getOriginalUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;", ref global::android.webkit.WebView._m41) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::android.graphics.Bitmap getFavicon()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;", ref global::android.webkit.WebView._m42) as android.graphics.Bitmap;
		}
		public new bool HorizontalScrollbarOverlay
		{
			set
			{
				setHorizontalScrollbarOverlay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setHorizontalScrollbarOverlay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V", ref global::android.webkit.WebView._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool VerticalScrollbarOverlay
		{
			set
			{
				setVerticalScrollbarOverlay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setVerticalScrollbarOverlay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V", ref global::android.webkit.WebView._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual bool overlayHorizontalScrollbar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z", ref global::android.webkit.WebView._m45);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual bool overlayVerticalScrollbar()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z", ref global::android.webkit.WebView._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void setCertificate(android.net.http.SslCertificate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V", ref global::android.webkit.WebView._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebView._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebView._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", ref global::android.webkit.WebView._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static void enablePlatformNotifications()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m51.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m51 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._m51);
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static void disablePlatformNotifications()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m52.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m52 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._m52);
		}
		public new bool NetworkAvailable
		{
			set
			{
				setNetworkAvailable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void setNetworkAvailable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V", ref global::android.webkit.WebView._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", ref global::android.webkit.WebView._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z", ref global::android.webkit.WebView._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V", ref global::android.webkit.WebView._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void loadUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V", ref global::android.webkit.WebView._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V", ref global::android.webkit.WebView._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebView._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.WebView._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual void stopLoading()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "stopLoading", "()V", ref global::android.webkit.WebView._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual bool canGoBack()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "canGoBack", "()Z", ref global::android.webkit.WebView._m62);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void goBack()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "goBack", "()V", ref global::android.webkit.WebView._m63);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual bool canGoForward()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "canGoForward", "()Z", ref global::android.webkit.WebView._m64);
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual void goForward()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "goForward", "()V", ref global::android.webkit.WebView._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual bool canGoBackOrForward(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z", ref global::android.webkit.WebView._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual void goBackOrForward(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V", ref global::android.webkit.WebView._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual bool pageUp(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z", ref global::android.webkit.WebView._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual bool pageDown(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z", ref global::android.webkit.WebView._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void clearView()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearView", "()V", ref global::android.webkit.WebView._m70);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual global::android.graphics.Picture capturePicture()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;", ref global::android.webkit.WebView._m71) as android.graphics.Picture;
		}
		public new float Scale
		{
			get
			{
				return getScale();
			}
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual float getScale()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.webkit.WebView.staticClass, "getScale", "()F", ref global::android.webkit.WebView._m72);
		}
		public new int InitialScale
		{
			set
			{
				setInitialScale(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void setInitialScale(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V", ref global::android.webkit.WebView._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual void invokeZoomPicker()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V", ref global::android.webkit.WebView._m74);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;", ref global::android.webkit.WebView._m75) as android.webkit.WebView.HitTestResult;
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual void requestFocusNodeHref(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V", ref global::android.webkit.WebView._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void requestImageRef(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V", ref global::android.webkit.WebView._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ContentHeight
		{
			get
			{
				return getContentHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual int getContentHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "getContentHeight", "()I", ref global::android.webkit.WebView._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void pauseTimers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "pauseTimers", "()V", ref global::android.webkit.WebView._m79);
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void resumeTimers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "resumeTimers", "()V", ref global::android.webkit.WebView._m80);
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void clearFormData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearFormData", "()V", ref global::android.webkit.WebView._m81);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void clearSslPreferences()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V", ref global::android.webkit.WebView._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;", ref global::android.webkit.WebView._m83) as android.webkit.WebBackForwardList;
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual void findNext(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "findNext", "(Z)V", ref global::android.webkit.WebView._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public virtual int findAll(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I", ref global::android.webkit.WebView._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public static global::java.lang.String findAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m86.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m86 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public virtual void clearMatches()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "clearMatches", "()V", ref global::android.webkit.WebView._m87);
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public virtual void documentHasImages(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V", ref global::android.webkit.WebView._m88, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.WebViewClient WebViewClient
		{
			set
			{
				setWebViewClient(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V", ref global::android.webkit.WebView._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.webkit.DownloadListener DownloadListener
		{
			set
			{
				setDownloadListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V", ref global::android.webkit.WebView._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V", ref global::android.webkit.WebView._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V", ref global::android.webkit.WebView._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPictureListener(global::android.webkit.WebView.PictureListenerDelegate arg0)
		{
			setPictureListener((global::android.webkit.WebView.PictureListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V", ref global::android.webkit.WebView._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.webkit.WebSettings Settings
		{
			get
			{
				return getSettings();
			}
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual global::android.webkit.WebSettings getSettings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;", ref global::android.webkit.WebView._m94) as android.webkit.WebSettings;
		}
		public static global::android.webkit.PluginList PluginList
		{
			get
			{
				return getPluginList();
			}
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public static global::android.webkit.PluginList getPluginList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m95.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m95 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._m95)) as android.webkit.PluginList;
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public virtual void refreshPlugins(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V", ref global::android.webkit.WebView._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public virtual void emulateShiftHeld()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V", ref global::android.webkit.WebView._m97);
		}
		public new bool MapTrackballToArrowKeys
		{
			set
			{
				setMapTrackballToArrowKeys(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public virtual void setMapTrackballToArrowKeys(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V", ref global::android.webkit.WebView._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public virtual void flingScroll(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "flingScroll", "(II)V", ref global::android.webkit.WebView._m99, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual global::android.view.View getZoomControls()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;", ref global::android.webkit.WebView._m100) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual bool zoomIn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "zoomIn", "()Z", ref global::android.webkit.WebView._m101);
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public virtual bool zoomOut()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebView.staticClass, "zoomOut", "()Z", ref global::android.webkit.WebView._m102);
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual void debugDump()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebView.staticClass, "debugDump", "()V", ref global::android.webkit.WebView._m103);
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m104.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m104 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m105;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m105.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m105 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public WebView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebView._m106.native == global::System.IntPtr.Zero)
				global::android.webkit.WebView._m106 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
