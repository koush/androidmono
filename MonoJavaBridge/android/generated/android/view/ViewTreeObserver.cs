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
			internal static global::MonoJavaBridge.MethodId _onGlobalFocusChanged15220;
			void android.view.ViewTreeObserver.OnGlobalFocusChangeListener.onGlobalFocusChanged(android.view.View arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged15220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGlobalFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalFocusChangeListener"));
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_._onGlobalFocusChanged15220 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListener_.staticClass, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
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
			internal static global::MonoJavaBridge.MethodId _OnGlobalFocusChangeListenerDelegateWrapper15221;
			public OnGlobalFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper._OnGlobalFocusChangeListenerDelegateWrapper15221);
				Init(@__env, handle);
			}
			static OnGlobalFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper"));
				global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper._OnGlobalFocusChangeListenerDelegateWrapper15221 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onGlobalLayout15222;
			void android.view.ViewTreeObserver.OnGlobalLayoutListener.onGlobalLayout()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout15222);
			}
			static OnGlobalLayoutListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnGlobalLayoutListener"));
				global::android.view.ViewTreeObserver.OnGlobalLayoutListener_._onGlobalLayout15222 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListener_.staticClass, "onGlobalLayout", "()V");
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
			internal static global::MonoJavaBridge.MethodId _OnGlobalLayoutListenerDelegateWrapper15223;
			public OnGlobalLayoutListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper._OnGlobalLayoutListenerDelegateWrapper15223);
				Init(@__env, handle);
			}
			static OnGlobalLayoutListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper"));
				global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper._OnGlobalLayoutListenerDelegateWrapper15223 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onPreDraw15224;
			bool android.view.ViewTreeObserver.OnPreDrawListener.onPreDraw()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw15224);
			}
			static OnPreDrawListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnPreDrawListener"));
				global::android.view.ViewTreeObserver.OnPreDrawListener_._onPreDraw15224 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListener_.staticClass, "onPreDraw", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _OnPreDrawListenerDelegateWrapper15225;
			public OnPreDrawListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper._OnPreDrawListenerDelegateWrapper15225);
				Init(@__env, handle);
			}
			static OnPreDrawListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnPreDrawListenerDelegateWrapper"));
				global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper._OnPreDrawListenerDelegateWrapper15225 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onScrollChanged15226;
			void android.view.ViewTreeObserver.OnScrollChangedListener.onScrollChanged()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged15226);
			}
			static OnScrollChangedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnScrollChangedListener"));
				global::android.view.ViewTreeObserver.OnScrollChangedListener_._onScrollChanged15226 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListener_.staticClass, "onScrollChanged", "()V");
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
			internal static global::MonoJavaBridge.MethodId _OnScrollChangedListenerDelegateWrapper15227;
			public OnScrollChangedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper._OnScrollChangedListenerDelegateWrapper15227);
				Init(@__env, handle);
			}
			static OnScrollChangedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnScrollChangedListenerDelegateWrapper"));
				global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper._OnScrollChangedListenerDelegateWrapper15227 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onTouchModeChanged15228;
			void android.view.ViewTreeObserver.OnTouchModeChangeListener.onTouchModeChanged(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged15228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnTouchModeChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver$OnTouchModeChangeListener"));
				global::android.view.ViewTreeObserver.OnTouchModeChangeListener_._onTouchModeChanged15228 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListener_.staticClass, "onTouchModeChanged", "(Z)V");
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
			internal static global::MonoJavaBridge.MethodId _OnTouchModeChangeListenerDelegateWrapper15229;
			public OnTouchModeChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass, global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper._OnTouchModeChangeListenerDelegateWrapper15229);
				Init(@__env, handle);
			}
			static OnTouchModeChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper"));
				global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper._OnTouchModeChangeListenerDelegateWrapper15229 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _isAlive15230;
		public bool isAlive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._isAlive15230);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalFocusChangeListener15231;
		public void addOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener15231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGlobalFocusChangeListener(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegate arg0)
		{
			addOnGlobalFocusChangeListener((global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGlobalFocusChangeListener15232;
		public void removeOnGlobalFocusChangeListener(android.view.ViewTreeObserver.OnGlobalFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener15232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnGlobalFocusChangeListener(global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegate arg0)
		{
			removeOnGlobalFocusChangeListener((global::android.view.ViewTreeObserver.OnGlobalFocusChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGlobalLayoutListener15233;
		public void addOnGlobalLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnGlobalLayoutListener15233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGlobalLayoutListener(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegate arg0)
		{
			addOnGlobalLayoutListener((global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeGlobalOnLayoutListener15234;
		public void removeGlobalOnLayoutListener(android.view.ViewTreeObserver.OnGlobalLayoutListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener15234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeGlobalOnLayoutListener(global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegate arg0)
		{
			removeGlobalOnLayoutListener((global::android.view.ViewTreeObserver.OnGlobalLayoutListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addOnPreDrawListener15235;
		public void addOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnPreDrawListener15235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnPreDrawListener(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegate arg0)
		{
			addOnPreDrawListener((global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeOnPreDrawListener15236;
		public void removeOnPreDrawListener(android.view.ViewTreeObserver.OnPreDrawListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnPreDrawListener15236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnPreDrawListener(global::android.view.ViewTreeObserver.OnPreDrawListenerDelegate arg0)
		{
			removeOnPreDrawListener((global::android.view.ViewTreeObserver.OnPreDrawListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addOnScrollChangedListener15237;
		public void addOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnScrollChangedListener15237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnScrollChangedListener(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegate arg0)
		{
			addOnScrollChangedListener((global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeOnScrollChangedListener15238;
		public void removeOnScrollChangedListener(android.view.ViewTreeObserver.OnScrollChangedListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnScrollChangedListener15238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnScrollChangedListener(global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegate arg0)
		{
			removeOnScrollChangedListener((global::android.view.ViewTreeObserver.OnScrollChangedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _addOnTouchModeChangeListener15239;
		public void addOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._addOnTouchModeChangeListener15239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnTouchModeChangeListener(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegate arg0)
		{
			addOnTouchModeChangeListener((global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeOnTouchModeChangeListener15240;
		public void removeOnTouchModeChangeListener(android.view.ViewTreeObserver.OnTouchModeChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener15240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnTouchModeChangeListener(global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegate arg0)
		{
			removeOnTouchModeChangeListener((global::android.view.ViewTreeObserver.OnTouchModeChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnGlobalLayout15241;
		public void dispatchOnGlobalLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnGlobalLayout15241);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchOnPreDraw15242;
		public bool dispatchOnPreDraw()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.ViewTreeObserver.staticClass, global::android.view.ViewTreeObserver._dispatchOnPreDraw15242);
		}
		static ViewTreeObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewTreeObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewTreeObserver"));
			global::android.view.ViewTreeObserver._isAlive15230 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "isAlive", "()Z");
			global::android.view.ViewTreeObserver._addOnGlobalFocusChangeListener15231 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnGlobalFocusChangeListener15232 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V");
			global::android.view.ViewTreeObserver._addOnGlobalLayoutListener15233 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._removeGlobalOnLayoutListener15234 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V");
			global::android.view.ViewTreeObserver._addOnPreDrawListener15235 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._removeOnPreDrawListener15236 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V");
			global::android.view.ViewTreeObserver._addOnScrollChangedListener15237 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._removeOnScrollChangedListener15238 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V");
			global::android.view.ViewTreeObserver._addOnTouchModeChangeListener15239 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._removeOnTouchModeChangeListener15240 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V");
			global::android.view.ViewTreeObserver._dispatchOnGlobalLayout15241 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnGlobalLayout", "()V");
			global::android.view.ViewTreeObserver._dispatchOnPreDraw15242 = @__env.GetMethodIDNoThrow(global::android.view.ViewTreeObserver.staticClass, "dispatchOnPreDraw", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
