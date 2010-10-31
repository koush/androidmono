namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class View : java.lang.Object, android.graphics.drawable.Drawable.Callback, android.view.KeyEvent.Callback, android.view.accessibility.AccessibilityEventSource
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected View(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class BaseSavedState : android.view.AbsSavedState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected BaseSavedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public BaseSavedState(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.BaseSavedState._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.BaseSavedState._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcel;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public BaseSavedState(android.os.Parcelable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.BaseSavedState._m1.native == global::System.IntPtr.Zero)
					global::android.view.View.BaseSavedState._m1 = @__env.GetMethodIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "<init>", "(Landroid/os/Parcelable;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.BaseSavedState.staticClass, global::android.view.View.BaseSavedState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR5686;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.View.BaseSavedState.staticClass, _CREATOR5686)) as android.os.Parcelable_Creator;
				}
			}
			static BaseSavedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.BaseSavedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$BaseSavedState"));
				global::android.view.View.BaseSavedState._CREATOR5686 = @__env.GetStaticFieldIDNoThrow(global::android.view.View.BaseSavedState.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MeasureSpec : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MeasureSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.String toString(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "toString", "(I)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static int getSize(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._m1.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._m1 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getSize", "(I)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static int getMode(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._m2.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._m2 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "getMode", "(I)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public static int makeMeasureSpec(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._m3.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._m3 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "makeMeasureSpec", "(II)I");
				return @__env.CallStaticIntMethod(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public MeasureSpec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.MeasureSpec._m4.native == global::System.IntPtr.Zero)
					global::android.view.View.MeasureSpec._m4 = @__env.GetMethodIDNoThrow(global::android.view.View.MeasureSpec.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.MeasureSpec.staticClass, global::android.view.View.MeasureSpec._m4);
				Init(@__env, handle);
			}
			public static int UNSPECIFIED
			{
				get
				{
					return 0;
				}
			}
			public static int EXACTLY
			{
				get
				{
					return 1073741824;
				}
			}
			public static int AT_MOST
			{
				get
				{
					return -2147483648;
				}
			}
			static MeasureSpec()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.MeasureSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$MeasureSpec"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnClickListener_))]
		public partial interface OnClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnClickListener))]
		internal sealed partial class OnClickListener_ : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.View.OnClickListener.onClick(android.view.View arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnClickListener_.staticClass, "onClick", "(Landroid/view/View;)V", ref global::android.view.View.OnClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnClickListener"));
			}
		}

		public delegate void OnClickListenerDelegate(android.view.View arg0);

		internal partial class OnClickListenerDelegateWrapper : java.lang.Object, OnClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnClickListenerDelegateWrapper.staticClass, global::android.view.View.OnClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnClickListenerDelegateWrapper"));
			}
		}
		internal partial class OnClickListenerDelegateWrapper
		{
			private OnClickListenerDelegate myDelegate;
			public void onClick(android.view.View arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnClickListenerDelegateWrapper(OnClickListenerDelegate d)
			{
				global::android.view.View.OnClickListenerDelegateWrapper ret = new global::android.view.View.OnClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnCreateContextMenuListener_))]
		public partial interface OnCreateContextMenuListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnCreateContextMenuListener))]
		internal sealed partial class OnCreateContextMenuListener_ : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnCreateContextMenuListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.View.OnCreateContextMenuListener.onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnCreateContextMenuListener_.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", ref global::android.view.View.OnCreateContextMenuListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnCreateContextMenuListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnCreateContextMenuListener"));
			}
		}

		public delegate void OnCreateContextMenuListenerDelegate(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2);

		internal partial class OnCreateContextMenuListenerDelegateWrapper : java.lang.Object, OnCreateContextMenuListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnCreateContextMenuListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnCreateContextMenuListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass, global::android.view.View.OnCreateContextMenuListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnCreateContextMenuListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnCreateContextMenuListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnCreateContextMenuListenerDelegateWrapper"));
			}
		}
		internal partial class OnCreateContextMenuListenerDelegateWrapper
		{
			private OnCreateContextMenuListenerDelegate myDelegate;
			public void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnCreateContextMenuListenerDelegateWrapper(OnCreateContextMenuListenerDelegate d)
			{
				global::android.view.View.OnCreateContextMenuListenerDelegateWrapper ret = new global::android.view.View.OnCreateContextMenuListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnFocusChangeListener_))]
		public partial interface OnFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onFocusChange(android.view.View arg0, bool arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnFocusChangeListener))]
		internal sealed partial class OnFocusChangeListener_ : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.View.OnFocusChangeListener.onFocusChange(android.view.View arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.OnFocusChangeListener_.staticClass, "onFocusChange", "(Landroid/view/View;Z)V", ref global::android.view.View.OnFocusChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnFocusChangeListener"));
			}
		}

		public delegate void OnFocusChangeListenerDelegate(android.view.View arg0, bool arg1);

		internal partial class OnFocusChangeListenerDelegateWrapper : java.lang.Object, OnFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnFocusChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnFocusChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnFocusChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass, global::android.view.View.OnFocusChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnFocusChangeListenerDelegateWrapper"));
			}
		}
		internal partial class OnFocusChangeListenerDelegateWrapper
		{
			private OnFocusChangeListenerDelegate myDelegate;
			public void onFocusChange(android.view.View arg0, bool arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnFocusChangeListenerDelegateWrapper(OnFocusChangeListenerDelegate d)
			{
				global::android.view.View.OnFocusChangeListenerDelegateWrapper ret = new global::android.view.View.OnFocusChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnKeyListener_))]
		public partial interface OnKeyListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnKeyListener))]
		internal sealed partial class OnKeyListener_ : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.View.OnKeyListener.onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnKeyListener_.staticClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", ref global::android.view.View.OnKeyListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnKeyListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnKeyListener"));
			}
		}

		public delegate bool OnKeyListenerDelegate(android.view.View arg0, int arg1, android.view.KeyEvent arg2);

		internal partial class OnKeyListenerDelegateWrapper : java.lang.Object, OnKeyListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnKeyListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnKeyListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnKeyListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnKeyListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnKeyListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnKeyListenerDelegateWrapper.staticClass, global::android.view.View.OnKeyListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnKeyListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnKeyListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnKeyListenerDelegateWrapper"));
			}
		}
		internal partial class OnKeyListenerDelegateWrapper
		{
			private OnKeyListenerDelegate myDelegate;
			public bool onKey(android.view.View arg0, int arg1, android.view.KeyEvent arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnKeyListenerDelegateWrapper(OnKeyListenerDelegate d)
			{
				global::android.view.View.OnKeyListenerDelegateWrapper ret = new global::android.view.View.OnKeyListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnLongClickListener_))]
		public partial interface OnLongClickListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLongClick(android.view.View arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnLongClickListener))]
		internal sealed partial class OnLongClickListener_ : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnLongClickListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.View.OnLongClickListener.onLongClick(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnLongClickListener_.staticClass, "onLongClick", "(Landroid/view/View;)Z", ref global::android.view.View.OnLongClickListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnLongClickListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnLongClickListener"));
			}
		}

		public delegate bool OnLongClickListenerDelegate(android.view.View arg0);

		internal partial class OnLongClickListenerDelegateWrapper : java.lang.Object, OnLongClickListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnLongClickListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnLongClickListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnLongClickListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnLongClickListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnLongClickListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnLongClickListenerDelegateWrapper.staticClass, global::android.view.View.OnLongClickListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnLongClickListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnLongClickListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnLongClickListenerDelegateWrapper"));
			}
		}
		internal partial class OnLongClickListenerDelegateWrapper
		{
			private OnLongClickListenerDelegate myDelegate;
			public bool onLongClick(android.view.View arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator OnLongClickListenerDelegateWrapper(OnLongClickListenerDelegate d)
			{
				global::android.view.View.OnLongClickListenerDelegateWrapper ret = new global::android.view.View.OnLongClickListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.View.OnTouchListener_))]
		public partial interface OnTouchListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onTouch(android.view.View arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.View.OnTouchListener))]
		internal sealed partial class OnTouchListener_ : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnTouchListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.View.OnTouchListener.onTouch(android.view.View arg0, android.view.MotionEvent arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.OnTouchListener_.staticClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", ref global::android.view.View.OnTouchListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnTouchListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View$OnTouchListener"));
			}
		}

		public delegate bool OnTouchListenerDelegate(android.view.View arg0, android.view.MotionEvent arg1);

		internal partial class OnTouchListenerDelegateWrapper : java.lang.Object, OnTouchListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnTouchListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnTouchListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.View.OnTouchListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.View.OnTouchListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.View.OnTouchListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.OnTouchListenerDelegateWrapper.staticClass, global::android.view.View.OnTouchListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnTouchListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.View.OnTouchListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View_OnTouchListenerDelegateWrapper"));
			}
		}
		internal partial class OnTouchListenerDelegateWrapper
		{
			private OnTouchListenerDelegate myDelegate;
			public bool onTouch(android.view.View arg0, android.view.MotionEvent arg1)
			{
				return myDelegate(arg0, arg1);
			}
			public static implicit operator OnTouchListenerDelegateWrapper(OnTouchListenerDelegate d)
			{
				global::android.view.View.OnTouchListenerDelegateWrapper ret = new global::android.view.View.OnTouchListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.content.res.Resources getResources()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getResources", "()Landroid/content/res/Resources;", ref global::android.view.View._m0) as android.content.res.Resources;
		}
		public new global::android.view.ViewParent Parent
		{
			get
			{
				return getParent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.ViewParent getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ViewParent>(this, global::android.view.View.staticClass, "getParent", "()Landroid/view/ViewParent;", ref global::android.view.View._m1) as android.view.ViewParent;
		}
		public new int Id
		{
			get
			{
				return getId();
			}
			set
			{
				setId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getId", "()I", ref global::android.view.View._m2);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.view.View._m3) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isOpaque()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isOpaque", "()Z", ref global::android.view.View._m4);
		}
		public new global::android.os.Handler Handler
		{
			get
			{
				return getHandler();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.os.Handler getHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getHandler", "()Landroid/os/Handler;", ref global::android.view.View._m5) as android.os.Handler;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.view.View inflate(android.content.Context arg0, int arg1, android.view.ViewGroup arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m6.native == global::System.IntPtr.Zero)
				global::android.view.View._m6 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Object getTag(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTag", "(I)Ljava/lang/Object;", ref global::android.view.View._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		public new global::java.lang.Object Tag
		{
			get
			{
				return getTag();
			}
			set
			{
				setTag(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.Object getTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTag", "()Ljava/lang/Object;", ref global::android.view.View._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void invalidate(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "(Landroid/graphics/Rect;)V", ref global::android.view.View._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void invalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "()V", ref global::android.view.View._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void invalidate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidate", "(IIII)V", ref global::android.view.View._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void layout(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "layout", "(IIII)V", ref global::android.view.View._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.View._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isEnabled", "()Z", ref global::android.view.View._m14);
		}
		public new bool Enabled
		{
			set
			{
				setEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setEnabled", "(Z)V", ref global::android.view.View._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string ContentDescription
		{
			get
			{
				return getContentDescription().toString();
			}
			set
			{
				setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.CharSequence getContentDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.view.View.staticClass, "getContentDescription", "()Ljava/lang/CharSequence;", ref global::android.view.View._m16) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setContentDescription(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setContentDescription", "(Ljava/lang/CharSequence;)V", ref global::android.view.View._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setContentDescription(string arg0)
		{
			setContentDescription((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new global::android.view.animation.Animation Animation
		{
			get
			{
				return getAnimation();
			}
			set
			{
				setAnimation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.view.animation.Animation getAnimation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getAnimation", "()Landroid/view/animation/Animation;", ref global::android.view.View._m18) as android.view.animation.Animation;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWidth", "()I", ref global::android.view.View._m20);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHeight", "()I", ref global::android.view.View._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool post(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "post", "(Ljava/lang/Runnable;)Z", ref global::android.view.View._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool post(global::java.lang.RunnableDelegate arg0)
		{
			return post((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool postDelayed(java.lang.Runnable arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "postDelayed", "(Ljava/lang/Runnable;J)Z", ref global::android.view.View._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public bool postDelayed(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			return postDelayed((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool removeCallbacks(java.lang.Runnable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "removeCallbacks", "(Ljava/lang/Runnable;)Z", ref global::android.view.View._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public bool removeCallbacks(global::java.lang.RunnableDelegate arg0)
		{
			return removeCallbacks((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		protected virtual void onRestoreInstanceState(android.os.Parcelable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V", ref global::android.view.View._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		protected virtual global::android.os.Parcelable onSaveInstanceState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.view.View.staticClass, "onSaveInstanceState", "()Landroid/os/Parcelable;", ref global::android.view.View._m26) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.view.View findViewById(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findViewById", "(I)Landroid/view/View;", ref global::android.view.View._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool onKeyLongPress(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.view.View._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool onTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void onWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onWindowFocusChanged", "(Z)V", ref global::android.view.View._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool hasFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasFocus", "()Z", ref global::android.view.View._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		protected virtual void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAttachedToWindow", "()V", ref global::android.view.View._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		protected virtual void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDetachedFromWindow", "()V", ref global::android.view.View._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual bool hasWindowFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasWindowFocus", "()Z", ref global::android.view.View._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual bool dispatchKeyEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool dispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.View._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", ref global::android.view.View._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		protected virtual void onCreateContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.view.View._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable BackgroundDrawable
		{
			set
			{
				setBackgroundDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void saveHierarchyState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "saveHierarchyState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void restoreHierarchyState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "restoreHierarchyState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		protected virtual void initializeFadingEdge(android.content.res.TypedArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "initializeFadingEdge", "(Landroid/content/res/TypedArray;)V", ref global::android.view.View._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalFadingEdgeLength
		{
			get
			{
				return getVerticalFadingEdgeLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual int getVerticalFadingEdgeLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVerticalFadingEdgeLength", "()I", ref global::android.view.View._m48);
		}
		public new int FadingEdgeLength
		{
			set
			{
				setFadingEdgeLength(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void setFadingEdgeLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFadingEdgeLength", "(I)V", ref global::android.view.View._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HorizontalFadingEdgeLength
		{
			get
			{
				return getHorizontalFadingEdgeLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual int getHorizontalFadingEdgeLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHorizontalFadingEdgeLength", "()I", ref global::android.view.View._m50);
		}
		public new int VerticalScrollbarWidth
		{
			get
			{
				return getVerticalScrollbarWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual int getVerticalScrollbarWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVerticalScrollbarWidth", "()I", ref global::android.view.View._m51);
		}
		protected new int HorizontalScrollbarHeight
		{
			get
			{
				return getHorizontalScrollbarHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m52;
		protected virtual int getHorizontalScrollbarHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getHorizontalScrollbarHeight", "()I", ref global::android.view.View._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		protected virtual void initializeScrollbars(android.content.res.TypedArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "initializeScrollbars", "(Landroid/content/res/TypedArray;)V", ref global::android.view.View._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void setOnFocusChangeListener(android.view.View.OnFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", ref global::android.view.View._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnFocusChangeListener(global::android.view.View.OnFocusChangeListenerDelegate arg0)
		{
			setOnFocusChangeListener((global::android.view.View.OnFocusChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::android.view.View.OnFocusChangeListener getOnFocusChangeListener()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.View.OnFocusChangeListener>(this, global::android.view.View.staticClass, "getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;", ref global::android.view.View._m55) as android.view.View.OnFocusChangeListener;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void setOnClickListener(android.view.View.OnClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V", ref global::android.view.View._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnClickListener(global::android.view.View.OnClickListenerDelegate arg0)
		{
			setOnClickListener((global::android.view.View.OnClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual void setOnLongClickListener(android.view.View.OnLongClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", ref global::android.view.View._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnLongClickListener(global::android.view.View.OnLongClickListenerDelegate arg0)
		{
			setOnLongClickListener((global::android.view.View.OnLongClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void setOnCreateContextMenuListener(android.view.View.OnCreateContextMenuListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V", ref global::android.view.View._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnCreateContextMenuListener(global::android.view.View.OnCreateContextMenuListenerDelegate arg0)
		{
			setOnCreateContextMenuListener((global::android.view.View.OnCreateContextMenuListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual bool performClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performClick", "()Z", ref global::android.view.View._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual bool performLongClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performLongClick", "()Z", ref global::android.view.View._m60);
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual bool showContextMenu()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "showContextMenu", "()Z", ref global::android.view.View._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual void setOnKeyListener(android.view.View.OnKeyListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V", ref global::android.view.View._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnKeyListener(global::android.view.View.OnKeyListenerDelegate arg0)
		{
			setOnKeyListener((global::android.view.View.OnKeyListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual void setOnTouchListener(android.view.View.OnTouchListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", ref global::android.view.View._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnTouchListener(global::android.view.View.OnTouchListenerDelegate arg0)
		{
			setOnTouchListener((global::android.view.View.OnTouchListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual bool requestRectangleOnScreen(android.graphics.Rect arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z", ref global::android.view.View._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual void clearFocus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "clearFocus", "()V", ref global::android.view.View._m66);
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual bool hasFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "hasFocusable", "()Z", ref global::android.view.View._m67);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		protected virtual void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.view.View._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual void sendAccessibilityEvent(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "sendAccessibilityEvent", "(I)V", ref global::android.view.View._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual void sendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", ref global::android.view.View._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual bool isFocused()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocused", "()Z", ref global::android.view.View._m71);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual global::android.view.View findFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findFocus", "()Landroid/view/View;", ref global::android.view.View._m72) as android.view.View;
		}
		public new bool ScrollContainer
		{
			set
			{
				setScrollContainer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual void setScrollContainer(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollContainer", "(Z)V", ref global::android.view.View._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheQuality
		{
			get
			{
				return getDrawingCacheQuality();
			}
			set
			{
				setDrawingCacheQuality(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual int getDrawingCacheQuality()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getDrawingCacheQuality", "()I", ref global::android.view.View._m74);
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual void setDrawingCacheQuality(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheQuality", "(I)V", ref global::android.view.View._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool KeepScreenOn
		{
			get
			{
				return getKeepScreenOn();
			}
			set
			{
				setKeepScreenOn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual bool getKeepScreenOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getKeepScreenOn", "()Z", ref global::android.view.View._m76);
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual void setKeepScreenOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setKeepScreenOn", "(Z)V", ref global::android.view.View._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusLeftId
		{
			get
			{
				return getNextFocusLeftId();
			}
			set
			{
				setNextFocusLeftId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual int getNextFocusLeftId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusLeftId", "()I", ref global::android.view.View._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void setNextFocusLeftId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusLeftId", "(I)V", ref global::android.view.View._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusRightId
		{
			get
			{
				return getNextFocusRightId();
			}
			set
			{
				setNextFocusRightId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual int getNextFocusRightId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusRightId", "()I", ref global::android.view.View._m80);
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void setNextFocusRightId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusRightId", "(I)V", ref global::android.view.View._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusUpId
		{
			get
			{
				return getNextFocusUpId();
			}
			set
			{
				setNextFocusUpId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual int getNextFocusUpId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusUpId", "()I", ref global::android.view.View._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public virtual void setNextFocusUpId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusUpId", "(I)V", ref global::android.view.View._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NextFocusDownId
		{
			get
			{
				return getNextFocusDownId();
			}
			set
			{
				setNextFocusDownId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public virtual int getNextFocusDownId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getNextFocusDownId", "()I", ref global::android.view.View._m84);
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public virtual void setNextFocusDownId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setNextFocusDownId", "(I)V", ref global::android.view.View._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public virtual bool isShown()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isShown", "()Z", ref global::android.view.View._m86);
		}
		private static global::MonoJavaBridge.MethodId _m87;
		protected virtual bool fitSystemWindows(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			get
			{
				return getVisibility();
			}
			set
			{
				setVisibility(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public virtual int getVisibility()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getVisibility", "()I", ref global::android.view.View._m88);
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public virtual void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVisibility", "(I)V", ref global::android.view.View._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Focusable
		{
			set
			{
				setFocusable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public virtual void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFocusable", "(Z)V", ref global::android.view.View._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FocusableInTouchMode
		{
			set
			{
				setFocusableInTouchMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public virtual void setFocusableInTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setFocusableInTouchMode", "(Z)V", ref global::android.view.View._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool SoundEffectsEnabled
		{
			set
			{
				setSoundEffectsEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public virtual void setSoundEffectsEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSoundEffectsEnabled", "(Z)V", ref global::android.view.View._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public virtual bool isSoundEffectsEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSoundEffectsEnabled", "()Z", ref global::android.view.View._m93);
		}
		public new bool HapticFeedbackEnabled
		{
			set
			{
				setHapticFeedbackEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public virtual void setHapticFeedbackEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHapticFeedbackEnabled", "(Z)V", ref global::android.view.View._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public virtual bool isHapticFeedbackEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHapticFeedbackEnabled", "()Z", ref global::android.view.View._m95);
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public virtual void setWillNotDraw(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setWillNotDraw", "(Z)V", ref global::android.view.View._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public virtual bool willNotDraw()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "willNotDraw", "()Z", ref global::android.view.View._m97);
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public virtual void setWillNotCacheDrawing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setWillNotCacheDrawing", "(Z)V", ref global::android.view.View._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		public virtual bool willNotCacheDrawing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "willNotCacheDrawing", "()Z", ref global::android.view.View._m99);
		}
		private static global::MonoJavaBridge.MethodId _m100;
		public virtual bool isClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isClickable", "()Z", ref global::android.view.View._m100);
		}
		public new bool Clickable
		{
			set
			{
				setClickable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m101;
		public virtual void setClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setClickable", "(Z)V", ref global::android.view.View._m101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m102;
		public virtual bool isLongClickable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isLongClickable", "()Z", ref global::android.view.View._m102);
		}
		public new bool LongClickable
		{
			set
			{
				setLongClickable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m103;
		public virtual void setLongClickable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setLongClickable", "(Z)V", ref global::android.view.View._m103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Pressed
		{
			set
			{
				setPressed(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m104;
		public virtual void setPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setPressed", "(Z)V", ref global::android.view.View._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		protected virtual void dispatchSetPressed(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSetPressed", "(Z)V", ref global::android.view.View._m105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m106;
		public virtual bool isPressed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isPressed", "()Z", ref global::android.view.View._m106);
		}
		private static global::MonoJavaBridge.MethodId _m107;
		public virtual bool isSaveEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSaveEnabled", "()Z", ref global::android.view.View._m107);
		}
		public new bool SaveEnabled
		{
			set
			{
				setSaveEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m108;
		public virtual void setSaveEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSaveEnabled", "(Z)V", ref global::android.view.View._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		public virtual bool isFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocusable", "()Z", ref global::android.view.View._m109);
		}
		private static global::MonoJavaBridge.MethodId _m110;
		public virtual bool isFocusableInTouchMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isFocusableInTouchMode", "()Z", ref global::android.view.View._m110);
		}
		private static global::MonoJavaBridge.MethodId _m111;
		public virtual global::android.view.View focusSearch(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "focusSearch", "(I)Landroid/view/View;", ref global::android.view.View._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m112;
		public virtual bool dispatchUnhandledMove(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z", ref global::android.view.View._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m113;
		public virtual global::java.util.ArrayList getFocusables(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getFocusables", "(I)Ljava/util/ArrayList;", ref global::android.view.View._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m114;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V", ref global::android.view.View._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		public virtual void addFocusables(java.util.ArrayList arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V", ref global::android.view.View._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.util.ArrayList Touchables
		{
			get
			{
				return getTouchables();
			}
		}
		private static global::MonoJavaBridge.MethodId _m116;
		public virtual global::java.util.ArrayList getTouchables()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTouchables", "()Ljava/util/ArrayList;", ref global::android.view.View._m116) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m117;
		public virtual void addTouchables(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V", ref global::android.view.View._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		public virtual bool requestFocus(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "(I)Z", ref global::android.view.View._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		public virtual bool requestFocus()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "()Z", ref global::android.view.View._m119);
		}
		private static global::MonoJavaBridge.MethodId _m120;
		public virtual bool requestFocus(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z", ref global::android.view.View._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		public virtual bool requestFocusFromTouch()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "requestFocusFromTouch", "()Z", ref global::android.view.View._m121);
		}
		private static global::MonoJavaBridge.MethodId _m122;
		public virtual void onStartTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onStartTemporaryDetach", "()V", ref global::android.view.View._m122);
		}
		private static global::MonoJavaBridge.MethodId _m123;
		public virtual void onFinishTemporaryDetach()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFinishTemporaryDetach", "()V", ref global::android.view.View._m123);
		}
		public new global::android.view.KeyEvent.DispatcherState KeyDispatcherState
		{
			get
			{
				return getKeyDispatcherState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m124;
		public virtual global::android.view.KeyEvent.DispatcherState getKeyDispatcherState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", ref global::android.view.View._m124) as android.view.KeyEvent.DispatcherState;
		}
		private static global::MonoJavaBridge.MethodId _m125;
		public virtual bool dispatchKeyEventPreIme(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		public virtual bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", ref global::android.view.View._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m127;
		public virtual void dispatchWindowFocusChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchWindowFocusChanged", "(Z)V", ref global::android.view.View._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m128;
		protected virtual void dispatchVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.view.View._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m129;
		protected virtual void onVisibilityChanged(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onVisibilityChanged", "(Landroid/view/View;I)V", ref global::android.view.View._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m130;
		public virtual void dispatchDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchDisplayHint", "(I)V", ref global::android.view.View._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m131;
		protected virtual void onDisplayHint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDisplayHint", "(I)V", ref global::android.view.View._m131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m132;
		public virtual void dispatchWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchWindowVisibilityChanged", "(I)V", ref global::android.view.View._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m133;
		protected virtual void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.view.View._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int WindowVisibility
		{
			get
			{
				return getWindowVisibility();
			}
		}
		private static global::MonoJavaBridge.MethodId _m134;
		public virtual int getWindowVisibility()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWindowVisibility", "()I", ref global::android.view.View._m134);
		}
		private static global::MonoJavaBridge.MethodId _m135;
		public virtual void getWindowVisibleDisplayFrame(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V", ref global::android.view.View._m135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m136;
		public virtual void dispatchConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.view.View._m136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m137;
		public virtual bool isInTouchMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isInTouchMode", "()Z", ref global::android.view.View._m137);
		}
		private static global::MonoJavaBridge.MethodId _m138;
		public virtual bool onKeyPreIme(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m139;
		public virtual bool onKeyShortcut(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", ref global::android.view.View._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m140;
		public virtual bool onCheckIsTextEditor()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onCheckIsTextEditor", "()Z", ref global::android.view.View._m140);
		}
		private static global::MonoJavaBridge.MethodId _m141;
		public virtual global::android.view.inputmethod.InputConnection onCreateInputConnection(android.view.inputmethod.EditorInfo arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.inputmethod.InputConnection>(this, global::android.view.View.staticClass, "onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;", ref global::android.view.View._m141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.inputmethod.InputConnection;
		}
		private static global::MonoJavaBridge.MethodId _m142;
		public virtual bool checkInputConnectionProxy(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "checkInputConnectionProxy", "(Landroid/view/View;)Z", ref global::android.view.View._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m143;
		public virtual void createContextMenu(android.view.ContextMenu arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "createContextMenu", "(Landroid/view/ContextMenu;)V", ref global::android.view.View._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new global::android.view.ContextMenu_ContextMenuInfo ContextMenuInfo
		{
			get
			{
				return getContextMenuInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m144;
		protected virtual global::android.view.ContextMenu_ContextMenuInfo getContextMenuInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.ContextMenu_ContextMenuInfo>(this, global::android.view.View.staticClass, "getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", ref global::android.view.View._m144) as android.view.ContextMenu_ContextMenuInfo;
		}
		private static global::MonoJavaBridge.MethodId _m145;
		public virtual void cancelLongPress()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "cancelLongPress", "()V", ref global::android.view.View._m145);
		}
		private static global::MonoJavaBridge.MethodId _m146;
		public virtual void setTouchDelegate(android.view.TouchDelegate arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTouchDelegate", "(Landroid/view/TouchDelegate;)V", ref global::android.view.View._m146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.TouchDelegate TouchDelegate
		{
			get
			{
				return getTouchDelegate();
			}
			set
			{
				setTouchDelegate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m147;
		public virtual global::android.view.TouchDelegate getTouchDelegate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getTouchDelegate", "()Landroid/view/TouchDelegate;", ref global::android.view.View._m147) as android.view.TouchDelegate;
		}
		private static global::MonoJavaBridge.MethodId _m148;
		public virtual void bringToFront()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "bringToFront", "()V", ref global::android.view.View._m148);
		}
		private static global::MonoJavaBridge.MethodId _m149;
		protected virtual void onScrollChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onScrollChanged", "(IIII)V", ref global::android.view.View._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m150;
		protected virtual void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onSizeChanged", "(IIII)V", ref global::android.view.View._m150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m151;
		protected virtual void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollX
		{
			get
			{
				return getScrollX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m152;
		public virtual int getScrollX()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollX", "()I", ref global::android.view.View._m152);
		}
		public new int ScrollY
		{
			get
			{
				return getScrollY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m153;
		public virtual int getScrollY()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollY", "()I", ref global::android.view.View._m153);
		}
		private static global::MonoJavaBridge.MethodId _m154;
		public virtual void getDrawingRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getDrawingRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._m154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MeasuredWidth
		{
			get
			{
				return getMeasuredWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m155;
		public virtual int getMeasuredWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getMeasuredWidth", "()I", ref global::android.view.View._m155);
		}
		public new int MeasuredHeight
		{
			get
			{
				return getMeasuredHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m156;
		public virtual int getMeasuredHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getMeasuredHeight", "()I", ref global::android.view.View._m156);
		}
		public new int Top
		{
			get
			{
				return getTop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m157;
		public virtual int getTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getTop", "()I", ref global::android.view.View._m157);
		}
		public new int Bottom
		{
			get
			{
				return getBottom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m158;
		public virtual int getBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBottom", "()I", ref global::android.view.View._m158);
		}
		public new int Left
		{
			get
			{
				return getLeft();
			}
		}
		private static global::MonoJavaBridge.MethodId _m159;
		public virtual int getLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getLeft", "()I", ref global::android.view.View._m159);
		}
		public new int Right
		{
			get
			{
				return getRight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m160;
		public virtual int getRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getRight", "()I", ref global::android.view.View._m160);
		}
		private static global::MonoJavaBridge.MethodId _m161;
		public virtual void getHitRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getHitRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._m161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m162;
		public virtual void getFocusedRect(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getFocusedRect", "(Landroid/graphics/Rect;)V", ref global::android.view.View._m162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m163;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0, android.graphics.Point arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z", ref global::android.view.View._m163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m164;
		public virtual bool getGlobalVisibleRect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		public virtual bool getLocalVisibleRect(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "getLocalVisibleRect", "(Landroid/graphics/Rect;)Z", ref global::android.view.View._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		public virtual void offsetTopAndBottom(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "offsetTopAndBottom", "(I)V", ref global::android.view.View._m166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m167;
		public virtual void offsetLeftAndRight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "offsetLeftAndRight", "(I)V", ref global::android.view.View._m167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.LayoutParams LayoutParams
		{
			get
			{
				return getLayoutParams();
			}
			set
			{
				setLayoutParams(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m168;
		public virtual global::android.view.ViewGroup.LayoutParams getLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.view.View._m168) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m169;
		public virtual void setLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.view.View._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m170;
		public virtual void scrollTo(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scrollTo", "(II)V", ref global::android.view.View._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m171;
		public virtual void scrollBy(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scrollBy", "(II)V", ref global::android.view.View._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		protected virtual bool awakenScrollBars(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "(IZ)Z", ref global::android.view.View._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m173;
		protected virtual bool awakenScrollBars()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "()Z", ref global::android.view.View._m173);
		}
		private static global::MonoJavaBridge.MethodId _m174;
		protected virtual bool awakenScrollBars(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "awakenScrollBars", "(I)Z", ref global::android.view.View._m174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m175;
		public virtual void postInvalidate(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidate", "(IIII)V", ref global::android.view.View._m175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m176;
		public virtual void postInvalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidate", "()V", ref global::android.view.View._m176);
		}
		private static global::MonoJavaBridge.MethodId _m177;
		public virtual void postInvalidateDelayed(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidateDelayed", "(J)V", ref global::android.view.View._m177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m178;
		public virtual void postInvalidateDelayed(long arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "postInvalidateDelayed", "(JIIII)V", ref global::android.view.View._m178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m179;
		public virtual void computeScroll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "computeScroll", "()V", ref global::android.view.View._m179);
		}
		private static global::MonoJavaBridge.MethodId _m180;
		public virtual bool isHorizontalFadingEdgeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHorizontalFadingEdgeEnabled", "()Z", ref global::android.view.View._m180);
		}
		public new bool HorizontalFadingEdgeEnabled
		{
			set
			{
				setHorizontalFadingEdgeEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m181;
		public virtual void setHorizontalFadingEdgeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHorizontalFadingEdgeEnabled", "(Z)V", ref global::android.view.View._m181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m182;
		public virtual bool isVerticalFadingEdgeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isVerticalFadingEdgeEnabled", "()Z", ref global::android.view.View._m182);
		}
		public new bool VerticalFadingEdgeEnabled
		{
			set
			{
				setVerticalFadingEdgeEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m183;
		public virtual void setVerticalFadingEdgeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVerticalFadingEdgeEnabled", "(Z)V", ref global::android.view.View._m183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new float TopFadingEdgeStrength
		{
			get
			{
				return getTopFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m184;
		protected virtual float getTopFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getTopFadingEdgeStrength", "()F", ref global::android.view.View._m184);
		}
		protected new float BottomFadingEdgeStrength
		{
			get
			{
				return getBottomFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m185;
		protected virtual float getBottomFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getBottomFadingEdgeStrength", "()F", ref global::android.view.View._m185);
		}
		protected new float LeftFadingEdgeStrength
		{
			get
			{
				return getLeftFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m186;
		protected virtual float getLeftFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getLeftFadingEdgeStrength", "()F", ref global::android.view.View._m186);
		}
		protected new float RightFadingEdgeStrength
		{
			get
			{
				return getRightFadingEdgeStrength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m187;
		protected virtual float getRightFadingEdgeStrength()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.View.staticClass, "getRightFadingEdgeStrength", "()F", ref global::android.view.View._m187);
		}
		private static global::MonoJavaBridge.MethodId _m188;
		public virtual bool isHorizontalScrollBarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isHorizontalScrollBarEnabled", "()Z", ref global::android.view.View._m188);
		}
		public new bool HorizontalScrollBarEnabled
		{
			set
			{
				setHorizontalScrollBarEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m189;
		public virtual void setHorizontalScrollBarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setHorizontalScrollBarEnabled", "(Z)V", ref global::android.view.View._m189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m190;
		public virtual bool isVerticalScrollBarEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isVerticalScrollBarEnabled", "()Z", ref global::android.view.View._m190);
		}
		public new bool VerticalScrollBarEnabled
		{
			set
			{
				setVerticalScrollBarEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m191;
		public virtual void setVerticalScrollBarEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setVerticalScrollBarEnabled", "(Z)V", ref global::android.view.View._m191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ScrollbarFadingEnabled
		{
			set
			{
				setScrollbarFadingEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m192;
		public virtual void setScrollbarFadingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollbarFadingEnabled", "(Z)V", ref global::android.view.View._m192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m193;
		public virtual bool isScrollbarFadingEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isScrollbarFadingEnabled", "()Z", ref global::android.view.View._m193);
		}
		private static global::MonoJavaBridge.MethodId _m194;
		public virtual void setScrollBarStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setScrollBarStyle", "(I)V", ref global::android.view.View._m194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ScrollBarStyle
		{
			get
			{
				return getScrollBarStyle();
			}
			set
			{
				setScrollBarStyle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m195;
		public virtual int getScrollBarStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getScrollBarStyle", "()I", ref global::android.view.View._m195);
		}
		private static global::MonoJavaBridge.MethodId _m196;
		protected virtual int computeHorizontalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollRange", "()I", ref global::android.view.View._m196);
		}
		private static global::MonoJavaBridge.MethodId _m197;
		protected virtual int computeHorizontalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollOffset", "()I", ref global::android.view.View._m197);
		}
		private static global::MonoJavaBridge.MethodId _m198;
		protected virtual int computeHorizontalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeHorizontalScrollExtent", "()I", ref global::android.view.View._m198);
		}
		private static global::MonoJavaBridge.MethodId _m199;
		protected virtual int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollRange", "()I", ref global::android.view.View._m199);
		}
		private static global::MonoJavaBridge.MethodId _m200;
		protected virtual int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.view.View._m200);
		}
		private static global::MonoJavaBridge.MethodId _m201;
		protected virtual int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.view.View._m201);
		}
		private static global::MonoJavaBridge.MethodId _m202;
		protected virtual void onDrawScrollBars(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDrawScrollBars", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._m202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m203;
		protected virtual void onDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.View._m203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		protected new int WindowAttachCount
		{
			get
			{
				return getWindowAttachCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m204;
		protected virtual int getWindowAttachCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getWindowAttachCount", "()I", ref global::android.view.View._m204);
		}
		public new global::android.os.IBinder WindowToken
		{
			get
			{
				return getWindowToken();
			}
		}
		private static global::MonoJavaBridge.MethodId _m205;
		public virtual global::android.os.IBinder getWindowToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.view.View.staticClass, "getWindowToken", "()Landroid/os/IBinder;", ref global::android.view.View._m205) as android.os.IBinder;
		}
		public new global::android.os.IBinder ApplicationWindowToken
		{
			get
			{
				return getApplicationWindowToken();
			}
		}
		private static global::MonoJavaBridge.MethodId _m206;
		public virtual global::android.os.IBinder getApplicationWindowToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.view.View.staticClass, "getApplicationWindowToken", "()Landroid/os/IBinder;", ref global::android.view.View._m206) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m207;
		protected virtual void dispatchSaveInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._m207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m208;
		protected virtual void dispatchRestoreInstanceState(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", ref global::android.view.View._m208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long DrawingTime
		{
			get
			{
				return getDrawingTime();
			}
		}
		private static global::MonoJavaBridge.MethodId _m209;
		public virtual long getDrawingTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.View.staticClass, "getDrawingTime", "()J", ref global::android.view.View._m209);
		}
		public new bool DuplicateParentStateEnabled
		{
			set
			{
				setDuplicateParentStateEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m210;
		public virtual void setDuplicateParentStateEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDuplicateParentStateEnabled", "(Z)V", ref global::android.view.View._m210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m211;
		public virtual bool isDuplicateParentStateEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isDuplicateParentStateEnabled", "()Z", ref global::android.view.View._m211);
		}
		public new bool DrawingCacheEnabled
		{
			set
			{
				setDrawingCacheEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m212;
		public virtual void setDrawingCacheEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheEnabled", "(Z)V", ref global::android.view.View._m212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m213;
		public virtual bool isDrawingCacheEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isDrawingCacheEnabled", "()Z", ref global::android.view.View._m213);
		}
		private static global::MonoJavaBridge.MethodId _m214;
		public virtual global::android.graphics.Bitmap getDrawingCache(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.view.View.staticClass, "getDrawingCache", "(Z)Landroid/graphics/Bitmap;", ref global::android.view.View._m214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Bitmap;
		}
		public new global::android.graphics.Bitmap DrawingCache
		{
			get
			{
				return getDrawingCache();
			}
		}
		private static global::MonoJavaBridge.MethodId _m215;
		public virtual global::android.graphics.Bitmap getDrawingCache()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.view.View.staticClass, "getDrawingCache", "()Landroid/graphics/Bitmap;", ref global::android.view.View._m215) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m216;
		public virtual void destroyDrawingCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "destroyDrawingCache", "()V", ref global::android.view.View._m216);
		}
		private static global::MonoJavaBridge.MethodId _m217;
		public virtual void setDrawingCacheBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setDrawingCacheBackgroundColor", "(I)V", ref global::android.view.View._m217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int DrawingCacheBackgroundColor
		{
			get
			{
				return getDrawingCacheBackgroundColor();
			}
			set
			{
				setDrawingCacheBackgroundColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m218;
		public virtual int getDrawingCacheBackgroundColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getDrawingCacheBackgroundColor", "()I", ref global::android.view.View._m218);
		}
		private static global::MonoJavaBridge.MethodId _m219;
		public virtual void buildDrawingCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "buildDrawingCache", "()V", ref global::android.view.View._m219);
		}
		private static global::MonoJavaBridge.MethodId _m220;
		public virtual void buildDrawingCache(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "buildDrawingCache", "(Z)V", ref global::android.view.View._m220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m221;
		public virtual bool isInEditMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isInEditMode", "()Z", ref global::android.view.View._m221);
		}
		private static global::MonoJavaBridge.MethodId _m222;
		protected virtual bool isPaddingOffsetRequired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isPaddingOffsetRequired", "()Z", ref global::android.view.View._m222);
		}
		protected new int LeftPaddingOffset
		{
			get
			{
				return getLeftPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m223;
		protected virtual int getLeftPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getLeftPaddingOffset", "()I", ref global::android.view.View._m223);
		}
		protected new int RightPaddingOffset
		{
			get
			{
				return getRightPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m224;
		protected virtual int getRightPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getRightPaddingOffset", "()I", ref global::android.view.View._m224);
		}
		protected new int TopPaddingOffset
		{
			get
			{
				return getTopPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m225;
		protected virtual int getTopPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getTopPaddingOffset", "()I", ref global::android.view.View._m225);
		}
		protected new int BottomPaddingOffset
		{
			get
			{
				return getBottomPaddingOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m226;
		protected virtual int getBottomPaddingOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBottomPaddingOffset", "()I", ref global::android.view.View._m226);
		}
		public new int SolidColor
		{
			get
			{
				return getSolidColor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m227;
		public virtual int getSolidColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSolidColor", "()I", ref global::android.view.View._m227);
		}
		private static global::MonoJavaBridge.MethodId _m228;
		public virtual bool isLayoutRequested()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isLayoutRequested", "()Z", ref global::android.view.View._m228);
		}
		private static global::MonoJavaBridge.MethodId _m229;
		protected virtual void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onLayout", "(ZIIII)V", ref global::android.view.View._m229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m230;
		protected virtual void onFinishInflate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onFinishInflate", "()V", ref global::android.view.View._m230);
		}
		private static global::MonoJavaBridge.MethodId _m231;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._m231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m232;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", ref global::android.view.View._m232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m233;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", ref global::android.view.View._m233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m234;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.view.View._m234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m235;
		protected virtual bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.view.View._m235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m236;
		protected virtual void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "drawableStateChanged", "()V", ref global::android.view.View._m236);
		}
		private static global::MonoJavaBridge.MethodId _m237;
		public virtual void refreshDrawableState()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "refreshDrawableState", "()V", ref global::android.view.View._m237);
		}
		public new int[] DrawableState
		{
			get
			{
				return getDrawableState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m238;
		public virtual int[] getDrawableState()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.view.View.staticClass, "getDrawableState", "()[I", ref global::android.view.View._m238) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m239;
		protected virtual int[] onCreateDrawableState(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.view.View.staticClass, "onCreateDrawableState", "(I)[I", ref global::android.view.View._m239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m240;
		protected static int[] mergeDrawableStates(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m240.native == global::System.IntPtr.Zero)
				global::android.view.View._m240 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "mergeDrawableStates", "([I[I)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.view.View.staticClass, global::android.view.View._m240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		public new int BackgroundColor
		{
			set
			{
				setBackgroundColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m241;
		public virtual void setBackgroundColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundColor", "(I)V", ref global::android.view.View._m241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundResource
		{
			set
			{
				setBackgroundResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m242;
		public virtual void setBackgroundResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setBackgroundResource", "(I)V", ref global::android.view.View._m242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		private static global::MonoJavaBridge.MethodId _m243;
		public virtual global::android.graphics.drawable.Drawable getBackground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;", ref global::android.view.View._m243) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m244;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setPadding", "(IIII)V", ref global::android.view.View._m244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int PaddingTop
		{
			get
			{
				return getPaddingTop();
			}
		}
		private static global::MonoJavaBridge.MethodId _m245;
		public virtual int getPaddingTop()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingTop", "()I", ref global::android.view.View._m245);
		}
		public new int PaddingBottom
		{
			get
			{
				return getPaddingBottom();
			}
		}
		private static global::MonoJavaBridge.MethodId _m246;
		public virtual int getPaddingBottom()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingBottom", "()I", ref global::android.view.View._m246);
		}
		public new int PaddingLeft
		{
			get
			{
				return getPaddingLeft();
			}
		}
		private static global::MonoJavaBridge.MethodId _m247;
		public virtual int getPaddingLeft()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingLeft", "()I", ref global::android.view.View._m247);
		}
		public new int PaddingRight
		{
			get
			{
				return getPaddingRight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m248;
		public virtual int getPaddingRight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getPaddingRight", "()I", ref global::android.view.View._m248);
		}
		public new bool Selected
		{
			set
			{
				setSelected(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m249;
		public virtual void setSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setSelected", "(Z)V", ref global::android.view.View._m249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m250;
		protected virtual void dispatchSetSelected(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "dispatchSetSelected", "(Z)V", ref global::android.view.View._m250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m251;
		public virtual bool isSelected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "isSelected", "()Z", ref global::android.view.View._m251);
		}
		public new global::android.view.ViewTreeObserver ViewTreeObserver
		{
			get
			{
				return getViewTreeObserver();
			}
		}
		private static global::MonoJavaBridge.MethodId _m252;
		public virtual global::android.view.ViewTreeObserver getViewTreeObserver()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.view.ViewTreeObserver>(this, global::android.view.View.staticClass, "getViewTreeObserver", "()Landroid/view/ViewTreeObserver;", ref global::android.view.View._m252) as android.view.ViewTreeObserver;
		}
		public new global::android.view.View RootView
		{
			get
			{
				return getRootView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m253;
		public virtual global::android.view.View getRootView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "getRootView", "()Landroid/view/View;", ref global::android.view.View._m253) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m254;
		public virtual void getLocationOnScreen(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getLocationOnScreen", "([I)V", ref global::android.view.View._m254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m255;
		public virtual void getLocationInWindow(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "getLocationInWindow", "([I)V", ref global::android.view.View._m255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m256;
		public virtual global::android.view.View findViewWithTag(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.View.staticClass, "findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;", ref global::android.view.View._m256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m257;
		public virtual void setId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setId", "(I)V", ref global::android.view.View._m257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m258;
		public virtual void setTag(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTag", "(ILjava/lang/Object;)V", ref global::android.view.View._m258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m259;
		public virtual void setTag(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setTag", "(Ljava/lang/Object;)V", ref global::android.view.View._m259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m260;
		public virtual int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getBaseline", "()I", ref global::android.view.View._m260);
		}
		private static global::MonoJavaBridge.MethodId _m261;
		public virtual void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "requestLayout", "()V", ref global::android.view.View._m261);
		}
		private static global::MonoJavaBridge.MethodId _m262;
		public virtual void forceLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "forceLayout", "()V", ref global::android.view.View._m262);
		}
		private static global::MonoJavaBridge.MethodId _m263;
		public virtual void measure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "measure", "(II)V", ref global::android.view.View._m263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m264;
		protected virtual void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onMeasure", "(II)V", ref global::android.view.View._m264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m265;
		protected virtual void setMeasuredDimension(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMeasuredDimension", "(II)V", ref global::android.view.View._m265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m266;
		public static int resolveSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m266.native == global::System.IntPtr.Zero)
				global::android.view.View._m266 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "resolveSize", "(II)I");
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._m266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m267;
		public static int getDefaultSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m267.native == global::System.IntPtr.Zero)
				global::android.view.View._m267 = @__env.GetStaticMethodIDNoThrow(global::android.view.View.staticClass, "getDefaultSize", "(II)I");
			return @__env.CallStaticIntMethod(android.view.View.staticClass, global::android.view.View._m267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		protected new int SuggestedMinimumHeight
		{
			get
			{
				return getSuggestedMinimumHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m268;
		protected virtual int getSuggestedMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSuggestedMinimumHeight", "()I", ref global::android.view.View._m268);
		}
		protected new int SuggestedMinimumWidth
		{
			get
			{
				return getSuggestedMinimumWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m269;
		protected virtual int getSuggestedMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.View.staticClass, "getSuggestedMinimumWidth", "()I", ref global::android.view.View._m269);
		}
		public new int MinimumHeight
		{
			set
			{
				setMinimumHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m270;
		public virtual void setMinimumHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMinimumHeight", "(I)V", ref global::android.view.View._m270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MinimumWidth
		{
			set
			{
				setMinimumWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m271;
		public virtual void setMinimumWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setMinimumWidth", "(I)V", ref global::android.view.View._m271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m272;
		public virtual void startAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "startAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.View._m272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m273;
		public virtual void clearAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "clearAnimation", "()V", ref global::android.view.View._m273);
		}
		private static global::MonoJavaBridge.MethodId _m274;
		public virtual void setAnimation(android.view.animation.Animation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "setAnimation", "(Landroid/view/animation/Animation;)V", ref global::android.view.View._m274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m275;
		protected virtual void onAnimationStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAnimationStart", "()V", ref global::android.view.View._m275);
		}
		private static global::MonoJavaBridge.MethodId _m276;
		protected virtual void onAnimationEnd()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "onAnimationEnd", "()V", ref global::android.view.View._m276);
		}
		private static global::MonoJavaBridge.MethodId _m277;
		protected virtual bool onSetAlpha(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "onSetAlpha", "(I)Z", ref global::android.view.View._m277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m278;
		public virtual void playSoundEffect(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.View.staticClass, "playSoundEffect", "(I)V", ref global::android.view.View._m278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m279;
		public virtual bool performHapticFeedback(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performHapticFeedback", "(I)Z", ref global::android.view.View._m279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m280;
		public virtual bool performHapticFeedback(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.View.staticClass, "performHapticFeedback", "(II)Z", ref global::android.view.View._m280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m281;
		public View(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m281.native == global::System.IntPtr.Zero)
				global::android.view.View._m281 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._m281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m282;
		public View(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m282.native == global::System.IntPtr.Zero)
				global::android.view.View._m282 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._m282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m283;
		public View(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.View._m283.native == global::System.IntPtr.Zero)
				global::android.view.View._m283 = @__env.GetMethodIDNoThrow(global::android.view.View.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.View.staticClass, global::android.view.View._m283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int NO_ID
		{
			get
			{
				return -1;
			}
		}
		public static int VISIBLE
		{
			get
			{
				return 0;
			}
		}
		public static int INVISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int GONE
		{
			get
			{
				return 8;
			}
		}
		public static int DRAWING_CACHE_QUALITY_LOW
		{
			get
			{
				return 524288;
			}
		}
		public static int DRAWING_CACHE_QUALITY_HIGH
		{
			get
			{
				return 1048576;
			}
		}
		public static int DRAWING_CACHE_QUALITY_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_OVERLAY
		{
			get
			{
				return 0;
			}
		}
		public static int SCROLLBARS_INSIDE_INSET
		{
			get
			{
				return 16777216;
			}
		}
		public static int SCROLLBARS_OUTSIDE_OVERLAY
		{
			get
			{
				return 33554432;
			}
		}
		public static int SCROLLBARS_OUTSIDE_INSET
		{
			get
			{
				return 50331648;
			}
		}
		public static int KEEP_SCREEN_ON
		{
			get
			{
				return 67108864;
			}
		}
		public static int SOUND_EFFECTS_ENABLED
		{
			get
			{
				return 134217728;
			}
		}
		public static int HAPTIC_FEEDBACK_ENABLED
		{
			get
			{
				return 268435456;
			}
		}
		public static int FOCUSABLES_ALL
		{
			get
			{
				return 0;
			}
		}
		public static int FOCUSABLES_TOUCH_MODE
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_BACKWARD
		{
			get
			{
				return 1;
			}
		}
		public static int FOCUS_FORWARD
		{
			get
			{
				return 2;
			}
		}
		public static int FOCUS_LEFT
		{
			get
			{
				return 17;
			}
		}
		public static int FOCUS_UP
		{
			get
			{
				return 33;
			}
		}
		public static int FOCUS_RIGHT
		{
			get
			{
				return 66;
			}
		}
		public static int FOCUS_DOWN
		{
			get
			{
				return 130;
			}
		}
		static View()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.View.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/View"));
		}
	}
}
