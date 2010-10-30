namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PopupWindow : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PopupWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.PopupWindow.OnDismissListener_))]
		public partial interface OnDismissListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onDismiss();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.PopupWindow.OnDismissListener))]
		internal sealed partial class OnDismissListener_ : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDismissListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.widget.PopupWindow.OnDismissListener.onDismiss()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.OnDismissListener_.staticClass, "onDismiss", "()V", ref global::android.widget.PopupWindow.OnDismissListener_._m0);
			}
			static OnDismissListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow$OnDismissListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnDismissListenerDelegate();

		internal partial class OnDismissListenerDelegateWrapper : java.lang.Object, OnDismissListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnDismissListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnDismissListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass, global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnDismissListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow_OnDismissListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnDismissListenerDelegateWrapper
		{
			private OnDismissListenerDelegate myDelegate;
			public void onDismiss()
			{
				myDelegate();
			}
			public static implicit operator OnDismissListenerDelegateWrapper(OnDismissListenerDelegate d)
			{
				global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper ret = new global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void update(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "(IIII)V", ref global::android.widget.PopupWindow._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void update()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "()V", ref global::android.widget.PopupWindow._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void update(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;IIII)V", ref global::android.widget.PopupWindow._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void update(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "(Landroid/view/View;II)V", ref global::android.widget.PopupWindow._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void update(int arg0, int arg1, int arg2, int arg3, bool arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "(IIIIZ)V", ref global::android.widget.PopupWindow._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void update(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "update", "(II)V", ref global::android.widget.PopupWindow._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
			set
			{
				setWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getWidth", "()I", ref global::android.widget.PopupWindow._m6);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
			set
			{
				setHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getHeight", "()I", ref global::android.widget.PopupWindow._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setContentView", "(Landroid/view/View;)V", ref global::android.widget.PopupWindow._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setSoftInputMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setSoftInputMode", "(I)V", ref global::android.widget.PopupWindow._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable BackgroundDrawable
		{
			set
			{
				setBackgroundDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.PopupWindow._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Focusable
		{
			set
			{
				setFocusable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setFocusable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setFocusable", "(Z)V", ref global::android.widget.PopupWindow._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isFocusable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isFocusable", "()Z", ref global::android.widget.PopupWindow._m12);
		}
		public new global::android.graphics.drawable.Drawable Background
		{
			get
			{
				return getBackground();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.graphics.drawable.Drawable getBackground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.PopupWindow.staticClass, "getBackground", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.PopupWindow._m13) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool isShowing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isShowing", "()Z", ref global::android.widget.PopupWindow._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void dismiss()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "dismiss", "()V", ref global::android.widget.PopupWindow._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setOnDismissListener(android.widget.PopupWindow.OnDismissListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", ref global::android.widget.PopupWindow._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnDismissListener(global::android.widget.PopupWindow.OnDismissListenerDelegate arg0)
		{
			setOnDismissListener((global::android.widget.PopupWindow.OnDismissListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setHeight", "(I)V", ref global::android.widget.PopupWindow._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setWidth", "(I)V", ref global::android.widget.PopupWindow._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AnimationStyle
		{
			get
			{
				return getAnimationStyle();
			}
			set
			{
				setAnimationStyle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getAnimationStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getAnimationStyle", "()I", ref global::android.widget.PopupWindow._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setIgnoreCheekPress()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setIgnoreCheekPress", "()V", ref global::android.widget.PopupWindow._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setAnimationStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setAnimationStyle", "(I)V", ref global::android.widget.PopupWindow._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View ContentView
		{
			get
			{
				return getContentView();
			}
			set
			{
				setContentView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.view.View getContentView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.PopupWindow.staticClass, "getContentView", "()Landroid/view/View;", ref global::android.widget.PopupWindow._m22) as android.view.View;
		}
		public new global::android.view.View.OnTouchListener TouchInterceptor
		{
			set
			{
				setTouchInterceptor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setTouchInterceptor(android.view.View.OnTouchListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V", ref global::android.widget.PopupWindow._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTouchInterceptor(global::android.view.View.OnTouchListenerDelegate arg0)
		{
			setTouchInterceptor((global::android.view.View.OnTouchListenerDelegateWrapper)arg0);
		}
		public new int InputMethodMode
		{
			get
			{
				return getInputMethodMode();
			}
			set
			{
				setInputMethodMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getInputMethodMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getInputMethodMode", "()I", ref global::android.widget.PopupWindow._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setInputMethodMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setInputMethodMode", "(I)V", ref global::android.widget.PopupWindow._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int SoftInputMode
		{
			get
			{
				return getSoftInputMode();
			}
			set
			{
				setSoftInputMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual int getSoftInputMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getSoftInputMode", "()I", ref global::android.widget.PopupWindow._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isTouchable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isTouchable", "()Z", ref global::android.widget.PopupWindow._m27);
		}
		public new bool Touchable
		{
			set
			{
				setTouchable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setTouchable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setTouchable", "(Z)V", ref global::android.widget.PopupWindow._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isOutsideTouchable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isOutsideTouchable", "()Z", ref global::android.widget.PopupWindow._m29);
		}
		public new bool OutsideTouchable
		{
			set
			{
				setOutsideTouchable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setOutsideTouchable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setOutsideTouchable", "(Z)V", ref global::android.widget.PopupWindow._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool isClippingEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isClippingEnabled", "()Z", ref global::android.widget.PopupWindow._m31);
		}
		public new bool ClippingEnabled
		{
			set
			{
				setClippingEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setClippingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setClippingEnabled", "(Z)V", ref global::android.widget.PopupWindow._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setWindowLayoutMode(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "setWindowLayoutMode", "(II)V", ref global::android.widget.PopupWindow._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void showAtLocation(android.view.View arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "showAtLocation", "(Landroid/view/View;III)V", ref global::android.widget.PopupWindow._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void showAsDropDown(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;)V", ref global::android.widget.PopupWindow._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void showAsDropDown(android.view.View arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.PopupWindow.staticClass, "showAsDropDown", "(Landroid/view/View;II)V", ref global::android.widget.PopupWindow._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool isAboveAnchor()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.PopupWindow.staticClass, "isAboveAnchor", "()Z", ref global::android.widget.PopupWindow._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual int getMaxAvailableHeight(android.view.View arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;I)I", ref global::android.widget.PopupWindow._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual int getMaxAvailableHeight(android.view.View arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.PopupWindow.staticClass, "getMaxAvailableHeight", "(Landroid/view/View;)I", ref global::android.widget.PopupWindow._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public PopupWindow(android.view.View arg0, int arg1, int arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m40.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m40 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;IIZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m41.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m41 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public PopupWindow(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m42.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m42 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public PopupWindow() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m43.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m43 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m43);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public PopupWindow(android.view.View arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m44.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m44 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public PopupWindow(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m45.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m45 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public PopupWindow(android.view.View arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m46.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m46 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/view/View;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public PopupWindow(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.PopupWindow._m47.native == global::System.IntPtr.Zero)
				global::android.widget.PopupWindow._m47 = @__env.GetMethodIDNoThrow(global::android.widget.PopupWindow.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.PopupWindow.staticClass, global::android.widget.PopupWindow._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int INPUT_METHOD_FROM_FOCUSABLE
		{
			get
			{
				return 0;
			}
		}
		public static int INPUT_METHOD_NEEDED
		{
			get
			{
				return 1;
			}
		}
		public static int INPUT_METHOD_NOT_NEEDED
		{
			get
			{
				return 2;
			}
		}
		static PopupWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.PopupWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/PopupWindow"));
		}
		internal static void InitJNI()
		{
		}
	}
}
