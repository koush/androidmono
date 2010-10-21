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
			internal static global::MonoJavaBridge.MethodId _getType16214;
			public virtual int getType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getType16214);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType16214);
			}
			public new global::java.lang.String Extra
			{
				get
				{
					return getExtra();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExtra16215;
			public virtual global::java.lang.String getExtra() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult._getExtra16215)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra16215)) as java.lang.String;
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
				global::android.webkit.WebView.HitTestResult._getType16214 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I");
				global::android.webkit.WebView.HitTestResult._getExtra16215 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;");
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
			internal static global::MonoJavaBridge.MethodId _onNewPicture16226;
			 void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_._onNewPicture16226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.PictureListener_.staticClass, global::android.webkit.WebView.PictureListener_._onNewPicture16226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.PictureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$PictureListener"));
				global::android.webkit.WebView.PictureListener_._onNewPicture16226 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.PictureListener_.staticClass, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
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
			internal static global::MonoJavaBridge.MethodId _setWebView16227;
			public virtual void setWebView(android.webkit.WebView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._setWebView16227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView16227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getWebView16228;
			public virtual global::android.webkit.WebView getWebView() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport._getWebView16228)) as android.webkit.WebView;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView16228)) as android.webkit.WebView;
			}
			internal static global::MonoJavaBridge.MethodId _WebViewTransport16229;
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport16229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.webkit.WebView.WebViewTransport.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebView$WebViewTransport"));
				global::android.webkit.WebView.WebViewTransport._setWebView16227 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V");
				global::android.webkit.WebView.WebViewTransport._getWebView16228 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;");
				global::android.webkit.WebView.WebViewTransport._WebViewTransport16229 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize16230;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._finalize16230);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._finalize16230);
		}
		internal static global::MonoJavaBridge.MethodId _destroy16231;
		public virtual void destroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._destroy16231);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy16231);
		}
		internal static global::MonoJavaBridge.MethodId _freeMemory16232;
		public virtual void freeMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._freeMemory16232);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory16232);
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
		internal static global::MonoJavaBridge.MethodId _getCertificate16233;
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getCertificate16233)) as android.net.http.SslCertificate;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate16233)) as android.net.http.SslCertificate;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache16234;
		public virtual void clearCache(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearCache16234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache16234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown16235;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyDown16235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown16235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp16236;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onKeyUp16236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp16236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent16237;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTouchEvent16237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent16237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onTrackballEvent16238;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._onTrackballEvent16238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent16238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged16239;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onWindowFocusChanged16239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged16239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onAttachedToWindow16240;
		protected override void onAttachedToWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onAttachedToWindow16240);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow16240);
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow16241;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDetachedFromWindow16241);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow16241);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent16242;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._dispatchKeyEvent16242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent16242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Title
		{
			get
			{
				return getTitle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle16243;
		public virtual global::java.lang.String getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getTitle16243)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle16243)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _performLongClick16244;
		public override bool performLongClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._performLongClick16244);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick16244);
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged16245;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onFocusChanged16245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged16245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _requestFocus16246;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestFocus16246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus16246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onCreateInputConnection16247;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._onCreateInputConnection16247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.inputmethod.InputConnection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onCreateInputConnection16247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.inputmethod.InputConnection;
		}
		internal static global::MonoJavaBridge.MethodId _onScrollChanged16248;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onScrollChanged16248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged16248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSizeChanged16249;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onSizeChanged16249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged16249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutParams16250;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setLayoutParams16250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams16250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeScroll16251;
		public override void computeScroll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._computeScroll16251);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll16251);
		}
		internal static global::MonoJavaBridge.MethodId _setScrollBarStyle16252;
		public override void setScrollBarStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setScrollBarStyle16252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle16252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _computeHorizontalScrollRange16253;
		protected override int computeHorizontalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeHorizontalScrollRange16253);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange16253);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange16254;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollRange16254);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange16254);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset16255;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollOffset16255);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset16255);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent16256;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._computeVerticalScrollExtent16256);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent16256);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw16257;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onDraw16257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw16257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundColor16258;
		public override void setBackgroundColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setBackgroundColor16258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor16258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16259;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onMeasure16259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure16259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestChildRectangleOnScreen16260;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._requestChildRectangleOnScreen16260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen16260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _drawChild16261;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._drawChild16261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild16261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress16262;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getProgress16262);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress16262);
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewAdded16263;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewAdded16263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded16263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onChildViewRemoved16264;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onChildViewRemoved16264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved16264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUrl16265;
		public virtual global::java.lang.String getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getUrl16265)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl16265)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _saveState16266;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._saveState16266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState16266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _restoreState16267;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._restoreState16267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState16267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _clearHistory16268;
		public virtual void clearHistory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearHistory16268);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory16268);
		}
		internal static global::MonoJavaBridge.MethodId _reload16269;
		public virtual void reload() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._reload16269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload16269);
		}
		internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged16270;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._onGlobalFocusChanged16270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged16270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String OriginalUrl
		{
			get
			{
				return getOriginalUrl();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOriginalUrl16271;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getOriginalUrl16271)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl16271)) as java.lang.String;
		}
		public new global::android.graphics.Bitmap Favicon
		{
			get
			{
				return getFavicon();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFavicon16272;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getFavicon16272)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon16272)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalScrollbarOverlay16273;
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHorizontalScrollbarOverlay16273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay16273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalScrollbarOverlay16274;
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setVerticalScrollbarOverlay16274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay16274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _overlayHorizontalScrollbar16275;
		public virtual bool overlayHorizontalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayHorizontalScrollbar16275);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar16275);
		}
		internal static global::MonoJavaBridge.MethodId _overlayVerticalScrollbar16276;
		public virtual bool overlayVerticalScrollbar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._overlayVerticalScrollbar16276);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar16276);
		}
		internal static global::MonoJavaBridge.MethodId _setCertificate16277;
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setCertificate16277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate16277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePassword16278;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._savePassword16278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword16278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setHttpAuthUsernamePassword16279;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setHttpAuthUsernamePassword16279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword16279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHttpAuthUsernamePassword16280;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHttpAuthUsernamePassword16280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword16280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _enablePlatformNotifications16281;
		public static void enablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications16281);
		}
		internal static global::MonoJavaBridge.MethodId _disablePlatformNotifications16282;
		public static void disablePlatformNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications16282);
		}
		internal static global::MonoJavaBridge.MethodId _setNetworkAvailable16283;
		public virtual void setNetworkAvailable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setNetworkAvailable16283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable16283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePicture16284;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._savePicture16284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture16284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restorePicture16285;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._restorePicture16285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture16285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl16286;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl16286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl16286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadUrl16287;
		public virtual void loadUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadUrl16287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl16287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postUrl16288;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._postUrl16288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl16288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _loadData16289;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadData16289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData16289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _loadDataWithBaseURL16290;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._loadDataWithBaseURL16290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL16290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _stopLoading16291;
		public virtual void stopLoading() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._stopLoading16291);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading16291);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBack16292;
		public virtual bool canGoBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBack16292);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack16292);
		}
		internal static global::MonoJavaBridge.MethodId _goBack16293;
		public virtual void goBack() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBack16293);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack16293);
		}
		internal static global::MonoJavaBridge.MethodId _canGoForward16294;
		public virtual bool canGoForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoForward16294);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward16294);
		}
		internal static global::MonoJavaBridge.MethodId _goForward16295;
		public virtual void goForward() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goForward16295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward16295);
		}
		internal static global::MonoJavaBridge.MethodId _canGoBackOrForward16296;
		public virtual bool canGoBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._canGoBackOrForward16296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward16296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _goBackOrForward16297;
		public virtual void goBackOrForward(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._goBackOrForward16297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward16297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageUp16298;
		public virtual bool pageUp(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageUp16298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp16298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _pageDown16299;
		public virtual bool pageDown(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._pageDown16299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown16299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearView16300;
		public virtual void clearView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearView16300);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView16300);
		}
		internal static global::MonoJavaBridge.MethodId _capturePicture16301;
		public virtual global::android.graphics.Picture capturePicture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._capturePicture16301)) as android.graphics.Picture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture16301)) as android.graphics.Picture;
		}
		public new float Scale
		{
			get
			{
				return getScale();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScale16302;
		public virtual float getScale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.webkit.WebView._getScale16302);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale16302);
		}
		internal static global::MonoJavaBridge.MethodId _setInitialScale16303;
		public virtual void setInitialScale(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setInitialScale16303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale16303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeZoomPicker16304;
		public virtual void invokeZoomPicker() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._invokeZoomPicker16304);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker16304);
		}
		internal static global::MonoJavaBridge.MethodId _getHitTestResult16305;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getHitTestResult16305)) as android.webkit.WebView.HitTestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult16305)) as android.webkit.WebView.HitTestResult;
		}
		internal static global::MonoJavaBridge.MethodId _requestFocusNodeHref16306;
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestFocusNodeHref16306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref16306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _requestImageRef16307;
		public virtual void requestImageRef(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._requestImageRef16307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef16307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ContentHeight
		{
			get
			{
				return getContentHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentHeight16308;
		public virtual int getContentHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._getContentHeight16308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight16308);
		}
		internal static global::MonoJavaBridge.MethodId _pauseTimers16309;
		public virtual void pauseTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._pauseTimers16309);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers16309);
		}
		internal static global::MonoJavaBridge.MethodId _resumeTimers16310;
		public virtual void resumeTimers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._resumeTimers16310);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers16310);
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData16311;
		public virtual void clearFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearFormData16311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData16311);
		}
		internal static global::MonoJavaBridge.MethodId _clearSslPreferences16312;
		public virtual void clearSslPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearSslPreferences16312);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences16312);
		}
		internal static global::MonoJavaBridge.MethodId _copyBackForwardList16313;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._copyBackForwardList16313)) as android.webkit.WebBackForwardList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList16313)) as android.webkit.WebBackForwardList;
		}
		internal static global::MonoJavaBridge.MethodId _findNext16314;
		public virtual void findNext(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._findNext16314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext16314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAll16315;
		public virtual int findAll(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.webkit.WebView._findAll16315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll16315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _findAddress16316;
		public static global::java.lang.String findAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress16316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearMatches16317;
		public virtual void clearMatches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._clearMatches16317);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches16317);
		}
		internal static global::MonoJavaBridge.MethodId _documentHasImages16318;
		public virtual void documentHasImages(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._documentHasImages16318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages16318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebViewClient16319;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebViewClient16319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient16319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDownloadListener16320;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setDownloadListener16320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener16320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWebChromeClient16321;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setWebChromeClient16321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient16321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPictureListener16322;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setPictureListener16322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener16322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addJavascriptInterface16323;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._addJavascriptInterface16323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface16323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.webkit.WebSettings Settings
		{
			get
			{
				return getSettings();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettings16324;
		public virtual global::android.webkit.WebSettings getSettings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getSettings16324)) as android.webkit.WebSettings;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings16324)) as android.webkit.WebSettings;
		}
		public static global::android.webkit.PluginList PluginList
		{
			get
			{
				return getPluginList();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPluginList16325;
		public static global::android.webkit.PluginList getPluginList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList16325)) as android.webkit.PluginList;
		}
		internal static global::MonoJavaBridge.MethodId _refreshPlugins16326;
		public virtual void refreshPlugins(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._refreshPlugins16326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins16326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _emulateShiftHeld16327;
		public virtual void emulateShiftHeld() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._emulateShiftHeld16327);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._emulateShiftHeld16327);
		}
		internal static global::MonoJavaBridge.MethodId _setMapTrackballToArrowKeys16328;
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._setMapTrackballToArrowKeys16328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys16328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _flingScroll16329;
		public virtual void flingScroll(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._flingScroll16329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll16329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.view.View ZoomControls
		{
			get
			{
				return getZoomControls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getZoomControls16330;
		public virtual global::android.view.View getZoomControls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.WebView._getZoomControls16330)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls16330)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _zoomIn16331;
		public virtual bool zoomIn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomIn16331);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn16331);
		}
		internal static global::MonoJavaBridge.MethodId _zoomOut16332;
		public virtual bool zoomOut() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebView._zoomOut16332);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut16332);
		}
		internal static global::MonoJavaBridge.MethodId _debugDump16333;
		public virtual void debugDump() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebView._debugDump16333);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump16333);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16334;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16335;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WebView16336;
		public WebView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView16336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.webkit.WebView._finalize16230 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "finalize", "()V");
			global::android.webkit.WebView._destroy16231 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "destroy", "()V");
			global::android.webkit.WebView._freeMemory16232 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "freeMemory", "()V");
			global::android.webkit.WebView._getCertificate16233 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.webkit.WebView._clearCache16234 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V");
			global::android.webkit.WebView._onKeyDown16235 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onKeyUp16236 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onTouchEvent16237 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onTrackballEvent16238 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onWindowFocusChanged16239 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.webkit.WebView._onAttachedToWindow16240 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V");
			global::android.webkit.WebView._onDetachedFromWindow16241 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V");
			global::android.webkit.WebView._dispatchKeyEvent16242 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._getTitle16243 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebView._performLongClick16244 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "performLongClick", "()Z");
			global::android.webkit.WebView._onFocusChanged16245 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.webkit.WebView._requestFocus16246 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.webkit.WebView._onCreateInputConnection16247 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.webkit.WebView._onScrollChanged16248 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V");
			global::android.webkit.WebView._onSizeChanged16249 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.webkit.WebView._setLayoutParams16250 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.webkit.WebView._computeScroll16251 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeScroll", "()V");
			global::android.webkit.WebView._setScrollBarStyle16252 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V");
			global::android.webkit.WebView._computeHorizontalScrollRange16253 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollRange16254 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollOffset16255 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.webkit.WebView._computeVerticalScrollExtent16256 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.webkit.WebView._onDraw16257 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.webkit.WebView._setBackgroundColor16258 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V");
			global::android.webkit.WebView._onMeasure16259 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V");
			global::android.webkit.WebView._requestChildRectangleOnScreen16260 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.webkit.WebView._drawChild16261 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.webkit.WebView._getProgress16262 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getProgress", "()I");
			global::android.webkit.WebView._onChildViewAdded16263 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._onChildViewRemoved16264 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getUrl16265 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._saveState16266 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._restoreState16267 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._clearHistory16268 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearHistory", "()V");
			global::android.webkit.WebView._reload16269 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "reload", "()V");
			global::android.webkit.WebView._onGlobalFocusChanged16270 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getOriginalUrl16271 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._getFavicon16272 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebView._setHorizontalScrollbarOverlay16273 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._setVerticalScrollbarOverlay16274 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._overlayHorizontalScrollbar16275 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z");
			global::android.webkit.WebView._overlayVerticalScrollbar16276 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z");
			global::android.webkit.WebView._setCertificate16277 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V");
			global::android.webkit.WebView._savePassword16278 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._setHttpAuthUsernamePassword16279 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._getHttpAuthUsernamePassword16280 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.webkit.WebView._enablePlatformNotifications16281 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			global::android.webkit.WebView._disablePlatformNotifications16282 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			global::android.webkit.WebView._setNetworkAvailable16283 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V");
			global::android.webkit.WebView._savePicture16284 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._restorePicture16285 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._loadUrl16286 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.webkit.WebView._loadUrl16287 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebView._postUrl16288 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V");
			global::android.webkit.WebView._loadData16289 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._loadDataWithBaseURL16290 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._stopLoading16291 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "stopLoading", "()V");
			global::android.webkit.WebView._canGoBack16292 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBack", "()Z");
			global::android.webkit.WebView._goBack16293 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBack", "()V");
			global::android.webkit.WebView._canGoForward16294 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoForward", "()Z");
			global::android.webkit.WebView._goForward16295 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goForward", "()V");
			global::android.webkit.WebView._canGoBackOrForward16296 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z");
			global::android.webkit.WebView._goBackOrForward16297 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V");
			global::android.webkit.WebView._pageUp16298 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z");
			global::android.webkit.WebView._pageDown16299 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z");
			global::android.webkit.WebView._clearView16300 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearView", "()V");
			global::android.webkit.WebView._capturePicture16301 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;");
			global::android.webkit.WebView._getScale16302 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getScale", "()F");
			global::android.webkit.WebView._setInitialScale16303 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V");
			global::android.webkit.WebView._invokeZoomPicker16304 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V");
			global::android.webkit.WebView._getHitTestResult16305 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;");
			global::android.webkit.WebView._requestFocusNodeHref16306 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._requestImageRef16307 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._getContentHeight16308 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getContentHeight", "()I");
			global::android.webkit.WebView._pauseTimers16309 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "pauseTimers", "()V");
			global::android.webkit.WebView._resumeTimers16310 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "resumeTimers", "()V");
			global::android.webkit.WebView._clearFormData16311 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearFormData", "()V");
			global::android.webkit.WebView._clearSslPreferences16312 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V");
			global::android.webkit.WebView._copyBackForwardList16313 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._findNext16314 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findNext", "(Z)V");
			global::android.webkit.WebView._findAll16315 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I");
			global::android.webkit.WebView._findAddress16316 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.WebView._clearMatches16317 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "clearMatches", "()V");
			global::android.webkit.WebView._documentHasImages16318 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._setWebViewClient16319 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V");
			global::android.webkit.WebView._setDownloadListener16320 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V");
			global::android.webkit.WebView._setWebChromeClient16321 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V");
			global::android.webkit.WebView._setPictureListener16322 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V");
			global::android.webkit.WebView._addJavascriptInterface16323 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V");
			global::android.webkit.WebView._getSettings16324 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;");
			global::android.webkit.WebView._getPluginList16325 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			global::android.webkit.WebView._refreshPlugins16326 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V");
			global::android.webkit.WebView._emulateShiftHeld16327 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V");
			global::android.webkit.WebView._setMapTrackballToArrowKeys16328 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V");
			global::android.webkit.WebView._flingScroll16329 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V");
			global::android.webkit.WebView._getZoomControls16330 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.webkit.WebView._zoomIn16331 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomIn", "()Z");
			global::android.webkit.WebView._zoomOut16332 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "zoomOut", "()Z");
			global::android.webkit.WebView._debugDump16333 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "debugDump", "()V");
			global::android.webkit.WebView._WebView16334 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.webkit.WebView._WebView16335 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.webkit.WebView._WebView16336 = @__env.GetMethodIDNoThrow(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
