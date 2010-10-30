namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ViewTreeObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewTreeObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_))]
		public partial interface OnGlobalFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener))]
		internal sealed partial class OnGlobalFocusChangeListener_ : java.lang.Object, OnGlobalFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGlobalFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", ref global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGlobalFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalFocusChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnGlobalFocusChangeListenerDelegate(android.view.View arg0, android.view.View arg1);

		internal partial class OnGlobalFocusChangeListenerDelegateWrapper : java.lang.Object, OnGlobalFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGlobalFocusChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGlobalFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGlobalFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnGlobalFocusChangeListenerDelegateWrapper
		{
			private OnGlobalFocusChangeListenerDelegate myDelegate;
			public void onGlobalFocusChanged(android.view.View arg0, android.view.View arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnGlobalFocusChangeListenerDelegateWrapper(OnGlobalFocusChangeListenerDelegate d)
			{
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper ret = new global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_))]
		public partial interface OnGlobalLayoutListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGlobalLayout();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnGlobalLayoutListener))]
		internal sealed partial class OnGlobalLayoutListener_ : java.lang.Object, OnGlobalLayoutListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGlobalLayoutListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, "onGlobalLayout", "()V", ref global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._m0);
			}
			static OnGlobalLayoutListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalLayoutListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnGlobalLayoutListenerDelegate();

		internal partial class OnGlobalLayoutListenerDelegateWrapper : java.lang.Object, OnGlobalLayoutListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGlobalLayoutListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGlobalLayoutListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGlobalLayoutListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnGlobalLayoutListenerDelegateWrapper
		{
			private OnGlobalLayoutListenerDelegate myDelegate;
			public void onGlobalLayout()
			{
				myDelegate();
			}
			public static implicit operator OnGlobalLayoutListenerDelegateWrapper(OnGlobalLayoutListenerDelegate d)
			{
				global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper ret = new global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnPreDrawListener_))]
		public partial interface OnPreDrawListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onPreDraw();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnPreDrawListener))]
		internal sealed partial class OnPreDrawListener_ : java.lang.Object, OnPreDrawListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnPreDrawListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, "onPreDraw", "()Z", ref global::android.view.ViewTreeObserver.OnPreDrawListener_._m0);
			}
			static OnPreDrawListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnPreDrawListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool OnPreDrawListenerDelegate();

		internal partial class OnPreDrawListenerDelegateWrapper : java.lang.Object, OnPreDrawListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnPreDrawListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnPreDrawListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnPreDrawListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnPreDrawListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnPreDrawListenerDelegateWrapper
		{
			private OnPreDrawListenerDelegate myDelegate;
			public bool onPreDraw()
			{
				return myDelegate();
			}
			public static implicit operator OnPreDrawListenerDelegateWrapper(OnPreDrawListenerDelegate d)
			{
				global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper ret = new global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnScrollChangedListener_))]
		public partial interface OnScrollChangedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onScrollChanged();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnScrollChangedListener))]
		internal sealed partial class OnScrollChangedListener_ : java.lang.Object, OnScrollChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnScrollChangedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, "onScrollChanged", "()V", ref global::android.view.ViewTreeObserver.OnScrollChangedListener_._m0);
			}
			static OnScrollChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnScrollChangedListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnScrollChangedListenerDelegate();

		internal partial class OnScrollChangedListenerDelegateWrapper : java.lang.Object, OnScrollChangedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnScrollChangedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnScrollChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnScrollChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnScrollChangedListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnScrollChangedListenerDelegateWrapper
		{
			private OnScrollChangedListenerDelegate myDelegate;
			public void onScrollChanged()
			{
				myDelegate();
			}
			public static implicit operator OnScrollChangedListenerDelegateWrapper(OnScrollChangedListenerDelegate d)
			{
				global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper ret = new global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_))]
		public partial interface OnTouchModeChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onTouchModeChanged(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewTreeObserver.OnTouchModeChangeListener))]
		internal sealed partial class OnTouchModeChangeListener_ : java.lang.Object, OnTouchModeChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTouchModeChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, "onTouchModeChanged", "(Z)V", ref global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnTouchModeChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnTouchModeChangeListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnTouchModeChangeListenerDelegate(bool arg0);

		internal partial class OnTouchModeChangeListenerDelegateWrapper : java.lang.Object, OnTouchModeChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTouchModeChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnTouchModeChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnTouchModeChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnTouchModeChangeListenerDelegateWrapper
		{
			private OnTouchModeChangeListenerDelegate myDelegate;
			public void onTouchModeChanged(bool arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnTouchModeChangeListenerDelegateWrapper(OnTouchModeChangeListenerDelegate d)
			{
				global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper ret = new global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public bool isAlive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z", ref global::android.view.ViewTreeObserver._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", ref global::android.view.ViewTreeObserver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGlobalFocusChangeListener(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegate arg0)
		{
			addOnGlobalFocusChangeListener((global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", ref global::android.view.ViewTreeObserver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnGlobalFocusChangeListener(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegate arg0)
		{
			removeOnGlobalFocusChangeListener((global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", ref global::android.view.ViewTreeObserver._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGlobalLayoutListener(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegate arg0)
		{
			addOnGlobalLayoutListener((global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", ref global::android.view.ViewTreeObserver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeGlobalOnLayoutListener(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegate arg0)
		{
			removeGlobalOnLayoutListener((global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", ref global::android.view.ViewTreeObserver._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnPreDrawListener(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegate arg0)
		{
			addOnPreDrawListener((global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", ref global::android.view.ViewTreeObserver._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnPreDrawListener(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegate arg0)
		{
			removeOnPreDrawListener((global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", ref global::android.view.ViewTreeObserver._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnScrollChangedListener(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegate arg0)
		{
			addOnScrollChangedListener((global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", ref global::android.view.ViewTreeObserver._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnScrollChangedListener(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegate arg0)
		{
			removeOnScrollChangedListener((global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", ref global::android.view.ViewTreeObserver._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnTouchModeChangeListener(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegate arg0)
		{
			addOnTouchModeChangeListener((global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", ref global::android.view.ViewTreeObserver._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnTouchModeChangeListener(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegate arg0)
		{
			removeOnTouchModeChangeListener((global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void dispatchOnGlobalLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V", ref global::android.view.ViewTreeObserver._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public bool dispatchOnPreDraw()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z", ref global::android.view.ViewTreeObserver._m12);
		}
		static ViewTreeObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewTreeObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
