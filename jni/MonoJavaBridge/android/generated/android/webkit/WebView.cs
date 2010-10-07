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
			internal static global::net.sf.jni4net.jni.MethodId _getType10215;
			public virtual int getType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.webkit.WebView.HitTestResult._getType10215);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getType10215);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getExtra10216;
			public virtual global::java.lang.String getExtra() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView.HitTestResult._getExtra10216));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.HitTestResult.staticClass, global::android.webkit.WebView.HitTestResult._getExtra10216));
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
				global::android.webkit.WebView.HitTestResult._getType10215 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getType", "()I");
				global::android.webkit.WebView.HitTestResult._getExtra10216 = @__env.GetMethodID(global::android.webkit.WebView.HitTestResult.staticClass, "getExtra", "()Ljava/lang/String;");
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
			internal static global::net.sf.jni4net.jni.MethodId _onNewPicture10217;
			 void android.webkit.WebView.PictureListener.onNewPicture(android.webkit.WebView arg0, android.graphics.Picture arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.WebView.__PictureListener._onNewPicture10217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.__PictureListener.staticClass, global::android.webkit.WebView.__PictureListener._onNewPicture10217, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebView.__PictureListener.staticClass = @__class;
				global::android.webkit.WebView.__PictureListener._onNewPicture10217 = @__env.GetMethodID(global::android.webkit.WebView.__PictureListener.staticClass, "android.webkit.WebView.PictureListener.onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _setWebView10218;
			public virtual void setWebView(android.webkit.WebView arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.webkit.WebView.WebViewTransport._setWebView10218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._setWebView10218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getWebView10219;
			public virtual global::android.webkit.WebView getWebView() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView.WebViewTransport._getWebView10219));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._getWebView10219));
			}
			internal static global::net.sf.jni4net.jni.MethodId _WebViewTransport10220;
			public WebViewTransport(android.webkit.WebView arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.webkit.WebView.WebViewTransport.staticClass, global::android.webkit.WebView.WebViewTransport._WebViewTransport10220, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.webkit.WebView.WebViewTransport.staticClass = @__class;
				global::android.webkit.WebView.WebViewTransport._setWebView10218 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "setWebView", "(Landroid/webkit/WebView;)V");
				global::android.webkit.WebView.WebViewTransport._getWebView10219 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "getWebView", "()Landroid/webkit/WebView;");
				global::android.webkit.WebView.WebViewTransport._WebViewTransport10220 = @__env.GetMethodID(global::android.webkit.WebView.WebViewTransport.staticClass, "<init>", "(Landroid/webkit/WebView;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroy10221;
		public virtual void destroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._destroy10221);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._destroy10221);
		}
		internal static global::net.sf.jni4net.jni.MethodId _freeMemory10222;
		public virtual void freeMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._freeMemory10222);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._freeMemory10222);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCertificate10223;
		public virtual global::android.net.http.SslCertificate getCertificate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getCertificate10223));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.http.SslCertificate>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getCertificate10223));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearCache10224;
		public virtual void clearCache(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearCache10224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearCache10224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10225;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onKeyDown10225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyDown10225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10226;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onKeyUp10226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onKeyUp10226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent10227;
		public override bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onTouchEvent10227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTouchEvent10227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTrackballEvent10228;
		public override bool onTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._onTrackballEvent10228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onTrackballEvent10228, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowFocusChanged10229;
		public override void onWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onWindowFocusChanged10229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onWindowFocusChanged10229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow10230;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onAttachedToWindow10230);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onAttachedToWindow10230);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10231;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onDetachedFromWindow10231);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDetachedFromWindow10231);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent10232;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._dispatchKeyEvent10232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._dispatchKeyEvent10232, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle10233;
		public virtual global::java.lang.String getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getTitle10233));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getTitle10233));
		}
		internal static global::net.sf.jni4net.jni.MethodId _performLongClick10234;
		public override bool performLongClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._performLongClick10234);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._performLongClick10234);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10235;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onFocusChanged10235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onFocusChanged10235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus10236;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._requestFocus10236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocus10236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateInputConnection10237;
		public override global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._onCreateInputConnection10237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.inputmethod.InputConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onCreateInputConnection10237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onScrollChanged10238;
		protected override void onScrollChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onScrollChanged10238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onScrollChanged10238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSizeChanged10239;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onSizeChanged10239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onSizeChanged10239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutParams10240;
		public override void setLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setLayoutParams10240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setLayoutParams10240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeScroll10241;
		public override void computeScroll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._computeScroll10241);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeScroll10241);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScrollBarStyle10242;
		public override void setScrollBarStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setScrollBarStyle10242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setScrollBarStyle10242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeHorizontalScrollRange10243;
		protected override int computeHorizontalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeHorizontalScrollRange10243);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeHorizontalScrollRange10243);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange10244;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollRange10244);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollRange10244);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset10245;
		protected override int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollOffset10245);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollOffset10245);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent10246;
		protected override int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._computeVerticalScrollExtent10246);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._computeVerticalScrollExtent10246);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw10247;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onDraw10247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onDraw10247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBackgroundColor10248;
		public override void setBackgroundColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setBackgroundColor10248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setBackgroundColor10248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10249;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onMeasure10249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onMeasure10249, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen10250;
		public override bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._requestChildRectangleOnScreen10250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestChildRectangleOnScreen10250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawChild10251;
		protected override bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._drawChild10251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._drawChild10251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProgress10252;
		public virtual int getProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._getProgress10252);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getProgress10252);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewAdded10253;
		public virtual void onChildViewAdded(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onChildViewAdded10253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewAdded10253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildViewRemoved10254;
		public virtual void onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onChildViewRemoved10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onChildViewRemoved10254, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUrl10255;
		public virtual global::java.lang.String getUrl() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getUrl10255));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getUrl10255));
		}
		internal static global::net.sf.jni4net.jni.MethodId _saveState10256;
		public virtual global::android.webkit.WebBackForwardList saveState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._saveState10256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._saveState10256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreState10257;
		public virtual global::android.webkit.WebBackForwardList restoreState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._restoreState10257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restoreState10257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearHistory10258;
		public virtual void clearHistory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearHistory10258);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearHistory10258);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reload10259;
		public virtual void reload() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._reload10259);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._reload10259);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGlobalFocusChanged10260;
		public virtual void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._onGlobalFocusChanged10260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._onGlobalFocusChanged10260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOriginalUrl10261;
		public virtual global::java.lang.String getOriginalUrl() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getOriginalUrl10261));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getOriginalUrl10261));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFavicon10262;
		public virtual global::android.graphics.Bitmap getFavicon() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getFavicon10262));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getFavicon10262));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalScrollbarOverlay10263;
		public virtual void setHorizontalScrollbarOverlay(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setHorizontalScrollbarOverlay10263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHorizontalScrollbarOverlay10263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalScrollbarOverlay10264;
		public virtual void setVerticalScrollbarOverlay(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setVerticalScrollbarOverlay10264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setVerticalScrollbarOverlay10264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _overlayHorizontalScrollbar10265;
		public virtual bool overlayHorizontalScrollbar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._overlayHorizontalScrollbar10265);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayHorizontalScrollbar10265);
		}
		internal static global::net.sf.jni4net.jni.MethodId _overlayVerticalScrollbar10266;
		public virtual bool overlayVerticalScrollbar() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._overlayVerticalScrollbar10266);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._overlayVerticalScrollbar10266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCertificate10267;
		public virtual void setCertificate(android.net.http.SslCertificate arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setCertificate10267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setCertificate10267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _savePassword10268;
		public virtual void savePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._savePassword10268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePassword10268, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHttpAuthUsernamePassword10269;
		public virtual void setHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setHttpAuthUsernamePassword10269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setHttpAuthUsernamePassword10269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHttpAuthUsernamePassword10270;
		public virtual global::java.lang.String[] getHttpAuthUsernamePassword(java.lang.String arg0, java.lang.String arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getHttpAuthUsernamePassword10270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHttpAuthUsernamePassword10270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enablePlatformNotifications10271;
		public static void enablePlatformNotifications() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._enablePlatformNotifications10271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _disablePlatformNotifications10272;
		public static void disablePlatformNotifications() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.webkit.WebView.staticClass, global::android.webkit.WebView._disablePlatformNotifications10272);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNetworkAvailable10273;
		public virtual void setNetworkAvailable(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setNetworkAvailable10273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setNetworkAvailable10273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _savePicture10274;
		public virtual bool savePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._savePicture10274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._savePicture10274, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restorePicture10275;
		public virtual bool restorePicture(android.os.Bundle arg0, java.io.File arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._restorePicture10275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._restorePicture10275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadUrl10276;
		public virtual void loadUrl(java.lang.String arg0, java.util.Map arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadUrl10276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl10276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadUrl10277;
		public virtual void loadUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadUrl10277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadUrl10277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postUrl10278;
		public virtual void postUrl(java.lang.String arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._postUrl10278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._postUrl10278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadData10279;
		public virtual void loadData(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadData10279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadData10279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDataWithBaseURL10280;
		public virtual void loadDataWithBaseURL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._loadDataWithBaseURL10280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._loadDataWithBaseURL10280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopLoading10281;
		public virtual void stopLoading() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._stopLoading10281);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._stopLoading10281);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canGoBack10282;
		public virtual bool canGoBack() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoBack10282);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBack10282);
		}
		internal static global::net.sf.jni4net.jni.MethodId _goBack10283;
		public virtual void goBack() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goBack10283);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBack10283);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canGoForward10284;
		public virtual bool canGoForward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoForward10284);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoForward10284);
		}
		internal static global::net.sf.jni4net.jni.MethodId _goForward10285;
		public virtual void goForward() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goForward10285);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goForward10285);
		}
		internal static global::net.sf.jni4net.jni.MethodId _canGoBackOrForward10286;
		public virtual bool canGoBackOrForward(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._canGoBackOrForward10286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._canGoBackOrForward10286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _goBackOrForward10287;
		public virtual void goBackOrForward(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._goBackOrForward10287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._goBackOrForward10287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pageUp10288;
		public virtual bool pageUp(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._pageUp10288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageUp10288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pageDown10289;
		public virtual bool pageDown(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._pageDown10289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pageDown10289, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearView10290;
		public virtual void clearView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearView10290);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearView10290);
		}
		internal static global::net.sf.jni4net.jni.MethodId _capturePicture10291;
		public virtual global::android.graphics.Picture capturePicture() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._capturePicture10291));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._capturePicture10291));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScale10292;
		public virtual float getScale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.webkit.WebView._getScale10292);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getScale10292);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInitialScale10293;
		public virtual void setInitialScale(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setInitialScale10293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setInitialScale10293, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invokeZoomPicker10294;
		public virtual void invokeZoomPicker() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._invokeZoomPicker10294);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._invokeZoomPicker10294);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHitTestResult10295;
		public virtual global::android.webkit.WebView.HitTestResult getHitTestResult() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getHitTestResult10295));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebView.HitTestResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getHitTestResult10295));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocusNodeHref10296;
		public virtual void requestFocusNodeHref(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._requestFocusNodeHref10296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestFocusNodeHref10296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestImageRef10297;
		public virtual void requestImageRef(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._requestImageRef10297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._requestImageRef10297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContentHeight10298;
		public virtual int getContentHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._getContentHeight10298);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getContentHeight10298);
		}
		internal static global::net.sf.jni4net.jni.MethodId _pauseTimers10299;
		public virtual void pauseTimers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._pauseTimers10299);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._pauseTimers10299);
		}
		internal static global::net.sf.jni4net.jni.MethodId _resumeTimers10300;
		public virtual void resumeTimers() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._resumeTimers10300);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._resumeTimers10300);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData10301;
		public virtual void clearFormData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearFormData10301);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearFormData10301);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearSslPreferences10302;
		public virtual void clearSslPreferences() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearSslPreferences10302);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearSslPreferences10302);
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyBackForwardList10303;
		public virtual global::android.webkit.WebBackForwardList copyBackForwardList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._copyBackForwardList10303));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebBackForwardList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._copyBackForwardList10303));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findNext10304;
		public virtual void findNext(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._findNext10304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findNext10304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findAll10305;
		public virtual int findAll(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.webkit.WebView._findAll10305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._findAll10305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findAddress10306;
		public static global::java.lang.String findAddress(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, global::android.webkit.WebView._findAddress10306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMatches10307;
		public virtual void clearMatches() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._clearMatches10307);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._clearMatches10307);
		}
		internal static global::net.sf.jni4net.jni.MethodId _documentHasImages10308;
		public virtual void documentHasImages(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._documentHasImages10308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._documentHasImages10308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWebViewClient10309;
		public virtual void setWebViewClient(android.webkit.WebViewClient arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setWebViewClient10309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebViewClient10309, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDownloadListener10310;
		public virtual void setDownloadListener(android.webkit.DownloadListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setDownloadListener10310, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setDownloadListener10310, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWebChromeClient10311;
		public virtual void setWebChromeClient(android.webkit.WebChromeClient arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setWebChromeClient10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setWebChromeClient10311, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPictureListener10312;
		public virtual void setPictureListener(android.webkit.WebView.PictureListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setPictureListener10312, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setPictureListener10312, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addJavascriptInterface10313;
		public virtual void addJavascriptInterface(java.lang.Object arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._addJavascriptInterface10313, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._addJavascriptInterface10313, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSettings10314;
		public virtual global::android.webkit.WebSettings getSettings() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getSettings10314));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebSettings>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getSettings10314));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPluginList10315;
		public static global::android.webkit.PluginList getPluginList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.PluginList>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebView.staticClass, global::android.webkit.WebView._getPluginList10315));
		}
		internal static global::net.sf.jni4net.jni.MethodId _refreshPlugins10316;
		public virtual void refreshPlugins(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._refreshPlugins10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._refreshPlugins10316, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _emulateShiftHeld10317;
		public virtual void emulateShiftHeld() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._emulateShiftHeld10317);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._emulateShiftHeld10317);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMapTrackballToArrowKeys10318;
		public virtual void setMapTrackballToArrowKeys(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._setMapTrackballToArrowKeys10318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._setMapTrackballToArrowKeys10318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _flingScroll10319;
		public virtual void flingScroll(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._flingScroll10319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._flingScroll10319, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getZoomControls10320;
		public virtual global::android.view.View getZoomControls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.WebView._getZoomControls10320));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._getZoomControls10320));
		}
		internal static global::net.sf.jni4net.jni.MethodId _zoomIn10321;
		public virtual bool zoomIn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._zoomIn10321);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomIn10321);
		}
		internal static global::net.sf.jni4net.jni.MethodId _zoomOut10322;
		public virtual bool zoomOut() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.WebView._zoomOut10322);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._zoomOut10322);
		}
		internal static global::net.sf.jni4net.jni.MethodId _debugDump10323;
		public virtual void debugDump() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.WebView._debugDump10323);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.WebView.staticClass, global::android.webkit.WebView._debugDump10323);
		}
		internal static global::net.sf.jni4net.jni.MethodId _WebView10324;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10324, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WebView10325;
		public WebView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10325, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WebView10326;
		public WebView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.webkit.WebView.staticClass, global::android.webkit.WebView._WebView10326, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.webkit.WebView._destroy10221 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "destroy", "()V");
			global::android.webkit.WebView._freeMemory10222 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "freeMemory", "()V");
			global::android.webkit.WebView._getCertificate10223 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getCertificate", "()Landroid/net/http/SslCertificate;");
			global::android.webkit.WebView._clearCache10224 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearCache", "(Z)V");
			global::android.webkit.WebView._onKeyDown10225 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onKeyUp10226 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._onTouchEvent10227 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onTrackballEvent10228 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.webkit.WebView._onWindowFocusChanged10229 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onWindowFocusChanged", "(Z)V");
			global::android.webkit.WebView._onAttachedToWindow10230 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onAttachedToWindow", "()V");
			global::android.webkit.WebView._onDetachedFromWindow10231 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDetachedFromWindow", "()V");
			global::android.webkit.WebView._dispatchKeyEvent10232 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.webkit.WebView._getTitle10233 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getTitle", "()Ljava/lang/String;");
			global::android.webkit.WebView._performLongClick10234 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "performLongClick", "()Z");
			global::android.webkit.WebView._onFocusChanged10235 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.webkit.WebView._requestFocus10236 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.webkit.WebView._onCreateInputConnection10237 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;");
			global::android.webkit.WebView._onScrollChanged10238 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onScrollChanged", "(IIII)V");
			global::android.webkit.WebView._onSizeChanged10239 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onSizeChanged", "(IIII)V");
			global::android.webkit.WebView._setLayoutParams10240 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.webkit.WebView._computeScroll10241 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeScroll", "()V");
			global::android.webkit.WebView._setScrollBarStyle10242 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setScrollBarStyle", "(I)V");
			global::android.webkit.WebView._computeHorizontalScrollRange10243 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeHorizontalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollRange10244 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.webkit.WebView._computeVerticalScrollOffset10245 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.webkit.WebView._computeVerticalScrollExtent10246 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.webkit.WebView._onDraw10247 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.webkit.WebView._setBackgroundColor10248 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setBackgroundColor", "(I)V");
			global::android.webkit.WebView._onMeasure10249 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onMeasure", "(II)V");
			global::android.webkit.WebView._requestChildRectangleOnScreen10250 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.webkit.WebView._drawChild10251 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.webkit.WebView._getProgress10252 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getProgress", "()I");
			global::android.webkit.WebView._onChildViewAdded10253 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._onChildViewRemoved10254 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getUrl10255 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._saveState10256 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "saveState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._restoreState10257 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restoreState", "(Landroid/os/Bundle;)Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._clearHistory10258 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearHistory", "()V");
			global::android.webkit.WebView._reload10259 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "reload", "()V");
			global::android.webkit.WebView._onGlobalFocusChanged10260 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.webkit.WebView._getOriginalUrl10261 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getOriginalUrl", "()Ljava/lang/String;");
			global::android.webkit.WebView._getFavicon10262 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getFavicon", "()Landroid/graphics/Bitmap;");
			global::android.webkit.WebView._setHorizontalScrollbarOverlay10263 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHorizontalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._setVerticalScrollbarOverlay10264 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setVerticalScrollbarOverlay", "(Z)V");
			global::android.webkit.WebView._overlayHorizontalScrollbar10265 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayHorizontalScrollbar", "()Z");
			global::android.webkit.WebView._overlayVerticalScrollbar10266 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "overlayVerticalScrollbar", "()Z");
			global::android.webkit.WebView._setCertificate10267 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setCertificate", "(Landroid/net/http/SslCertificate;)V");
			global::android.webkit.WebView._savePassword10268 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._setHttpAuthUsernamePassword10269 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._getHttpAuthUsernamePassword10270 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHttpAuthUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			global::android.webkit.WebView._enablePlatformNotifications10271 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "enablePlatformNotifications", "()V");
			global::android.webkit.WebView._disablePlatformNotifications10272 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "disablePlatformNotifications", "()V");
			global::android.webkit.WebView._setNetworkAvailable10273 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setNetworkAvailable", "(Z)V");
			global::android.webkit.WebView._savePicture10274 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "savePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._restorePicture10275 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "restorePicture", "(Landroid/os/Bundle;Ljava/io/File;)Z");
			global::android.webkit.WebView._loadUrl10276 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;Ljava/util/Map;)V");
			global::android.webkit.WebView._loadUrl10277 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadUrl", "(Ljava/lang/String;)V");
			global::android.webkit.WebView._postUrl10278 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "postUrl", "(Ljava/lang/String;[B)V");
			global::android.webkit.WebView._loadData10279 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._loadDataWithBaseURL10280 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "loadDataWithBaseURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.WebView._stopLoading10281 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "stopLoading", "()V");
			global::android.webkit.WebView._canGoBack10282 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBack", "()Z");
			global::android.webkit.WebView._goBack10283 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBack", "()V");
			global::android.webkit.WebView._canGoForward10284 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoForward", "()Z");
			global::android.webkit.WebView._goForward10285 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goForward", "()V");
			global::android.webkit.WebView._canGoBackOrForward10286 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "canGoBackOrForward", "(I)Z");
			global::android.webkit.WebView._goBackOrForward10287 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "goBackOrForward", "(I)V");
			global::android.webkit.WebView._pageUp10288 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageUp", "(Z)Z");
			global::android.webkit.WebView._pageDown10289 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pageDown", "(Z)Z");
			global::android.webkit.WebView._clearView10290 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearView", "()V");
			global::android.webkit.WebView._capturePicture10291 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "capturePicture", "()Landroid/graphics/Picture;");
			global::android.webkit.WebView._getScale10292 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getScale", "()F");
			global::android.webkit.WebView._setInitialScale10293 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setInitialScale", "(I)V");
			global::android.webkit.WebView._invokeZoomPicker10294 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "invokeZoomPicker", "()V");
			global::android.webkit.WebView._getHitTestResult10295 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getHitTestResult", "()Landroid/webkit/WebView$HitTestResult;");
			global::android.webkit.WebView._requestFocusNodeHref10296 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestFocusNodeHref", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._requestImageRef10297 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "requestImageRef", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._getContentHeight10298 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getContentHeight", "()I");
			global::android.webkit.WebView._pauseTimers10299 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "pauseTimers", "()V");
			global::android.webkit.WebView._resumeTimers10300 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "resumeTimers", "()V");
			global::android.webkit.WebView._clearFormData10301 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearFormData", "()V");
			global::android.webkit.WebView._clearSslPreferences10302 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearSslPreferences", "()V");
			global::android.webkit.WebView._copyBackForwardList10303 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "copyBackForwardList", "()Landroid/webkit/WebBackForwardList;");
			global::android.webkit.WebView._findNext10304 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findNext", "(Z)V");
			global::android.webkit.WebView._findAll10305 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "findAll", "(Ljava/lang/String;)I");
			global::android.webkit.WebView._findAddress10306 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "findAddress", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.WebView._clearMatches10307 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "clearMatches", "()V");
			global::android.webkit.WebView._documentHasImages10308 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "documentHasImages", "(Landroid/os/Message;)V");
			global::android.webkit.WebView._setWebViewClient10309 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebViewClient", "(Landroid/webkit/WebViewClient;)V");
			global::android.webkit.WebView._setDownloadListener10310 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setDownloadListener", "(Landroid/webkit/DownloadListener;)V");
			global::android.webkit.WebView._setWebChromeClient10311 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setWebChromeClient", "(Landroid/webkit/WebChromeClient;)V");
			global::android.webkit.WebView._setPictureListener10312 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setPictureListener", "(Landroid/webkit/WebView$PictureListener;)V");
			global::android.webkit.WebView._addJavascriptInterface10313 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "addJavascriptInterface", "(Ljava/lang/Object;Ljava/lang/String;)V");
			global::android.webkit.WebView._getSettings10314 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getSettings", "()Landroid/webkit/WebSettings;");
			global::android.webkit.WebView._getPluginList10315 = @__env.GetStaticMethodID(global::android.webkit.WebView.staticClass, "getPluginList", "()Landroid/webkit/PluginList;");
			global::android.webkit.WebView._refreshPlugins10316 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "refreshPlugins", "(Z)V");
			global::android.webkit.WebView._emulateShiftHeld10317 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "emulateShiftHeld", "()V");
			global::android.webkit.WebView._setMapTrackballToArrowKeys10318 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "setMapTrackballToArrowKeys", "(Z)V");
			global::android.webkit.WebView._flingScroll10319 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "flingScroll", "(II)V");
			global::android.webkit.WebView._getZoomControls10320 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "getZoomControls", "()Landroid/view/View;");
			global::android.webkit.WebView._zoomIn10321 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomIn", "()Z");
			global::android.webkit.WebView._zoomOut10322 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "zoomOut", "()Z");
			global::android.webkit.WebView._debugDump10323 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "debugDump", "()V");
			global::android.webkit.WebView._WebView10324 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.webkit.WebView._WebView10325 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.webkit.WebView._WebView10326 = @__env.GetMethodID(global::android.webkit.WebView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
